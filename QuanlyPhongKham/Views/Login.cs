﻿using System;
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
using QuanlyPhongKham.Services;
using QuanlyPhongKham.Views;
using QuanlyPhongKham.Views.Admin;
using QuanlyPhongKham.Views.Receptionist;

namespace QuanlyPhongKham
{
    public partial class Login : Form
    {
        UserControllers userController;
        LoggingController loggingController;
        public Login()
        {
            InitializeComponent();
            userController = new UserControllers();
            loggingController = new LoggingController();
            KeyPreview = true;
        }



        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtTendangnhap.Text;
            string password = PasswordHasher.HashPassword(txtMatKhau.Text);
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

            var user = await userController.LoginAsync(userName, password);
            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                string content = $"Tài khoản {user.UserName} đăng nhập";
                await loggingController.AddLoggingAsync(user.Id, userName, content);

                Form form = null;

                if (user.Role == UserRole.Admin)
                {
                    form = new AdminMain(user);
                }
                else if (user.Role == UserRole.Doctor)
                {
                    form = new BacSi(user, new LoggingController());
                }
                else if (user.Role == UserRole.Receptionist)
                {
                    form = new ReceptionistMainFrm(user);
                }
                else
                {
                    MessageBox.Show("Tài khoản không có quyền truy cập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //this.Show();
                this.Hide(); // Ẩn LoginForm
                form.FormClosed += (s, args) => this.Close(); // Khi mainForm đóng thì LoginForm cũng đóng
                form.Show();
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

        private void showPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void showPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = false;
        }


        //private void showPassword_CheckedChanged(object sender, EventArgs e)
        //{
        //    txtMatKhau.UseSystemPasswordChar = false;
        //}
    }
}
