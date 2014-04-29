namespace TeemaApplication
{
    partial class frmManualAttendance
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
            this.gbxEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.txtEPF_No = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNIC_No = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxDepartmentDetails = new System.Windows.Forms.GroupBox();
            this.lblSubDepartment = new System.Windows.Forms.Label();
            this.cmbSubDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbWorkingBranch = new System.Windows.Forms.ComboBox();
            this.lblWorkingBranch = new System.Windows.Forms.Label();
            this.lblFormTopic = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbTokenNo = new System.Windows.Forms.ComboBox();
            this.cmbEmployeeName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAttendaceDate = new System.Windows.Forms.DateTimePicker();
            this.dupHour = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dupMiniutes = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.btnSaveDetails = new System.Windows.Forms.Button();
            this.gbxEmployeeDetails.SuspendLayout();
            this.gbxDepartmentDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxEmployeeDetails
            // 
            this.gbxEmployeeDetails.Controls.Add(this.cmbEmployeeName);
            this.gbxEmployeeDetails.Controls.Add(this.cmbTokenNo);
            this.gbxEmployeeDetails.Controls.Add(this.label13);
            this.gbxEmployeeDetails.Controls.Add(this.txtEPF_No);
            this.gbxEmployeeDetails.Controls.Add(this.label12);
            this.gbxEmployeeDetails.Controls.Add(this.txtNIC_No);
            this.gbxEmployeeDetails.Controls.Add(this.label7);
            this.gbxEmployeeDetails.Controls.Add(this.txtDesignation);
            this.gbxEmployeeDetails.Controls.Add(this.label6);
            this.gbxEmployeeDetails.Controls.Add(this.label3);
            this.gbxEmployeeDetails.Location = new System.Drawing.Point(12, 149);
            this.gbxEmployeeDetails.Name = "gbxEmployeeDetails";
            this.gbxEmployeeDetails.Size = new System.Drawing.Size(285, 155);
            this.gbxEmployeeDetails.TabIndex = 7;
            this.gbxEmployeeDetails.TabStop = false;
            this.gbxEmployeeDetails.Text = "Employee Details";
            // 
            // txtEPF_No
            // 
            this.txtEPF_No.Location = new System.Drawing.Point(96, 126);
            this.txtEPF_No.Name = "txtEPF_No";
            this.txtEPF_No.ReadOnly = true;
            this.txtEPF_No.Size = new System.Drawing.Size(183, 20);
            this.txtEPF_No.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "EPF No.";
            // 
            // txtNIC_No
            // 
            this.txtNIC_No.Location = new System.Drawing.Point(96, 99);
            this.txtNIC_No.Name = "txtNIC_No";
            this.txtNIC_No.ReadOnly = true;
            this.txtNIC_No.Size = new System.Drawing.Size(183, 20);
            this.txtNIC_No.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "NIC No";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(96, 73);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.ReadOnly = true;
            this.txtDesignation.Size = new System.Drawing.Size(183, 20);
            this.txtDesignation.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Designation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Employee Name";
            // 
            // gbxDepartmentDetails
            // 
            this.gbxDepartmentDetails.BackColor = System.Drawing.SystemColors.Control;
            this.gbxDepartmentDetails.Controls.Add(this.lblSubDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbSubDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.lblDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbWorkingBranch);
            this.gbxDepartmentDetails.Controls.Add(this.lblWorkingBranch);
            this.gbxDepartmentDetails.Location = new System.Drawing.Point(12, 43);
            this.gbxDepartmentDetails.Name = "gbxDepartmentDetails";
            this.gbxDepartmentDetails.Size = new System.Drawing.Size(285, 100);
            this.gbxDepartmentDetails.TabIndex = 6;
            this.gbxDepartmentDetails.TabStop = false;
            this.gbxDepartmentDetails.Text = "Department Details";
            // 
            // lblSubDepartment
            // 
            this.lblSubDepartment.AutoSize = true;
            this.lblSubDepartment.Location = new System.Drawing.Point(6, 76);
            this.lblSubDepartment.Name = "lblSubDepartment";
            this.lblSubDepartment.Size = new System.Drawing.Size(84, 13);
            this.lblSubDepartment.TabIndex = 5;
            this.lblSubDepartment.Text = "Sub Department";
            // 
            // cmbSubDepartment
            // 
            this.cmbSubDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubDepartment.FormattingEnabled = true;
            this.cmbSubDepartment.Location = new System.Drawing.Point(96, 73);
            this.cmbSubDepartment.Name = "cmbSubDepartment";
            this.cmbSubDepartment.Size = new System.Drawing.Size(183, 21);
            this.cmbSubDepartment.TabIndex = 4;
            this.cmbSubDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbSubDepartment_SelectedIndexChanged);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(6, 50);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "Department";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(96, 46);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(183, 21);
            this.cmbDepartment.TabIndex = 2;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // cmbWorkingBranch
            // 
            this.cmbWorkingBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkingBranch.FormattingEnabled = true;
            this.cmbWorkingBranch.Location = new System.Drawing.Point(96, 19);
            this.cmbWorkingBranch.Name = "cmbWorkingBranch";
            this.cmbWorkingBranch.Size = new System.Drawing.Size(183, 21);
            this.cmbWorkingBranch.TabIndex = 1;
            this.cmbWorkingBranch.SelectedIndexChanged += new System.EventHandler(this.cmbWorkingBranch_SelectedIndexChanged);
            // 
            // lblWorkingBranch
            // 
            this.lblWorkingBranch.AutoSize = true;
            this.lblWorkingBranch.Location = new System.Drawing.Point(6, 22);
            this.lblWorkingBranch.Name = "lblWorkingBranch";
            this.lblWorkingBranch.Size = new System.Drawing.Size(84, 13);
            this.lblWorkingBranch.TabIndex = 0;
            this.lblWorkingBranch.Text = "Working Branch";
            // 
            // lblFormTopic
            // 
            this.lblFormTopic.AutoSize = true;
            this.lblFormTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTopic.Location = new System.Drawing.Point(12, 9);
            this.lblFormTopic.Name = "lblFormTopic";
            this.lblFormTopic.Size = new System.Drawing.Size(247, 31);
            this.lblFormTopic.TabIndex = 8;
            this.lblFormTopic.Text = "Manual Attendance";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Token No";
            // 
            // cmbTokenNo
            // 
            this.cmbTokenNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTokenNo.FormattingEnabled = true;
            this.cmbTokenNo.Location = new System.Drawing.Point(96, 19);
            this.cmbTokenNo.Name = "cmbTokenNo";
            this.cmbTokenNo.Size = new System.Drawing.Size(183, 21);
            this.cmbTokenNo.TabIndex = 20;
            this.cmbTokenNo.SelectedIndexChanged += new System.EventHandler(this.cmbTokenNo_SelectedIndexChanged);
            // 
            // cmbEmployeeName
            // 
            this.cmbEmployeeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeName.FormattingEnabled = true;
            this.cmbEmployeeName.Location = new System.Drawing.Point(96, 46);
            this.cmbEmployeeName.Name = "cmbEmployeeName";
            this.cmbEmployeeName.Size = new System.Drawing.Size(183, 21);
            this.cmbEmployeeName.TabIndex = 21;
            this.cmbEmployeeName.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeName_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dupMiniutes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dupHour);
            this.groupBox1.Controls.Add(this.dtpAttendaceDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 99);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attendance Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Attendance Date";
            // 
            // dtpAttendaceDate
            // 
            this.dtpAttendaceDate.Location = new System.Drawing.Point(95, 19);
            this.dtpAttendaceDate.Name = "dtpAttendaceDate";
            this.dtpAttendaceDate.Size = new System.Drawing.Size(183, 20);
            this.dtpAttendaceDate.TabIndex = 16;
            // 
            // dupHour
            // 
            this.dupHour.Items.Add("00");
            this.dupHour.Items.Add("01");
            this.dupHour.Items.Add("02");
            this.dupHour.Items.Add("03");
            this.dupHour.Items.Add("04");
            this.dupHour.Items.Add("05");
            this.dupHour.Items.Add("06");
            this.dupHour.Items.Add("07");
            this.dupHour.Items.Add("08");
            this.dupHour.Items.Add("09");
            this.dupHour.Items.Add("10");
            this.dupHour.Items.Add("11");
            this.dupHour.Items.Add("12");
            this.dupHour.Items.Add("13");
            this.dupHour.Items.Add("14");
            this.dupHour.Items.Add("15");
            this.dupHour.Items.Add("16");
            this.dupHour.Items.Add("17");
            this.dupHour.Items.Add("18");
            this.dupHour.Items.Add("19");
            this.dupHour.Items.Add("20");
            this.dupHour.Items.Add("21");
            this.dupHour.Items.Add("22");
            this.dupHour.Items.Add("23");
            this.dupHour.Location = new System.Drawing.Point(95, 46);
            this.dupHour.Name = "dupHour";
            this.dupHour.Size = new System.Drawing.Size(40, 20);
            this.dupHour.TabIndex = 17;
            this.dupHour.Text = "HH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Time";
            // 
            // dupMiniutes
            // 
            this.dupMiniutes.Items.Add("00");
            this.dupMiniutes.Items.Add("01");
            this.dupMiniutes.Items.Add("02");
            this.dupMiniutes.Items.Add("03");
            this.dupMiniutes.Items.Add("04");
            this.dupMiniutes.Items.Add("05");
            this.dupMiniutes.Items.Add("06");
            this.dupMiniutes.Items.Add("07");
            this.dupMiniutes.Items.Add("08");
            this.dupMiniutes.Items.Add("09");
            this.dupMiniutes.Items.Add("10");
            this.dupMiniutes.Items.Add("11");
            this.dupMiniutes.Items.Add("12");
            this.dupMiniutes.Items.Add("13");
            this.dupMiniutes.Items.Add("14");
            this.dupMiniutes.Items.Add("15");
            this.dupMiniutes.Items.Add("16");
            this.dupMiniutes.Items.Add("17");
            this.dupMiniutes.Items.Add("18");
            this.dupMiniutes.Items.Add("19");
            this.dupMiniutes.Items.Add("20");
            this.dupMiniutes.Items.Add("21");
            this.dupMiniutes.Items.Add("22");
            this.dupMiniutes.Items.Add("23");
            this.dupMiniutes.Items.Add("24");
            this.dupMiniutes.Items.Add("25");
            this.dupMiniutes.Items.Add("26");
            this.dupMiniutes.Items.Add("27");
            this.dupMiniutes.Items.Add("28");
            this.dupMiniutes.Items.Add("29");
            this.dupMiniutes.Items.Add("30");
            this.dupMiniutes.Items.Add("31");
            this.dupMiniutes.Items.Add("32");
            this.dupMiniutes.Items.Add("33");
            this.dupMiniutes.Items.Add("34");
            this.dupMiniutes.Items.Add("35");
            this.dupMiniutes.Items.Add("36");
            this.dupMiniutes.Items.Add("37");
            this.dupMiniutes.Items.Add("38");
            this.dupMiniutes.Items.Add("39");
            this.dupMiniutes.Items.Add("40");
            this.dupMiniutes.Items.Add("41");
            this.dupMiniutes.Items.Add("42");
            this.dupMiniutes.Items.Add("43");
            this.dupMiniutes.Items.Add("44");
            this.dupMiniutes.Items.Add("45");
            this.dupMiniutes.Items.Add("46");
            this.dupMiniutes.Items.Add("47");
            this.dupMiniutes.Items.Add("48");
            this.dupMiniutes.Items.Add("49");
            this.dupMiniutes.Items.Add("50");
            this.dupMiniutes.Items.Add("51");
            this.dupMiniutes.Items.Add("52");
            this.dupMiniutes.Items.Add("53");
            this.dupMiniutes.Items.Add("54");
            this.dupMiniutes.Items.Add("55");
            this.dupMiniutes.Items.Add("56");
            this.dupMiniutes.Items.Add("57");
            this.dupMiniutes.Items.Add("58");
            this.dupMiniutes.Items.Add("59");
            this.dupMiniutes.Location = new System.Drawing.Point(141, 46);
            this.dupMiniutes.Name = "dupMiniutes";
            this.dupMiniutes.Size = new System.Drawing.Size(40, 20);
            this.dupMiniutes.TabIndex = 19;
            this.dupMiniutes.Text = "MM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mode";
            // 
            // cmbMode
            // 
            this.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Items.AddRange(new object[] {
            "In",
            "Out",
            "Duty On",
            "Duty Off",
            "Overtime On",
            "Overtime Off"});
            this.cmbMode.Location = new System.Drawing.Point(95, 72);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(183, 21);
            this.cmbMode.TabIndex = 21;
            // 
            // btnSaveDetails
            // 
            this.btnSaveDetails.Location = new System.Drawing.Point(222, 416);
            this.btnSaveDetails.Name = "btnSaveDetails";
            this.btnSaveDetails.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDetails.TabIndex = 10;
            this.btnSaveDetails.Text = "Save Details";
            this.btnSaveDetails.UseVisualStyleBackColor = true;
            this.btnSaveDetails.Click += new System.EventHandler(this.btnSaveDetails_Click);
            // 
            // frmManualAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 451);
            this.Controls.Add(this.btnSaveDetails);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFormTopic);
            this.Controls.Add(this.gbxEmployeeDetails);
            this.Controls.Add(this.gbxDepartmentDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManualAttendance";
            this.Text = "Manual Attendance";
            this.Load += new System.EventHandler(this.frmManualAttendance_Load);
            this.gbxEmployeeDetails.ResumeLayout(false);
            this.gbxEmployeeDetails.PerformLayout();
            this.gbxDepartmentDetails.ResumeLayout(false);
            this.gbxDepartmentDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEmployeeDetails;
        private System.Windows.Forms.TextBox txtEPF_No;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNIC_No;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxDepartmentDetails;
        private System.Windows.Forms.Label lblSubDepartment;
        private System.Windows.Forms.ComboBox cmbSubDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbWorkingBranch;
        private System.Windows.Forms.Label lblWorkingBranch;
        private System.Windows.Forms.ComboBox cmbEmployeeName;
        private System.Windows.Forms.ComboBox cmbTokenNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblFormTopic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DomainUpDown dupMiniutes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown dupHour;
        private System.Windows.Forms.DateTimePicker dtpAttendaceDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveDetails;
    }
}