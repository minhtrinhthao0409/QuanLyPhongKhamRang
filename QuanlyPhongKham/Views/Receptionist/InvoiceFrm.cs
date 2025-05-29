using QuanlyPhongKham.Controllers;
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
        private readonly InvoiceService _invoiceService = new InvoiceService();
        private readonly InvoiceController _invoiceController = new InvoiceController();
        private readonly LoggingController _loggingController;
        public InvoiceFrm(User user)
        {
            this.user = user;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _invoiceService = new InvoiceService();
            _loggingController = new LoggingController();

            startTimePicker.Value = DateTime.Now.AddDays(-7);
            endTimePicker.Value = DateTime.Now.AddDays(1);


            Appointmentlbl.Click += menulbl_click;
            Patientlbl.Click += menulbl_click;
            Invoicelbl.Click += menulbl_click;
            Homelbl.Click += menulbl_click;

            InvoiceGridView.CellClick += InvoiceGridView_CellClick;
            InvoiceGridView.CellValueChanged += InvoiceGridView_CellValueChanged;
            InvoiceGridView.CellContentClick += InvoiceGridView_CellContentClick;
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

                List<Invoice> result;
                if (!string.IsNullOrWhiteSpace(patientPhoneNo))
                {
                    result = await _invoiceService.GetInvoiceByTime(startDate, endDate);
                }
                else
                {
                    result = await _invoiceService.SearchInvoicesAsync(patientPhoneNo, startDate, endDate);
                }

                BindingSource source = new BindingSource();
                source.DataSource = result;
                InvoiceGridView.DataSource = source;

                if (InvoiceGridView.Columns["CreatedAt"] != null)
                {
                    InvoiceGridView.Columns["CreatedAt"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    InvoiceGridView.Columns["CreatedAt"].HeaderText = "Ngày tạo";
                }

                if (InvoiceGridView.Columns["InvoiceId"] != null)
                    InvoiceGridView.Columns["InvoiceId"].HeaderText = "Mã hóa đơn";
                if (InvoiceGridView.Columns["PatientName"] != null)
                    InvoiceGridView.Columns["PatientName"].HeaderText = "Tên bệnh nhân";
                if (InvoiceGridView.Columns["TotalAmount"] != null)
                {
                    InvoiceGridView.Columns["TotalAmount"].HeaderText = "Tổng tiền";
                    InvoiceGridView.Columns["TotalAmount"].DefaultCellStyle.Format = "N0";
                }
                if (InvoiceGridView.Columns["PaidAmount"] != null)
                    InvoiceGridView.Columns["PaidAmount"].HeaderText = "Đã thanh toán";
                if (InvoiceGridView.Columns["Status"] != null)
                    InvoiceGridView.Columns["Status"].HeaderText = "Trạng thái";

                InvoiceGridView.Columns["PatientId"].Visible = false;

                // Thêm cột checkbox nếu chưa có
                if (!InvoiceGridView.Columns.Contains("PaidCheck"))
                {
                    DataGridViewCheckBoxColumn paidCheckCol = new DataGridViewCheckBoxColumn
                    {
                        HeaderText = "Xác nhận đã thanh toán",
                        Name = "PaidCheck",
                        Width = 120
                    };
                    InvoiceGridView.Columns.Add(paidCheckCol);
                }
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

                    if (InvoiceDetailGridView.Columns["ServiceName"] != null)
                        InvoiceDetailGridView.Columns["ServiceName"].HeaderText = "Dịch vụ";

                    if (InvoiceDetailGridView.Columns["UnitPrice"] != null)
                    {
                        InvoiceDetailGridView.Columns["UnitPrice"].HeaderText = "Đơn giá";
                        InvoiceDetailGridView.Columns["UnitPrice"].DefaultCellStyle.Format = "N0";
                    }

                    if (InvoiceDetailGridView.Columns["Quantity"] != null)
                        InvoiceDetailGridView.Columns["Quantity"].HeaderText = "Số lượng";

                    if (InvoiceDetailGridView.Columns["TotalPrice"] != null)
                    {
                        InvoiceDetailGridView.Columns["TotalPrice"].HeaderText = "Tổng tiền";
                        InvoiceDetailGridView.Columns["TotalPrice"].DefaultCellStyle.Format = "N0";
                    }

                    InvoiceDetailGridView.Columns["InvoiceId"].Visible = false;
                    InvoiceDetailGridView.Columns["InvoiceDetailId"].Visible = false;
                    if (InvoiceDetailGridView.Columns.Contains("Invoice"))
                        InvoiceDetailGridView.Columns["Invoice"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải chi tiết hóa đơn: " + ex.Message);
                }
            }
        }
        private void InvoiceGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InvoiceGridView.Columns[e.ColumnIndex].Name == "PaidCheck" && e.RowIndex >= 0)
            {
                InvoiceGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private async void InvoiceGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && InvoiceGridView.Columns[e.ColumnIndex].Name == "PaidCheck")
            {
                if (InvoiceGridView.Rows[e.RowIndex].DataBoundItem is Invoice invoice)
                {
                    try
                    {
                        await _invoiceController.UpdateInvoiceStatusAsync(invoice.InvoiceId);
                        invoice.Status = "Đã thanh toán"; // Cập nhật status thủ công
                        InvoiceGridView.Refresh(); // Cập nhật lại UI
                        MessageBox.Show("Cập nhật trạng thái thành công!");
                        await _loggingController.AddLoggingAsync(this.user.Id, this.user.UserName, $"Đã cập nhật trạng thái thanh toán hóa đơn {invoice.InvoiceId}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật trạng thái: " + ex.Message);
                    }
                }
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

        private void Searchbtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Searchbtn.PerformClick();
            }
        }
    }
}
