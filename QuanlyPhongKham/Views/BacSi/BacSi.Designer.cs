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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            GhiBenhAn = new System.Windows.Forms.TabPage();
            txtTreatmentPlan = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            txtDiagnosis = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            cbNamePatientRecord = new System.Windows.Forms.ComboBox();
            cbIdPatientRecord = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            dtpRecordDate = new System.Windows.Forms.DateTimePicker();
            btnSaveRecord = new System.Windows.Forms.Button();
            txtSymptom = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            LenLichHen = new System.Windows.Forms.TabPage();
            dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            mtbEndTime = new System.Windows.Forms.MaskedTextBox();
            mtbStartTime = new System.Windows.Forms.MaskedTextBox();
            cbPatientId = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            btnSchedule = new System.Windows.Forms.Button();
            cbPatientName = new System.Windows.Forms.ComboBox();
            lbEndTime = new System.Windows.Forms.Label();
            lbStartTime = new System.Windows.Forms.Label();
            lbdtpAppointmentDate = new System.Windows.Forms.Label();
            lbPatientID = new System.Windows.Forms.Label();
            XemLichHen = new System.Windows.Forms.TabPage();
            btnLoadAppointments = new System.Windows.Forms.Button();
            dgvAppointments = new System.Windows.Forms.DataGridView();
            TapBacSi = new System.Windows.Forms.TabControl();
            XemBenhAn = new System.Windows.Forms.TabPage();
            btnLoadMedicalRecords = new System.Windows.Forms.Button();
            dgvMedicalRecordView = new System.Windows.Forms.DataGridView();
            QLHoaDon = new System.Windows.Forms.TabPage();
            btnSaveInvoice = new System.Windows.Forms.Button();
            dgvChiTiet = new System.Windows.Forms.DataGridView();
            TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnThemDichVu = new System.Windows.Forms.Button();
            nuChonSoLuong = new System.Windows.Forms.NumericUpDown();
            cbChonDichVu = new System.Windows.Forms.ComboBox();
            dtpNgayIn = new System.Windows.Forms.DateTimePicker();
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtPatientName = new System.Windows.Forms.TextBox();
            cboPatientId = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            txtTongTien = new System.Windows.Forms.TextBox();
            btnCalculateTotal = new System.Windows.Forms.Button();
            lblInvoiceTotalAmount = new System.Windows.Forms.Label();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            GhiBenhAn.SuspendLayout();
            LenLichHen.SuspendLayout();
            XemLichHen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            TapBacSi.SuspendLayout();
            XemBenhAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicalRecordView).BeginInit();
            QLHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuChonSoLuong).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // GhiBenhAn
            // 
            GhiBenhAn.Controls.Add(txtTreatmentPlan);
            GhiBenhAn.Controls.Add(label10);
            GhiBenhAn.Controls.Add(txtDiagnosis);
            GhiBenhAn.Controls.Add(label9);
            GhiBenhAn.Controls.Add(cbNamePatientRecord);
            GhiBenhAn.Controls.Add(cbIdPatientRecord);
            GhiBenhAn.Controls.Add(label8);
            GhiBenhAn.Controls.Add(dtpRecordDate);
            GhiBenhAn.Controls.Add(btnSaveRecord);
            GhiBenhAn.Controls.Add(txtSymptom);
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
            // txtTreatmentPlan
            // 
            txtTreatmentPlan.Location = new System.Drawing.Point(256, 256);
            txtTreatmentPlan.Name = "txtTreatmentPlan";
            txtTreatmentPlan.Size = new System.Drawing.Size(394, 27);
            txtTreatmentPlan.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(123, 259);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(124, 20);
            label10.TabIndex = 23;
            label10.Text = "Kế hoạch điều trị:";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Location = new System.Drawing.Point(256, 209);
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new System.Drawing.Size(394, 27);
            txtDiagnosis.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(123, 212);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(83, 20);
            label9.TabIndex = 21;
            label9.Text = "Chẩn đoán:";
            // 
            // cbNamePatientRecord
            // 
            cbNamePatientRecord.FormattingEnabled = true;
            cbNamePatientRecord.Location = new System.Drawing.Point(256, 114);
            cbNamePatientRecord.Name = "cbNamePatientRecord";
            cbNamePatientRecord.Size = new System.Drawing.Size(394, 28);
            cbNamePatientRecord.TabIndex = 19;
            cbNamePatientRecord.SelectedIndexChanged += cbNamePatientRecord_SelectedIndexChanged;
            // 
            // cbIdPatientRecord
            // 
            cbIdPatientRecord.FormattingEnabled = true;
            cbIdPatientRecord.Location = new System.Drawing.Point(256, 66);
            cbIdPatientRecord.Name = "cbIdPatientRecord";
            cbIdPatientRecord.Size = new System.Drawing.Size(394, 28);
            cbIdPatientRecord.TabIndex = 18;
            cbIdPatientRecord.SelectedIndexChanged += cbIdPatientRecord_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(123, 74);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(112, 20);
            label8.TabIndex = 17;
            label8.Text = "SĐT bệnh nhân:";
            // 
            // dtpRecordDate
            // 
            dtpRecordDate.CustomFormat = "dd-MM-yyyy";
            dtpRecordDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpRecordDate.Location = new System.Drawing.Point(256, 303);
            dtpRecordDate.Name = "dtpRecordDate";
            dtpRecordDate.Size = new System.Drawing.Size(125, 27);
            dtpRecordDate.TabIndex = 15;
            dtpRecordDate.Value = new System.DateTime(2025, 5, 21, 0, 0, 0, 0);
            // 
            // btnSaveRecord
            // 
            btnSaveRecord.Location = new System.Drawing.Point(331, 404);
            btnSaveRecord.Name = "btnSaveRecord";
            btnSaveRecord.Size = new System.Drawing.Size(111, 29);
            btnSaveRecord.TabIndex = 3;
            btnSaveRecord.Text = "Lưu Bệnh Án";
            btnSaveRecord.UseVisualStyleBackColor = true;
            btnSaveRecord.Click += btnSaveRecord_Click;
            // 
            // txtSymptom
            // 
            txtSymptom.Location = new System.Drawing.Point(256, 162);
            txtSymptom.Name = "txtSymptom";
            txtSymptom.Size = new System.Drawing.Size(394, 27);
            txtSymptom.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(123, 308);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 20);
            label3.TabIndex = 6;
            label3.Text = "Ngày khám:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(123, 165);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(89, 20);
            label2.TabIndex = 5;
            label2.Text = "Triệu chứng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(123, 117);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 20);
            label1.TabIndex = 4;
            label1.Text = "Tên bệnh nhân:";
            // 
            // LenLichHen
            // 
            LenLichHen.BackColor = System.Drawing.Color.Transparent;
            LenLichHen.Controls.Add(dtpAppointmentDate);
            LenLichHen.Controls.Add(mtbEndTime);
            LenLichHen.Controls.Add(mtbStartTime);
            LenLichHen.Controls.Add(cbPatientId);
            LenLichHen.Controls.Add(label7);
            LenLichHen.Controls.Add(btnSchedule);
            LenLichHen.Controls.Add(cbPatientName);
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
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.CustomFormat = "dd-MM-yyyy";
            dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpAppointmentDate.Location = new System.Drawing.Point(273, 164);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new System.Drawing.Size(125, 27);
            dtpAppointmentDate.TabIndex = 14;
            dtpAppointmentDate.Value = new System.DateTime(2025, 5, 21, 0, 0, 0, 0);
            // 
            // mtbEndTime
            // 
            mtbEndTime.Location = new System.Drawing.Point(273, 254);
            mtbEndTime.Mask = "00:00";
            mtbEndTime.Name = "mtbEndTime";
            mtbEndTime.Size = new System.Drawing.Size(125, 27);
            mtbEndTime.TabIndex = 13;
            mtbEndTime.ValidatingType = typeof(System.DateTime);
            // 
            // mtbStartTime
            // 
            mtbStartTime.Location = new System.Drawing.Point(273, 211);
            mtbStartTime.Mask = "00:00";
            mtbStartTime.Name = "mtbStartTime";
            mtbStartTime.Size = new System.Drawing.Size(125, 27);
            mtbStartTime.TabIndex = 12;
            mtbStartTime.ValidatingType = typeof(System.DateTime);
            // 
            // cbPatientId
            // 
            cbPatientId.FormattingEnabled = true;
            cbPatientId.Location = new System.Drawing.Point(273, 65);
            cbPatientId.Name = "cbPatientId";
            cbPatientId.Size = new System.Drawing.Size(340, 28);
            cbPatientId.TabIndex = 0;
            cbPatientId.SelectedIndexChanged += cbPatientId_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(159, 68);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(112, 20);
            label7.TabIndex = 6;
            label7.Text = "SĐT bệnh nhân:";
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
            // lbEndTime
            // 
            lbEndTime.AutoSize = true;
            lbEndTime.Location = new System.Drawing.Point(159, 257);
            lbEndTime.Name = "lbEndTime";
            lbEndTime.Size = new System.Drawing.Size(91, 20);
            lbEndTime.TabIndex = 10;
            lbEndTime.Text = "Giờ kết thúc:";
            // 
            // lbStartTime
            // 
            lbStartTime.AutoSize = true;
            lbStartTime.Location = new System.Drawing.Point(159, 214);
            lbStartTime.Name = "lbStartTime";
            lbStartTime.Size = new System.Drawing.Size(90, 20);
            lbStartTime.TabIndex = 9;
            lbStartTime.Text = "Giờ bắt đầu:";
            // 
            // lbdtpAppointmentDate
            // 
            lbdtpAppointmentDate.AutoSize = true;
            lbdtpAppointmentDate.Location = new System.Drawing.Point(159, 169);
            lbdtpAppointmentDate.Name = "lbdtpAppointmentDate";
            lbdtpAppointmentDate.Size = new System.Drawing.Size(75, 20);
            lbdtpAppointmentDate.TabIndex = 8;
            lbdtpAppointmentDate.Text = "Ngày hẹn:";
            // 
            // lbPatientID
            // 
            lbPatientID.AutoSize = true;
            lbPatientID.Location = new System.Drawing.Point(159, 119);
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
            btnLoadAppointments.Size = new System.Drawing.Size(100, 30);
            btnLoadAppointments.TabIndex = 1;
            btnLoadAppointments.Text = "Tải Lịch Hẹn";
            btnLoadAppointments.UseVisualStyleBackColor = true;
            btnLoadAppointments.Click += btnLoadAppointments_Click;
            // 
            // dgvAppointments
            // 
            dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAppointments.ColumnHeadersHeight = 29;
            dgvAppointments.Location = new System.Drawing.Point(3, 3);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.Size = new System.Drawing.Size(767, 451);
            dgvAppointments.TabIndex = 0;
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
            TapBacSi.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // XemBenhAn
            // 
            XemBenhAn.Controls.Add(btnLoadMedicalRecords);
            XemBenhAn.Controls.Add(dgvMedicalRecordView);
            XemBenhAn.Location = new System.Drawing.Point(4, 29);
            XemBenhAn.Name = "XemBenhAn";
            XemBenhAn.Padding = new System.Windows.Forms.Padding(3);
            XemBenhAn.Size = new System.Drawing.Size(773, 521);
            XemBenhAn.TabIndex = 4;
            XemBenhAn.Text = "Xem Bệnh Án";
            XemBenhAn.UseVisualStyleBackColor = true;
            // 
            // btnLoadMedicalRecords
            // 
            btnLoadMedicalRecords.AutoSize = true;
            btnLoadMedicalRecords.Location = new System.Drawing.Point(339, 471);
            btnLoadMedicalRecords.Name = "btnLoadMedicalRecords";
            btnLoadMedicalRecords.Size = new System.Drawing.Size(98, 30);
            btnLoadMedicalRecords.TabIndex = 2;
            btnLoadMedicalRecords.Text = "Tải Bệnh Án";
            btnLoadMedicalRecords.UseVisualStyleBackColor = true;
            btnLoadMedicalRecords.Click += btnLoadMedicalRecords_Click;
            // 
            // dgvMedicalRecordView
            // 
            dgvMedicalRecordView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicalRecordView.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvMedicalRecordView.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMedicalRecordView.Location = new System.Drawing.Point(3, 1);
            dgvMedicalRecordView.Name = "dgvMedicalRecordView";
            dgvMedicalRecordView.RowHeadersWidth = 51;
            dgvMedicalRecordView.Size = new System.Drawing.Size(767, 451);
            dgvMedicalRecordView.TabIndex = 1;
            // 
            // QLHoaDon
            // 
            QLHoaDon.Controls.Add(btnSaveInvoice);
            QLHoaDon.Controls.Add(dgvChiTiet);
            QLHoaDon.Controls.Add(btnThemDichVu);
            QLHoaDon.Controls.Add(nuChonSoLuong);
            QLHoaDon.Controls.Add(cbChonDichVu);
            QLHoaDon.Controls.Add(dtpNgayIn);
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
            btnSaveInvoice.Location = new System.Drawing.Point(326, 477);
            btnSaveInvoice.Name = "btnSaveInvoice";
            btnSaveInvoice.Size = new System.Drawing.Size(102, 30);
            btnSaveInvoice.TabIndex = 12;
            btnSaveInvoice.Text = "Lưu hóa đơn";
            btnSaveInvoice.UseVisualStyleBackColor = true;
            btnSaveInvoice.Click += btnSaveInvoice_Click;
            // 
            // dgvChiTiet
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgvChiTiet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { TenDichVu, SoLuong, Gia });
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvChiTiet.DefaultCellStyle = dataGridViewCellStyle5;
            dgvChiTiet.Location = new System.Drawing.Point(0, 195);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvChiTiet.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvChiTiet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvChiTiet.Size = new System.Drawing.Size(770, 188);
            dgvChiTiet.TabIndex = 10;
            // 
            // TenDichVu
            // 
            TenDichVu.HeaderText = "Tên dịch vụ";
            TenDichVu.MinimumWidth = 6;
            TenDichVu.Name = "TenDichVu";
            // 
            // SoLuong
            // 
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // Gia
            // 
            Gia.HeaderText = "Giá";
            Gia.MinimumWidth = 6;
            Gia.Name = "Gia";
            // 
            // btnThemDichVu
            // 
            btnThemDichVu.AutoSize = true;
            btnThemDichVu.Location = new System.Drawing.Point(581, 144);
            btnThemDichVu.Name = "btnThemDichVu";
            btnThemDichVu.Size = new System.Drawing.Size(107, 30);
            btnThemDichVu.TabIndex = 9;
            btnThemDichVu.Text = "Thêm dịch vụ";
            btnThemDichVu.UseVisualStyleBackColor = true;
            btnThemDichVu.Click += btnThemDichVu_Click;
            // 
            // nuChonSoLuong
            // 
            nuChonSoLuong.Location = new System.Drawing.Point(381, 146);
            nuChonSoLuong.Name = "nuChonSoLuong";
            nuChonSoLuong.Size = new System.Drawing.Size(108, 27);
            nuChonSoLuong.TabIndex = 8;
            // 
            // cbChonDichVu
            // 
            cbChonDichVu.FormattingEnabled = true;
            cbChonDichVu.Location = new System.Drawing.Point(82, 145);
            cbChonDichVu.Name = "cbChonDichVu";
            cbChonDichVu.Size = new System.Drawing.Size(207, 28);
            cbChonDichVu.TabIndex = 7;
            // 
            // dtpNgayIn
            // 
            dtpNgayIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpNgayIn.Location = new System.Drawing.Point(239, 103);
            dtpNgayIn.Name = "dtpNgayIn";
            dtpNgayIn.Size = new System.Drawing.Size(126, 27);
            dtpNgayIn.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPatientName);
            groupBox1.Controls.Add(cboPatientId);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new System.Drawing.Point(0, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(770, 186);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new System.Drawing.Point(239, 54);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.ReadOnly = true;
            txtPatientName.Size = new System.Drawing.Size(340, 27);
            txtPatientName.TabIndex = 18;
            // 
            // cboPatientId
            // 
            cboPatientId.FormattingEnabled = true;
            cboPatientId.Location = new System.Drawing.Point(239, 16);
            cboPatientId.Name = "cboPatientId";
            cboPatientId.Size = new System.Drawing.Size(340, 28);
            cboPatientId.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(121, 23);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(112, 20);
            label6.TabIndex = 16;
            label6.Text = "SĐT bệnh nhân:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(121, 57);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(81, 20);
            label4.TabIndex = 3;
            label4.Text = "Bệnh nhân:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(121, 102);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(63, 20);
            label5.TabIndex = 4;
            label5.Text = "Ngày in:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTongTien);
            groupBox2.Controls.Add(btnCalculateTotal);
            groupBox2.Controls.Add(lblInvoiceTotalAmount);
            groupBox2.Location = new System.Drawing.Point(6, 389);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(767, 82);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new System.Drawing.Point(465, 26);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new System.Drawing.Size(217, 27);
            txtTongTien.TabIndex = 14;
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
            btnCalculateTotal.Click += btnCalculateTotal_Click;
            // 
            // lblInvoiceTotalAmount
            // 
            lblInvoiceTotalAmount.AutoSize = true;
            lblInvoiceTotalAmount.Location = new System.Drawing.Point(384, 29);
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
            Load += BacSi_Load;
            GhiBenhAn.ResumeLayout(false);
            GhiBenhAn.PerformLayout();
            LenLichHen.ResumeLayout(false);
            LenLichHen.PerformLayout();
            XemLichHen.ResumeLayout(false);
            XemLichHen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            TapBacSi.ResumeLayout(false);
            XemBenhAn.ResumeLayout(false);
            XemBenhAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicalRecordView).EndInit();
            QLHoaDon.ResumeLayout(false);
            QLHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuChonSoLuong).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage GhiBenhAn;
        private System.Windows.Forms.Button btnSaveRecord;
        private System.Windows.Forms.TextBox txtSymptom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage LenLichHen;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Label lbEndTime;
        private System.Windows.Forms.Label lbStartTime;
        private System.Windows.Forms.Label lbdtpAppointmentDate;
        private System.Windows.Forms.Label lbPatientID;
        private System.Windows.Forms.TabPage XemLichHen;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.TabControl TapBacSi;
        private System.Windows.Forms.TabPage QLHoaDon;
        private System.Windows.Forms.DateTimePicker dtpNgayIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThemDichVu;
        private System.Windows.Forms.NumericUpDown nuChonSoLuong;
        private System.Windows.Forms.ComboBox cbChonDichVu;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.ComboBox cbPatientName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnCalculateTotal;
        private System.Windows.Forms.Label lblInvoiceTotalAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPatientId;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private System.Windows.Forms.Button btnLoadAppointments;
        private System.Windows.Forms.MaskedTextBox mtbEndTime;
        private System.Windows.Forms.MaskedTextBox mtbStartTime;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.DateTimePicker dtpRecordDate;
        private System.Windows.Forms.ComboBox cbNamePatientRecord;
        private System.Windows.Forms.ComboBox cbIdPatientRecord;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTreatmentPlan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage XemBenhAn;
        private System.Windows.Forms.DataGridView dgvMedicalRecordView;
        private System.Windows.Forms.Button btnLoadMedicalRecords;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.ComboBox cboPatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.TextBox txtPatientName;
    }
}