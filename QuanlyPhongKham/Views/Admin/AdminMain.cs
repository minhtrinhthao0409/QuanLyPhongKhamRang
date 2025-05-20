using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanlyPhongKham.Models;


namespace QuanlyPhongKham.Views.Admin
{
    public partial class AdminMain : Form
    {
        private User Admin { get; set; }
        public AdminMain(User user)
        {
            InitializeComponent();
            this.Admin = user;
            AdminIDtb.Text = user.Id;
            AdminNametb.Text = user.FullName;
        }
         
        private void AdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
