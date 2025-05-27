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
        PatientController patientController = new PatientController();
        MedicalRecordController medicalRecordController = new MedicalRecordController();
        InvoiceController _invoiceController = new InvoiceController();
        private readonly MedicalServiceController _medicalServiceController = new MedicalServiceController();
        private Dictionary<string, string> patientMap;
        private User user;
        private string currentDoctorId;
        private string currentDoctorName;
        private List<Patient> allPatients;
        private readonly LoggingService loggingService;

        public BacSi(User user, LoggingService loggingService)
        {
            InitializeComponent();
            this.user = user;
            this.loggingService = loggingService;
        }

        private async void BacSi_Load(object sender, EventArgs e)
        {
            currentDoctorId = user.Id;
            currentDoctorName = user.UserName;
            var appointmentDate = dtpAppointmentDate.Value.Date;
            cboPatientId.SelectedIndexChanged += cboPatientId_SelectedIndexChanged;
            await loggingService.AddLoggingAsync(currentDoctorId, currentDoctorName, "Đăng nhập vào giao diện bác sĩ.");
            await LoadPatientsToComboBoxes();
            await LoadPatientsAsync();
            await LoadAppointmentsAsync();
        }

        private async Task LoadPatientsAsync()
        {

            try
            {
                var patients = await patientController.GetAllPatientsAsync();
                allPatients = patients;

                cbPatientId.DataSource = new BindingSource(patients, null);
                cbPatientId.DisplayMember = "PhoneNumber";
                cbPatientId.ValueMember = "PatientId";

                cbPatientName.DataSource = new BindingSource(patients, null);
                cbPatientName.DisplayMember = "Name";
                cbPatientName.ValueMember = "PatientId";

                // Gắn sự kiện đồng bộ
                cbPatientId.SelectedIndexChanged += (s, e) =>
                {
                    cbPatientName.SelectedIndex = cbPatientId.SelectedIndex;
                };
                cbPatientName.SelectedIndexChanged += (s, e) =>
                {
                    cbPatientId.SelectedIndex = cbPatientName.SelectedIndex;
                };
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
            await loggingService.AddLoggingAsync(currentDoctorId, currentDoctorName, "Xem danh sách lịch hẹn.");
        }
        private void cbPatientId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPatientId.SelectedValue == null || allPatients == null) return;

            string selectedId = cbPatientId.SelectedValue.ToString();

            var selectedPatient = allPatients.FirstOrDefault(p => p.PatientId == selectedId);

            if (selectedPatient != null)
            {
                cbPatientName.SelectedValue = selectedPatient.PatientId;
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

            string patientId = cbPatientId.SelectedValue?.ToString();

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
            await loggingService.AddLoggingAsync(currentDoctorId, currentDoctorName, "Xác nhận lịch hẹn với bệnh nhân.");
        }
        private async Task LoadPatientsToComboBoxes()
        {
            var patients = await patientController.GetAllPatientsAsync();

            cbIdPatientRecord.DataSource = patients;
            cbIdPatientRecord.DisplayMember = "PhoneNumber";
            cbIdPatientRecord.ValueMember = "PatientId";

            cbNamePatientRecord.DataSource = new List<Patient>(patients);
            cbNamePatientRecord.DisplayMember = "Name";
            cbNamePatientRecord.ValueMember = "PatientId";
        }
        private async void btnSaveRecord_Click(object sender, EventArgs e)
        {
            try
            {
                string patientId = cbIdPatientRecord.SelectedValue?.ToString();
                string patientName = cbNamePatientRecord.Text;
                string symptoms = txtSymptom.Text.Trim();
                string diagnosis = txtDiagnosis.Text.Trim();
                string treatmentPlan = txtTreatmentPlan.Text.Trim();
                DateTime recordDate = dtpRecordDate.Value;

                if (string.IsNullOrWhiteSpace(patientId) || string.IsNullOrWhiteSpace(patientName))
                {
                    MessageBox.Show("Vui lòng chọn ID và tên bệnh nhân.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(symptoms))
                {
                    MessageBox.Show("Vui lòng nhập triệu chứng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int result = await medicalRecordController.CreateMedicalRecordAsync(
                    patientId, currentDoctorId, symptoms, diagnosis, treatmentPlan);

                if (result > 0)
                {
                    MessageBox.Show("Lưu bệnh án thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể lưu bệnh án.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu bệnh án: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            await loggingService.AddLoggingAsync(currentDoctorId, currentDoctorName, "Lưu bệnh án.");
        }

        private async void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TapBacSi.SelectedTab.Text == "Xem Bệnh Án")
            {
                btnLoadMedicalRecords_Click(null, null);
            }
            else if (TapBacSi.SelectedTab.Text == "Quản Lý Hóa Đơn")
            {
                await LoadServicesToComboBoxAsync();
                await LoadPatientsToComboBoxAsync();
            }
        }
        private async void btnLoadMedicalRecords_Click(object sender, EventArgs e)
        {
            try
            {
                var medicalRecordRepository = new MedicalRecordRepository();
                var records = await medicalRecordRepository.GetMedicalRecordsByDoctorAsync(currentDoctorId);

                if (records == null || records.Count == 0)
                {
                    MessageBox.Show("Không có hồ sơ bệnh án nào để hiển thị!");
                    dgvMedicalRecordView.DataSource = null;
                    return;
                }

                // Chuyển đổi danh sách MedicalRecord thành danh sách có thuộc tính FullName trực tiếp
                var displayRecords = records.Select(r => new
                {
                    PatientName = r.Patient.Name, // Lấy FullName từ Patient
                    Symptoms = r.Symptoms,
                    Diagnosis = r.Diagnosis,
                    RecordDate = r.RecordDate
                }).ToList();

                dgvMedicalRecordView.DataSource = displayRecords;

                dgvMedicalRecordView.Columns["PatientName"].HeaderText = "Tên bệnh nhân";
                dgvMedicalRecordView.Columns["Symptoms"].HeaderText = "Triệu chứng";
                dgvMedicalRecordView.Columns["Diagnosis"].HeaderText = "Chẩn đoán";
                dgvMedicalRecordView.Columns["RecordDate"].HeaderText = "Ngày ghi nhận";

                dgvMedicalRecordView.Columns["RecordDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

                foreach (DataGridViewColumn column in dgvMedicalRecordView.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                dgvMedicalRecordView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải hồ sơ bệnh án: {ex.Message}");
            }
            await loggingService.AddLoggingAsync(currentDoctorId, currentDoctorName, "Xem bệnh án.");
        }
        private void cbIdPatientRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNamePatientRecord.SelectedIndex = cbIdPatientRecord.SelectedIndex;
        }
        private void cbNamePatientRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIdPatientRecord.SelectedIndex = cbNamePatientRecord.SelectedIndex;
        }
        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            string tenDichVu = cbChonDichVu.Text;
            int soLuong = (int)nuChonSoLuong.Value;

            if (string.IsNullOrWhiteSpace(tenDichVu) || soLuong <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và hợp lệ.");
                return;
            }

            var gia = _medicalServiceController.LayGiaDichVu(tenDichVu);

            if (gia == null)
            {
                MessageBox.Show("Không tìm thấy giá dịch vụ.");
                return;
            }

            dgvChiTiet.Rows.Add(tenDichVu, soLuong, gia.Value);
            btnCalculateTotal.PerformClick();
        }

        private async Task LoadServicesToComboBoxAsync()
        {
            var repo = new InvoiceRepository();
            var services = await repo.GetActiveServicesAsync();

            cbChonDichVu.DisplayMember = "ServicesName";
            cbChonDichVu.ValueMember = "CurrentPrice";
            cbChonDichVu.DataSource = services;
        }
        private async void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            string rawTotal = txtTongTien.Text.Replace("VNĐ", "").Replace(".", "").Trim();

            if (!decimal.TryParse(rawTotal, out decimal totalAmount))
            {
                MessageBox.Show("Tổng tiền không hợp lệ. Vui lòng kiểm tra lại.");
                return;
            }

            var invoice = new Invoice
            {
                PatientId = cboPatientId.SelectedValue?.ToString(),
                PatientName = txtPatientName.Text,
                CreatedAt = dtpNgayIn.Value,
                TotalAmount = totalAmount,
                PaidAmount = 0,
                Status = "Chưa thanh toán",
                Details = new List<InvoiceDetail>()
            };
            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                if (row.Cells["TenDichVu"].Value != null)
                {
                    // Làm sạch giá (phòng trường hợp bạn hiển thị giá có định dạng VNĐ trong DataGridView)
                    string rawGia = row.Cells["Gia"].Value?.ToString().Replace("VNĐ", "").Replace(".", "").Trim() ?? "0";

                    if (!decimal.TryParse(rawGia, out decimal unitPrice))
                    {
                        MessageBox.Show("Giá dịch vụ không hợp lệ ở một dòng.");
                        return;
                    }

                    invoice.Details.Add(new InvoiceDetail
                    {
                        ServiceName = row.Cells["TenDichVu"].Value.ToString(),
                        UnitPrice = unitPrice,
                        Quantity = Convert.ToInt32(row.Cells["SoLuong"].Value)
                    });
                }
            }

            await _invoiceController.CreateInvoiceAsync(invoice);
            MessageBox.Show("Lưu hóa đơn thành công");
            await loggingService.AddLoggingAsync(currentDoctorId, currentDoctorName, "Lưu hóa đơn.");
        }
        
        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            decimal tongTien = 0;

            // Duyệt qua tất cả các dòng trong DataGridView
            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                // Bỏ qua dòng trống mới nếu có (thường là dòng cuối trong DataGridView)
                if (row.IsNewRow) continue;

                try
                {
                    int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    decimal gia = Convert.ToDecimal(row.Cells["Gia"].Value);
                    tongTien += soLuong * gia;
                }
                catch
                {
                    MessageBox.Show("Lỗi khi tính tổng tiền. Vui lòng kiểm tra dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Hiển thị tổng tiền vào TextBox
            txtTongTien.Text = tongTien.ToString("N0") + " VNĐ";
        }
        private void cboPatientId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPatientId.SelectedValue == null || allPatients == null) return;

            string selectedId = cboPatientId.SelectedValue.ToString();
            var selectedPatient = allPatients.FirstOrDefault(p => p.PatientId == selectedId);

            if (selectedPatient != null)
            {
                txtPatientName.Text = selectedPatient.Name;
            }
        }
        private async Task LoadPatientsToComboBoxAsync()
        {
            try
            {
                allPatients = await patientController.GetAllPatientsAsync();
                cboPatientId.DataSource = allPatients;
                cboPatientId.DisplayMember = "PhoneNumber";
                cboPatientId.ValueMember = "PhoneNumber";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách bệnh nhân: " + ex.Message);
            }
        }
        private void BacSi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
