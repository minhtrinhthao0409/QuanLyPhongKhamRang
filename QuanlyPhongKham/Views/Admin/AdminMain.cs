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



namespace QuanlyPhongKham.Views.Admin
{
    public partial class AdminMain : Form
    {
        private User Admin { get; set; }
        private UserControllers _userControllers;
        private MedicalServiceController _medicalServiceController;

        public AdminMain(User user)
        {
            InitializeComponent();
            this.Admin = user;
            this._userControllers = new UserControllers();
            this._medicalServiceController = new MedicalServiceController();
            AdminIDtb.Text = user.Id;
            AdminNametb.Text = user.FullName;
            LoadUserDataAsync();
            LoadServiceDataasync();
            AdminQLTKUpdatebtn.Enabled = false;
            AdminQLTKDeletebtn.Enabled = false;
            AdminQLDVbtn.Enabled = false;
            AdminQLDVDelbtn.Enabled = false;
            //  AdminQLDVNameTb.Enabled = false;
        }
        private void AdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #region QLKH

        private async void LoadUserDataAsync()
        {
            AdminQLTKdata.DataSource = await _userControllers.GetAllUser();
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
        #endregion QLKH
        #region QLDV
        private async void LoadServiceDataasync()
        {
            AdminQLDVdata.DataSource = await _medicalServiceController.GetAllService();
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



    }
}
