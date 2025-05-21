using QuanlyPhongKham.Models;
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

namespace QuanlyPhongKham.Views.Receptionist
{
    public partial class PatientFrm : Form
    {
        private User user;
        private Form currentForm = null;

        private readonly PatientService _patientService;


        public PatientFrm(User user)
        {
            InitializeComponent();
            this.user = user;
            _patientService = new PatientService();



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

        private async void AddPatientbtn_Click(object sender, EventArgs e)
        {

            try
            {
                string name = PatientName.Text.Trim();
                string phoneNo = PatientPhoneNo.Text.Trim();
                string? guardianName = Guardian.Text.Trim();
                string email = PatientEmail.Text.Trim();
                DateTime dob = dateTimePicker1.Value;
                bool gender = listBox2.Text.Trim() == "Male";

                Guid patientId = Guid.NewGuid();
                Guid? guardianId = null;

                int result;
                

                if (!string.IsNullOrWhiteSpace(guardianName))
                {

                    guardianId = Guid.NewGuid();
                    result = await _patientService.CreatePatientAsync(
                        patientId, name, gender, phoneNo, email, dob, guardianId);
                    int result_guardian = await _patientService.CreateGuardianAsync(guardianId.Value, guardianName, phoneNo, email);
                }
                else
                {
                    result = await _patientService.CreatePatientAsync(
                        patientId, name, gender, phoneNo, email, dob);
                }


                if (result > 0)
                {
                    MessageBox.Show("Thêm bệnh nhân thành công!");
                    //ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Thêm bệnh nhân thất bại.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message +
                                "\nChi tiết: " + ex.InnerException?.Message +
                                "\nToàn bộ: " + ex.ToString());
            }

        }

        private void PatientFrm_Load(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.Items.Add("Male");
            listBox2.Items.Add("Female");
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            PatientName.Text = "";
            PatientPhoneNo.Text = "";
            Guardian.Text = "";
            PatientEmail.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            //listBox2.SelectedItem = "Male";
         }
    }
}
