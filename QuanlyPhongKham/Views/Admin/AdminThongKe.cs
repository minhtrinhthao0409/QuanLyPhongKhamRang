using QuanlyPhongKham.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanlyPhongKham.Views.Admin
{
    public partial class AdminThongKe : Form
    {
        private readonly MedicalServiceController medicalServiceController = new MedicalServiceController();
        private readonly UserControllers userController = new UserControllers();
        private readonly LoggingController loggingController = new LoggingController();
        private DataTable dt;

        public AdminThongKe(int a)
        {
            InitializeComponent(); // Gọi InitializeComponent trước

            if (a == 1)
            {
                this.Text = "Thống kê lịch hẹn cho bác sĩ";
                LoadAppointmentDataAsync(); // Tải dữ liệu lịch hẹn
            }
            if (a == 2)
            {
                this.Text = "Thống kê dịch vụ theo doanh số";
                LoadServiceRevenueToGridAsync(); // Tải dữ liệu doanh số dịch vụ
            }
            else if (a == 3)
            {
                this.Text = "Thống kê chấm công";
                LoadUserLogOutBefore17Async();
            }
        }

        private async void LoadServiceRevenueToGridAsync()
        {
            try
            {
                var serviceRevenues = await medicalServiceController.GetTopServiceRevenueAsync();

                dt = new DataTable();
                dt.Columns.Add("ServiceName", typeof(string));
                dt.Columns.Add("TotalRevenue", typeof(decimal));

                foreach (var item in serviceRevenues)
                {
                    dt.Rows.Add(item.ServiceName, item.TotalRevenue);
                }

                // Gán dữ liệu cho DataGridView
                AdminBieuDodgv.DataSource = dt;
             
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
            }
        }

        private async void LoadAppointmentDataAsync()
        {
            try
            {
                // Giả định có phương thức để lấy dữ liệu lịch hẹn (cần thêm vào MedicalServiceController)
                var appointmentData = await userController.GetDoctorAppointmentRankingAsync(); // Cần định nghĩa phương thức này

                dt = new DataTable();
                dt.Columns.Add("DoctorName", typeof(string));
                dt.Columns.Add("AppointmentCount", typeof(int));

                foreach (var item in appointmentData)
                {
                    dt.Rows.Add(item.DoctorName, item.AppointmentCount); // Giả định tuple (string, int)
                }

                AdminBieuDodgv.DataSource = dt;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
            }
        }

        private async void LoadUserLogOutBefore17Async()
        {
            try
            {
                // Gọi hàm lấy danh sách username và số lần đăng xuất trước 17h
                var userLogOutData = await loggingController.GetUsersLogOutCountBefore17Async();

                // Tạo DataTable để hiển thị dữ liệu
                var dt = new DataTable();
                dt.Columns.Add("UserName", typeof(string));
                dt.Columns.Add("LogOutCount", typeof(int));

                // Thêm dữ liệu vào DataTable
                foreach (var item in userLogOutData)
                {
                    dt.Rows.Add(item.username, item.logOutCount);
                }

                // Gán DataTable vào DataGridView
                AdminBieuDodgv.DataSource = dt;
                dt.Columns["UserName"].ColumnName = "Tên người dùng";
                dt.Columns["LogOutCount"].ColumnName = "Số lần đăng xuất";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private async void AdminBieuDodgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            MessageBox.Show("Sự kiện click đã được gọi!");
            if (this.Text == "Biểu đồ chấm công" && e.RowIndex >= 0)
            {
                var clickedColumn = AdminBieuDodgv.Columns[e.ColumnIndex];

                // Kiểm tra theo DataPropertyName thay vì Name
                if (clickedColumn.DataPropertyName == "UserName")
                {
                    string username = AdminBieuDodgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                    if (!string.IsNullOrEmpty(username))
                    {
                        LoadUserLogOutDetailsBefore17Async(username);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tên người dùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private async void LoadUserLogOutDetailsBefore17Async(string username)
        {
            try
            {
                // Gọi hàm lấy danh sách lần đăng xuất trước 17h của username
                var userLogOutData = await loggingController.GetUserLogOutBefore17Async(username);

                // Tạo DataTable để hiển thị dữ liệu
                dt = new DataTable();
                dt.Columns.Add("UserName", typeof(string));
                dt.Columns.Add("LogOutTime", typeof(DateTime));

                // Thêm dữ liệu vào DataTable
                foreach (var item in userLogOutData)
                {
                    dt.Rows.Add(item.username, item.logOutTime);
                }

                // Gán DataTable vào DataGridView
                AdminBieuDodgv.DataSource = dt;

                // Đặt tên hiển thị cho cột
                dt.Columns["UserName"].ColumnName = "Tên người dùng";
                dt.Columns["LogOutTime"].ColumnName = "Thời gian đăng xuất";

                // Định dạng cột thời gian
                AdminBieuDodgv.Columns["LogOutTime"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải chi tiết đăng xuất: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AdminBieuDo_Load(object sender, EventArgs e)
        {
            if (this.Text == "Biểu đồ chấm công")
            {
                LoadUserLogOutBefore17Async();
            }
        }

        private void AdminBieuDodgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Text == "Biểu đồ chấm công" && e.RowIndex >= 0)
            {
                var clickedColumn = AdminBieuDodgv.Columns[e.ColumnIndex];

                // Kiểm tra theo DataPropertyName thay vì Name
                if (clickedColumn.DataPropertyName == "UserName")
                {
                    string username = AdminBieuDodgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                    if (!string.IsNullOrEmpty(username))
                    {
                        LoadUserLogOutDetailsBefore17Async(username);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tên người dùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}