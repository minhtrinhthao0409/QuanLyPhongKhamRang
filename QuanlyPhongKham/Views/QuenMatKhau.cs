using System;
using System.Drawing;
using System.Windows.Forms;
using QuanlyPhongKham.Controllers;

namespace QuanlyPhongKham
{
    public partial class QuenMatKhau : Form
    {
        UserControllers userControllers;
        public QuenMatKhau()
        {
            InitializeComponent();
            userControllers = new UserControllers();
            KeyPreview = true; //bat su kien nhan enter

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            lblResult.Text = await userControllers.GetPasswordByEmail(email);

        }

        private void QuenMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuenMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
