using QuanlyPhongKham.Models;
using QuanlyPhongKham.Repository;
using QuanlyPhongKham.Views.Receptionist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyPhongKham.Views
{
    public partial class ReceptionistMain : LeftSideMenu
    {
        private User user;
        private Form currentForm = null;
        
        private readonly AppointmentRepository _appointmentRepo = new AppointmentRepository();


        public ReceptionistMain(User user)
        {
            InitializeComponent();
            this.user = user;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

    }
}
