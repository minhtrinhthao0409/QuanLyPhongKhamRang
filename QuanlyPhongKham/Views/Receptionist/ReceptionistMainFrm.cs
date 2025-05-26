using QuanlyPhongKham.Controllers;
using QuanlyPhongKham.Models;
using QuanlyPhongKham.Repository;
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
    public partial class ReceptionistMainFrm : Form
    {
        private User user;
        private Form currentForm = null;

        private readonly AppointmentRepository _appointmentRepo = new();
        private readonly AppointmentController _appointmentController;
        private readonly UserRepository _userRepo = new();

        public ReceptionistMainFrm(User user)
        {
            this.user = user;
            InitializeComponent();
            _appointmentController = new AppointmentController();
            this.StartPosition = FormStartPosition.CenterScreen;

            Appointmentlbl.Click += menulbl_click;
            Patientlbl.Click += menulbl_click;
            //Schedulelbl.Click += menulbl_click;
            Invoicelbl.Click += menulbl_click;
            Homelbl.Click += menulbl_click;

            Welcomelbl.Text = $"Welcome, {user.FullName}";
            Usernamelbl.Text = $"Username: {user.UserName}";
            Emaillbl.Text = $"Email: {user.Email}";
        }

        private void menulbl_click(object sender, EventArgs e)
        {
            if (currentForm != null && !currentForm.IsDisposed)
            {
                currentForm.BringToFront();
                return;
            }

            if (sender == Homelbl)
                currentForm = new ReceptionistMainFrm(user);
            else if (sender == Appointmentlbl)
                currentForm = new AppointmentFrm(user);
            else if (sender == Patientlbl)
                currentForm = new PatientFrm(user);
            //else if (sender == Schedulelbl)
            //    currentForm = new ScheduleFrm(user);
            else if (sender == Invoicelbl)
                currentForm = new InvoiceFrm(user);

            if (currentForm != null)
            {
                this.Hide();
                currentForm.FormClosed += (s, args) =>
                {
                    Application.Exit();
                };
                currentForm.Show();
            }

        }

        private void UpcomingAppointmentView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void ReceptionistMainFrm_Load(object sender, EventArgs e)
        {
            DateTime Date = DateTime.Now.Date;
            //DateTime endDate = EndDatePicker.Value.Date;

            try
            {
                List<Appointment> result = await _appointmentController.GetAllAppointmentsAsync();


                UpcomingAppointmentView.DataSource = result;


                UpcomingAppointmentView.Columns["DoctorId"].Visible = false;
                UpcomingAppointmentView.Columns["PatientId"].Visible = false;
                UpcomingAppointmentView.Columns["AppointmentId"].Visible = false;
                //SearchAppointmentGridView.Columns["Appointments"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignOutlbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
