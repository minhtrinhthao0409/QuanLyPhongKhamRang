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

        //private readonly AppointmentRepository _appointmentRepo = new();
        private readonly AppointmentController _appointmentController;
        //private readonly UserRepository _userRepo = new();
        private readonly MedicalServiceController _medicalServiceController;

        public ReceptionistMainFrm(User user)
        {
            this.user = user;
            InitializeComponent();
            _appointmentController = new AppointmentController();
            _medicalServiceController = new MedicalServiceController();
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
                UpcomingAppointmentView.Columns["PaymentStatus"].Visible = false;
                UpcomingAppointmentView.Columns["EndTime"].Visible = false;


                UpcomingAppointmentView.Columns["PatientName"].HeaderText = "Tên bệnh nhân";
                UpcomingAppointmentView.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
                UpcomingAppointmentView.Columns["DoctorName"].HeaderText = "Bác sĩ phụ trách";
                UpcomingAppointmentView.Columns["AppointmentDate"].HeaderText = "Ngày hẹn";
                UpcomingAppointmentView.Columns["StartTime"].HeaderText = "Giờ bắt đầu";
                //UpcomingAppointmentView.Columns["EndTime"].HeaderText = "Giờ kết thúc";



                var services = _medicalServiceController.GetAllService();
                var loadservices = services.Result.Select(s => new
                {
                    s.ServicesId,
                    s.ServicesName,
                    CurrentPrice = string.Format("{0:N0} VNĐ", s.CurrentPrice)
                }).OrderBy(s => s.ServicesName).ToList();
                ServiceGridView1.DataSource = loadservices;
                ServiceGridView1.Columns["ServicesId"].Visible=false;
                ServiceGridView1.Columns["ServicesName"].HeaderText = "Tên dịch vụ";
                ServiceGridView1.Columns["CurrentPrice"].HeaderText = "Giá Hiện Hành";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void Editbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ admin để chỉnh sửa thông tin!");
        }
    }
}
