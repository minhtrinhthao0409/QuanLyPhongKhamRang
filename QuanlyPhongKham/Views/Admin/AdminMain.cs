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


namespace QuanlyPhongKham.Views.Admin
{
    public partial class AdminMain : Form
    {
        private User Admin { get; set; }
        private UserControllers _userControllers;

        public AdminMain(User user)
        {
            InitializeComponent();
            this.Admin = user;
            this._userControllers = new UserControllers();
            AdminIDtb.Text = user.Id;
            AdminNametb.Text = user.FullName;
            LoadUserDataAsync();
        }

        private async void LoadUserDataAsync()
        {
            AdminQLTKdata.DataSource = await _userControllers.GetAllUser();
        }


        private void AdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            if(rolestring == "Admin" || rolestring == "Null")
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
    }
}
