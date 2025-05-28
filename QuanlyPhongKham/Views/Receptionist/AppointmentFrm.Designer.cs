namespace QuanlyPhongKham.Views.Receptionist
{
    partial class AppointmentFrm
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
            AppointmentTab = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            CrudPanel = new System.Windows.Forms.Panel();
            searchPatientbtn = new System.Windows.Forms.Button();
            cbDoctorEmail = new System.Windows.Forms.ComboBox();
            cbDoctorName = new System.Windows.Forms.ComboBox();
            startTimeMask = new System.Windows.Forms.MaskedTextBox();
            endTimeMask = new System.Windows.Forms.MaskedTextBox();
            label3 = new System.Windows.Forms.Label();
            startTime = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            start_time_lbl = new System.Windows.Forms.Label();
            PatientPhoneNoTxt = new System.Windows.Forms.TextBox();
            startTimePicker = new System.Windows.Forms.DateTimePicker();
            PatientPhoneNolbl = new System.Windows.Forms.Label();
            PatientNameTxt = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            CrudAppointment = new System.Windows.Forms.Label();
            AddScheduleBtn = new System.Windows.Forms.Button();
            doctorlbl = new System.Windows.Forms.Label();
            tabPage2 = new System.Windows.Forms.TabPage();
            SearchAppointmentGridView = new System.Windows.Forms.DataGridView();
            panel1 = new System.Windows.Forms.Panel();
            EndDatePicker = new System.Windows.Forms.DateTimePicker();
            label4 = new System.Windows.Forms.Label();
            Searchlbl = new System.Windows.Forms.Label();
            Searchbtn = new System.Windows.Forms.Button();
            StartDatePicker = new System.Windows.Forms.DateTimePicker();
            SearchDatelbl = new System.Windows.Forms.Label();
            patientPhoneNoTextbox = new System.Windows.Forms.TextBox();
            SearchPatientNameLbl = new System.Windows.Forms.Label();
            doctorNameTextbox = new System.Windows.Forms.TextBox();
            SearchDoctorNamelbl = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            Homelbl = new System.Windows.Forms.Label();
            Invoicelbl = new System.Windows.Forms.Label();
            Patientlbl = new System.Windows.Forms.Label();
            Appointmentlbl = new System.Windows.Forms.Label();
            SignOutlbl = new System.Windows.Forms.Label();
            AppointmentTab.SuspendLayout();
            tabPage1.SuspendLayout();
            CrudPanel.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchAppointmentGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // AppointmentTab
            // 
            AppointmentTab.Controls.Add(tabPage1);
            AppointmentTab.Controls.Add(tabPage2);
            AppointmentTab.Location = new System.Drawing.Point(193, 3);
            AppointmentTab.Name = "AppointmentTab";
            AppointmentTab.SelectedIndex = 0;
            AppointmentTab.Size = new System.Drawing.Size(808, 668);
            AppointmentTab.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(CrudPanel);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(800, 640);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thêm Lịch Hẹn";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // CrudPanel
            // 
            CrudPanel.Controls.Add(searchPatientbtn);
            CrudPanel.Controls.Add(cbDoctorEmail);
            CrudPanel.Controls.Add(cbDoctorName);
            CrudPanel.Controls.Add(startTimeMask);
            CrudPanel.Controls.Add(endTimeMask);
            CrudPanel.Controls.Add(label3);
            CrudPanel.Controls.Add(startTime);
            CrudPanel.Controls.Add(label2);
            CrudPanel.Controls.Add(start_time_lbl);
            CrudPanel.Controls.Add(PatientPhoneNoTxt);
            CrudPanel.Controls.Add(startTimePicker);
            CrudPanel.Controls.Add(PatientPhoneNolbl);
            CrudPanel.Controls.Add(PatientNameTxt);
            CrudPanel.Controls.Add(label1);
            CrudPanel.Controls.Add(CrudAppointment);
            CrudPanel.Controls.Add(AddScheduleBtn);
            CrudPanel.Controls.Add(doctorlbl);
            CrudPanel.Location = new System.Drawing.Point(0, 0);
            CrudPanel.Name = "CrudPanel";
            CrudPanel.Size = new System.Drawing.Size(797, 290);
            CrudPanel.TabIndex = 4;
            // 
            // searchPatientbtn
            // 
            searchPatientbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            searchPatientbtn.Location = new System.Drawing.Point(204, 118);
            searchPatientbtn.Name = "searchPatientbtn";
            searchPatientbtn.Size = new System.Drawing.Size(145, 24);
            searchPatientbtn.TabIndex = 3;
            searchPatientbtn.Text = "Search Patient Info";
            searchPatientbtn.UseVisualStyleBackColor = true;
            searchPatientbtn.Click += searchPatientbtn_Click;
            // 
            // cbDoctorEmail
            // 
            cbDoctorEmail.FormattingEnabled = true;
            cbDoctorEmail.Location = new System.Drawing.Point(492, 54);
            cbDoctorEmail.Name = "cbDoctorEmail";
            cbDoctorEmail.Size = new System.Drawing.Size(211, 23);
            cbDoctorEmail.TabIndex = 2;
            cbDoctorEmail.SelectedIndexChanged += cbDoctorEmail_SelectedIndexChanged;
            // 
            // cbDoctorName
            // 
            cbDoctorName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbDoctorName.FormattingEnabled = true;
            cbDoctorName.Location = new System.Drawing.Point(138, 53);
            cbDoctorName.Name = "cbDoctorName";
            cbDoctorName.Size = new System.Drawing.Size(211, 23);
            cbDoctorName.TabIndex = 1;
            // 
            // startTimeMask
            // 
            startTimeMask.Location = new System.Drawing.Point(492, 168);
            startTimeMask.Mask = "00:00";
            startTimeMask.Name = "startTimeMask";
            startTimeMask.Size = new System.Drawing.Size(49, 23);
            startTimeMask.TabIndex = 5;
            startTimeMask.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            startTimeMask.ValidatingType = typeof(System.DateTime);
            // 
            // endTimeMask
            // 
            endTimeMask.Location = new System.Drawing.Point(654, 166);
            endTimeMask.Mask = "00:00";
            endTimeMask.Name = "endTimeMask";
            endTimeMask.Size = new System.Drawing.Size(49, 23);
            endTimeMask.TabIndex = 6;
            endTimeMask.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            endTimeMask.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(561, 172);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 17);
            label3.TabIndex = 24;
            label3.Text = "Giờ Kết Thúc";
            // 
            // startTime
            // 
            startTime.AutoSize = true;
            startTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            startTime.Location = new System.Drawing.Point(373, 168);
            startTime.Name = "startTime";
            startTime.Size = new System.Drawing.Size(82, 17);
            startTime.TabIndex = 22;
            startTime.Text = "Giờ Bắt Đầu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(373, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 17);
            label2.TabIndex = 20;
            label2.Text = "Email Bác Sĩ";
            // 
            // start_time_lbl
            // 
            start_time_lbl.AutoSize = true;
            start_time_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            start_time_lbl.Location = new System.Drawing.Point(16, 164);
            start_time_lbl.Name = "start_time_lbl";
            start_time_lbl.Size = new System.Drawing.Size(40, 17);
            start_time_lbl.TabIndex = 1;
            start_time_lbl.Text = "Ngày";
            // 
            // PatientPhoneNoTxt
            // 
            PatientPhoneNoTxt.Location = new System.Drawing.Point(492, 94);
            PatientPhoneNoTxt.Name = "PatientPhoneNoTxt";
            PatientPhoneNoTxt.ReadOnly = true;
            PatientPhoneNoTxt.Size = new System.Drawing.Size(211, 23);
            PatientPhoneNoTxt.TabIndex = 3;
            // 
            // startTimePicker
            // 
            startTimePicker.Location = new System.Drawing.Point(138, 164);
            startTimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            startTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            startTimePicker.Name = "startTimePicker";
            startTimePicker.Size = new System.Drawing.Size(211, 23);
            startTimePicker.TabIndex = 4;
            startTimePicker.Value = new System.DateTime(2025, 5, 23, 0, 0, 0, 0);
            // 
            // PatientPhoneNolbl
            // 
            PatientPhoneNolbl.AutoSize = true;
            PatientPhoneNolbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            PatientPhoneNolbl.Location = new System.Drawing.Point(373, 95);
            PatientPhoneNolbl.Name = "PatientPhoneNolbl";
            PatientPhoneNolbl.Size = new System.Drawing.Size(105, 17);
            PatientPhoneNolbl.TabIndex = 17;
            PatientPhoneNolbl.Text = "SĐT Bệnh Nhân";
            // 
            // PatientNameTxt
            // 
            PatientNameTxt.Location = new System.Drawing.Point(138, 89);
            PatientNameTxt.Name = "PatientNameTxt";
            PatientNameTxt.ReadOnly = true;
            PatientNameTxt.Size = new System.Drawing.Size(211, 23);
            PatientNameTxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(15, 91);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 17);
            label1.TabIndex = 15;
            label1.Text = "Tên Bệnh Nhân";
            // 
            // CrudAppointment
            // 
            CrudAppointment.AutoSize = true;
            CrudAppointment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            CrudAppointment.Location = new System.Drawing.Point(301, 10);
            CrudAppointment.Name = "CrudAppointment";
            CrudAppointment.Size = new System.Drawing.Size(166, 25);
            CrudAppointment.TabIndex = 15;
            CrudAppointment.Text = "Quản Lý Lịch Hẹn";
            // 
            // AddScheduleBtn
            // 
            AddScheduleBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            AddScheduleBtn.Location = new System.Drawing.Point(326, 226);
            AddScheduleBtn.Name = "AddScheduleBtn";
            AddScheduleBtn.Size = new System.Drawing.Size(93, 50);
            AddScheduleBtn.TabIndex = 7;
            AddScheduleBtn.Text = "&Thêm";
            AddScheduleBtn.UseVisualStyleBackColor = true;
            AddScheduleBtn.Click += AddScheduleBtn_Click;
            AddScheduleBtn.KeyDown += AddScheduleBtn_KeyDown;
            // 
            // doctorlbl
            // 
            doctorlbl.AutoSize = true;
            doctorlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            doctorlbl.Location = new System.Drawing.Point(16, 54);
            doctorlbl.Name = "doctorlbl";
            doctorlbl.Size = new System.Drawing.Size(70, 17);
            doctorlbl.TabIndex = 0;
            doctorlbl.Text = "Tên Bác Sĩ";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(SearchAppointmentGridView);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(800, 640);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tra cứu lịch hẹn";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // SearchAppointmentGridView
            // 
            SearchAppointmentGridView.AllowUserToAddRows = false;
            SearchAppointmentGridView.AllowUserToDeleteRows = false;
            SearchAppointmentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            SearchAppointmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchAppointmentGridView.Location = new System.Drawing.Point(2, 229);
            SearchAppointmentGridView.Name = "SearchAppointmentGridView";
            SearchAppointmentGridView.ReadOnly = true;
            SearchAppointmentGridView.Size = new System.Drawing.Size(796, 411);
            SearchAppointmentGridView.TabIndex = 6;
            SearchAppointmentGridView.CellClick += SearchAppointmentGridView_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(EndDatePicker);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Searchlbl);
            panel1.Controls.Add(Searchbtn);
            panel1.Controls.Add(StartDatePicker);
            panel1.Controls.Add(SearchDatelbl);
            panel1.Controls.Add(patientPhoneNoTextbox);
            panel1.Controls.Add(SearchPatientNameLbl);
            panel1.Controls.Add(doctorNameTextbox);
            panel1.Controls.Add(SearchDoctorNamelbl);
            panel1.Location = new System.Drawing.Point(0, 6);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(804, 226);
            panel1.TabIndex = 5;
            // 
            // EndDatePicker
            // 
            EndDatePicker.Location = new System.Drawing.Point(492, 114);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.Size = new System.Drawing.Size(211, 23);
            EndDatePicker.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(449, 118);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(33, 17);
            label4.TabIndex = 15;
            label4.Text = "Đến";
            // 
            // Searchlbl
            // 
            Searchlbl.AutoSize = true;
            Searchlbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Searchlbl.Location = new System.Drawing.Point(301, 23);
            Searchlbl.Name = "Searchlbl";
            Searchlbl.Size = new System.Drawing.Size(152, 25);
            Searchlbl.TabIndex = 14;
            Searchlbl.Text = "Tra cứu lịch hẹn";
            // 
            // Searchbtn
            // 
            Searchbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            Searchbtn.Location = new System.Drawing.Point(492, 167);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new System.Drawing.Size(93, 50);
            Searchbtn.TabIndex = 3;
            Searchbtn.Text = "Tìm Kiếm";
            Searchbtn.UseVisualStyleBackColor = true;
            Searchbtn.Click += Searchbtn_Click;
            Searchbtn.KeyDown += Searchbtn_KeyDown;
            // 
            // StartDatePicker
            // 
            StartDatePicker.Location = new System.Drawing.Point(492, 68);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new System.Drawing.Size(211, 23);
            StartDatePicker.TabIndex = 13;
            // 
            // SearchDatelbl
            // 
            SearchDatelbl.AutoSize = true;
            SearchDatelbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            SearchDatelbl.Location = new System.Drawing.Point(449, 72);
            SearchDatelbl.Name = "SearchDatelbl";
            SearchDatelbl.Size = new System.Drawing.Size(25, 17);
            SearchDatelbl.TabIndex = 12;
            SearchDatelbl.Text = "Từ";
            // 
            // patientPhoneNoTextbox
            // 
            patientPhoneNoTextbox.Location = new System.Drawing.Point(200, 108);
            patientPhoneNoTextbox.Name = "patientPhoneNoTextbox";
            patientPhoneNoTextbox.Size = new System.Drawing.Size(211, 23);
            patientPhoneNoTextbox.TabIndex = 2;
            // 
            // SearchPatientNameLbl
            // 
            SearchPatientNameLbl.AutoSize = true;
            SearchPatientNameLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            SearchPatientNameLbl.Location = new System.Drawing.Point(50, 114);
            SearchPatientNameLbl.Name = "SearchPatientNameLbl";
            SearchPatientNameLbl.Size = new System.Drawing.Size(105, 17);
            SearchPatientNameLbl.TabIndex = 10;
            SearchPatientNameLbl.Text = "SĐT Bệnh Nhân";
            // 
            // doctorNameTextbox
            // 
            doctorNameTextbox.Location = new System.Drawing.Point(199, 66);
            doctorNameTextbox.Name = "doctorNameTextbox";
            doctorNameTextbox.Size = new System.Drawing.Size(211, 23);
            doctorNameTextbox.TabIndex = 1;
            // 
            // SearchDoctorNamelbl
            // 
            SearchDoctorNamelbl.AutoSize = true;
            SearchDoctorNamelbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            SearchDoctorNamelbl.Location = new System.Drawing.Point(77, 72);
            SearchDoctorNamelbl.Name = "SearchDoctorNamelbl";
            SearchDoctorNamelbl.Size = new System.Drawing.Size(70, 17);
            SearchDoctorNamelbl.TabIndex = 8;
            SearchDoctorNamelbl.Text = "Tên Bác Sĩ";
            // 
            // panel2
            // 
            panel2.Controls.Add(Homelbl);
            panel2.Controls.Add(Invoicelbl);
            panel2.Controls.Add(Patientlbl);
            panel2.Controls.Add(Appointmentlbl);
            panel2.Controls.Add(SignOutlbl);
            panel2.Location = new System.Drawing.Point(12, 31);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(176, 638);
            panel2.TabIndex = 9;
            // 
            // Homelbl
            // 
            Homelbl.Cursor = System.Windows.Forms.Cursors.Hand;
            Homelbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Homelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            Homelbl.Location = new System.Drawing.Point(3, 206);
            Homelbl.Name = "Homelbl";
            Homelbl.Size = new System.Drawing.Size(170, 46);
            Homelbl.TabIndex = 7;
            Homelbl.Text = "Trang chủ";
            Homelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Homelbl.Click += menulbl_click;
            // 
            // Invoicelbl
            // 
            Invoicelbl.Cursor = System.Windows.Forms.Cursors.Hand;
            Invoicelbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Invoicelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            Invoicelbl.Location = new System.Drawing.Point(3, 354);
            Invoicelbl.Name = "Invoicelbl";
            Invoicelbl.Size = new System.Drawing.Size(170, 46);
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
            Patientlbl.Location = new System.Drawing.Point(3, 308);
            Patientlbl.Name = "Patientlbl";
            Patientlbl.Size = new System.Drawing.Size(170, 46);
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
            Appointmentlbl.Location = new System.Drawing.Point(3, 252);
            Appointmentlbl.Name = "Appointmentlbl";
            Appointmentlbl.Size = new System.Drawing.Size(170, 46);
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
            SignOutlbl.Location = new System.Drawing.Point(3, 582);
            SignOutlbl.Name = "SignOutlbl";
            SignOutlbl.Size = new System.Drawing.Size(170, 46);
            SignOutlbl.TabIndex = 4;
            SignOutlbl.Text = "Đăng Xuất";
            SignOutlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            SignOutlbl.Click += SignOutlbl_Click;
            // 
            // AppointmentFrm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1008, 681);
            Controls.Add(panel2);
            Controls.Add(AppointmentTab);
            Name = "AppointmentFrm";
            Text = "AppointmentFrm";
            AppointmentTab.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            CrudPanel.ResumeLayout(false);
            CrudPanel.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SearchAppointmentGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl AppointmentTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel CrudPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label start_time_lbl;
        private System.Windows.Forms.TextBox PatientPhoneNoTxt;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Label PatientPhoneNolbl;
        private System.Windows.Forms.TextBox PatientNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CrudAppointment;
        private System.Windows.Forms.Button AddScheduleBtn;
        private System.Windows.Forms.Label doctorlbl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Searchlbl;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.Label SearchDatelbl;
        private System.Windows.Forms.TextBox patientPhoneNoTextbox;
        private System.Windows.Forms.Label SearchPatientNameLbl;
        private System.Windows.Forms.TextBox doctorNameTextbox;
        private System.Windows.Forms.Label SearchDoctorNamelbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Homelbl;
        private System.Windows.Forms.Label Invoicelbl;
        private System.Windows.Forms.Label Patientlbl;
        private System.Windows.Forms.Label Appointmentlbl;
        private System.Windows.Forms.Label SignOutlbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.DataGridView SearchAppointmentGridView;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox endTimeMask;
        private System.Windows.Forms.MaskedTextBox startTimeMask;
        private System.Windows.Forms.ComboBox cbDoctorName;
        private System.Windows.Forms.ComboBox cbDoctorEmail;
        private System.Windows.Forms.Button searchPatientbtn;
    }
}