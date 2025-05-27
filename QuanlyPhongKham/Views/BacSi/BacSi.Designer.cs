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
            GhiBenhAn.Location = new System.Drawing.Point(4, 24);
            GhiBenhAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            GhiBenhAn.Name = "GhiBenhAn";
            GhiBenhAn.Size = new System.Drawing.Size(675, 388);
            GhiBenhAn.TabIndex = 2;
            GhiBenhAn.Text = "Ghi Bệnh Án";
            GhiBenhAn.UseVisualStyleBackColor = true;
            GhiBenhAn.Click += GhiBenhAn_Click;
            // 
            // txtTreatmentPlan
            // 
            txtTreatmentPlan.Location = new System.Drawing.Point(224, 224);
            txtTreatmentPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtTreatmentPlan.Multiline = true;
            txtTreatmentPlan.Name = "txtTreatmentPlan";
            txtTreatmentPlan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtTreatmentPlan.Size = new System.Drawing.Size(345, 57);
            txtTreatmentPlan.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(108, 226);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(99, 15);
            label10.TabIndex = 23;
            label10.Text = "Kế hoạch điều trị:";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Location = new System.Drawing.Point(224, 160);
            txtDiagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtDiagnosis.Size = new System.Drawing.Size(345, 47);
            txtDiagnosis.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(108, 162);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(68, 15);
            label9.TabIndex = 21;
            label9.Text = "Chẩn đoán:";
            // 
            // cbNamePatientRecord
            // 
            cbNamePatientRecord.FormattingEnabled = true;
            cbNamePatientRecord.Location = new System.Drawing.Point(224, 55);
            cbNamePatientRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbNamePatientRecord.Name = "cbNamePatientRecord";
            cbNamePatientRecord.Size = new System.Drawing.Size(345, 23);
            cbNamePatientRecord.TabIndex = 19;
            cbNamePatientRecord.SelectedIndexChanged += cbNamePatientRecord_SelectedIndexChanged;
            // 
            // cbIdPatientRecord
            // 
            cbIdPatientRecord.FormattingEnabled = true;
            cbIdPatientRecord.Location = new System.Drawing.Point(224, 19);
            cbIdPatientRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbIdPatientRecord.Name = "cbIdPatientRecord";
            cbIdPatientRecord.Size = new System.Drawing.Size(345, 23);
            cbIdPatientRecord.TabIndex = 18;
            cbIdPatientRecord.SelectedIndexChanged += cbIdPatientRecord_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(108, 25);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(91, 15);
            label8.TabIndex = 17;
            label8.Text = "SĐT bệnh nhân:";
            // 
            // dtpRecordDate
            // 
            dtpRecordDate.CustomFormat = "dd-MM-yyyy";
            dtpRecordDate.Enabled = false;
            dtpRecordDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpRecordDate.Location = new System.Drawing.Point(224, 303);
            dtpRecordDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dtpRecordDate.Name = "dtpRecordDate";
            dtpRecordDate.Size = new System.Drawing.Size(110, 23);
            dtpRecordDate.TabIndex = 15;
            dtpRecordDate.Value = new System.DateTime(2025, 5, 21, 0, 0, 0, 0);
            // 
            // btnSaveRecord
            // 
            btnSaveRecord.Location = new System.Drawing.Point(285, 348);
            btnSaveRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSaveRecord.Name = "btnSaveRecord";
            btnSaveRecord.Size = new System.Drawing.Size(97, 22);
            btnSaveRecord.TabIndex = 3;
            btnSaveRecord.Text = "Lưu Bệnh Án";
            btnSaveRecord.UseVisualStyleBackColor = true;
            btnSaveRecord.Click += btnSaveRecord_Click;
            // 
            // txtSymptom
            // 
            txtSymptom.Location = new System.Drawing.Point(224, 91);
            txtSymptom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtSymptom.Multiline = true;
            txtSymptom.Name = "txtSymptom";
            txtSymptom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtSymptom.Size = new System.Drawing.Size(345, 49);
            txtSymptom.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(108, 307);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 15);
            label3.TabIndex = 6;
            label3.Text = "Ngày khám:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(108, 93);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 15);
            label2.TabIndex = 5;
            label2.Text = "Triệu chứng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(108, 57);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 15);
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
            LenLichHen.Location = new System.Drawing.Point(4, 24);
            LenLichHen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            LenLichHen.Name = "LenLichHen";
            LenLichHen.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            LenLichHen.Size = new System.Drawing.Size(675, 388);
            LenLichHen.TabIndex = 1;
            LenLichHen.Text = "Lên Lịch Hẹn";
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.CustomFormat = "dd-MM-yyyy";
            dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpAppointmentDate.Location = new System.Drawing.Point(239, 123);
            dtpAppointmentDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new System.Drawing.Size(110, 23);
            dtpAppointmentDate.TabIndex = 14;
            dtpAppointmentDate.Value = new System.DateTime(2025, 5, 21, 0, 0, 0, 0);
            // 
            // mtbEndTime
            // 
            mtbEndTime.Location = new System.Drawing.Point(239, 190);
            mtbEndTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            mtbEndTime.Mask = "00:00";
            mtbEndTime.Name = "mtbEndTime";
            mtbEndTime.Size = new System.Drawing.Size(110, 23);
            mtbEndTime.TabIndex = 13;
            mtbEndTime.ValidatingType = typeof(System.DateTime);
            // 
            // mtbStartTime
            // 
            mtbStartTime.Location = new System.Drawing.Point(239, 158);
            mtbStartTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            mtbStartTime.Mask = "00:00";
            mtbStartTime.Name = "mtbStartTime";
            mtbStartTime.Size = new System.Drawing.Size(110, 23);
            mtbStartTime.TabIndex = 12;
            mtbStartTime.ValidatingType = typeof(System.DateTime);
            // 
            // cbPatientId
            // 
            cbPatientId.FormattingEnabled = true;
            cbPatientId.Location = new System.Drawing.Point(239, 49);
            cbPatientId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbPatientId.Name = "cbPatientId";
            cbPatientId.Size = new System.Drawing.Size(298, 23);
            cbPatientId.TabIndex = 0;
            cbPatientId.SelectedIndexChanged += cbPatientId_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(139, 51);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(91, 15);
            label7.TabIndex = 6;
            label7.Text = "SĐT bệnh nhân:";
            // 
            // btnSchedule
            // 
            btnSchedule.AutoSize = true;
            btnSchedule.Location = new System.Drawing.Point(289, 233);
            btnSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new System.Drawing.Size(98, 25);
            btnSchedule.TabIndex = 5;
            btnSchedule.Text = "Xác Nhận Lịch";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // cbPatientName
            // 
            cbPatientName.FormattingEnabled = true;
            cbPatientName.Location = new System.Drawing.Point(239, 87);
            cbPatientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbPatientName.Name = "cbPatientName";
            cbPatientName.Size = new System.Drawing.Size(298, 23);
            cbPatientName.TabIndex = 1;
            // 
            // lbEndTime
            // 
            lbEndTime.AutoSize = true;
            lbEndTime.Location = new System.Drawing.Point(139, 193);
            lbEndTime.Name = "lbEndTime";
            lbEndTime.Size = new System.Drawing.Size(74, 15);
            lbEndTime.TabIndex = 10;
            lbEndTime.Text = "Giờ kết thúc:";
            // 
            // lbStartTime
            // 
            lbStartTime.AutoSize = true;
            lbStartTime.Location = new System.Drawing.Point(139, 160);
            lbStartTime.Name = "lbStartTime";
            lbStartTime.Size = new System.Drawing.Size(71, 15);
            lbStartTime.TabIndex = 9;
            lbStartTime.Text = "Giờ bắt đầu:";
            // 
            // lbdtpAppointmentDate
            // 
            lbdtpAppointmentDate.AutoSize = true;
            lbdtpAppointmentDate.Location = new System.Drawing.Point(139, 127);
            lbdtpAppointmentDate.Name = "lbdtpAppointmentDate";
            lbdtpAppointmentDate.Size = new System.Drawing.Size(61, 15);
            lbdtpAppointmentDate.TabIndex = 8;
            lbdtpAppointmentDate.Text = "Ngày hẹn:";
            // 
            // lbPatientID
            // 
            lbPatientID.AutoSize = true;
            lbPatientID.Location = new System.Drawing.Point(139, 89);
            lbPatientID.Name = "lbPatientID";
            lbPatientID.Size = new System.Drawing.Size(89, 15);
            lbPatientID.TabIndex = 7;
            lbPatientID.Text = "Tên bệnh nhân:";
            // 
            // XemLichHen
            // 
            XemLichHen.Controls.Add(btnLoadAppointments);
            XemLichHen.Controls.Add(dgvAppointments);
            XemLichHen.Location = new System.Drawing.Point(4, 24);
            XemLichHen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            XemLichHen.Name = "XemLichHen";
            XemLichHen.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            XemLichHen.Size = new System.Drawing.Size(675, 388);
            XemLichHen.TabIndex = 0;
            XemLichHen.Text = "Xem Lịch Hẹn";
            XemLichHen.UseVisualStyleBackColor = true;
            // 
            // btnLoadAppointments
            // 
            btnLoadAppointments.AutoSize = true;
            btnLoadAppointments.Location = new System.Drawing.Point(297, 353);
            btnLoadAppointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLoadAppointments.Name = "btnLoadAppointments";
            btnLoadAppointments.Size = new System.Drawing.Size(88, 25);
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
            dgvAppointments.Location = new System.Drawing.Point(3, 2);
            dgvAppointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.Size = new System.Drawing.Size(671, 338);
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
            TapBacSi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            TapBacSi.Name = "TapBacSi";
            TapBacSi.SelectedIndex = 0;
            TapBacSi.Size = new System.Drawing.Size(683, 416);
            TapBacSi.TabIndex = 0;
            TapBacSi.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // XemBenhAn
            // 
            XemBenhAn.Controls.Add(btnLoadMedicalRecords);
            XemBenhAn.Controls.Add(dgvMedicalRecordView);
            XemBenhAn.Location = new System.Drawing.Point(4, 24);
            XemBenhAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            XemBenhAn.Name = "XemBenhAn";
            XemBenhAn.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            XemBenhAn.Size = new System.Drawing.Size(675, 388);
            XemBenhAn.TabIndex = 4;
            XemBenhAn.Text = "Xem Bệnh Án";
            XemBenhAn.UseVisualStyleBackColor = true;
            // 
            // btnLoadMedicalRecords
            // 
            btnLoadMedicalRecords.AutoSize = true;
            btnLoadMedicalRecords.Location = new System.Drawing.Point(297, 353);
            btnLoadMedicalRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLoadMedicalRecords.Name = "btnLoadMedicalRecords";
            btnLoadMedicalRecords.Size = new System.Drawing.Size(86, 25);
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
            dgvMedicalRecordView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvMedicalRecordView.Name = "dgvMedicalRecordView";
            dgvMedicalRecordView.RowHeadersWidth = 51;
            dgvMedicalRecordView.Size = new System.Drawing.Size(671, 338);
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
            QLHoaDon.Location = new System.Drawing.Point(4, 24);
            QLHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            QLHoaDon.Name = "QLHoaDon";
            QLHoaDon.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            QLHoaDon.Size = new System.Drawing.Size(675, 388);
            QLHoaDon.TabIndex = 3;
            QLHoaDon.Text = "Quản Lý Hóa Đơn";
            QLHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnSaveInvoice
            // 
            btnSaveInvoice.AutoSize = true;
            btnSaveInvoice.Location = new System.Drawing.Point(285, 358);
            btnSaveInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSaveInvoice.Name = "btnSaveInvoice";
            btnSaveInvoice.Size = new System.Drawing.Size(89, 25);
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
            dgvChiTiet.Location = new System.Drawing.Point(0, 146);
            dgvChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            dgvChiTiet.Size = new System.Drawing.Size(674, 141);
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
            btnThemDichVu.Location = new System.Drawing.Point(508, 108);
            btnThemDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnThemDichVu.Name = "btnThemDichVu";
            btnThemDichVu.Size = new System.Drawing.Size(94, 25);
            btnThemDichVu.TabIndex = 9;
            btnThemDichVu.Text = "Thêm dịch vụ";
            btnThemDichVu.UseVisualStyleBackColor = true;
            btnThemDichVu.Click += btnThemDichVu_Click;
            // 
            // nuChonSoLuong
            // 
            nuChonSoLuong.Location = new System.Drawing.Point(333, 110);
            nuChonSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            nuChonSoLuong.Name = "nuChonSoLuong";
            nuChonSoLuong.Size = new System.Drawing.Size(94, 23);
            nuChonSoLuong.TabIndex = 8;
            // 
            // cbChonDichVu
            // 
            cbChonDichVu.FormattingEnabled = true;
            cbChonDichVu.Location = new System.Drawing.Point(72, 109);
            cbChonDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbChonDichVu.Name = "cbChonDichVu";
            cbChonDichVu.Size = new System.Drawing.Size(182, 23);
            cbChonDichVu.TabIndex = 7;
            // 
            // dtpNgayIn
            // 
            dtpNgayIn.Enabled = false;
            dtpNgayIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpNgayIn.Location = new System.Drawing.Point(209, 77);
            dtpNgayIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dtpNgayIn.Name = "dtpNgayIn";
            dtpNgayIn.Size = new System.Drawing.Size(111, 23);
            dtpNgayIn.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPatientName);
            groupBox1.Controls.Add(cboPatientId);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new System.Drawing.Point(0, 4);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Size = new System.Drawing.Size(674, 140);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new System.Drawing.Point(209, 40);
            txtPatientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.ReadOnly = true;
            txtPatientName.Size = new System.Drawing.Size(298, 23);
            txtPatientName.TabIndex = 18;
            // 
            // cboPatientId
            // 
            cboPatientId.FormattingEnabled = true;
            cboPatientId.Location = new System.Drawing.Point(209, 12);
            cboPatientId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cboPatientId.Name = "cboPatientId";
            cboPatientId.Size = new System.Drawing.Size(298, 23);
            cboPatientId.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(106, 17);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(91, 15);
            label6.TabIndex = 16;
            label6.Text = "SĐT bệnh nhân:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(106, 43);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Bệnh nhân:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(106, 76);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Ngày in:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTongTien);
            groupBox2.Controls.Add(btnCalculateTotal);
            groupBox2.Controls.Add(lblInvoiceTotalAmount);
            groupBox2.Location = new System.Drawing.Point(5, 292);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox2.Size = new System.Drawing.Size(671, 62);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new System.Drawing.Point(407, 20);
            txtTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new System.Drawing.Size(190, 23);
            txtTongTien.TabIndex = 14;
            // 
            // btnCalculateTotal
            // 
            btnCalculateTotal.AutoSize = true;
            btnCalculateTotal.Location = new System.Drawing.Point(69, 18);
            btnCalculateTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCalculateTotal.Name = "btnCalculateTotal";
            btnCalculateTotal.Size = new System.Drawing.Size(82, 25);
            btnCalculateTotal.TabIndex = 11;
            btnCalculateTotal.Text = "Tính tiền";
            btnCalculateTotal.UseVisualStyleBackColor = true;
            btnCalculateTotal.Click += btnCalculateTotal_Click;
            // 
            // lblInvoiceTotalAmount
            // 
            lblInvoiceTotalAmount.AutoSize = true;
            lblInvoiceTotalAmount.Location = new System.Drawing.Point(336, 22);
            lblInvoiceTotalAmount.Name = "lblInvoiceTotalAmount";
            lblInvoiceTotalAmount.Size = new System.Drawing.Size(61, 15);
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
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(683, 416);
            Controls.Add(TapBacSi);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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