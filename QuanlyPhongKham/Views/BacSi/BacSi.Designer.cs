namespace QuanlyPhongKham.Views
{
    partial class BacSi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            tabPage3 = new System.Windows.Forms.TabPage();
            btnSaveRecord = new System.Windows.Forms.Button();
            dtpExaminationDate = new System.Windows.Forms.DateTimePicker();
            txtDetails = new System.Windows.Forms.TextBox();
            txtMedicalPatientID = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tabPage2 = new System.Windows.Forms.TabPage();
            cbPatientName = new System.Windows.Forms.ComboBox();
            dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            btnSchedule = new System.Windows.Forms.Button();
            txtEndTime = new System.Windows.Forms.TextBox();
            txtStartTime = new System.Windows.Forms.TextBox();
            lbEndTime = new System.Windows.Forms.Label();
            lbStartTime = new System.Windows.Forms.Label();
            lbdtpAppointmentDate = new System.Windows.Forms.Label();
            lblDoctorName = new System.Windows.Forms.Label();
            lbPatientID = new System.Windows.Forms.Label();
            tabPage1 = new System.Windows.Forms.TabPage();
            dgvAppointments = new System.Windows.Forms.DataGridView();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage4 = new System.Windows.Forms.TabPage();
            btnSaveInvoice = new System.Windows.Forms.Button();
            dgvInvoiceServices = new System.Windows.Forms.DataGridView();
            ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnAddvice = new System.Windows.Forms.Button();
            nudInvoiceQuantity = new System.Windows.Forms.NumericUpDown();
            cbInvoiceService = new System.Windows.Forms.ComboBox();
            dtpInvoiceIssueDate = new System.Windows.Forms.DateTimePicker();
            txtInvoicePatientName = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtInvoicePatientId = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            txtInvoiceTotalAmount = new System.Windows.Forms.TextBox();
            btnCalculateTotal = new System.Windows.Forms.Button();
            lblInvoiceTotalAmount = new System.Windows.Forms.Label();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            tabControl1.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceServices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInvoiceQuantity).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnSaveRecord);
            tabPage3.Controls.Add(dtpExaminationDate);
            tabPage3.Controls.Add(txtDetails);
            tabPage3.Controls.Add(txtMedicalPatientID);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(label1);
            tabPage3.Location = new System.Drawing.Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(773, 521);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Ghi Bệnh Án";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSaveRecord
            // 
            btnSaveRecord.Location = new System.Drawing.Point(307, 263);
            btnSaveRecord.Name = "btnSaveRecord";
            btnSaveRecord.Size = new System.Drawing.Size(111, 29);
            btnSaveRecord.TabIndex = 6;
            btnSaveRecord.Text = "Lưu Bệnh Án";
            btnSaveRecord.UseVisualStyleBackColor = true;
            btnSaveRecord.Click += btnSaveRecord_Click;
            // 
            // dtpExaminationDate
            // 
            dtpExaminationDate.Location = new System.Drawing.Point(195, 196);
            dtpExaminationDate.Name = "dtpExaminationDate";
            dtpExaminationDate.Size = new System.Drawing.Size(250, 27);
            dtpExaminationDate.TabIndex = 5;
            // 
            // txtDetails
            // 
            txtDetails.Location = new System.Drawing.Point(195, 141);
            txtDetails.Name = "txtDetails";
            txtDetails.Size = new System.Drawing.Size(394, 27);
            txtDetails.TabIndex = 4;
            // 
            // txtMedicalPatientID
            // 
            txtMedicalPatientID.Location = new System.Drawing.Point(195, 88);
            txtMedicalPatientID.Name = "txtMedicalPatientID";
            txtMedicalPatientID.Size = new System.Drawing.Size(394, 27);
            txtMedicalPatientID.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(81, 196);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày khám:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(81, 144);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 20);
            label2.TabIndex = 1;
            label2.Text = "Chi tiết bệnh:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(81, 95);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên bệnh nhân:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = System.Drawing.Color.Transparent;
            tabPage2.Controls.Add(cbPatientName);
            tabPage2.Controls.Add(dtpAppointmentDate);
            tabPage2.Controls.Add(btnSchedule);
            tabPage2.Controls.Add(txtEndTime);
            tabPage2.Controls.Add(txtStartTime);
            tabPage2.Controls.Add(lbEndTime);
            tabPage2.Controls.Add(lbStartTime);
            tabPage2.Controls.Add(lbdtpAppointmentDate);
            tabPage2.Controls.Add(lblDoctorName);
            tabPage2.Controls.Add(lbPatientID);
            tabPage2.Location = new System.Drawing.Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(773, 521);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lên Lịch Hẹn";
            // 
            // cbPatientName
            // 
            cbPatientName.FormattingEnabled = true;
            cbPatientName.Location = new System.Drawing.Point(229, 116);
            cbPatientName.Name = "cbPatientName";
            cbPatientName.Size = new System.Drawing.Size(340, 28);
            cbPatientName.TabIndex = 12;
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.ImeMode = System.Windows.Forms.ImeMode.Disable;
            dtpAppointmentDate.Location = new System.Drawing.Point(227, 159);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new System.Drawing.Size(250, 27);
            dtpAppointmentDate.TabIndex = 11;
            // 
            // btnSchedule
            // 
            btnSchedule.Location = new System.Drawing.Point(339, 311);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new System.Drawing.Size(94, 29);
            btnSchedule.TabIndex = 10;
            btnSchedule.Text = "Lên Lịch";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // txtEndTime
            // 
            txtEndTime.Location = new System.Drawing.Point(227, 251);
            txtEndTime.Name = "txtEndTime";
            txtEndTime.Size = new System.Drawing.Size(340, 27);
            txtEndTime.TabIndex = 9;
            // 
            // txtStartTime
            // 
            txtStartTime.Location = new System.Drawing.Point(227, 204);
            txtStartTime.Name = "txtStartTime";
            txtStartTime.Size = new System.Drawing.Size(340, 27);
            txtStartTime.TabIndex = 8;
            // 
            // lbEndTime
            // 
            lbEndTime.AutoSize = true;
            lbEndTime.Location = new System.Drawing.Point(115, 254);
            lbEndTime.Name = "lbEndTime";
            lbEndTime.Size = new System.Drawing.Size(91, 20);
            lbEndTime.TabIndex = 4;
            lbEndTime.Text = "Giờ kết thúc:";
            // 
            // lbStartTime
            // 
            lbStartTime.AutoSize = true;
            lbStartTime.Location = new System.Drawing.Point(115, 204);
            lbStartTime.Name = "lbStartTime";
            lbStartTime.Size = new System.Drawing.Size(90, 20);
            lbStartTime.TabIndex = 3;
            lbStartTime.Text = "Giờ bắt đầu:";
            // 
            // lbdtpAppointmentDate
            // 
            lbdtpAppointmentDate.AutoSize = true;
            lbdtpAppointmentDate.Location = new System.Drawing.Point(115, 164);
            lbdtpAppointmentDate.Name = "lbdtpAppointmentDate";
            lbdtpAppointmentDate.Size = new System.Drawing.Size(75, 20);
            lbdtpAppointmentDate.TabIndex = 2;
            lbdtpAppointmentDate.Text = "Ngày hẹn:";
            // 
            // lblDoctorName
            // 
            lblDoctorName.AutoSize = true;
            lblDoctorName.Location = new System.Drawing.Point(339, 59);
            lblDoctorName.Name = "lblDoctorName";
            lblDoctorName.Size = new System.Drawing.Size(47, 20);
            lblDoctorName.TabIndex = 1;
            lblDoctorName.Text = "Bác sĩ";
            // 
            // lbPatientID
            // 
            lbPatientID.AutoSize = true;
            lbPatientID.Location = new System.Drawing.Point(115, 124);
            lbPatientID.Name = "lbPatientID";
            lbPatientID.Size = new System.Drawing.Size(108, 20);
            lbPatientID.TabIndex = 0;
            lbPatientID.Text = "Tên bệnh nhân:";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvAppointments);
            tabPage1.Location = new System.Drawing.Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(773, 521);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Xem Lịch Hẹn";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvAppointments
            // 
            dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.ColumnHeadersHeight = 29;
            dgvAppointments.Location = new System.Drawing.Point(3, 3);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.Size = new System.Drawing.Size(767, 518);
            dgvAppointments.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(781, 554);
            tabControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnSaveInvoice);
            tabPage4.Controls.Add(dgvInvoiceServices);
            tabPage4.Controls.Add(btnAddvice);
            tabPage4.Controls.Add(nudInvoiceQuantity);
            tabPage4.Controls.Add(cbInvoiceService);
            tabPage4.Controls.Add(dtpInvoiceIssueDate);
            tabPage4.Controls.Add(txtInvoicePatientName);
            tabPage4.Controls.Add(label4);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(groupBox1);
            tabPage4.Controls.Add(groupBox2);
            tabPage4.Location = new System.Drawing.Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(3);
            tabPage4.Size = new System.Drawing.Size(773, 521);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Quản Lý Hóa Đơn";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnSaveInvoice
            // 
            btnSaveInvoice.AutoSize = true;
            btnSaveInvoice.Location = new System.Drawing.Point(335, 486);
            btnSaveInvoice.Name = "btnSaveInvoice";
            btnSaveInvoice.Size = new System.Drawing.Size(102, 30);
            btnSaveInvoice.TabIndex = 12;
            btnSaveInvoice.Text = "Lưu hóa đơn";
            btnSaveInvoice.UseVisualStyleBackColor = true;
            btnSaveInvoice.Click += btnSaveInvoice_Click;
            // 
            // dgvInvoiceServices
            // 
            dgvInvoiceServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoiceServices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dgvInvoiceServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoiceServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ServiceName, Price, Quantity, Subtotal });
            dgvInvoiceServices.Location = new System.Drawing.Point(0, 195);
            dgvInvoiceServices.Name = "dgvInvoiceServices";
            dgvInvoiceServices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvInvoiceServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInvoiceServices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvInvoiceServices.Size = new System.Drawing.Size(770, 188);
            dgvInvoiceServices.TabIndex = 10;
            // 
            // ServiceName
            // 
            ServiceName.HeaderText = "Tên dịch vụ";
            ServiceName.MinimumWidth = 6;
            ServiceName.Name = "ServiceName";
            // 
            // Price
            // 
            Price.HeaderText = "Giá";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Số lượng";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Tổng";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            // 
            // btnAddvice
            // 
            btnAddvice.AutoSize = true;
            btnAddvice.Location = new System.Drawing.Point(581, 144);
            btnAddvice.Name = "btnAddvice";
            btnAddvice.Size = new System.Drawing.Size(107, 30);
            btnAddvice.TabIndex = 9;
            btnAddvice.Text = "Thêm dịch vụ";
            btnAddvice.UseVisualStyleBackColor = true;
            // 
            // nudInvoiceQuantity
            // 
            nudInvoiceQuantity.Location = new System.Drawing.Point(381, 146);
            nudInvoiceQuantity.Name = "nudInvoiceQuantity";
            nudInvoiceQuantity.Size = new System.Drawing.Size(108, 27);
            nudInvoiceQuantity.TabIndex = 8;
            // 
            // cbInvoiceService
            // 
            cbInvoiceService.FormattingEnabled = true;
            cbInvoiceService.Location = new System.Drawing.Point(82, 145);
            cbInvoiceService.Name = "cbInvoiceService";
            cbInvoiceService.Size = new System.Drawing.Size(207, 28);
            cbInvoiceService.TabIndex = 7;
            // 
            // dtpInvoiceIssueDate
            // 
            dtpInvoiceIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpInvoiceIssueDate.Location = new System.Drawing.Point(239, 103);
            dtpInvoiceIssueDate.Name = "dtpInvoiceIssueDate";
            dtpInvoiceIssueDate.Size = new System.Drawing.Size(250, 27);
            dtpInvoiceIssueDate.TabIndex = 6;
            // 
            // txtInvoicePatientName
            // 
            txtInvoicePatientName.Location = new System.Drawing.Point(239, 60);
            txtInvoicePatientName.Name = "txtInvoicePatientName";
            txtInvoicePatientName.Size = new System.Drawing.Size(403, 27);
            txtInvoicePatientName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(133, 63);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(81, 20);
            label4.TabIndex = 3;
            label4.Text = "Bệnh nhân:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(133, 108);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(63, 20);
            label5.TabIndex = 4;
            label5.Text = "Ngày in:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInvoicePatientId);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new System.Drawing.Point(0, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(770, 186);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // txtInvoicePatientId
            // 
            txtInvoicePatientId.Location = new System.Drawing.Point(239, 21);
            txtInvoicePatientId.Name = "txtInvoicePatientId";
            txtInvoicePatientId.ReadOnly = true;
            txtInvoicePatientId.Size = new System.Drawing.Size(97, 27);
            txtInvoicePatientId.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(133, 24);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(100, 20);
            label6.TabIndex = 16;
            label6.Text = "ID bệnh nhân:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtInvoiceTotalAmount);
            groupBox2.Controls.Add(btnCalculateTotal);
            groupBox2.Controls.Add(lblInvoiceTotalAmount);
            groupBox2.Location = new System.Drawing.Point(6, 389);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(767, 82);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // txtInvoiceTotalAmount
            // 
            txtInvoiceTotalAmount.Location = new System.Drawing.Point(471, 26);
            txtInvoiceTotalAmount.Name = "txtInvoiceTotalAmount";
            txtInvoiceTotalAmount.Size = new System.Drawing.Size(217, 27);
            txtInvoiceTotalAmount.TabIndex = 14;
            // 
            // btnCalculateTotal
            // 
            btnCalculateTotal.AutoSize = true;
            btnCalculateTotal.Location = new System.Drawing.Point(79, 24);
            btnCalculateTotal.Name = "btnCalculateTotal";
            btnCalculateTotal.Size = new System.Drawing.Size(94, 30);
            btnCalculateTotal.TabIndex = 11;
            btnCalculateTotal.Text = "Tính tiền";
            btnCalculateTotal.UseVisualStyleBackColor = true;
            // 
            // lblInvoiceTotalAmount
            // 
            lblInvoiceTotalAmount.AutoSize = true;
            lblInvoiceTotalAmount.Location = new System.Drawing.Point(393, 29);
            lblInvoiceTotalAmount.Name = "lblInvoiceTotalAmount";
            lblInvoiceTotalAmount.Size = new System.Drawing.Size(75, 20);
            lblInvoiceTotalAmount.TabIndex = 13;
            lblInvoiceTotalAmount.Text = "Tổng tiền:";
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // BacSi
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(781, 554);
            Controls.Add(tabControl1);
            Name = "BacSi";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bác Sĩ";
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceServices).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInvoiceQuantity).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSaveRecord;
        private System.Windows.Forms.DateTimePicker dtpExaminationDate;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.TextBox txtMedicalPatientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label lbEndTime;
        private System.Windows.Forms.Label lbStartTime;
        private System.Windows.Forms.Label lbdtpAppointmentDate;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Label lbPatientID;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DateTimePicker dtpInvoiceIssueDate;
        private System.Windows.Forms.TextBox txtInvoicePatientName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddvice;
        private System.Windows.Forms.NumericUpDown nudInvoiceQuantity;
        private System.Windows.Forms.ComboBox cbInvoiceService;
        private System.Windows.Forms.DataGridView dgvInvoiceServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.ComboBox cbPatientName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInvoicePatientId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtInvoiceTotalAmount;
        private System.Windows.Forms.Button btnCalculateTotal;
        private System.Windows.Forms.Label lblInvoiceTotalAmount;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
    }
}