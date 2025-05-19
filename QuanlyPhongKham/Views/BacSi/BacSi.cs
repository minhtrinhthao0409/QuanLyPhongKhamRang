using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Linq;
using QuanlyPhongKham.Models;

namespace QuanlyPhongKham.Views
{
    public partial class BacSi : Form
    {
        private string connectionString = @"QuanLyPhongKham.db";
        private DataTable invoiceDetailsTable;
        private string lastPatientName;
        private int lastPatientId;
        private string currentDoctorId;
        private string currentDoctorName;
        private User currentUser;
        private User user;


        public BacSi(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnLoadAppointments_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT a.ID AS AppointmentID, p.Name AS PatientName, d.Name AS DoctorName, a.AppointmentDate, a.StartTime, a.EndTime " +
                                   "FROM Appointments a " +
                                   "JOIN Patients p ON a.PatientID = p.ID " +
                                   "JOIN Doctors d ON a.DoctorID = d.ID";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    // Tùy chỉnh tiêu đề cột
                    dt.Columns["AppointmentID"].ColumnName = "ID Lịch Hẹn";
                    dt.Columns["PatientName"].ColumnName = "Tên Bệnh Nhân";
                    dt.Columns["DoctorName"].ColumnName = "Tên Bác Sĩ";
                    dt.Columns["AppointmentDate"].ColumnName = "Ngày Hẹn";
                    dt.Columns["StartTime"].ColumnName = "Giờ Bắt Đầu";
                    dt.Columns["EndTime"].ColumnName = "Giờ Kết Thúc";
                    dgvAppointments.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                string patientName = cbPatientName.Text.Trim();
                string startTime = txtStartTime.Text.Trim();
                string endTime = txtEndTime.Text.Trim();

                if (string.IsNullOrEmpty(patientName) || string.IsNullOrEmpty(startTime) || string.IsNullOrEmpty(endTime))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    // 1. Kiểm tra bệnh nhân đã tồn tại chưa
                    string getPatientIdQuery = "SELECT ID FROM Patients WHERE Name = @Name";
                    SQLiteCommand getCmd = new SQLiteCommand(getPatientIdQuery, conn);
                    getCmd.Parameters.AddWithValue("@Name", patientName);
                    object patientIdObj = getCmd.ExecuteScalar();

                    int patientId;

                    if (patientIdObj == null)
                    {
                        // 2. Nếu chưa có, thêm mới bệnh nhân
                        string insertPatientQuery = "INSERT INTO Patients (Name) VALUES (@Name); SELECT last_insert_rowid();";
                        SQLiteCommand insertCmd = new SQLiteCommand(insertPatientQuery, conn);
                        insertCmd.Parameters.AddWithValue("@Name", patientName);
                        patientId = Convert.ToInt32(insertCmd.ExecuteScalar());
                    }
                    else
                    {
                        patientId = Convert.ToInt32(patientIdObj);
                    }

                    // 3. Tạo lịch hẹn
                    string query = @"INSERT INTO Appointments (PatientID, DoctorUserId, AppointmentDate, StartTime, EndTime) 
                             VALUES (@PatientID, @DoctorUserId, @AppointmentDate, @StartTime, @EndTime)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PatientID", patientId);
                    cmd.Parameters.AddWithValue("@DoctorUserId", currentDoctorId); // string
                    cmd.Parameters.AddWithValue("@AppointmentDate", dtpAppointmentDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@StartTime", startTime);
                    cmd.Parameters.AddWithValue("@EndTime", endTime);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Lên lịch hẹn thành công!");

                    // Làm mới
                    cbPatientName.Text = "";
                    txtStartTime.Text = "";
                    txtEndTime.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    // Lấy tên bệnh nhân từ PatientID
                    string patientNameQuery = "SELECT Name FROM Patients WHERE ID = @PatientID";
                    SQLiteCommand nameCmd = new SQLiteCommand(patientNameQuery, conn);
                    nameCmd.Parameters.AddWithValue("@PatientID", txtMedicalPatientID.Text);
                    object result = nameCmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("Không tìm thấy bệnh nhân với ID này! Vui lòng thêm bệnh nhân trước.");
                        return;
                    }

                    // Lưu tên bệnh nhân và ID vào biến tạm
                    lastPatientName = result.ToString();
                    lastPatientId = Convert.ToInt32(txtMedicalPatientID.Text);
                    txtInvoicePatientId.Text = lastPatientId.ToString();
                    txtInvoicePatientName.Text = lastPatientName;

                    // Thêm bệnh án
                    string query = "INSERT INTO MedicalRecords (PatientID, Details, ExaminationDate) " +
                                   "VALUES (@PatientID, @Details, @ExaminationDate); " +
                                   "SELECT last_insert_rowid();";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PatientID", txtMedicalPatientID.Text);
                    cmd.Parameters.AddWithValue("@Details", txtDetails.Text);
                    cmd.Parameters.AddWithValue("@ExaminationDate", dtpExaminationDate.Value.ToString("yyyy-MM-dd"));
                    long medicalRecordID = (long)cmd.ExecuteScalar();

                    // Cập nhật MedicalRecordID trong bảng Patients
                    string updateQuery = "UPDATE Patients SET MedicalRecordID = @MedicalRecordID WHERE ID = @PatientID";
                    SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@MedicalRecordID", medicalRecordID);
                    updateCmd.Parameters.AddWithValue("@PatientID", txtMedicalPatientID.Text);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Ghi bệnh án thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void BacSi_Load(object sender, EventArgs e)
        {
            invoiceDetailsTable = new DataTable();
            invoiceDetailsTable.Columns.Add("ServiceName", typeof(string));
            invoiceDetailsTable.Columns.Add("Price", typeof(decimal));
            invoiceDetailsTable.Columns.Add("Quantity", typeof(int));
            invoiceDetailsTable.Columns.Add("Subtotal", typeof(decimal));
            dgvInvoiceServices.DataSource = invoiceDetailsTable;

            LoadServices();
            LoadPatients();

            currentDoctorId = user.Id;
            currentDoctorName = user.UserName;

            LoadAppointmentsForDoctor();
        }
        private void LoadAppointmentsForDoctor()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT a.ID AS AppointmentID, p.Name AS PatientName, d.Name AS DoctorName, 
                                    a.AppointmentDate, a.StartTime, a.EndTime
                             FROM Appointments a
                             JOIN Patients p ON a.PatientID = p.ID
                             JOIN Doctors d ON a.DoctorID = d.ID
                             WHERE a.DoctorUserId = @DoctorId";

                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DoctorId", currentDoctorId);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Đặt tên cột tiếng Việt
                    dt.Columns["AppointmentID"].ColumnName = "ID Lịch Hẹn";
                    dt.Columns["PatientName"].ColumnName = "Tên Bệnh Nhân";
                    dt.Columns["DoctorName"].ColumnName = "Tên Bác Sĩ";
                    dt.Columns["AppointmentDate"].ColumnName = "Ngày Hẹn";
                    dt.Columns["StartTime"].ColumnName = "Giờ Bắt Đầu";
                    dt.Columns["EndTime"].ColumnName = "Giờ Kết Thúc";

                    dgvAppointments.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lịch hẹn: " + ex.Message);
            }
        }
        private void LoadServices()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ID, ServiceName, Price FROM Services";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cbInvoiceService.DataSource = dt;
                    cbInvoiceService.DisplayMember = "ServiceName";
                    cbInvoiceService.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void LoadPatients()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ID, Name FROM Patients";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cbPatientName.DataSource = dt;
                    cbPatientName.DisplayMember = "Name";
                    cbPatientName.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách bệnh nhân: " + ex.Message);
            }
        }

        private void btnAddInvoiceService_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbInvoiceService.SelectedIndex == -1 || nudInvoiceQuantity.Value == 0)
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ và số lượng!");
                    return;
                }

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ServiceName, Price FROM Services WHERE ID = @ServiceID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ServiceID", cbInvoiceService.SelectedValue);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string serviceName = reader["ServiceName"].ToString();
                        decimal price = Convert.ToDecimal(reader["Price"]);
                        int quantity = (int)nudInvoiceQuantity.Value;
                        decimal subtotal = price * quantity;

                        invoiceDetailsTable.Rows.Add(serviceName, price, quantity, subtotal);
                        dgvInvoiceServices.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnCalculateInvoiceTotal_Click(object sender, EventArgs e)
        {
            try
            {
                decimal total = invoiceDetailsTable.AsEnumerable()
                    .Sum(row => row.Field<decimal>("Subtotal"));
                lblInvoiceTotalAmount.Text = $"Tổng tiền: {total:N0} VNĐ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtInvoicePatientId.Text) || string.IsNullOrEmpty(txtInvoicePatientName.Text) || invoiceDetailsTable.Rows.Count == 0)
                {
                    MessageBox.Show("Vui lòng ghi bệnh án trước để lấy thông tin bệnh nhân và thêm ít nhất một dịch vụ!");
                    return;
                }

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    // Lưu hóa đơn
                    string invoiceQuery = "INSERT INTO Invoices (PatientID, TotalAmount) VALUES (@PatientID, @TotalAmount); SELECT last_insert_rowid();";
                    SQLiteCommand invoiceCmd = new SQLiteCommand(invoiceQuery, conn);
                    decimal total = invoiceDetailsTable.AsEnumerable().Sum(row => row.Field<decimal>("Subtotal"));
                    invoiceCmd.Parameters.AddWithValue("@PatientID", txtInvoicePatientId.Text);
                    invoiceCmd.Parameters.AddWithValue("@TotalAmount", total);
                    long invoiceID = (long)invoiceCmd.ExecuteScalar();

                    // Lưu chi tiết hóa đơn
                    foreach (DataRow row in invoiceDetailsTable.Rows)
                    {
                        string detailQuery = "INSERT INTO InvoiceDetails (InvoiceID, ServiceID, Quantity, Subtotal) VALUES (@InvoiceID, @ServiceID, @Quantity, @Subtotal)";
                        SQLiteCommand detailCmd = new SQLiteCommand(detailQuery, conn);
                        detailCmd.Parameters.AddWithValue("@InvoiceID", invoiceID);
                        detailCmd.Parameters.AddWithValue("@ServiceID", GetServiceID(row["ServiceName"].ToString()));
                        detailCmd.Parameters.AddWithValue("@Quantity", row["Quantity"]);
                        detailCmd.Parameters.AddWithValue("@Subtotal", row["Subtotal"]);
                        detailCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Lưu hóa đơn thành công!");
                    invoiceDetailsTable.Clear();
                    txtInvoicePatientId.Text = "";
                    txtInvoicePatientName.Text = "";
                    lblInvoiceTotalAmount.Text = "Tổng tiền: 0 VNĐ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private int GetServiceID(string serviceName)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ID FROM Services WHERE ServiceName = @ServiceName";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@ServiceName", serviceName);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private void BacSi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}