namespace TeemaApplication
{
    partial class frmOver_Time_Approve
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
            this.lblFormTopic = new System.Windows.Forms.Label();
            this.gbxEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.txtSub_Department = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtToken_No = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEPF_No = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNIC_No = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxDepartmentDetails = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSubDepartment = new System.Windows.Forms.Label();
            this.cmbSubDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbWorkingBranch = new System.Windows.Forms.ComboBox();
            this.lblWorkingBranch = new System.Windows.Forms.Label();
            this.gbxOver_Time_Details = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtOver_Time_Hours = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.dtpOver_Time_Date = new System.Windows.Forms.DateTimePicker();
            this.gbxOver_Time_Type = new System.Windows.Forms.GroupBox();
            this.rdbTreble = new System.Windows.Forms.RadioButton();
            this.rdbDouble = new System.Windows.Forms.RadioButton();
            this.rdbSingle = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxTime = new System.Windows.Forms.GroupBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gdvOver_Time_Request = new System.Windows.Forms.DataGridView();
            this.clmnApprove = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnToken_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEPF_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmployee_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNo_Of_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxEmployeeDetails.SuspendLayout();
            this.gbxDepartmentDetails.SuspendLayout();
            this.gbxOver_Time_Details.SuspendLayout();
            this.gbxOver_Time_Type.SuspendLayout();
            this.gbxTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvOver_Time_Request)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTopic
            // 
            this.lblFormTopic.AutoSize = true;
            this.lblFormTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTopic.Location = new System.Drawing.Point(12, 9);
            this.lblFormTopic.Name = "lblFormTopic";
            this.lblFormTopic.Size = new System.Drawing.Size(248, 31);
            this.lblFormTopic.TabIndex = 4;
            this.lblFormTopic.Text = "Over Time Approve";
            // 
            // gbxEmployeeDetails
            // 
            this.gbxEmployeeDetails.Controls.Add(this.btnClear);
            this.gbxEmployeeDetails.Controls.Add(this.txtBranch);
            this.gbxEmployeeDetails.Controls.Add(this.txtSub_Department);
            this.gbxEmployeeDetails.Controls.Add(this.txtDepartment);
            this.gbxEmployeeDetails.Controls.Add(this.txtToken_No);
            this.gbxEmployeeDetails.Controls.Add(this.label16);
            this.gbxEmployeeDetails.Controls.Add(this.label15);
            this.gbxEmployeeDetails.Controls.Add(this.label14);
            this.gbxEmployeeDetails.Controls.Add(this.label13);
            this.gbxEmployeeDetails.Controls.Add(this.txtEPF_No);
            this.gbxEmployeeDetails.Controls.Add(this.label12);
            this.gbxEmployeeDetails.Controls.Add(this.txtNIC_No);
            this.gbxEmployeeDetails.Controls.Add(this.label7);
            this.gbxEmployeeDetails.Controls.Add(this.txtDesignation);
            this.gbxEmployeeDetails.Controls.Add(this.label6);
            this.gbxEmployeeDetails.Controls.Add(this.txtEmployeeName);
            this.gbxEmployeeDetails.Controls.Add(this.label3);
            this.gbxEmployeeDetails.Location = new System.Drawing.Point(12, 185);
            this.gbxEmployeeDetails.Name = "gbxEmployeeDetails";
            this.gbxEmployeeDetails.Size = new System.Drawing.Size(285, 264);
            this.gbxEmployeeDetails.TabIndex = 7;
            this.gbxEmployeeDetails.TabStop = false;
            this.gbxEmployeeDetails.Text = "Employee Details";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(204, 228);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(97, 202);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(176, 20);
            this.txtBranch.TabIndex = 25;
            // 
            // txtSub_Department
            // 
            this.txtSub_Department.Location = new System.Drawing.Point(97, 176);
            this.txtSub_Department.Name = "txtSub_Department";
            this.txtSub_Department.Size = new System.Drawing.Size(176, 20);
            this.txtSub_Department.TabIndex = 24;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(97, 150);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(176, 20);
            this.txtDepartment.TabIndex = 19;
            // 
            // txtToken_No
            // 
            this.txtToken_No.Location = new System.Drawing.Point(97, 124);
            this.txtToken_No.Name = "txtToken_No";
            this.txtToken_No.Size = new System.Drawing.Size(176, 20);
            this.txtToken_No.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 205);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Branch";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Sub Department";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Department";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Token No";
            // 
            // txtEPF_No
            // 
            this.txtEPF_No.Location = new System.Drawing.Point(97, 98);
            this.txtEPF_No.Name = "txtEPF_No";
            this.txtEPF_No.Size = new System.Drawing.Size(176, 20);
            this.txtEPF_No.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "EPF No.";
            // 
            // txtNIC_No
            // 
            this.txtNIC_No.Location = new System.Drawing.Point(97, 71);
            this.txtNIC_No.Name = "txtNIC_No";
            this.txtNIC_No.Size = new System.Drawing.Size(176, 20);
            this.txtNIC_No.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "NIC No";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(97, 45);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(176, 20);
            this.txtDesignation.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Designation";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(97, 19);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(176, 20);
            this.txtEmployeeName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Employee Name";
            // 
            // gbxDepartmentDetails
            // 
            this.gbxDepartmentDetails.BackColor = System.Drawing.SystemColors.Control;
            this.gbxDepartmentDetails.Controls.Add(this.btnSearch);
            this.gbxDepartmentDetails.Controls.Add(this.lblSubDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbSubDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.lblDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbWorkingBranch);
            this.gbxDepartmentDetails.Controls.Add(this.lblWorkingBranch);
            this.gbxDepartmentDetails.Location = new System.Drawing.Point(12, 48);
            this.gbxDepartmentDetails.Name = "gbxDepartmentDetails";
            this.gbxDepartmentDetails.Size = new System.Drawing.Size(285, 131);
            this.gbxDepartmentDetails.TabIndex = 6;
            this.gbxDepartmentDetails.TabStop = false;
            this.gbxDepartmentDetails.Text = "Department Details";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(198, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
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
            this.cmbSubDepartment.FormattingEnabled = true;
            this.cmbSubDepartment.Location = new System.Drawing.Point(96, 73);
            this.cmbSubDepartment.Name = "cmbSubDepartment";
            this.cmbSubDepartment.Size = new System.Drawing.Size(177, 21);
            this.cmbSubDepartment.TabIndex = 4;
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
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(96, 46);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(177, 21);
            this.cmbDepartment.TabIndex = 2;
            // 
            // cmbWorkingBranch
            // 
            this.cmbWorkingBranch.FormattingEnabled = true;
            this.cmbWorkingBranch.Location = new System.Drawing.Point(96, 19);
            this.cmbWorkingBranch.Name = "cmbWorkingBranch";
            this.cmbWorkingBranch.Size = new System.Drawing.Size(177, 21);
            this.cmbWorkingBranch.TabIndex = 1;
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
            // gbxOver_Time_Details
            // 
            this.gbxOver_Time_Details.Controls.Add(this.btnSave);
            this.gbxOver_Time_Details.Controls.Add(this.txtOver_Time_Hours);
            this.gbxOver_Time_Details.Controls.Add(this.label8);
            this.gbxOver_Time_Details.Controls.Add(this.txtReason);
            this.gbxOver_Time_Details.Controls.Add(this.dtpOver_Time_Date);
            this.gbxOver_Time_Details.Controls.Add(this.gbxOver_Time_Type);
            this.gbxOver_Time_Details.Controls.Add(this.label5);
            this.gbxOver_Time_Details.Controls.Add(this.gbxTime);
            this.gbxOver_Time_Details.Controls.Add(this.label1);
            this.gbxOver_Time_Details.Location = new System.Drawing.Point(303, 48);
            this.gbxOver_Time_Details.Name = "gbxOver_Time_Details";
            this.gbxOver_Time_Details.Size = new System.Drawing.Size(438, 255);
            this.gbxOver_Time_Details.TabIndex = 8;
            this.gbxOver_Time_Details.TabStop = false;
            this.gbxOver_Time_Details.Text = "Over Time Details";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(359, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtOver_Time_Hours
            // 
            this.txtOver_Time_Hours.Location = new System.Drawing.Point(122, 137);
            this.txtOver_Time_Hours.Name = "txtOver_Time_Hours";
            this.txtOver_Time_Hours.Size = new System.Drawing.Size(176, 20);
            this.txtOver_Time_Hours.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Over Time Hours";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(122, 163);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(176, 75);
            this.txtReason.TabIndex = 10;
            // 
            // dtpOver_Time_Date
            // 
            this.dtpOver_Time_Date.Location = new System.Drawing.Point(104, 19);
            this.dtpOver_Time_Date.Name = "dtpOver_Time_Date";
            this.dtpOver_Time_Date.Size = new System.Drawing.Size(200, 20);
            this.dtpOver_Time_Date.TabIndex = 5;
            // 
            // gbxOver_Time_Type
            // 
            this.gbxOver_Time_Type.Controls.Add(this.rdbTreble);
            this.gbxOver_Time_Type.Controls.Add(this.rdbDouble);
            this.gbxOver_Time_Type.Controls.Add(this.rdbSingle);
            this.gbxOver_Time_Type.Location = new System.Drawing.Point(310, 19);
            this.gbxOver_Time_Type.Name = "gbxOver_Time_Type";
            this.gbxOver_Time_Type.Size = new System.Drawing.Size(122, 112);
            this.gbxOver_Time_Type.TabIndex = 4;
            this.gbxOver_Time_Type.TabStop = false;
            this.gbxOver_Time_Type.Text = "Over Time Type";
            // 
            // rdbTreble
            // 
            this.rdbTreble.AutoSize = true;
            this.rdbTreble.Location = new System.Drawing.Point(18, 74);
            this.rdbTreble.Name = "rdbTreble";
            this.rdbTreble.Size = new System.Drawing.Size(55, 17);
            this.rdbTreble.TabIndex = 2;
            this.rdbTreble.TabStop = true;
            this.rdbTreble.Text = "Treble";
            this.rdbTreble.UseVisualStyleBackColor = true;
            // 
            // rdbDouble
            // 
            this.rdbDouble.AutoSize = true;
            this.rdbDouble.Location = new System.Drawing.Point(18, 51);
            this.rdbDouble.Name = "rdbDouble";
            this.rdbDouble.Size = new System.Drawing.Size(59, 17);
            this.rdbDouble.TabIndex = 1;
            this.rdbDouble.TabStop = true;
            this.rdbDouble.Text = "Double";
            this.rdbDouble.UseVisualStyleBackColor = true;
            // 
            // rdbSingle
            // 
            this.rdbSingle.AutoSize = true;
            this.rdbSingle.Location = new System.Drawing.Point(18, 28);
            this.rdbSingle.Name = "rdbSingle";
            this.rdbSingle.Size = new System.Drawing.Size(54, 17);
            this.rdbSingle.TabIndex = 0;
            this.rdbSingle.TabStop = true;
            this.rdbSingle.Text = "Single";
            this.rdbSingle.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Reason";
            // 
            // gbxTime
            // 
            this.gbxTime.Controls.Add(this.txtTo);
            this.gbxTime.Controls.Add(this.txtFrom);
            this.gbxTime.Controls.Add(this.label4);
            this.gbxTime.Controls.Add(this.label2);
            this.gbxTime.Location = new System.Drawing.Point(6, 45);
            this.gbxTime.Name = "gbxTime";
            this.gbxTime.Size = new System.Drawing.Size(298, 86);
            this.gbxTime.TabIndex = 2;
            this.gbxTime.TabStop = false;
            this.gbxTime.Text = "Time";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(116, 45);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(176, 20);
            this.txtTo.TabIndex = 29;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(116, 19);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(176, 20);
            this.txtFrom.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OverTime Date";
            // 
            // gdvOver_Time_Request
            // 
            this.gdvOver_Time_Request.AllowUserToDeleteRows = false;
            this.gdvOver_Time_Request.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvOver_Time_Request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvOver_Time_Request.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnApprove,
            this.clmnToken_no,
            this.clmnEPF_No,
            this.clmnEmployee_Name,
            this.clmnNo_Of_Employee});
            this.gdvOver_Time_Request.Location = new System.Drawing.Point(303, 309);
            this.gdvOver_Time_Request.Name = "gdvOver_Time_Request";
            this.gdvOver_Time_Request.RowHeadersVisible = false;
            this.gdvOver_Time_Request.Size = new System.Drawing.Size(438, 140);
            this.gdvOver_Time_Request.TabIndex = 9;
            // 
            // clmnApprove
            // 
            this.clmnApprove.HeaderText = "Approve";
            this.clmnApprove.Name = "clmnApprove";
            // 
            // clmnToken_no
            // 
            this.clmnToken_no.HeaderText = "Token No.";
            this.clmnToken_no.Name = "clmnToken_no";
            // 
            // clmnEPF_No
            // 
            this.clmnEPF_No.HeaderText = "E.P.F No.";
            this.clmnEPF_No.Name = "clmnEPF_No";
            // 
            // clmnEmployee_Name
            // 
            this.clmnEmployee_Name.HeaderText = "Employee Name";
            this.clmnEmployee_Name.Name = "clmnEmployee_Name";
            // 
            // clmnNo_Of_Employee
            // 
            this.clmnNo_Of_Employee.HeaderText = "No Of Employee";
            this.clmnNo_Of_Employee.Name = "clmnNo_Of_Employee";
            // 
            // frmOver_Time_Approve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 461);
            this.Controls.Add(this.gdvOver_Time_Request);
            this.Controls.Add(this.gbxOver_Time_Details);
            this.Controls.Add(this.gbxEmployeeDetails);
            this.Controls.Add(this.gbxDepartmentDetails);
            this.Controls.Add(this.lblFormTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOver_Time_Approve";
            this.Text = "Over Time Approve";
            this.gbxEmployeeDetails.ResumeLayout(false);
            this.gbxEmployeeDetails.PerformLayout();
            this.gbxDepartmentDetails.ResumeLayout(false);
            this.gbxDepartmentDetails.PerformLayout();
            this.gbxOver_Time_Details.ResumeLayout(false);
            this.gbxOver_Time_Details.PerformLayout();
            this.gbxOver_Time_Type.ResumeLayout(false);
            this.gbxOver_Time_Type.PerformLayout();
            this.gbxTime.ResumeLayout(false);
            this.gbxTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvOver_Time_Request)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTopic;
        private System.Windows.Forms.GroupBox gbxEmployeeDetails;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.TextBox txtSub_Department;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtToken_No;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEPF_No;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNIC_No;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxDepartmentDetails;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSubDepartment;
        private System.Windows.Forms.ComboBox cmbSubDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbWorkingBranch;
        private System.Windows.Forms.Label lblWorkingBranch;
        private System.Windows.Forms.GroupBox gbxOver_Time_Details;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtOver_Time_Hours;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.DateTimePicker dtpOver_Time_Date;
        private System.Windows.Forms.GroupBox gbxOver_Time_Type;
        private System.Windows.Forms.RadioButton rdbTreble;
        private System.Windows.Forms.RadioButton rdbDouble;
        private System.Windows.Forms.RadioButton rdbSingle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbxTime;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gdvOver_Time_Request;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnApprove;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnToken_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEPF_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployee_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNo_Of_Employee;
    }
}