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
    public partial class InvoiceFrm : Form
    {
        private User user;
        private Form currentForm = null;
        private readonly InvoiceService _invoiceService;

        public InvoiceFrm(User user)
        {
            this.user = user;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _invoiceService = new InvoiceService();

            Appointmentlbl.Click += menulbl_click;
            Patientlbl.Click += menulbl_click;
            //Schedulelbl.Click += menulbl_click;
            Invoicelbl.Click += menulbl_click;
            Homelbl.Click += menulbl_click;

            InvoiceGridView.CellClick += InvoiceGridView_CellClick;

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

        private async void Searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = startTimePicker.Value.Date;
                DateTime endDate = endTimePicker.Value.Date;
                string patientPhoneNo = patientPhoneNoTxt.Text.Trim();

                var result = await _invoiceService.SearchInvoicesAsync(patientPhoneNo, startDate, endDate);


                InvoiceGridView.DataSource = result;
                InvoiceGridView.Columns["PatientId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void InvoiceGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && InvoiceGridView.Rows[e.RowIndex].DataBoundItem is Invoice selectedInvoice)
            {
                try
                {
                    var details = await _invoiceService.GetInvoiceDetailsAsync(selectedInvoice.InvoiceId);
                    InvoiceDetailGridView.DataSource = details;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải chi tiết hóa đơn: " + ex.Message);
                }
            }
        }

        private void SignOutlbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
