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
        private UserControllers _userControllers; // Add an instance of UserControllers

        public AdminMain(User user)
        {
            InitializeComponent();
            this.Admin = user;
            this._userControllers = new UserControllers(); // Initialize the instance
            AdminIDtb.Text = user.Id;
            AdminNametb.Text = user.FullName;
            LoadUserDataAsync(); // Call the async method to load user data
        }

        private async void LoadUserDataAsync()
        {
            AdminQLTKdata.DataSource = await _userControllers.GetAllUser(); // Use the instance and await in an async method
        }

        private void AdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
