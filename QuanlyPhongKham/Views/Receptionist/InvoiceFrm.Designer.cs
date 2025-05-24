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
            panel2 = new System.Windows.Forms.Panel();
            Homelbl = new System.Windows.Forms.Label();
            Invoicelbl = new System.Windows.Forms.Label();
            Patientlbl = new System.Windows.Forms.Label();
            Schedulelbl = new System.Windows.Forms.Label();
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
            panel2.Controls.Add(Schedulelbl);
            panel2.Controls.Add(Appointmentlbl);
            panel2.Controls.Add(SignOutlbl);
            panel2.Location = new System.Drawing.Point(12, 31);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(176, 638);
            panel2.TabIndex = 10;
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
            // panel1
            // 
            panel1.Controls.Add(Searchbtn);
            panel1.Controls.Add(patientPhoneNoTxt);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(endTimePicker);
            panel1.Controls.Add(endTimelbl);
            panel1.Controls.Add(start_time_lbl);
            panel1.Controls.Add(startTimePicker);
            panel1.Location = new System.Drawing.Point(205, 31);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(791, 206);
            panel1.TabIndex = 11;
            // 
            // Searchbtn
            // 
            Searchbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            Searchbtn.Location = new System.Drawing.Point(409, 118);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new System.Drawing.Size(93, 50);
            Searchbtn.TabIndex = 21;
            Searchbtn.Text = "Search";
            Searchbtn.UseVisualStyleBackColor = true;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // patientPhoneNoTxt
            // 
            patientPhoneNoTxt.Location = new System.Drawing.Point(169, 117);
            patientPhoneNoTxt.Name = "patientPhoneNoTxt";
            patientPhoneNoTxt.Size = new System.Drawing.Size(211, 23);
            patientPhoneNoTxt.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(50, 118);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(101, 17);
            label5.TabIndex = 19;
            label5.Text = "Phone Number";
            // 
            // endTimePicker
            // 
            endTimePicker.Location = new System.Drawing.Point(522, 51);
            endTimePicker.Name = "endTimePicker";
            endTimePicker.Size = new System.Drawing.Size(210, 23);
            endTimePicker.TabIndex = 8;
            // 
            // endTimelbl
            // 
            endTimelbl.AutoSize = true;
            endTimelbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            endTimelbl.Location = new System.Drawing.Point(403, 51);
            endTimelbl.Name = "endTimelbl";
            endTimelbl.Size = new System.Drawing.Size(99, 17);
            endTimelbl.TabIndex = 7;
            endTimelbl.Text = "End Date Time";
            // 
            // start_time_lbl
            // 
            start_time_lbl.AutoSize = true;
            start_time_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            start_time_lbl.Location = new System.Drawing.Point(46, 51);
            start_time_lbl.Name = "start_time_lbl";
            start_time_lbl.Size = new System.Drawing.Size(105, 17);
            start_time_lbl.TabIndex = 5;
            start_time_lbl.Text = "Start Date Time";
            // 
            // startTimePicker
            // 
            startTimePicker.Location = new System.Drawing.Point(168, 51);
            startTimePicker.Name = "startTimePicker";
            startTimePicker.Size = new System.Drawing.Size(211, 23);
            startTimePicker.TabIndex = 6;
            // 
            // InvoiceGridView
            // 
            InvoiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InvoiceGridView.Location = new System.Drawing.Point(208, 244);
            InvoiceGridView.Name = "InvoiceGridView";
            InvoiceGridView.Size = new System.Drawing.Size(787, 183);
            InvoiceGridView.TabIndex = 12;
            InvoiceGridView.CellClick += InvoiceGridView_CellClick;
            // 
            // InvoiceDetailGridView
            // 
            InvoiceDetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InvoiceDetailGridView.Location = new System.Drawing.Point(205, 486);
            InvoiceDetailGridView.Name = "InvoiceDetailGridView";
            InvoiceDetailGridView.Size = new System.Drawing.Size(787, 183);
            InvoiceDetailGridView.TabIndex = 13;
            // 
            // CrudPatient
            // 
            CrudPatient.AutoSize = true;
            CrudPatient.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            CrudPatient.Location = new System.Drawing.Point(575, 442);
            CrudPatient.Name = "CrudPatient";
            CrudPatient.Size = new System.Drawing.Size(132, 25);
            CrudPatient.TabIndex = 16;
            CrudPatient.Text = "Invoice Detail";
            // 
            // InvoiceFrm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1008, 681);
            Controls.Add(CrudPatient);
            Controls.Add(InvoiceDetailGridView);
            Controls.Add(InvoiceGridView);
            Controls.Add(panel1);
            Controls.Add(panel2);
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
        private System.Windows.Forms.Label Schedulelbl;
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