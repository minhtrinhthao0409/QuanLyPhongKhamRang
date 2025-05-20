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

namespace QuanlyPhongKham.Views
{
    public partial class BacSi : Form
    {
        AppointmentController appointmentController = new AppointmentController();
        private PatientController patientController = new PatientController();
        private Dictionary<string, string> patientMap;
        private string currentDoctorId;
        private string currentDoctorName;
        private User user;
        public BacSi(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnLoadAppointments_Click(object sender, EventArgs e)
        {

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

            if (dtpAppointmentDate == null || string.IsNullOrEmpty(mtbStartTime.Text) || string.IsNullOrEmpty(mtbEndTime.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin lịch hẹn!");
                return;
            }

            DateTime appointmentDate = dtpAppointmentDate.Value;
            if (!TimeSpan.TryParse(mtbStartTime.Text, out TimeSpan startTime) ||
                !TimeSpan.TryParse(mtbEndTime.Text, out TimeSpan endTime))
            {
                MessageBox.Show("Thời gian không hợp lệ!");
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
                await LoadAppointments(); // Làm mới danh sách
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm lịch hẹn!");
            }
        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {

        }

        private async void BacSi_Load(object sender, EventArgs e)
        {
            appointmentController = new AppointmentController();
            currentDoctorId = user.Id;
            currentDoctorName = user.UserName;

            await LoadPatients(); 
            await LoadAppointments();

            dgvAppointments.Columns["NgayHen"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvAppointments.Columns["GioBatDau"].DefaultCellStyle.Format = "HH:mm:ss";
            dgvAppointments.Columns["GioKetThuc"].DefaultCellStyle.Format = "HH:mm:ss";
        }
        private async Task LoadPatients()
        {
            try
            {
                var patients = patientController.GetAllPatients();
                Console.WriteLine($"Số bệnh nhân: {patients?.Count ?? 0}"); // Log để gỡ lỗi
                if (patients == null || patients.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy bệnh nhân nào!");
                    cbPatientId.DataSource = null;
                    cbPatientName.DataSource = null;
                    return;
                }

                // Làm mới DataSource
                cbPatientId.DataSource = null;
                cbPatientName.DataSource = null;

                cbPatientId.DataSource = patients;
                cbPatientId.DisplayMember = "PatientId";
                cbPatientId.ValueMember = "PatientId";

                cbPatientName.DataSource = patients.ToList();
                cbPatientName.DisplayMember = "Name";
                cbPatientName.ValueMember = "PatientId";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách bệnh nhân: {ex.Message}");
            }
        }
        private async Task LoadAppointments()
        {
            try
            {
                var appointments = await appointmentController.GetDoctorAppointmentsAsync(currentDoctorId);
                if (appointments == null || appointments.Count == 0)
                {
                    MessageBox.Show("Không có lịch hẹn nào để hiển thị!");
                    dgvAppointments.DataSource = null;
                    return;
                }
                dgvAppointments.DataSource = appointments;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải lịch hẹn: {ex.Message}");
            }
        }
        
        private void cbPatientId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnAddInvoiceService_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculateInvoiceTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
        }

        private void BacSi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}