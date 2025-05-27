using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanlyPhongKham.Controllers;
using QuanlyPhongKham.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace QuanlyPhongKham.Views.Admin
{
    public partial class AdminMain : Form
    {
        private User Admin { get; set; }
        private UserControllers _userControllers;
        private MedicalServiceController _medicalServiceController;
        private InvoiceController _invoiceController;
        private LoggingController _loggingController;

        public AdminMain(User user)
        {
            InitializeComponent();
            this.Admin = user;
            this._userControllers = new UserControllers();
            this._medicalServiceController = new MedicalServiceController();
            this._invoiceController = new InvoiceController();
            this._loggingController = new LoggingController();
            AdminIDtb.Text = user.Id;
            AdminNametb.Text = user.FullName;
            //LoadUserDataAsync();
            //LoadServiceDataasync();
            //LoadLogDataAsync();
            AdminQLTKUpdatebtn.Enabled = false;
            AdminQLTKDeletebtn.Enabled = false;
            AdminQLTKPasstbx.Enabled = false;
            AdminQLTKUserNametbx.Enabled = false;
            AdminQLTKRolecb.Enabled = false;
            AdminQLDVbtn.Enabled = false;
            AdminQLDVDelbtn.Enabled = false;
        }
        private void AdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #region QLTK

        private async void LoadUserDataAsync()
        {
            var users = await _userControllers.GetAllUser();
            var loadusers = users.Select(u => new
            {
                u.Id,
                u.UserName,
                u.Password,
                u.Email,
                u.FullName,
                u.PhoneNumber,
                u.Role
            }).ToList();
            AdminQLTKdata.DataSource = loadusers;
        }
        private void AdminQLTKdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = AdminQLTKdata.Rows[e.RowIndex];
                AdminQLTKUserNametbx.Text = selectedRow.Cells["UserName"].Value.ToString();
                AdminQLTKFullNametbx.Text = selectedRow.Cells["FullName"].Value.ToString();
                AdminQLTKPhonetbx.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                AdminQLTKEmailtbx.Text = selectedRow.Cells["Email"].Value.ToString();
                AdminQLTKPasstbx.Text = selectedRow.Cells["Password"].Value.ToString();
                AdminQLTKRolecb.Text = selectedRow.Cells["Role"].Value.ToString() == "Admin" ? "Admin" : selectedRow.Cells["Role"].Value.ToString() == "Doctor" ? "Doctor" : "Receptionist";
                AdminQLTKUpdatebtn.Enabled = true;
                AdminQLTKDeletebtn.Enabled = true;
            }

        }

        private async void AdminQLTKAddbtn_Click(object sender, EventArgs e)
        {
            string username = AdminQLTKUserNametbx.Text.Trim();
            string password = AdminQLTKPasstbx.Text;
            string email = AdminQLTKEmailtbx.Text.Trim();
            string fullName = AdminQLTKFullNametbx.Text.Trim();
            string phone = AdminQLTKPhonetbx.Text.Trim();
            string rolestring = AdminQLTKRolecb.Text.Trim();
            if (rolestring == "Admin" || rolestring == "Null")
            {
                MessageBox.Show("Vui lòng chọn vai trò khác ngoài Admin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int role = rolestring == "Doctor" ? 2 :
                       rolestring == "Receptionist" ? 3 : 0;


            if (await _userControllers.CheckUsernameExists(username))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(fullName) ||
                (role != 2 && role != 3))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin và chọn vai trò.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool success = await _userControllers.CreateAccount(username, password, email, fullName, phone, role);
                if (success)
                {
                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUserDataAsync();
                    _loggingController.AddLoggingAsync(Admin.Id, Admin.UserName, $"Đã đăng ký tài khoản mới: {username} với vai trò {rolestring}").Wait();
                }
                else
                {
                    MessageBox.Show("Đăng ký không thành công. Tên đăng nhập hoặc email có thể đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            AdminQLTKUserNametbx.Text = null;
            AdminQLTKFullNametbx.Text = null;
            AdminQLTKPhonetbx.Text = null;
            AdminQLTKEmailtbx.Text = null;
            AdminQLTKPasstbx.Text = null;
            AdminQLTKRolecb.SelectedIndex = 3;
        }

        private void AdminQLTKUpdatebtn_Click(object sender, EventArgs e)
        {
            string username = AdminQLTKUserNametbx.Text.Trim();
            string password = AdminQLTKPasstbx.Text;
            string email = AdminQLTKEmailtbx.Text.Trim();
            string fullName = AdminQLTKFullNametbx.Text.Trim();
            string phone = AdminQLTKPhonetbx.Text.Trim();
            string rolestring = AdminQLTKRolecb.Text.Trim();
            if (rolestring == "Admin" || rolestring == "Null")
            {
                MessageBox.Show("Vui lòng chọn vai trò khác ngoài Admin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int role = rolestring == "Doctor" ? 2 :
                       rolestring == "Receptionist" ? 3 : 0;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(fullName) ||
                (role != 2 && role != 3))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin và chọn vai trò.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bool success = _userControllers.UpdateUserAsync(username, password, fullName, email, phone).Result;
                if (success)
                {
                    MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUserDataAsync();
                    _loggingController.AddLoggingAsync(Admin.Id, Admin.UserName, $"Đã cập nhật tài khoản: {username} với vai trò {rolestring}").Wait();
                }
                else
                {
                    MessageBox.Show("Cập nhật tài khoản không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AdminQLTKDeletebtn_Click(object sender, EventArgs e)
        {
            string username = AdminQLTKUserNametbx.Text.Trim();
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Vui lòng chọn tài khoản để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bool success = _userControllers.DeleteUserAsync(username).Result;
                if (success)
                {
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUserDataAsync();
                    _loggingController.AddLoggingAsync(Admin.Id, Admin.UserName, $"Đã xóa tài khoản: {username}").Wait();
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion QLTK
        #region QLDV
        private async void LoadServiceDataasync()
        {
            var services = _medicalServiceController.GetAllService();
            var loadservices = services.Result.Select(s => new
            {
                s.ServicesId,
                s.ServicesName,
                s.CurrentPrice
            }).ToList();
            AdminQLDVdata.DataSource = loadservices;
        }


        private void AdminQLDVdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = AdminQLDVdata.Rows[e.RowIndex];
                AdminQLDVNameTb.Text = selectedRow.Cells["ServicesName"].Value.ToString();
                AdminQLDVPricetbx.Text = selectedRow.Cells["CurrentPrice"].Value.ToString();
                AdminQLDVbtn.Enabled = true;
                AdminQLDVDelbtn.Enabled = true;
                AdminQLDVNameTb.Enabled = false;
            }
        }
        private async void AdminQLDVAddButton_Click(object sender, EventArgs e)
        {
            string serviceName = AdminQLDVNameTb.Text.Trim();
            string priceText = AdminQLDVPricetbx.Text.Trim();

            if (string.IsNullOrWhiteSpace(serviceName) || string.IsNullOrWhiteSpace(priceText))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Giá dịch vụ không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (price <= 0)
            {
                MessageBox.Show("Giá dịch vụ phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bool success = await _medicalServiceController.AddService(serviceName, price);
                if (success)
                {
                    MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadServiceDataasync();
                    _loggingController.AddLoggingAsync(Admin.Id, Admin.UserName, $"Đã thêm dịch vụ: {serviceName} với giá {price}").Wait();
                }
                else
                {
                    MessageBox.Show("Thêm dịch vụ không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void AdminQLDVDelbtn_Click(object sender, EventArgs e)
        {
            string serviceName = AdminQLDVNameTb.Text.Trim();
            if (await _medicalServiceController.DeleteService(serviceName))
            {
                MessageBox.Show("Xóa dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadServiceDataasync();
                _loggingController.AddLoggingAsync(Admin.Id, Admin.UserName, $"Đã xóa dịch vụ: {serviceName}").Wait();
            }
            else
            {
                MessageBox.Show("Xóa dịch vụ không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminQLDVbtn_Click(object sender, EventArgs e)
        {
            decimal price = AdminQLDVPricetbx.Text == "" ? 0 : decimal.Parse(AdminQLDVPricetbx.Text);
            string serviceName = AdminQLDVNameTb.Text.Trim();
            if (string.IsNullOrWhiteSpace(serviceName) || price <= 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bool success = _medicalServiceController.UpdateServicePrice(serviceName, price).Result;
                if (success)
                {
                    MessageBox.Show("Cập nhật dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadServiceDataasync();
                    _loggingController.AddLoggingAsync(Admin.Id, Admin.UserName, $"Đã cập nhật dịch vụ: {serviceName} với giá {price}").Wait();
                }
                else
                {
                    MessageBox.Show("Cập nhật dịch vụ không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminQbtnLDVRabtn_Click(object sender, EventArgs e)
        {
            AdminQLDVdata.DataSource = _medicalServiceController.SortServiceByCount().Result;
        }
        private void AdminQLDV_Click(object sender, EventArgs e)
        {
            AdminQLDVNameTb.Text = null;
            AdminQLDVPricetbx.Text = null;
            AdminQLDVNameTb.Enabled = true;
        }
        #endregion QLDV



        #region BCTC

        private async void AdminBCTCXuatbtn_ClickAsync(object sender, EventArgs e)
        {
            LoadInvoiceDataAsync();
        }
        private async void LoadInvoiceDataAsync()
        {
            try
            {
                // Lấy giá trị từ DateTimePicker
                DateTime startDate = AdminBCTCFromTP.Value;
                DateTime endDate = AdminBCTCFToTP.Value;
                // Kiểm tra ngày hợp lệ
                if (endDate < startDate)
                {
                    MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Gọi phương thức từ controller để lấy danh sách hóa đơn
                var invoices = await _invoiceController.GetInvoiceByTime(startDate, endDate);
                // Hiển thị danh sách hóa đơn trong DataGridView
                AdminBCTCdgv.DataSource = invoices;
                _loggingController.AddLoggingAsync(Admin.Id, Admin.UserName, $"Đã xuất báo cáo tài chính từ {startDate.ToShortDateString()} đến {endDate.ToShortDateString()}").Wait();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AdminBCTCFromTP_ValueChanged(object sender, EventArgs e)
        {
            LoadInvoiceDataAsync();
        }

        private void AdminBCTCFToTP_ValueChanged(object sender, EventArgs e)
        {
            LoadInvoiceDataAsync();
        }

        #endregion BCTC


        private async void LoadLogDataAsync()
        {
            try
            {
                Console.WriteLine("Đang lấy dữ liệu log...");
                var logs = await _loggingController.GetAllLoggingsAsync();
                Console.WriteLine($"Đã lấy được {logs?.Count ?? 0} log.");

                if (logs == null || !logs.Any())
                {
                    if (!this.IsDisposed)
                    {
                        MessageBox.Show("Không có dữ liệu log để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return;
                }

                if (this.IsDisposed || LoggingData.IsDisposed)
                {
                    Console.WriteLine("Form hoặc DataGridView đã bị hủy. Thoát.");
                    return;
                }

                Console.WriteLine("Đang cập nhật DataGridView...");
                if (this.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        // Tạo danh sách hiển thị với các thuộc tính được định dạng
                        var displayList = logs.Select(l => new
                        {
                            MaLog = l.LoggingID,
                            MaNguoiDung = l.UserID,
                            TenNguoiDung = l.UserName,
                            NoiDung = l.Content,
                            ThoiGian = l.DateTime // Đã là chuỗi, không cần định dạng lại
                        }).ToList();

                        // Gắn dữ liệu vào DataGridView
                        LoggingData.DataSource = displayList;

                        // Đặt tiêu đề cho từng cột
                        LoggingData.Columns["MaLog"].HeaderText = "Mã Log";
                        LoggingData.Columns["MaNguoiDung"].HeaderText = "Mã Người Dùng";
                        LoggingData.Columns["TenNguoiDung"].HeaderText = "Tên Người Dùng";
                        LoggingData.Columns["NoiDung"].HeaderText = "Nội Dung";
                        LoggingData.Columns["ThoiGian"].HeaderText = "Thời Gian";

                        // Căn giữa nội dung và tiêu đề, tự động điều chỉnh kích thước cột
                        foreach (DataGridViewColumn col in LoggingData.Columns)
                        {
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }

                        LoggingData.Refresh();
                        Console.WriteLine("DataGridView đã được cập nhật.");
                    }));
                }
                else
                {
                    Console.WriteLine("Đang đặt DataSource trên luồng UI (trực tiếp)...");

                    var displayList = logs.Select(l => new
                    {
                        MaLog = l.LoggingID,
                        MaNguoiDung = l.UserID,
                        TenNguoiDung = l.UserName,
                        NoiDung = l.Content,
                        ThoiGian = l.DateTime
                    }).ToList();

                    LoggingData.DataSource = displayList;

                    LoggingData.Columns["MaLog"].HeaderText = "Mã Log";
                    LoggingData.Columns["MaNguoiDung"].HeaderText = "Mã Người Dùng";
                    LoggingData.Columns["TenNguoiDung"].HeaderText = "Tên Người Dùng";
                    LoggingData.Columns["NoiDung"].HeaderText = "Nội Dung";
                    LoggingData.Columns["ThoiGian"].HeaderText = "Thời Gian";

                    foreach (DataGridViewColumn col in LoggingData.Columns)
                    {
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                    LoggingData.Refresh();
                    Console.WriteLine("DataGridView đã được cập nhật.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi trong LoadLogDataAsync: {ex.Message}\nStack Trace: {ex.StackTrace}");
                if (!this.IsDisposed)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {

                Console.WriteLine("LoadLogDataAsync hoàn tất.");
            }
        }

        private void AdminLoggingbtn_Click(object sender, EventArgs e)
        {
            LoadLogDataAsync();
        }

        private void AdminMainTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedTabIndex = AdminMainTab.SelectedIndex;
            string selectedTabName = AdminMainTab.SelectedTab.Text;

            switch (selectedTabIndex)
            {
                case 0:
                    break;
                case 1:
                   
                    break;
                case 2:
                    LoadUserDataAsync();
                    break;
                case 3:
                    LoadServiceDataasync();
                    break;
                case 4:
                    LoadLogDataAsync();
                    break;
                default:
                    break;
            }
        }
    }
}