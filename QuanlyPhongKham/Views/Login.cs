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

namespace QuanlyPhongKham
{
    public partial class Login : Form
    {
        UserControllers userController;
        public Login()
        {
            InitializeComponent();
            userController = new UserControllers();
            KeyPreview = true; //bat su kien nhan enter
        }

        private void linkQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();
        }

        private void linkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy login = new DangKy();
            login.ShowDialog();
        }

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtTendangnhap.Text;
            string password = txtMatKhau.Text;  
            if (userName.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return;
            }
            if(password.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }
            bool result = await userController.Login(userName, password);
            //String hasPassword = PasswordHasher.HashPassword(password);
            
            if (result)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }
    }
}
