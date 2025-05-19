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
using QuanlyPhongKham.Views;
using QuanlyPhongKham.Views.Admin;

namespace QuanlyPhongKham
{
    public partial class Login : Form
    {
        UserControllers userController;
        private User currentUser;
        public Login()
        {
            InitializeComponent();
            userController = new UserControllers();
            KeyPreview = true; //bat su kien nhan enter
        }

        private void linkQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            using (QuenMatKhau quenMatKhau = new QuenMatKhau())
            {
                quenMatKhau.ShowDialog();
            }
            this.Show();
        }

        private void linkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            using (DangKy dangKyForm = new DangKy())
            {
                dangKyForm.ShowDialog(); // Show modal
            }
            this.Show();
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
            if (password.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }

            var user = await userController.LoginAssyn(userName, password);
            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                if (user.Role == UserRole.Admin)
                {
                    AdminMain form = new AdminMain();
                    form.ShowDialog();
                }
                else if (user.Role == UserRole.Doctor)
                {
                    BacSi form = new BacSi(user);
                    form.ShowDialog();
                }
                else if (user.Role == UserRole.Receptionist)
                {
                    ReceptionistMain form = new ReceptionistMain(user);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tài khoản không có quyền truy cập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
