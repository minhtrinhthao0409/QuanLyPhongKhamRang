using QuanlyPhongKham.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyPhongKham.Views.Receptionist
{
    public partial class LeftSideMenu : Form
    {
        private User user;
        public LeftSideMenu()
        {
            //this.user = user;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Appointmentlbl.Click += MenuLabel_Click;
            Patientlbl.Click += MenuLabel_Click;
            Schedulelbl.Click += MenuLabel_Click;
            Invoicelbl.Click += MenuLabel_Click;
            Homelbl.Click += MenuLabel_Click;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private Form currentForm = null;

        protected virtual void MenuLabel_Click(object sender, EventArgs e)
        {
            if (currentForm != null && !currentForm.IsDisposed)
            {
                currentForm.BringToFront();
                return;
            }

            if (sender == Homelbl)
                currentForm = new ReceptionistMain(user);
            else if (sender == Appointmentlbl)
                currentForm = new AppointmentFrm(user);
            else if (sender == Patientlbl)
                currentForm = new PatientFrm(user);
            else if (sender == Schedulelbl)
                currentForm = new ScheduleFrm(user);
            else if (sender == Invoicelbl)
                currentForm = new InvoiceFrm(user);

            if (currentForm != null)
            {
                this.Hide();
                currentForm.FormClosed += (s, args) =>
                {
                    this.Show();
                    currentForm = null;
                };
                currentForm.Show();
            }
        }


        protected virtual void btnExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();

        }

    }
}
