using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Linq;
using QuanlyPhongKham.Models;
using QuanlyPhongKham.Controllers;
using QuanlyPhongKham.Views.Receptionist;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;

namespace QuanlyPhongKham.Views
{
    public partial class BacSi : Form
    {
        AppointmentController appointmentController;
        private PatientController patientController = new PatientController();
        private Dictionary<string, string> patientMap;
        private string currentDoctorId;
        private string currentDoctorName;
        private User user;
        public BacSi(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnLoadAppointments_Click(object sender, EventArgs e)
        {

        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            string doctorId = currentDoctorId;
            string patientId = cbPatientName.SelectedValue.ToString();
            DateTime date = dtpAppointmentDate.Value;

            if (!TimeSpan.TryParse(mtbStartTime.Text, out TimeSpan startTime))
            {
                MessageBox.Show("Giờ bắt đầu không hợp lệ! Vui lòng nhập đúng định dạng HH:mm.");
                return;
            }

            if (!TimeSpan.TryParse(mtbEndTime.Text, out TimeSpan endTime))
            {
                MessageBox.Show("Giờ kết thúc không hợp lệ! Vui lòng nhập đúng định dạng HH:mm.");
                return;
            }

            if (endTime <= startTime)
            {
                MessageBox.Show("Giờ kết thúc phải sau giờ bắt đầu.");
                return;
            }

            bool result = appointmentController.AddAppointment(doctorId, patientId, date, startTime, endTime);
            if (result)
                MessageBox.Show("Đặt lịch thành công!");
            else
                MessageBox.Show("Lịch bị trùng hoặc lỗi xảy ra.");
        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {

        }

        private void BacSi_Load(object sender, EventArgs e)
        {
            appointmentController = new AppointmentController();
            currentDoctorId = user.Id;
            currentDoctorName = user.UserName;
            LoadPatients();
        }
        private void LoadPatients()
        {
            var patients = patientController.GetAllPatients();

            cbPatientId.DataSource = new BindingSource(patients, null);
            cbPatientId.DisplayMember = "PatientId";
            cbPatientId.ValueMember = "PatientId";

            cbPatientName.DataSource = new BindingSource(patients, null);
            cbPatientName.DisplayMember = "Name";
            cbPatientName.ValueMember = "PatientId";
        }

        private void btnAddInvoiceService_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculateInvoiceTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
        }



        private void BacSi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cbPatientId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPatientId.SelectedItem is Patient selectedPatient)
            {
                cbPatientName.Text = selectedPatient.Name;
            }
        }
    }
}