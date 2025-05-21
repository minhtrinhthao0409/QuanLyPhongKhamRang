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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            GhiBenhAn = new System.Windows.Forms.TabPage();
            btnSaveRecord = new System.Windows.Forms.Button();
            dtpExaminationDate = new System.Windows.Forms.DateTimePicker();
            txtDetails = new System.Windows.Forms.TextBox();
            txtMedicalPatientID = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            LenLichHen = new System.Windows.Forms.TabPage();
            cbPatientId = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            mtbEndTime = new System.Windows.Forms.MaskedTextBox();
            mtbStartTime = new System.Windows.Forms.MaskedTextBox();
            btnSchedule = new System.Windows.Forms.Button();
            cbPatientName = new System.Windows.Forms.ComboBox();
            dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            lbEndTime = new System.Windows.Forms.Label();
            lbStartTime = new System.Windows.Forms.Label();
            lbdtpAppointmentDate = new System.Windows.Forms.Label();
            lbPatientID = new System.Windows.Forms.Label();
            XemLichHen = new System.Windows.Forms.TabPage();
            btnLoadAppointments = new System.Windows.Forms.Button();
            dgvAppointments = new System.Windows.Forms.DataGridView();
            BenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NgayHen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            GioBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            GioKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TapBacSi = new System.Windows.Forms.TabControl();
            XemBenhAn = new System.Windows.Forms.TabPage();
            dgvXemBenhAn = new System.Windows.Forms.DataGridView();
            QLHoaDon = new System.Windows.Forms.TabPage();
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
            GhiBenhAn.SuspendLayout();
            LenLichHen.SuspendLayout();
            XemLichHen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            TapBacSi.SuspendLayout();
            XemBenhAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvXemBenhAn).BeginInit();
            QLHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceServices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInvoiceQuantity).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // GhiBenhAn
            // 
            GhiBenhAn.Controls.Add(btnSaveRecord);
            GhiBenhAn.Controls.Add(dtpExaminationDate);
            GhiBenhAn.Controls.Add(txtDetails);
            GhiBenhAn.Controls.Add(txtMedicalPatientID);
            GhiBenhAn.Controls.Add(label3);
            GhiBenhAn.Controls.Add(label2);
            GhiBenhAn.Controls.Add(label1);
            GhiBenhAn.Location = new System.Drawing.Point(4, 29);
            GhiBenhAn.Name = "GhiBenhAn";
            GhiBenhAn.Size = new System.Drawing.Size(773, 521);
            GhiBenhAn.TabIndex = 2;
            GhiBenhAn.Text = "Ghi Bệnh Án";
            GhiBenhAn.UseVisualStyleBackColor = true;
            // 
            // btnSaveRecord
            // 
            btnSaveRecord.Location = new System.Drawing.Point(331, 332);
            btnSaveRecord.Name = "btnSaveRecord";
            btnSaveRecord.Size = new System.Drawing.Size(111, 29);
            btnSaveRecord.TabIndex = 3;
            btnSaveRecord.Text = "Lưu Bệnh Án";
            btnSaveRecord.UseVisualStyleBackColor = true;
            btnSaveRecord.Click += btnSaveRecord_Click;
            // 
            // dtpExaminationDate
            // 
            dtpExaminationDate.Location = new System.Drawing.Point(246, 265);
            dtpExaminationDate.Name = "dtpExaminationDate";
            dtpExaminationDate.Size = new System.Drawing.Size(250, 27);
            dtpExaminationDate.TabIndex = 2;
            // 
            // txtDetails
            // 
            txtDetails.Location = new System.Drawing.Point(246, 210);
            txtDetails.Name = "txtDetails";
            txtDetails.Size = new System.Drawing.Size(394, 27);
            txtDetails.TabIndex = 1;
            // 
            // txtMedicalPatientID
            // 
            txtMedicalPatientID.Location = new System.Drawing.Point(246, 160);
            txtMedicalPatientID.Name = "txtMedicalPatientID";
            txtMedicalPatientID.Size = new System.Drawing.Size(394, 27);
            txtMedicalPatientID.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(132, 265);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 20);
            label3.TabIndex = 6;
            label3.Text = "Ngày khám:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(132, 213);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 20);
            label2.TabIndex = 5;
            label2.Text = "Chi tiết bệnh:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(132, 167);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 20);
            label1.TabIndex = 4;
            label1.Text = "Tên bệnh nhân:";
            // 
            // LenLichHen
            // 
            LenLichHen.BackColor = System.Drawing.Color.Transparent;
            LenLichHen.Controls.Add(cbPatientId);
            LenLichHen.Controls.Add(label7);
            LenLichHen.Controls.Add(mtbEndTime);
            LenLichHen.Controls.Add(mtbStartTime);
            LenLichHen.Controls.Add(btnSchedule);
            LenLichHen.Controls.Add(cbPatientName);
            LenLichHen.Controls.Add(dtpAppointmentDate);
            LenLichHen.Controls.Add(lbEndTime);
            LenLichHen.Controls.Add(lbStartTime);
            LenLichHen.Controls.Add(lbdtpAppointmentDate);
            LenLichHen.Controls.Add(lbPatientID);
            LenLichHen.Location = new System.Drawing.Point(4, 29);
            LenLichHen.Name = "LenLichHen";
            LenLichHen.Padding = new System.Windows.Forms.Padding(3);
            LenLichHen.Size = new System.Drawing.Size(773, 521);
            LenLichHen.TabIndex = 1;
            LenLichHen.Text = "Lên Lịch Hẹn";
            // 
            // cbPatientId
            // 
            cbPatientId.FormattingEnabled = true;
            cbPatientId.Location = new System.Drawing.Point(273, 65);
            cbPatientId.Name = "cbPatientId";
            cbPatientId.Size = new System.Drawing.Size(125, 28);
            cbPatientId.TabIndex = 0;
            cbPatientId.SelectedIndexChanged += cbPatientId_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(159, 73);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(100, 20);
            label7.TabIndex = 6;
            label7.Text = "ID bệnh nhân:";
            // 
            // mtbEndTime
            // 
            mtbEndTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            mtbEndTime.Location = new System.Drawing.Point(273, 247);
            mtbEndTime.Mask = "00:00";
            mtbEndTime.Name = "mtbEndTime";
            mtbEndTime.PromptChar = ' ';
            mtbEndTime.Size = new System.Drawing.Size(125, 27);
            mtbEndTime.TabIndex = 4;
            // 
            // mtbStartTime
            // 
            mtbStartTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            mtbStartTime.Location = new System.Drawing.Point(273, 204);
            mtbStartTime.Mask = "00:00";
            mtbStartTime.Name = "mtbStartTime";
            mtbStartTime.PromptChar = ' ';
            mtbStartTime.Size = new System.Drawing.Size(125, 27);
            mtbStartTime.TabIndex = 3;
            // 
            // btnSchedule
            // 
            btnSchedule.AutoSize = true;
            btnSchedule.Location = new System.Drawing.Point(330, 311);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new System.Drawing.Size(112, 30);
            btnSchedule.TabIndex = 5;
            btnSchedule.Text = "Xác Nhận Lịch";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // cbPatientName
            // 
            cbPatientName.FormattingEnabled = true;
            cbPatientName.Location = new System.Drawing.Point(273, 116);
            cbPatientName.Name = "cbPatientName";
            cbPatientName.Size = new System.Drawing.Size(340, 28);
            cbPatientName.TabIndex = 1;
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.ImeMode = System.Windows.Forms.ImeMode.Disable;
            dtpAppointmentDate.Location = new System.Drawing.Point(271, 159);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new System.Drawing.Size(250, 27);
            dtpAppointmentDate.TabIndex = 2;
            // 
            // lbEndTime
            // 
            lbEndTime.AutoSize = true;
            lbEndTime.Location = new System.Drawing.Point(159, 254);
            lbEndTime.Name = "lbEndTime";
            lbEndTime.Size = new System.Drawing.Size(91, 20);
            lbEndTime.TabIndex = 10;
            lbEndTime.Text = "Giờ kết thúc:";
            // 
            // lbStartTime
            // 
            lbStartTime.AutoSize = true;
            lbStartTime.Location = new System.Drawing.Point(159, 211);
            lbStartTime.Name = "lbStartTime";
            lbStartTime.Size = new System.Drawing.Size(90, 20);
            lbStartTime.TabIndex = 9;
            lbStartTime.Text = "Giờ bắt đầu:";
            // 
            // lbdtpAppointmentDate
            // 
            lbdtpAppointmentDate.AutoSize = true;
            lbdtpAppointmentDate.Location = new System.Drawing.Point(159, 164);
            lbdtpAppointmentDate.Name = "lbdtpAppointmentDate";
            lbdtpAppointmentDate.Size = new System.Drawing.Size(75, 20);
            lbdtpAppointmentDate.TabIndex = 8;
            lbdtpAppointmentDate.Text = "Ngày hẹn:";
            // 
            // lbPatientID
            // 
            lbPatientID.AutoSize = true;
            lbPatientID.Location = new System.Drawing.Point(159, 124);
            lbPatientID.Name = "lbPatientID";
            lbPatientID.Size = new System.Drawing.Size(108, 20);
            lbPatientID.TabIndex = 7;
            lbPatientID.Text = "Tên bệnh nhân:";
            // 
            // XemLichHen
            // 
            XemLichHen.Controls.Add(btnLoadAppointments);
            XemLichHen.Controls.Add(dgvAppointments);
            XemLichHen.Location = new System.Drawing.Point(4, 29);
            XemLichHen.Name = "XemLichHen";
            XemLichHen.Padding = new System.Windows.Forms.Padding(3);
            XemLichHen.Size = new System.Drawing.Size(773, 521);
            XemLichHen.TabIndex = 0;
            XemLichHen.Text = "Xem Lịch Hẹn";
            XemLichHen.UseVisualStyleBackColor = true;
            // 
            // btnLoadAppointments
            // 
            btnLoadAppointments.AutoSize = true;
            btnLoadAppointments.Location = new System.Drawing.Point(339, 471);
            btnLoadAppointments.Name = "btnLoadAppointments";
            btnLoadAppointments.Size = new System.Drawing.Size(94, 30);
            btnLoadAppointments.TabIndex = 1;
            btnLoadAppointments.Text = "Tải lịch hẹn";
            btnLoadAppointments.UseVisualStyleBackColor = true;
            btnLoadAppointments.Click += btnLoadAppointments_Click;
            // 
            // dgvAppointments
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAppointments.ColumnHeadersHeight = 29;
            dgvAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { BenhNhan, NgayHen, GioBatDau, GioKetThuc });
            dgvAppointments.Location = new System.Drawing.Point(3, 3);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.Size = new System.Drawing.Size(767, 451);
            dgvAppointments.TabIndex = 0;
            // 
            // BenhNhan
            // 
            BenhNhan.HeaderText = "Tên bệnh nhân";
            BenhNhan.MinimumWidth = 6;
            BenhNhan.Name = "BenhNhan";
            BenhNhan.Width = 179;
            // 
            // NgayHen
            // 
            NgayHen.HeaderText = "Ngày hẹn";
            NgayHen.MinimumWidth = 6;
            NgayHen.Name = "NgayHen";
            NgayHen.Width = 178;
            // 
            // GioBatDau
            // 
            GioBatDau.HeaderText = "Giờ bắt đầu";
            GioBatDau.MinimumWidth = 6;
            GioBatDau.Name = "GioBatDau";
            GioBatDau.Width = 179;
            // 
            // GioKetThuc
            // 
            GioKetThuc.HeaderText = "Giờ kết thúc";
            GioKetThuc.MinimumWidth = 6;
            GioKetThuc.Name = "GioKetThuc";
            GioKetThuc.Width = 178;
            // 
            // TapBacSi
            // 
            TapBacSi.Controls.Add(XemLichHen);
            TapBacSi.Controls.Add(LenLichHen);
            TapBacSi.Controls.Add(GhiBenhAn);
            TapBacSi.Controls.Add(XemBenhAn);
            TapBacSi.Controls.Add(QLHoaDon);
            TapBacSi.Dock = System.Windows.Forms.DockStyle.Fill;
            TapBacSi.Location = new System.Drawing.Point(0, 0);
            TapBacSi.Name = "TapBacSi";
            TapBacSi.SelectedIndex = 0;
            TapBacSi.Size = new System.Drawing.Size(781, 554);
            TapBacSi.TabIndex = 0;
            // 
            // XemBenhAn
            // 
            XemBenhAn.Controls.Add(dgvXemBenhAn);
            XemBenhAn.Location = new System.Drawing.Point(4, 29);
            XemBenhAn.Name = "XemBenhAn";
            XemBenhAn.Padding = new System.Windows.Forms.Padding(3);
            XemBenhAn.Size = new System.Drawing.Size(773, 521);
            XemBenhAn.TabIndex = 4;
            XemBenhAn.Text = "Xem Bệnh Án";
            XemBenhAn.UseVisualStyleBackColor = true;
            // 
            // dgvXemBenhAn
            // 
            dgvXemBenhAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvXemBenhAn.ColumnHeadersHeight = 29;
            dgvXemBenhAn.Location = new System.Drawing.Point(3, 1);
            dgvXemBenhAn.Name = "dgvXemBenhAn";
            dgvXemBenhAn.RowHeadersWidth = 51;
            dgvXemBenhAn.Size = new System.Drawing.Size(767, 518);
            dgvXemBenhAn.TabIndex = 1;
            // 
            // QLHoaDon
            // 
            QLHoaDon.Controls.Add(btnSaveInvoice);
            QLHoaDon.Controls.Add(dgvInvoiceServices);
            QLHoaDon.Controls.Add(btnAddvice);
            QLHoaDon.Controls.Add(nudInvoiceQuantity);
            QLHoaDon.Controls.Add(cbInvoiceService);
            QLHoaDon.Controls.Add(dtpInvoiceIssueDate);
            QLHoaDon.Controls.Add(txtInvoicePatientName);
            QLHoaDon.Controls.Add(label4);
            QLHoaDon.Controls.Add(label5);
            QLHoaDon.Controls.Add(groupBox1);
            QLHoaDon.Controls.Add(groupBox2);
            QLHoaDon.Location = new System.Drawing.Point(4, 29);
            QLHoaDon.Name = "QLHoaDon";
            QLHoaDon.Padding = new System.Windows.Forms.Padding(3);
            QLHoaDon.Size = new System.Drawing.Size(773, 521);
            QLHoaDon.TabIndex = 3;
            QLHoaDon.Text = "Quản Lý Hóa Đơn";
            QLHoaDon.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvInvoiceServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInvoiceServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoiceServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ServiceName, Price, Quantity, Subtotal });
            dgvInvoiceServices.Location = new System.Drawing.Point(0, 195);
            dgvInvoiceServices.Name = "dgvInvoiceServices";
            dgvInvoiceServices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvInvoiceServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            Controls.Add(TapBacSi);
            Name = "BacSi";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bác Sĩ";
            FormClosing += BacSi_FormClosing;
            GhiBenhAn.ResumeLayout(false);
            GhiBenhAn.PerformLayout();
            LenLichHen.ResumeLayout(false);
            LenLichHen.PerformLayout();
            XemLichHen.ResumeLayout(false);
            XemLichHen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            TapBacSi.ResumeLayout(false);
            XemBenhAn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvXemBenhAn).EndInit();
            QLHoaDon.ResumeLayout(false);
            QLHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceServices).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInvoiceQuantity).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage GhiBenhAn;
        private System.Windows.Forms.Button btnSaveRecord;
        private System.Windows.Forms.DateTimePicker dtpExaminationDate;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.TextBox txtMedicalPatientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage LenLichHen;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Label lbEndTime;
        private System.Windows.Forms.Label lbStartTime;
        private System.Windows.Forms.Label lbdtpAppointmentDate;
        private System.Windows.Forms.Label lbPatientID;
        private System.Windows.Forms.TabPage XemLichHen;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.TabControl TapBacSi;
        private System.Windows.Forms.TabPage QLHoaDon;
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
        private System.Windows.Forms.TabPage XemBenhAn;
        private System.Windows.Forms.DataGridView dgvXemBenhAn;
        private System.Windows.Forms.MaskedTextBox mtbEndTime;
        private System.Windows.Forms.MaskedTextBox mtbStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioKetThuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPatientId;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private System.Windows.Forms.Button btnLoadAppointments;
    }
}