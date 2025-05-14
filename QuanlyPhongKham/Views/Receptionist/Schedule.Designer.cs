namespace QuanlyPhongKham.Views.Receptionist
{
    partial class Schedule
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
            CrudPanel = new System.Windows.Forms.Panel();
            doctorlbl = new System.Windows.Forms.Label();
            start_time_lbl = new System.Windows.Forms.Label();
            startTimePicker = new System.Windows.Forms.DateTimePicker();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            endTimelbl = new System.Windows.Forms.Label();
            doctor_input = new System.Windows.Forms.ListBox();
            AddScheduleBtn = new System.Windows.Forms.Button();
            UpdateBtn = new System.Windows.Forms.Button();
            ResetBtn = new System.Windows.Forms.Button();
            CrudPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CrudPanel
            // 
            CrudPanel.Controls.Add(ResetBtn);
            CrudPanel.Controls.Add(UpdateBtn);
            CrudPanel.Controls.Add(AddScheduleBtn);
            CrudPanel.Controls.Add(doctor_input);
            CrudPanel.Controls.Add(dateTimePicker1);
            CrudPanel.Controls.Add(endTimelbl);
            CrudPanel.Controls.Add(startTimePicker);
            CrudPanel.Controls.Add(start_time_lbl);
            CrudPanel.Controls.Add(doctorlbl);
            CrudPanel.Location = new System.Drawing.Point(194, 42);
            CrudPanel.Name = "CrudPanel";
            CrudPanel.Size = new System.Drawing.Size(814, 256);
            CrudPanel.TabIndex = 0;
            CrudPanel.Paint += CrudPanel_Paint;
            // 
            // doctorlbl
            // 
            doctorlbl.AutoSize = true;
            doctorlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            doctorlbl.Location = new System.Drawing.Point(178, 22);
            doctorlbl.Name = "doctorlbl";
            doctorlbl.Size = new System.Drawing.Size(50, 17);
            doctorlbl.TabIndex = 0;
            doctorlbl.Text = "Doctor";
            // 
            // start_time_lbl
            // 
            start_time_lbl.AutoSize = true;
            start_time_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            start_time_lbl.Location = new System.Drawing.Point(178, 96);
            start_time_lbl.Name = "start_time_lbl";
            start_time_lbl.Size = new System.Drawing.Size(105, 17);
            start_time_lbl.TabIndex = 1;
            start_time_lbl.Text = "Start Date Time";
            // 
            // startTimePicker
            // 
            startTimePicker.Location = new System.Drawing.Point(178, 126);
            startTimePicker.Name = "startTimePicker";
            startTimePicker.Size = new System.Drawing.Size(206, 23);
            startTimePicker.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(433, 126);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(210, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // endTimelbl
            // 
            endTimelbl.AutoSize = true;
            endTimelbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            endTimelbl.Location = new System.Drawing.Point(433, 96);
            endTimelbl.Name = "endTimelbl";
            endTimelbl.Size = new System.Drawing.Size(99, 17);
            endTimelbl.TabIndex = 3;
            endTimelbl.Text = "End Date Time";
            // 
            // doctor_input
            // 
            doctor_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            doctor_input.FormattingEnabled = true;
            doctor_input.ItemHeight = 15;
            doctor_input.Items.AddRange(new object[] { "A", "B", "C" });
            doctor_input.Location = new System.Drawing.Point(178, 55);
            doctor_input.Name = "doctor_input";
            doctor_input.ScrollAlwaysVisible = true;
            doctor_input.Size = new System.Drawing.Size(170, 15);
            doctor_input.TabIndex = 0;
            // 
            // AddScheduleBtn
            // 
            AddScheduleBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            AddScheduleBtn.Location = new System.Drawing.Point(178, 175);
            AddScheduleBtn.Name = "AddScheduleBtn";
            AddScheduleBtn.Size = new System.Drawing.Size(93, 50);
            AddScheduleBtn.TabIndex = 5;
            AddScheduleBtn.Text = "Add";
            AddScheduleBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            UpdateBtn.Location = new System.Drawing.Point(370, 175);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new System.Drawing.Size(93, 50);
            UpdateBtn.TabIndex = 6;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // ResetBtn
            // 
            ResetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            ResetBtn.Location = new System.Drawing.Point(550, 175);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new System.Drawing.Size(93, 50);
            ResetBtn.TabIndex = 7;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            // 
            // Schedule
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1008, 681);
            Controls.Add(CrudPanel);
            Name = "Schedule";
            Text = "Schedule";
            CrudPanel.ResumeLayout(false);
            CrudPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel CrudPanel;
        private System.Windows.Forms.Label start_time_lbl;
        private System.Windows.Forms.Label doctorlbl;
        private System.Windows.Forms.ListBox doctor_input;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label endTimelbl;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddScheduleBtn;
    }
}