namespace QuanlyPhongKham.Views.Receptionist
{
    partial class InvoiceFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            panel2 = new System.Windows.Forms.Panel();
            Homelbl = new System.Windows.Forms.Label();
            Invoicelbl = new System.Windows.Forms.Label();
            Patientlbl = new System.Windows.Forms.Label();
            Appointmentlbl = new System.Windows.Forms.Label();
            SignOutlbl = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            Searchbtn = new System.Windows.Forms.Button();
            patientPhoneNoTxt = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            endTimePicker = new System.Windows.Forms.DateTimePicker();
            endTimelbl = new System.Windows.Forms.Label();
            start_time_lbl = new System.Windows.Forms.Label();
            startTimePicker = new System.Windows.Forms.DateTimePicker();
            InvoiceGridView = new System.Windows.Forms.DataGridView();
            InvoiceDetailGridView = new System.Windows.Forms.DataGridView();
            CrudPatient = new System.Windows.Forms.Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InvoiceGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InvoiceDetailGridView).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(Homelbl);
            panel2.Controls.Add(Invoicelbl);
            panel2.Controls.Add(Patientlbl);
            panel2.Controls.Add(Appointmentlbl);
            panel2.Controls.Add(SignOutlbl);
            panel2.Location = new System.Drawing.Point(14, 41);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(201, 851);
            panel2.TabIndex = 10;
            // 
            // Homelbl
            // 
            Homelbl.Cursor = System.Windows.Forms.Cursors.Hand;
            Homelbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Homelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            Homelbl.Location = new System.Drawing.Point(3, 275);
            Homelbl.Name = "Homelbl";
            Homelbl.Size = new System.Drawing.Size(194, 61);
            Homelbl.TabIndex = 7;
            Homelbl.Text = "Trang Chủ";
            Homelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Homelbl.Click += menulbl_click;
            // 
            // Invoicelbl
            // 
            Invoicelbl.Cursor = System.Windows.Forms.Cursors.Hand;
            Invoicelbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Invoicelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            Invoicelbl.Location = new System.Drawing.Point(3, 472);
            Invoicelbl.Name = "Invoicelbl";
            Invoicelbl.Size = new System.Drawing.Size(194, 61);
            Invoicelbl.TabIndex = 6;
            Invoicelbl.Text = "Quản Lý Hóa Đơn";
            Invoicelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Invoicelbl.Click += menulbl_click;
            // 
            // Patientlbl
            // 
            Patientlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            Patientlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Patientlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            Patientlbl.Location = new System.Drawing.Point(3, 411);
            Patientlbl.Name = "Patientlbl";
            Patientlbl.Size = new System.Drawing.Size(194, 61);
            Patientlbl.TabIndex = 5;
            Patientlbl.Text = "Quản Lý Bệnh Nhân";
            Patientlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Patientlbl.Click += menulbl_click;
            // 
            // Appointmentlbl
            // 
            Appointmentlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            Appointmentlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Appointmentlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            Appointmentlbl.Location = new System.Drawing.Point(3, 336);
            Appointmentlbl.Name = "Appointmentlbl";
            Appointmentlbl.Size = new System.Drawing.Size(194, 61);
            Appointmentlbl.TabIndex = 5;
            Appointmentlbl.Text = "Quản Lý Lịch Hẹn";
            Appointmentlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Appointmentlbl.Click += menulbl_click;
            // 
            // SignOutlbl
            // 
            SignOutlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            SignOutlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SignOutlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            SignOutlbl.Location = new System.Drawing.Point(3, 776);
            SignOutlbl.Name = "SignOutlbl";
            SignOutlbl.Size = new System.Drawing.Size(194, 61);
            SignOutlbl.TabIndex = 4;
            SignOutlbl.Text = "Đăng Xuất";
            SignOutlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            SignOutlbl.Click += SignOutlbl_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(Searchbtn);
            panel1.Controls.Add(patientPhoneNoTxt);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(endTimePicker);
            panel1.Controls.Add(endTimelbl);
            panel1.Controls.Add(start_time_lbl);
            panel1.Controls.Add(startTimePicker);
            panel1.Location = new System.Drawing.Point(234, 41);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(904, 275);
            panel1.TabIndex = 11;
            // 
            // Searchbtn
            // 
            Searchbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            Searchbtn.Location = new System.Drawing.Point(467, 157);
            Searchbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new System.Drawing.Size(106, 67);
            Searchbtn.TabIndex = 21;
            Searchbtn.Text = "Tìm kiếm";
            Searchbtn.UseVisualStyleBackColor = true;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // patientPhoneNoTxt
            // 
            patientPhoneNoTxt.Location = new System.Drawing.Point(193, 156);
            patientPhoneNoTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            patientPhoneNoTxt.Name = "patientPhoneNoTxt";
            patientPhoneNoTxt.Size = new System.Drawing.Size(241, 27);
            patientPhoneNoTxt.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(57, 157);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(116, 23);
            label5.TabIndex = 19;
            label5.Text = "Số điện thoại";
            // 
            // endTimePicker
            // 
            endTimePicker.Location = new System.Drawing.Point(597, 68);
            endTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            endTimePicker.Name = "endTimePicker";
            endTimePicker.Size = new System.Drawing.Size(239, 27);
            endTimePicker.TabIndex = 8;
            // 
            // endTimelbl
            // 
            endTimelbl.AutoSize = true;
            endTimelbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            endTimelbl.Location = new System.Drawing.Point(461, 68);
            endTimelbl.Name = "endTimelbl";
            endTimelbl.Size = new System.Drawing.Size(86, 23);
            endTimelbl.TabIndex = 7;
            endTimelbl.Text = "Đến ngày";
            // 
            // start_time_lbl
            // 
            start_time_lbl.AutoSize = true;
            start_time_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            start_time_lbl.Location = new System.Drawing.Point(53, 68);
            start_time_lbl.Name = "start_time_lbl";
            start_time_lbl.Size = new System.Drawing.Size(75, 23);
            start_time_lbl.TabIndex = 5;
            start_time_lbl.Text = "Từ ngày";
            // 
            // startTimePicker
            // 
            startTimePicker.Location = new System.Drawing.Point(192, 68);
            startTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            startTimePicker.Name = "startTimePicker";
            startTimePicker.Size = new System.Drawing.Size(241, 27);
            startTimePicker.TabIndex = 6;
            // 
            // InvoiceGridView
            // 
            InvoiceGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            InvoiceGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            InvoiceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            InvoiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            InvoiceGridView.DefaultCellStyle = dataGridViewCellStyle2;
            InvoiceGridView.Location = new System.Drawing.Point(238, 325);
            InvoiceGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            InvoiceGridView.Name = "InvoiceGridView";
            InvoiceGridView.RowHeadersWidth = 51;
            InvoiceGridView.Size = new System.Drawing.Size(899, 244);
            InvoiceGridView.TabIndex = 12;
            InvoiceGridView.CellClick += InvoiceGridView_CellClick;
            // 
            // InvoiceDetailGridView
            // 
            InvoiceDetailGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            InvoiceDetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InvoiceDetailGridView.Location = new System.Drawing.Point(234, 648);
            InvoiceDetailGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            InvoiceDetailGridView.Name = "InvoiceDetailGridView";
            InvoiceDetailGridView.RowHeadersWidth = 51;
            InvoiceDetailGridView.Size = new System.Drawing.Size(899, 244);
            InvoiceDetailGridView.TabIndex = 13;
            // 
            // CrudPatient
            // 
            CrudPatient.AutoSize = true;
            CrudPatient.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            CrudPatient.Location = new System.Drawing.Point(657, 589);
            CrudPatient.Name = "CrudPatient";
            CrudPatient.Size = new System.Drawing.Size(208, 32);
            CrudPatient.TabIndex = 16;
            CrudPatient.Text = "Chi Tiết Hóa Đơn";
            // 
            // InvoiceFrm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1152, 908);
            Controls.Add(CrudPatient);
            Controls.Add(InvoiceDetailGridView);
            Controls.Add(InvoiceGridView);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "InvoiceFrm";
            Text = "InvoiceForm";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InvoiceGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)InvoiceDetailGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Homelbl;
        private System.Windows.Forms.Label Invoicelbl;
        private System.Windows.Forms.Label Patientlbl;
        private System.Windows.Forms.Label Appointmentlbl;
        private System.Windows.Forms.Label SignOutlbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox patientPhoneNoTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label endTimelbl;
        private System.Windows.Forms.Label start_time_lbl;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DataGridView InvoiceGridView;
        private System.Windows.Forms.DataGridView InvoiceDetailGridView;
        private System.Windows.Forms.Label CrudPatient;
    }
}