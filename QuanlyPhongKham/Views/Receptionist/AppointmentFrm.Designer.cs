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
            startTimeMask = new System.Windows.Forms.MaskedTextBox();
            endTimeMask = new System.Windows.Forms.MaskedTextBox();
            label3 = new System.Windows.Forms.Label();
            startTime = new System.Windows.Forms.Label();
            DoctorEmailTxt = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            DoctorNameTxT = new System.Windows.Forms.TextBox();
            start_time_lbl = new System.Windows.Forms.Label();
            PatientPhoneNoTxt = new System.Windows.Forms.TextBox();
            startTimePicker = new System.Windows.Forms.DateTimePicker();
            PatientPhoneNolbl = new System.Windows.Forms.Label();
            PatientNameTxt = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            CrudAppointment = new System.Windows.Forms.Label();
            UpdateBtn = new System.Windows.Forms.Button();
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
            Schedulelbl = new System.Windows.Forms.Label();
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
            tabPage1.Text = "Manage Appointment";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // CrudPanel
            // 
            CrudPanel.Controls.Add(startTimeMask);
            CrudPanel.Controls.Add(endTimeMask);
            CrudPanel.Controls.Add(label3);
            CrudPanel.Controls.Add(startTime);
            CrudPanel.Controls.Add(DoctorEmailTxt);
            CrudPanel.Controls.Add(label2);
            CrudPanel.Controls.Add(DoctorNameTxT);
            CrudPanel.Controls.Add(start_time_lbl);
            CrudPanel.Controls.Add(PatientPhoneNoTxt);
            CrudPanel.Controls.Add(startTimePicker);
            CrudPanel.Controls.Add(PatientPhoneNolbl);
            CrudPanel.Controls.Add(PatientNameTxt);
            CrudPanel.Controls.Add(label1);
            CrudPanel.Controls.Add(CrudAppointment);
            CrudPanel.Controls.Add(UpdateBtn);
            CrudPanel.Controls.Add(AddScheduleBtn);
            CrudPanel.Controls.Add(doctorlbl);
            CrudPanel.Location = new System.Drawing.Point(0, 0);
            CrudPanel.Name = "CrudPanel";
            CrudPanel.Size = new System.Drawing.Size(797, 302);
            CrudPanel.TabIndex = 4;
            // 
            // startTimeMask
            // 
            startTimeMask.Location = new System.Drawing.Point(492, 148);
            startTimeMask.Mask = "00:00";
            startTimeMask.Name = "startTimeMask";
            startTimeMask.Size = new System.Drawing.Size(49, 23);
            startTimeMask.TabIndex = 28;
            startTimeMask.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            startTimeMask.ValidatingType = typeof(System.DateTime);
            // 
            // endTimeMask
            // 
            endTimeMask.Location = new System.Drawing.Point(654, 146);
            endTimeMask.Mask = "00:00";
            endTimeMask.Name = "endTimeMask";
            endTimeMask.Size = new System.Drawing.Size(49, 23);
            endTimeMask.TabIndex = 27;
            endTimeMask.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            endTimeMask.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(577, 147);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(66, 17);
            label3.TabIndex = 24;
            label3.Text = "End Time";
            // 
            // startTime
            // 
            startTime.AutoSize = true;
            startTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            startTime.Location = new System.Drawing.Point(373, 148);
            startTime.Name = "startTime";
            startTime.Size = new System.Drawing.Size(72, 17);
            startTime.TabIndex = 22;
            startTime.Text = "Start Time";
            // 
            // DoctorEmailTxt
            // 
            DoctorEmailTxt.Location = new System.Drawing.Point(492, 51);
            DoctorEmailTxt.Name = "DoctorEmailTxt";
            DoctorEmailTxt.Size = new System.Drawing.Size(211, 23);
            DoctorEmailTxt.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(373, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 17);
            label2.TabIndex = 20;
            label2.Text = "Doctor Email";
            // 
            // DoctorNameTxT
            // 
            DoctorNameTxT.Location = new System.Drawing.Point(138, 48);
            DoctorNameTxT.Name = "DoctorNameTxT";
            DoctorNameTxT.Size = new System.Drawing.Size(211, 23);
            DoctorNameTxT.TabIndex = 19;
            // 
            // start_time_lbl
            // 
            start_time_lbl.AutoSize = true;
            start_time_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            start_time_lbl.Location = new System.Drawing.Point(16, 144);
            start_time_lbl.Name = "start_time_lbl";
            start_time_lbl.Size = new System.Drawing.Size(37, 17);
            start_time_lbl.TabIndex = 1;
            start_time_lbl.Text = "Date";
            // 
            // PatientPhoneNoTxt
            // 
            PatientPhoneNoTxt.Location = new System.Drawing.Point(492, 94);
            PatientPhoneNoTxt.Name = "PatientPhoneNoTxt";
            PatientPhoneNoTxt.Size = new System.Drawing.Size(211, 23);
            PatientPhoneNoTxt.TabIndex = 18;
            // 
            // startTimePicker
            // 
            startTimePicker.Location = new System.Drawing.Point(138, 144);
            startTimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            startTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            startTimePicker.Name = "startTimePicker";
            startTimePicker.Size = new System.Drawing.Size(211, 23);
            startTimePicker.TabIndex = 2;
            startTimePicker.Value = new System.DateTime(2025, 5, 23, 0, 0, 0, 0);
            // 
            // PatientPhoneNolbl
            // 
            PatientPhoneNolbl.AutoSize = true;
            PatientPhoneNolbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            PatientPhoneNolbl.Location = new System.Drawing.Point(373, 95);
            PatientPhoneNolbl.Name = "PatientPhoneNolbl";
            PatientPhoneNolbl.Size = new System.Drawing.Size(113, 17);
            PatientPhoneNolbl.TabIndex = 17;
            PatientPhoneNolbl.Text = "Patient PhoneNo";
            // 
            // PatientNameTxt
            // 
            PatientNameTxt.Location = new System.Drawing.Point(138, 89);
            PatientNameTxt.Name = "PatientNameTxt";
            PatientNameTxt.Size = new System.Drawing.Size(211, 23);
            PatientNameTxt.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(15, 91);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 17);
            label1.TabIndex = 15;
            label1.Text = "Patient Name";
            // 
            // CrudAppointment
            // 
            CrudAppointment.AutoSize = true;
            CrudAppointment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            CrudAppointment.Location = new System.Drawing.Point(301, 10);
            CrudAppointment.Name = "CrudAppointment";
            CrudAppointment.Size = new System.Drawing.Size(208, 25);
            CrudAppointment.TabIndex = 15;
            CrudAppointment.Text = "Manage Appointment";
            // 
            // UpdateBtn
            // 
            UpdateBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            UpdateBtn.Location = new System.Drawing.Point(445, 228);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new System.Drawing.Size(93, 50);
            UpdateBtn.TabIndex = 6;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // AddScheduleBtn
            // 
            AddScheduleBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            AddScheduleBtn.Location = new System.Drawing.Point(301, 228);
            AddScheduleBtn.Name = "AddScheduleBtn";
            AddScheduleBtn.Size = new System.Drawing.Size(93, 50);
            AddScheduleBtn.TabIndex = 5;
            AddScheduleBtn.Text = "Add";
            AddScheduleBtn.UseVisualStyleBackColor = true;
            AddScheduleBtn.Click += AddScheduleBtn_Click;
            // 
            // doctorlbl
            // 
            doctorlbl.AutoSize = true;
            doctorlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            doctorlbl.Location = new System.Drawing.Point(16, 54);
            doctorlbl.Name = "doctorlbl";
            doctorlbl.Size = new System.Drawing.Size(90, 17);
            doctorlbl.TabIndex = 0;
            doctorlbl.Text = "Doctor Name";
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
            tabPage2.Text = "Search Appointment";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // SearchAppointmentGridView
            // 
            SearchAppointmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchAppointmentGridView.Location = new System.Drawing.Point(2, 229);
            SearchAppointmentGridView.Name = "SearchAppointmentGridView";
            SearchAppointmentGridView.Size = new System.Drawing.Size(796, 411);
            SearchAppointmentGridView.TabIndex = 6;
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
            label4.Size = new System.Drawing.Size(23, 17);
            label4.TabIndex = 15;
            label4.Text = "To";
            // 
            // Searchlbl
            // 
            Searchlbl.AutoSize = true;
            Searchlbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Searchlbl.Location = new System.Drawing.Point(301, 23);
            Searchlbl.Name = "Searchlbl";
            Searchlbl.Size = new System.Drawing.Size(195, 25);
            Searchlbl.TabIndex = 14;
            Searchlbl.Text = "Search Appointment";
            // 
            // Searchbtn
            // 
            Searchbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            Searchbtn.Location = new System.Drawing.Point(492, 167);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new System.Drawing.Size(93, 50);
            Searchbtn.TabIndex = 8;
            Searchbtn.Text = "Search";
            Searchbtn.UseVisualStyleBackColor = true;
            Searchbtn.Click += Searchbtn_Click;
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
            SearchDatelbl.Size = new System.Drawing.Size(40, 17);
            SearchDatelbl.TabIndex = 12;
            SearchDatelbl.Text = "From";
            // 
            // patientPhoneNoTextbox
            // 
            patientPhoneNoTextbox.Location = new System.Drawing.Point(200, 108);
            patientPhoneNoTextbox.Name = "patientPhoneNoTextbox";
            patientPhoneNoTextbox.Size = new System.Drawing.Size(211, 23);
            patientPhoneNoTextbox.TabIndex = 11;
            // 
            // SearchPatientNameLbl
            // 
            SearchPatientNameLbl.AutoSize = true;
            SearchPatientNameLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            SearchPatientNameLbl.Location = new System.Drawing.Point(50, 114);
            SearchPatientNameLbl.Name = "SearchPatientNameLbl";
            SearchPatientNameLbl.Size = new System.Drawing.Size(117, 17);
            SearchPatientNameLbl.TabIndex = 10;
            SearchPatientNameLbl.Text = "Patient Phone No";
            // 
            // doctorNameTextbox
            // 
            doctorNameTextbox.Location = new System.Drawing.Point(199, 66);
            doctorNameTextbox.Name = "doctorNameTextbox";
            doctorNameTextbox.Size = new System.Drawing.Size(211, 23);
            doctorNameTextbox.TabIndex = 9;
            // 
            // SearchDoctorNamelbl
            // 
            SearchDoctorNamelbl.AutoSize = true;
            SearchDoctorNamelbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            SearchDoctorNamelbl.Location = new System.Drawing.Point(77, 72);
            SearchDoctorNamelbl.Name = "SearchDoctorNamelbl";
            SearchDoctorNamelbl.Size = new System.Drawing.Size(90, 17);
            SearchDoctorNamelbl.TabIndex = 8;
            SearchDoctorNamelbl.Text = "Doctor Name";
            // 
            // panel2
            // 
            panel2.Controls.Add(Homelbl);
            panel2.Controls.Add(Invoicelbl);
            panel2.Controls.Add(Patientlbl);
            panel2.Controls.Add(Schedulelbl);
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
            Homelbl.Text = "Home";
            Homelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Homelbl.Click += menulbl_click;
            // 
            // Invoicelbl
            // 
            Invoicelbl.Cursor = System.Windows.Forms.Cursors.Hand;
            Invoicelbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Invoicelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            Invoicelbl.Location = new System.Drawing.Point(3, 390);
            Invoicelbl.Name = "Invoicelbl";
            Invoicelbl.Size = new System.Drawing.Size(170, 46);
            Invoicelbl.TabIndex = 6;
            Invoicelbl.Text = "Invoice";
            Invoicelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Invoicelbl.Click += menulbl_click;
            // 
            // Patientlbl
            // 
            Patientlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            Patientlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Patientlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            Patientlbl.Location = new System.Drawing.Point(3, 344);
            Patientlbl.Name = "Patientlbl";
            Patientlbl.Size = new System.Drawing.Size(170, 46);
            Patientlbl.TabIndex = 5;
            Patientlbl.Text = "Patient";
            Patientlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Patientlbl.Click += menulbl_click;
            // 
            // Schedulelbl
            // 
            Schedulelbl.Cursor = System.Windows.Forms.Cursors.Hand;
            Schedulelbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Schedulelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            Schedulelbl.Location = new System.Drawing.Point(3, 298);
            Schedulelbl.Name = "Schedulelbl";
            Schedulelbl.Size = new System.Drawing.Size(170, 46);
            Schedulelbl.TabIndex = 5;
            Schedulelbl.Text = "Schedule";
            Schedulelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Schedulelbl.Click += menulbl_click;
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
            Appointmentlbl.Text = "Appointment";
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
            SignOutlbl.Text = "Sign Out";
            SignOutlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
        private System.Windows.Forms.TextBox DoctorEmailTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DoctorNameTxT;
        private System.Windows.Forms.Label start_time_lbl;
        private System.Windows.Forms.TextBox PatientPhoneNoTxt;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Label PatientPhoneNolbl;
        private System.Windows.Forms.TextBox PatientNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CrudAppointment;
        private System.Windows.Forms.Button UpdateBtn;
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
        private System.Windows.Forms.Label Schedulelbl;
        private System.Windows.Forms.Label Appointmentlbl;
        private System.Windows.Forms.Label SignOutlbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.DataGridView SearchAppointmentGridView;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox endTimeMask;
        private System.Windows.Forms.MaskedTextBox startTimeMask;
    }
}