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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanlyPhongKham.Views.Receptionist
{
    public partial class AppointmentFrm : Form
    {
        private User user;
        private Form currentForm = null;

        private readonly AppointmentRepository _appointmentRepo;
        private AppointmentController _appointmentControllers;
        private readonly UserRepository _userRepo = new();

        public AppointmentFrm(User user)
        {
            this.user = user;
            InitializeComponent();
            _appointmentControllers = new AppointmentController();


            this.StartPosition = FormStartPosition.CenterScreen;


            Appointmentlbl.Click += menulbl_click;
            Patientlbl.Click += menulbl_click;
            Schedulelbl.Click += menulbl_click;
            Invoicelbl.Click += menulbl_click;
            Homelbl.Click += menulbl_click;

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

        private async void Searchbtn_Click(object sender, EventArgs e)
        {
            string doctorName = doctorNameTextbox.Text.Trim();
            string patientPhoneNo = patientPhoneNoTextbox.Text.Trim();
            DateTime startDate = StartDatePicker.Value.Date;
            DateTime endDate = EndDatePicker.Value.Date;

            try
            {
                List<Appointment> result = await _appointmentControllers.GetDoctorAppointmentsAsync_v2(startDate, endDate, doctorName, patientPhoneNo);

                // Gán kết quả vào DataGridView
                SearchAppointmentGridView.DataSource = result;
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

                string doctorName = DoctorNameTxT.Text.Trim();
                string doctorPhoneNo = DoctorPhoneNoTxt.Text.Trim();

                DateTime date = startTimePicker.Value;
                TimeSpan startTime = TimeSpan.Parse(startTimeTxt.Text.Trim());
                TimeSpan endTime = TimeSpan.Parse(endTimeTxt.Text.Trim());


                bool result = await _appointmentControllers.AddAppointmentAsync_v2(doctorName, patientName, doctorPhoneNo, patientPhoneNo, date, startTime, endTime);


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
    }
 }

