using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Linq;
using QuanlyPhongKham.Models;
using QuanlyPhongKham.Controllers;
using QuanlyPhongKham.Views.Receptionist;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Threading.Tasks;
using QuanlyPhongKham.Repository;
using QuanlyPhongKham.Services;

namespace QuanlyPhongKham.Views
{
    public partial class BacSi : Form
    {
        AppointmentController appointmentController = new AppointmentController();
        private PatientController patientController = new PatientController();
        private Dictionary<string, string> patientMap;
        private User user;
        private string currentDoctorId;
        private string currentDoctorName;

        public BacSi(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private async void BacSi_Load(object sender, EventArgs e)
        {
            currentDoctorId = user.Id;
            currentDoctorName = user.UserName;
            var appointmentDate = dtpAppointmentDate.Value.Date;

            await LoadPatientsAsync();
            await LoadAppointmentsAsync();
        }

        private async Task LoadPatientsAsync()
        {
            try
            {
                var patients = await patientController.GetAllPatientsAsync();
                if (patients == null || patients.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy bệnh nhân nào!");
                    cbPatientId.DataSource = null;
                    cbPatientName.DataSource = null;
                    return;
                }

                cbPatientId.DataSource = null;
                cbPatientName.DataSource = null;

                cbPatientId.DataSource = patients;
                cbPatientId.DisplayMember = "PatientId";
                cbPatientId.ValueMember = "PatientId";
                cbPatientId.Refresh();

                cbPatientName.DataSource = patients.ToList();
                cbPatientName.DisplayMember = "Name";
                cbPatientName.ValueMember = "PatientId";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách bệnh nhân: {ex.Message}");
            }
        }

        private async Task LoadAppointmentsAsync()
        {
            var appointments = await appointmentController.GetDoctorAppointmentsAsync(currentDoctorId);

            var displayList = appointments.Select(a => new
            {
                TenBenhNhan = a.PatientName,
                NgayHen = a.AppointmentDate.ToString("dd/MM/yyyy"),
                GioBatDau = a.StartTime.ToString(@"hh\:mm"),
                GioKetThuc = a.EndTime.ToString(@"hh\:mm")
            }).ToList();

            dgvAppointments.DataSource = displayList;

            dgvAppointments.Columns["TenBenhNhan"].HeaderText = "Tên Bệnh Nhân";
            dgvAppointments.Columns["NgayHen"].HeaderText = "Ngày Hẹn";
            dgvAppointments.Columns["GioBatDau"].HeaderText = "Giờ Bắt Đầu";
            dgvAppointments.Columns["GioKetThuc"].HeaderText = "Giờ Kết Thúc";

            foreach (DataGridViewColumn col in dgvAppointments.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private async void btnLoadAppointments_Click(object sender, EventArgs e)
        {
            await LoadAppointmentsAsync();
        }

        private async void btnSchedule_Click(object sender, EventArgs e)
        {

            if (appointmentController == null)
            {
                MessageBox.Show("Lỗi: AppointmentController chưa được khởi tạo!");
                return;
            }

            if (string.IsNullOrEmpty(currentDoctorId))
            {
                MessageBox.Show("Lỗi: Không xác định được bác sĩ!");
                return;
            }

            if (cbPatientId.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân!");
                return;
            }

            if (string.IsNullOrEmpty(mtbStartTime.Text) || string.IsNullOrEmpty(mtbEndTime.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ giờ hẹn!");
                return;
            }

            DateTime appointmentDate = dtpAppointmentDate.Value.Date;

            if (!TimeSpan.TryParseExact(mtbStartTime.Text, "hh\\:mm", null, out TimeSpan startTime) ||
                !TimeSpan.TryParseExact(mtbEndTime.Text, "hh\\:mm", null, out TimeSpan endTime))
            {
                MessageBox.Show("Thời gian không hợp lệ! Vui lòng nhập theo định dạng HH:mm.");
                return;
            }

            if (startTime >= endTime)
            {
                MessageBox.Show("Giờ bắt đầu phải nhỏ hơn giờ kết thúc!");
                return;
            }

            string patientId = cbPatientId.SelectedValue.ToString();

            if (await appointmentController.HasScheduleConflictAsync(currentDoctorId, patientId, appointmentDate, startTime, endTime))
            {
                MessageBox.Show("Lịch hẹn bị trùng! Vui lòng chọn thời gian khác.");
                return;
            }

            bool success = await appointmentController.AddAppointmentAsync(currentDoctorId, patientId, appointmentDate, startTime, endTime);
            if (success)
            {
                MessageBox.Show("Thêm lịch hẹn thành công!");
                await LoadAppointmentsAsync();
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm lịch hẹn!");
            }
        }


        private void btnSaveRecord_Click(object sender, EventArgs e) { }
        private void cbPatientId_SelectedIndexChanged(object sender, EventArgs e) { }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void btnSaveInvoice_Click(object sender, EventArgs e) { }

        private void BacSi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LenLichHen_Click(object sender, EventArgs e)
        {

        }

        private void mtbStartTime_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
