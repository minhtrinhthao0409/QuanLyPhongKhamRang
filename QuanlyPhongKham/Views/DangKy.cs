using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanlyPhongKham.Controllers;
using QuanlyPhongKham.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SQLite;
using QuanlyPhongKham.config;

namespace QuanlyPhongKham
{
    public partial class DangKy : Form
    {
        UserControllers userController;
        public DangKy()
        {
            InitializeComponent();
            userController = new UserControllers();
            KeyPreview = true;
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private async void btnDangKy_Click(object sender, EventArgs e)
        {
            /*
             string username = txtTentaikhoan.Text.Trim();
             string password = txtMatKhau.Text;
             string confirmPassword = txt_XNMatKhai.Text;
             string email = txtEmail.Text.Trim();
             string fullName = txtHoten.Text.Trim();
             string phone = txtSDT.Text.Trim();

             if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                 string.IsNullOrWhiteSpace(confirmPassword) || string.IsNullOrWhiteSpace(fullName) ||
                 (!rbDoctor.Checked && !rbCashier.Checked))
             {
                 MessageBox.Show("Vui lòng điền đầy đủ thông tin và chọn vai trò.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }

             if (password != confirmPassword)
             {
                 MessageBox.Show("Mật khẩu xác nhận không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }

             int role = rbDoctor.Checked ? 2 : 3;

             try
             {
                 bool success = await userController.CreateAccount(username, password, email, fullName, phone, role);
                 if (success)
                 {
                     MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     this.Close();
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
            */

            string username = txtTentaikhoan.Text.Trim();
            string password = txtMatKhau.Text;
            string confirmPassword = txt_XNMatKhai.Text;
            string email = txtEmail.Text.Trim();
            string fullName = txtHoten.Text.Trim();
            string phone = txtSDT.Text.Trim();

            ValidInput validCheck = new ValidInput();
            bool isValidPassword = validCheck.IsStrongPassword(password);
            bool isValidPhoneNo = validCheck.IsValidPhoneNumber(phone);
            bool isValidEmail = validCheck.IsValidEmail(email);

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) || string.IsNullOrWhiteSpace(fullName) ||
                (!rbAdmin.Checked && !rbDoctor.Checked && !rbCashier.Checked))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin và chọn vai trò.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isValidPassword)
            {
                MessageBox.Show("Vui lòng đặt mật khẩu có nhiều hơn 8 ký tự, bao gồm cả chữ hoa, chữ thường và ký tự đặc biệt");
                return;
            }

            if (!isValidPhoneNo)
            {
                MessageBox.Show("Số điện thoại không hợp lệ. XIn vui lòng nhập lại");
                return;
            }

            if (!isValidEmail)
            {
                MessageBox.Show("Email không hợp lệ. XIn vui lòng nhập lại");
                return;
            }


            int role = rbAdmin.Checked ? 1 : (rbDoctor.Checked ? 2 : 3);
            
            bool checkUsername = await userController.CheckUsernameExists(username);

            if (checkUsername)
            {
                MessageBox.Show("Tên người dùng đã tồn tại. Vui lòng chọn tên khác.");
                return;
            }
            
            try
            {
                bool success = await userController.CreateAccount(username, password, email, fullName, phone, role);
                if (success)
                {
                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    using (Login login = new Login())
                    {
                        login.ShowDialog();
                    }
                    this.Show();
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

        private void DangKy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangKy.PerformClick();
            }
             
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //using (Login login = new Login()) 
            //{
            //    login.ShowDialog();
            //}
            //this.Show();
            this.Close();
        }

        private void DangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
