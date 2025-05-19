using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyPhongKham.Views.Admin
{
    public partial class AdminBCTC : Form
    {
        public AdminBCTC()
        {
            InitializeComponent();
        }

        private void AdminBCTC_Load(object sender, EventArgs e)
        {

        }

        private void AdminBCTC_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
