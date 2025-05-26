using Microsoft.VisualBasic.ApplicationServices;
using QuanlyPhongKham.Controllers;
using QuanlyPhongKham.Models;
using QuanlyPhongKham.Repository;
using QuanlyPhongKham.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using User = QuanlyPhongKham.Models.User;

namespace QuanlyPhongKham.Views.Receptionist
{
    public partial class AppointmentFrm : Form
    {
        private Models.User user;
        private List<User> doctors;
        private Form currentForm = null;

        private readonly AppointmentRepository _appointmentRepo;
        private AppointmentController _appointmentControllers;
        private UserControllers _userController;

        public delegate void AppointmentSelectedHandler(string name, string phone);
        public event AppointmentSelectedHandler OnAppointmentSelected;


        public AppointmentFrm(User user)
        {
            this.user = user;
            InitializeComponent();
            _appointmentControllers = new AppointmentController();
            _userController = new UserControllers();


            this.StartPosition = FormStartPosition.CenterScreen;


            Appointmentlbl.Click += menulbl_click;
            Patientlbl.Click += menulbl_click;
            //Schedulelbl.Click += menulbl_click;
            Invoicelbl.Click += menulbl_click;
            Homelbl.Click += menulbl_click;
            cbDoctorName.SelectedIndexChanged += cbDoctorName_SelectedIndexChanged;
            cbDoctorEmail.SelectedIndexChanged += cbDoctorEmail_SelectedIndexChanged;


            //LoadDoctorNameComboBox();
            this.Load += AppointmentFrm_Load;

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
        private async void LoadDoctorNameComboBox()
        {


            var doctorList = doctors
                .Where(u => u.Role == UserRole.Doctor)
                .ToList();

            cbDoctorName.DataSource = null;
            cbDoctorName.Items.Clear();

            cbDoctorName.DisplayMember = "FullName";
            cbDoctorName.ValueMember = "Id";
            cbDoctorName.DataSource = doctorList;

            cbDoctorEmail.DataSource = null;
            cbDoctorEmail.Items.Clear();

            cbDoctorEmail.DisplayMember = "Email";
            cbDoctorEmail.ValueMember = "Id";
            cbDoctorEmail.DataSource = doctorList;
        }




        private async void Searchbtn_Click(object sender, EventArgs e)
        {
            string doctorName = doctorNameTextbox.Text.Trim();
            string patientPhoneNo = patientPhoneNoTextbox.Text.Trim();
            DateTime startDate = StartDatePicker.Value.Date;
            DateTime endDate = EndDatePicker.Value.Date;

            try
            {
                List<Appointment> result = await _appointmentControllers.GetDoctorAppointmentsAsync_v2(startDate, endDate, doctorName, patientPhoneNo);


                SearchAppointmentGridView.DataSource = result;


                SearchAppointmentGridView.Columns["DoctorId"].Visible = false;
                SearchAppointmentGridView.Columns["PatientId"].Visible = false;
                SearchAppointmentGridView.Columns["AppointmentId"].Visible = false;
                //SearchAppointmentGridView.Columns["Appointments"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void AddScheduleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string patientName = PatientNameTxt.Text.Trim();
                string patientPhoneNo = PatientPhoneNoTxt.Text.Trim();

                string doctorName = cbDoctorName.SelectedValue.ToString();
                string doctorEmail = cbDoctorEmail.SelectedValue.ToString();

                DateTime date = startTimePicker.Value.Date;
                TimeSpan startTime = TimeSpan.Parse(startTimeMask.Text.Trim());
                TimeSpan endTime = TimeSpan.Parse(endTimeMask.Text.Trim());

                if (cbDoctorName.SelectedItem is User selectedDoctor)
                {
                    doctorName = selectedDoctor.FullName;

                }
                if (cbDoctorEmail.SelectedItem is User selectedEmail)
                {
                    doctorEmail = selectedEmail.Email;
                }


                bool result = await _appointmentControllers.AddAppointmentAsync_v2(doctorName, patientName, doctorEmail, patientPhoneNo, date, startTime, endTime);


                if (result)
                {
                    MessageBox.Show("Thêm lịch hẹn thành công!");
                    //ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Thêm lịch hẹn thất bại.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message +
                                "\nChi tiết: " + ex.InnerException?.Message +
                                "\nToàn bộ: " + ex.ToString());
            }

        }

        private void cbDoctorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDoctorName.SelectedValue == null || doctors == null) return;

            string selectedName = cbDoctorName.SelectedValue.ToString();

            var selectedDoctor = doctors.FirstOrDefault(p => p.FullName == selectedName && p.Role == UserRole.Doctor);

            if (selectedDoctor != null)
            {
                cbDoctorName.SelectedValue = selectedDoctor.FullName;
            }
        }

        private async void tabPage1_Click(object sender, EventArgs e)
        {


        }

        private async void AppointmentFrm_Load(object sender, EventArgs e)
        {

            doctors = await _userController.GetAllUser();


            if (doctors == null || doctors.Count == 0)
            {
                MessageBox.Show("⚠ Không có dữ liệu người dùng.");
                return;
            }

            LoadDoctorNameComboBox();

        }

        private void cbDoctorEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDoctorEmail.SelectedValue == null || doctors == null) return;

            string email = cbDoctorEmail.SelectedValue.ToString();
            string doctorName = cbDoctorName.SelectedValue.ToString();

            var selectedEmail = doctors.FirstOrDefault(p => p.Email == email && p.Role == UserRole.Doctor && p.FullName == doctorName);

            if (selectedEmail != null)
            {
                cbDoctorName.SelectedValue = selectedEmail.Email;
            }
        }

        private void searchPatientbtn_Click(object sender, EventArgs e)
        {
            var searchForm = new PatientFrm(user);


            searchForm.OnPatientSelected += (name, phone) =>
            {
                PatientNameTxt.Text = name;
                PatientPhoneNoTxt.Text = phone;
            };

            searchForm.ShowDialog(); // modal
        }

        private void SearchAppointmentGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SignOutlbl_Click(object sender, EventArgs e)
        {
            
            
            Application.Exit();
        }
    }
}


