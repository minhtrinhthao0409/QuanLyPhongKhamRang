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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanlyPhongKham.Views.Receptionist
{
    public partial class PatientFrm : Form
    {
        private User user;
        private Form currentForm = null;
        private object selectedGender;
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
                    Application.Exit();
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
                DateTime dob = dateTimePicker1.Value.Date;
                
                string selectedGender = cbGender.SelectedItem?.ToString()?.Trim() ?? "";
                bool gender = selectedGender == "Male"; // Nam 1 Nữ 0

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
            //listBox2.Items.Clear();
            //listBox2.Items.Add("Male");
            //listBox2.Items.Add("Female");
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

        private void ResetSearchPatientbtn_Click(object sender, EventArgs e)
        {
            PatientNameTxt.Text = "";
            PatientPhoneNoTxt.Text = "";
            patientEmailTxt.Text = "";
        }

        private async void SearchPatientBtn_Click(object sender, EventArgs e)
        {
            string name = PatientNameTxt.Text.Trim();
            string phoneNo = PatientPhoneNoTxt.Text.Trim();
            string email = patientEmailTxt.Text.Trim();

            try
            {
                List<Patient> result = await _patientService.SearchPatientsAsync(name, phoneNo, email);

                // Gán kết quả vào DataGridView
                SearchPatientResultView.DataSource = result;


                SearchPatientResultView.Columns["PatientId"].Visible = false;
                SearchPatientResultView.Columns["GuardianId"].Visible = false;
                SearchPatientResultView.Columns["MedRec"].Visible = false;
                //SearchPatientResultView.Columns["Appoinments"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ResetInfoBtn_Click(object sender, EventArgs e)
        {
            currentNameTxt.Text = "";
            currentPhoneNoTxt.Text = "";
            currentEmailTxt.Text = "";

            updatedPhoneNoTxt.Text = "";
            updatedEmailTxt.Text = "";
            updatedGuardianTxt.Text = "";
        }

        private async void UpdateInfoBtn_Click(object sender, EventArgs e)
        {
            string currentName = currentNameTxt.Text.Trim();
            string currentPhoneNo = currentPhoneNoTxt.Text.Trim();
            string currentEmail = currentEmailTxt.Text.Trim();

            string updatedPhoneNo = updatedPhoneNoTxt.Text.Trim();
            string updatedGuardianName = updatedGuardianTxt.Text.Trim();
            string updatedEmail = updatedEmailTxt.Text.Trim();

            //try
            //{
            //    //bool result = await _patientService.UpdatePatientAsync(
            //    //    name: currentName,
            //    //    phoneNumber: currentPhoneNo,
            //    //    email: currentEmail
            //        //newPhone: string.IsNullOrWhiteSpace(updatedPhoneNo) ? null : updatedPhoneNo,
            //        //newEmail: string.IsNullOrWhiteSpace(updatedEmail) ? null : updatedEmail,
            //        //newGuardianName: string.IsNullOrWhiteSpace(updatedGuardianName) ? null : updatedGuardianName,
            //        //newGuardianPhone: string.IsNullOrWhiteSpace(updatedPhoneNo) ? null : updatedPhoneNo,
            //        //newGuardianEmail: string.IsNullOrWhiteSpace(updatedEmail) ? null : updatedEmail
            //    );


            //    if (result)
            //    {
            //        MessageBox.Show("Cập nhật thông tin thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Không có thay đổi nào được thực hiện.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGender = cbGender.SelectedItem.ToString();
        }
    }
}
