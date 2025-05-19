using QuanlyPhongKham.Models;
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
    public partial class ReceptionistMain : Form
    {
        private User user;
        private string connectionString = @"QuanLyPhongKham.db";


        public ReceptionistMain(User user)
        {
            InitializeComponent();
            this.user = user;

            Appointmentlbl.Click += MenuLabel_Click;
            Patientlbl.Click += MenuLabel_Click;
            Schedulelbl.Click += MenuLabel_Click;
            Invoicelbl.Click += MenuLabel_Click;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        

        private void MenuLabel_Click(object sender, EventArgs e)
        {

            
            this.Hide();

            Form nextForm = null;

            if (sender == Appointmentlbl)
                nextForm = new AppointmentFrm();

            else if (sender == Patientlbl)
                nextForm = new PatientFrm();

            else if (sender == Schedulelbl)
                nextForm = new ScheduleFrm();

            else if (sender == Invoicelbl)
                nextForm = new InvoiceFrm();

            nextForm.Show();

            
        }

    }
}
