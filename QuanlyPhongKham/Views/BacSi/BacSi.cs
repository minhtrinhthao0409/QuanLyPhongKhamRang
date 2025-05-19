using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Linq;
using QuanlyPhongKham.Models;
using QuanlyPhongKham.Controllers;
using QuanlyPhongKham.Views.Receptionist;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        private AppointmentController appointmentController = new AppointmentController();

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
            string doctorId = currentDoctorId;
            string patientId = cbPatientName.SelectedValue.ToString();
            DateTime date = dtpAppointmentDate.Value;

            if (!TimeSpan.TryParse(mtbStartTime.Text, out TimeSpan startTime))
            {
                MessageBox.Show("Giờ bắt đầu không hợp lệ! Vui lòng nhập đúng định dạng HH:mm.");
                return;
            }

            if (!TimeSpan.TryParse(mtbEndTime.Text, out TimeSpan endTime))
            {
                MessageBox.Show("Giờ kết thúc không hợp lệ! Vui lòng nhập đúng định dạng HH:mm.");
                return;
            }

            if (endTime <= startTime)
            {
                MessageBox.Show("Giờ kết thúc phải sau giờ bắt đầu.");
                return;
            }

            bool result = appointmentController.AddAppointment(doctorId, patientId, date, startTime, endTime);
            if (result)
                MessageBox.Show("Đặt lịch thành công!");
            else
                MessageBox.Show("Lịch bị trùng hoặc lỗi xảy ra.");
        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
         
        }

        private void BacSi_Load(object sender, EventArgs e)
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