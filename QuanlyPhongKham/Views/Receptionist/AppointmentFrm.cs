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

        //private readonly AppointmentRepository _appointmentRepo;
        private AppointmentController _appointmentControllers;
        private UserControllers _userController;
        private readonly LoggingService _loggService;

        public delegate void AppointmentSelectedHandler(string name, string phone);
        public event AppointmentSelectedHandler OnAppointmentSelected;


        public AppointmentFrm(User user)
        {
            this.user = user;
            InitializeComponent();
            _appointmentControllers = new AppointmentController();
            _userController = new UserControllers();
            _loggService = new LoggingService();


            this.StartPosition = FormStartPosition.CenterScreen;


            Appointmentlbl.Click += menulbl_click;
            Patientlbl.Click += menulbl_click;
            //Schedulelbl.Click += menulbl_click;
            Invoicelbl.Click += menulbl_click;
            Homelbl.Click += menulbl_click;
            cbDoctorName.SelectedIndexChanged += cbDoctorName_SelectedIndexChanged;
            cbDoctorEmail.SelectedIndexChanged += cbDoctorEmail_SelectedIndexChanged;

            startTimePicker.Value = DateTime.Now;
            startTimePicker.MinDate = DateTime.Today;

            StartDatePicker.Value = DateTime.Today.AddDays(-7);
            EndDatePicker.Value = DateTime.Today;

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
        private void LoadDoctorNameComboBox()
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
                SearchAppointmentGridView.Columns["PaymentStatus"].Visible = false;

                SearchAppointmentGridView.Columns["PatientName"].HeaderText = "Tên bệnh nhân";
                SearchAppointmentGridView.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
                SearchAppointmentGridView.Columns["DoctorName"].HeaderText = "Bác sĩ phụ trách";
                SearchAppointmentGridView.Columns["AppointmentDate"].HeaderText = "Ngày hẹn";
                SearchAppointmentGridView.Columns["StartTime"].HeaderText = "Giờ bắt đầu";
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
                    await _loggService.AddLoggingAsync(this.user.Id, this.user.UserName, $"Thêm lịch hẹn cho bệnh nhân {patientName} với bác sĩ {doctorName} lúc {startTime} ngày {date}");
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
                MessageBox.Show("Không có dữ liệu người dùng.");
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

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();

                var loginForm = new Login();
                loginForm.FormClosed += (s, args) => Application.Exit();
                loginForm.Show();
            }
        }

        private void AddScheduleBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddScheduleBtn.PerformClick();
            }
        }

        private void Searchbtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Searchbtn.PerformClick();
            }
        }

        private void AppointmentFrm_Load_1(object sender, EventArgs e)
        {

        }
    }
}


