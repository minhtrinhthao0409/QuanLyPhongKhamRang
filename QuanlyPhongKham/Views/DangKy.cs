using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanlyPhongKham.Controllers;
using QuanlyPhongKham.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
      
       
        private async void btnDangKy_Click(object sender, EventArgs e)
        {
            string username = txtTentaikhoan.Text;
            string password = txtMatKhau.Text;
            string xnpasswoed = txt_XNMatKhai.Text;
            string email = txtEmail.Text;
            if (password != xnpasswoed)
            {
                MessageBox.Show("Password không trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            int result = await userController.CreateUser(username, password, email);
            if (result == 0)
            {

                MessageBox.Show("Đăng ký không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Chúc mừng! Bạn đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    this.Close();
                }
            }

        }

        private void DangKy_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void DangKy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangKy.PerformClick();
            }
        }
    }
}
