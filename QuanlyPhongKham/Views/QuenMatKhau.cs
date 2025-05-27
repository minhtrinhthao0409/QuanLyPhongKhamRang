using System;
using System.Drawing;
using System.Windows.Forms;
using QuanlyPhongKham.Controllers;
using QuanlyPhongKham.Services;

namespace QuanlyPhongKham
{
    public partial class QuenMatKhau : Form
    {
        UserControllers userControllers;
        private readonly UserService _userService = new UserService();
        public QuenMatKhau()
        {
            InitializeComponent();
            userControllers = new UserControllers();
            KeyPreview = true; 
        }
        
        private async void btnLayLaiMatKhau_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                lblKetQua.Text = "Vui lòng nhập email.";
                return;
            }

            var newPassword = await _userService.ResetPasswordAsync(email);
            if (newPassword == null)
            {
                lblKetQua.Text = "Không tìm thấy email.";
            }
            else
            {
                lblKetQua.Text = $"Mật khẩu mới của bạn là: {newPassword}";
            }
        }
        private void QuenMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLayLaiMatKhau.PerformClick();
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuenMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close(); //???có nên exit không hay là close
        }
    }
}
