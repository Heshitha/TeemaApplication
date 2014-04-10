namespace TeemaApplication
{
    partial class frmSalaryAdvanceRequest
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
            this.gbxDepartmentDetails = new System.Windows.Forms.GroupBox();
            this.lblSubDepartment = new System.Windows.Forms.Label();
            this.cmbSubDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbWorkingBranch = new System.Windows.Forms.ComboBox();
            this.lblWorkingBranch = new System.Windows.Forms.Label();
            this.gbxSalaryMonth = new System.Windows.Forms.GroupBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbxEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.txtSub_Department = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtToken_No = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.txtEPF_No = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.txtNIC_No = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.gbxSalaryAdvance = new System.Windows.Forms.GroupBox();
            this.gdvDeductionFrom = new System.Windows.Forms.GroupBox();
            this.txtVariableIncentiveAllowance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFixedIncentiveAllowance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDayWages = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalFromEPFSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRequested_Amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gdvSalaryAdvance = new System.Windows.Forms.DataGridView();
            this.clmnToken_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEPFNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnRequestedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTotalFromEPFSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDayWages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFixedIncentiveAllowance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnVariableIncentiveAllowance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpsate = new System.Windows.Forms.Button();
            this.gbxDepartmentDetails.SuspendLayout();
            this.gbxSalaryMonth.SuspendLayout();
            this.gbxEmployeeDetails.SuspendLayout();
            this.gbxSalaryAdvance.SuspendLayout();
            this.gdvDeductionFrom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSalaryAdvance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTopic
            // 
            this.lblFormTopic.AutoSize = true;
            this.lblFormTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTopic.Location = new System.Drawing.Point(12, 9);
            this.lblFormTopic.Name = "lblFormTopic";
            this.lblFormTopic.Size = new System.Drawing.Size(313, 31);
            this.lblFormTopic.TabIndex = 2;
            this.lblFormTopic.Text = "Salary Advance Request";
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
            this.gbxDepartmentDetails.Size = new System.Drawing.Size(285, 103);
            this.gbxDepartmentDetails.TabIndex = 5;
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
            // gbxSalaryMonth
            // 
            this.gbxSalaryMonth.Controls.Add(this.cmbMonth);
            this.gbxSalaryMonth.Controls.Add(this.cmbYear);
            this.gbxSalaryMonth.Controls.Add(this.label10);
            this.gbxSalaryMonth.Controls.Add(this.label2);
            this.gbxSalaryMonth.Location = new System.Drawing.Point(12, 152);
            this.gbxSalaryMonth.Name = "gbxSalaryMonth";
            this.gbxSalaryMonth.Size = new System.Drawing.Size(285, 80);
            this.gbxSalaryMonth.TabIndex = 21;
            this.gbxSalaryMonth.TabStop = false;
            this.gbxSalaryMonth.Text = "Salary Month";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(96, 46);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(183, 21);
            this.cmbMonth.TabIndex = 24;
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.cmbYear.Location = new System.Drawing.Point(96, 19);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(183, 21);
            this.cmbYear.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Year";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(222, 238);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbxEmployeeDetails
            // 
            this.gbxEmployeeDetails.Controls.Add(this.btnClear);
            this.gbxEmployeeDetails.Controls.Add(this.txtBranch);
            this.gbxEmployeeDetails.Controls.Add(this.txtSub_Department);
            this.gbxEmployeeDetails.Controls.Add(this.txtDepartment);
            this.gbxEmployeeDetails.Controls.Add(this.txtToken_No);
            this.gbxEmployeeDetails.Controls.Add(this.label3);
            this.gbxEmployeeDetails.Controls.Add(this.label6);
            this.gbxEmployeeDetails.Controls.Add(this.label7);
            this.gbxEmployeeDetails.Controls.Add(this.label44);
            this.gbxEmployeeDetails.Controls.Add(this.txtEPF_No);
            this.gbxEmployeeDetails.Controls.Add(this.label45);
            this.gbxEmployeeDetails.Controls.Add(this.txtNIC_No);
            this.gbxEmployeeDetails.Controls.Add(this.label46);
            this.gbxEmployeeDetails.Controls.Add(this.txtDesignation);
            this.gbxEmployeeDetails.Controls.Add(this.label47);
            this.gbxEmployeeDetails.Controls.Add(this.txtEmployeeName);
            this.gbxEmployeeDetails.Controls.Add(this.label48);
            this.gbxEmployeeDetails.Location = new System.Drawing.Point(12, 267);
            this.gbxEmployeeDetails.Name = "gbxEmployeeDetails";
            this.gbxEmployeeDetails.Size = new System.Drawing.Size(285, 266);
            this.gbxEmployeeDetails.TabIndex = 25;
            this.gbxEmployeeDetails.TabStop = false;
            this.gbxEmployeeDetails.Text = "Employee Details";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(198, 228);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Branch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Sub Department";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Department";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 127);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(55, 13);
            this.label44.TabIndex = 19;
            this.label44.Text = "Token No";
            // 
            // txtEPF_No
            // 
            this.txtEPF_No.Location = new System.Drawing.Point(97, 98);
            this.txtEPF_No.Name = "txtEPF_No";
            this.txtEPF_No.Size = new System.Drawing.Size(176, 20);
            this.txtEPF_No.TabIndex = 18;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(6, 101);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(47, 13);
            this.label45.TabIndex = 17;
            this.label45.Text = "EPF No.";
            // 
            // txtNIC_No
            // 
            this.txtNIC_No.Location = new System.Drawing.Point(97, 71);
            this.txtNIC_No.Name = "txtNIC_No";
            this.txtNIC_No.Size = new System.Drawing.Size(176, 20);
            this.txtNIC_No.TabIndex = 16;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(6, 74);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(42, 13);
            this.label46.TabIndex = 15;
            this.label46.Text = "NIC No";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(97, 45);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(176, 20);
            this.txtDesignation.TabIndex = 14;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(6, 48);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(63, 13);
            this.label47.TabIndex = 13;
            this.label47.Text = "Designation";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(97, 19);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(176, 20);
            this.txtEmployeeName.TabIndex = 9;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(6, 22);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(84, 13);
            this.label48.TabIndex = 8;
            this.label48.Text = "Employee Name";
            // 
            // gbxSalaryAdvance
            // 
            this.gbxSalaryAdvance.Controls.Add(this.gdvDeductionFrom);
            this.gbxSalaryAdvance.Controls.Add(this.txtRequested_Amount);
            this.gbxSalaryAdvance.Controls.Add(this.label1);
            this.gbxSalaryAdvance.Location = new System.Drawing.Point(303, 43);
            this.gbxSalaryAdvance.Name = "gbxSalaryAdvance";
            this.gbxSalaryAdvance.Size = new System.Drawing.Size(364, 184);
            this.gbxSalaryAdvance.TabIndex = 26;
            this.gbxSalaryAdvance.TabStop = false;
            this.gbxSalaryAdvance.Text = "Salary Advance";
            // 
            // gdvDeductionFrom
            // 
            this.gdvDeductionFrom.Controls.Add(this.txtVariableIncentiveAllowance);
            this.gdvDeductionFrom.Controls.Add(this.label9);
            this.gdvDeductionFrom.Controls.Add(this.txtFixedIncentiveAllowance);
            this.gdvDeductionFrom.Controls.Add(this.label8);
            this.gdvDeductionFrom.Controls.Add(this.txtDayWages);
            this.gdvDeductionFrom.Controls.Add(this.label5);
            this.gdvDeductionFrom.Controls.Add(this.txtTotalFromEPFSalary);
            this.gdvDeductionFrom.Controls.Add(this.label4);
            this.gdvDeductionFrom.Location = new System.Drawing.Point(6, 45);
            this.gdvDeductionFrom.Name = "gdvDeductionFrom";
            this.gdvDeductionFrom.Size = new System.Drawing.Size(352, 133);
            this.gdvDeductionFrom.TabIndex = 19;
            this.gdvDeductionFrom.TabStop = false;
            this.gdvDeductionFrom.Text = "Deduction From";
            // 
            // txtVariableIncentiveAllowance
            // 
            this.txtVariableIncentiveAllowance.Location = new System.Drawing.Point(161, 97);
            this.txtVariableIncentiveAllowance.Name = "txtVariableIncentiveAllowance";
            this.txtVariableIncentiveAllowance.Size = new System.Drawing.Size(177, 20);
            this.txtVariableIncentiveAllowance.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Variable Incentive Allowance";
            // 
            // txtFixedIncentiveAllowance
            // 
            this.txtFixedIncentiveAllowance.Location = new System.Drawing.Point(161, 71);
            this.txtFixedIncentiveAllowance.Name = "txtFixedIncentiveAllowance";
            this.txtFixedIncentiveAllowance.Size = new System.Drawing.Size(177, 20);
            this.txtFixedIncentiveAllowance.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Fixed Incentive Allowance";
            // 
            // txtDayWages
            // 
            this.txtDayWages.Location = new System.Drawing.Point(161, 45);
            this.txtDayWages.Name = "txtDayWages";
            this.txtDayWages.Size = new System.Drawing.Size(177, 20);
            this.txtDayWages.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Day Wages";
            // 
            // txtTotalFromEPFSalary
            // 
            this.txtTotalFromEPFSalary.Location = new System.Drawing.Point(161, 19);
            this.txtTotalFromEPFSalary.Name = "txtTotalFromEPFSalary";
            this.txtTotalFromEPFSalary.Size = new System.Drawing.Size(177, 20);
            this.txtTotalFromEPFSalary.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total From EPF Salary";
            // 
            // txtRequested_Amount
            // 
            this.txtRequested_Amount.Location = new System.Drawing.Point(167, 19);
            this.txtRequested_Amount.Name = "txtRequested_Amount";
            this.txtRequested_Amount.Size = new System.Drawing.Size(177, 20);
            this.txtRequested_Amount.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Requested Amount";
            // 
            // gdvSalaryAdvance
            // 
            this.gdvSalaryAdvance.AllowUserToAddRows = false;
            this.gdvSalaryAdvance.AllowUserToDeleteRows = false;
            this.gdvSalaryAdvance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvSalaryAdvance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnToken_No,
            this.clmnEPFNo,
            this.clmnEmployeeName,
            this.clmnRequestedAmount,
            this.clmnTotalFromEPFSalary,
            this.clmnDayWages,
            this.clmnFixedIncentiveAllowance,
            this.clmnVariableIncentiveAllowance,
            this.clmnYear,
            this.clmnMonth});
            this.gdvSalaryAdvance.Location = new System.Drawing.Point(303, 233);
            this.gdvSalaryAdvance.Name = "gdvSalaryAdvance";
            this.gdvSalaryAdvance.RowHeadersVisible = false;
            this.gdvSalaryAdvance.Size = new System.Drawing.Size(488, 300);
            this.gdvSalaryAdvance.TabIndex = 27;
            // 
            // clmnToken_No
            // 
            this.clmnToken_No.HeaderText = "Token No";
            this.clmnToken_No.Name = "clmnToken_No";
            // 
            // clmnEPFNo
            // 
            this.clmnEPFNo.HeaderText = "E.P.F No,";
            this.clmnEPFNo.Name = "clmnEPFNo";
            // 
            // clmnEmployeeName
            // 
            this.clmnEmployeeName.HeaderText = "Employee Name";
            this.clmnEmployeeName.Name = "clmnEmployeeName";
            // 
            // clmnRequestedAmount
            // 
            this.clmnRequestedAmount.HeaderText = "Requested Amount";
            this.clmnRequestedAmount.Name = "clmnRequestedAmount";
            // 
            // clmnTotalFromEPFSalary
            // 
            this.clmnTotalFromEPFSalary.HeaderText = "Total From EPF Salary";
            this.clmnTotalFromEPFSalary.Name = "clmnTotalFromEPFSalary";
            // 
            // clmnDayWages
            // 
            this.clmnDayWages.HeaderText = "Day Wages";
            this.clmnDayWages.Name = "clmnDayWages";
            // 
            // clmnFixedIncentiveAllowance
            // 
            this.clmnFixedIncentiveAllowance.HeaderText = "Fixed Incentive Allowance";
            this.clmnFixedIncentiveAllowance.Name = "clmnFixedIncentiveAllowance";
            // 
            // clmnVariableIncentiveAllowance
            // 
            this.clmnVariableIncentiveAllowance.HeaderText = "Variable Incentive Allowance";
            this.clmnVariableIncentiveAllowance.Name = "clmnVariableIncentiveAllowance";
            // 
            // clmnYear
            // 
            this.clmnYear.HeaderText = "Year";
            this.clmnYear.Name = "clmnYear";
            // 
            // clmnMonth
            // 
            this.clmnMonth.HeaderText = "Month";
            this.clmnMonth.Name = "clmnMonth";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(677, 101);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 23);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(677, 72);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 23);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnUpsate
            // 
            this.btnUpsate.Location = new System.Drawing.Point(677, 43);
            this.btnUpsate.Name = "btnUpsate";
            this.btnUpsate.Size = new System.Drawing.Size(114, 23);
            this.btnUpsate.TabIndex = 28;
            this.btnUpsate.Text = "Update";
            this.btnUpsate.UseVisualStyleBackColor = true;
            this.btnUpsate.Click += new System.EventHandler(this.btnUpsate_Click);
            // 
            // frmSalaryAdvanceRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 550);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpsate);
            this.Controls.Add(this.gdvSalaryAdvance);
            this.Controls.Add(this.gbxSalaryAdvance);
            this.Controls.Add(this.gbxEmployeeDetails);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbxSalaryMonth);
            this.Controls.Add(this.gbxDepartmentDetails);
            this.Controls.Add(this.lblFormTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSalaryAdvanceRequest";
            this.Text = "Salary Advance Request";
            this.Load += new System.EventHandler(this.frmSalaryAdvanceRequest_Load);
            this.gbxDepartmentDetails.ResumeLayout(false);
            this.gbxDepartmentDetails.PerformLayout();
            this.gbxSalaryMonth.ResumeLayout(false);
            this.gbxSalaryMonth.PerformLayout();
            this.gbxEmployeeDetails.ResumeLayout(false);
            this.gbxEmployeeDetails.PerformLayout();
            this.gbxSalaryAdvance.ResumeLayout(false);
            this.gbxSalaryAdvance.PerformLayout();
            this.gdvDeductionFrom.ResumeLayout(false);
            this.gdvDeductionFrom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSalaryAdvance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTopic;
        private System.Windows.Forms.GroupBox gbxDepartmentDetails;
        private System.Windows.Forms.Label lblSubDepartment;
        private System.Windows.Forms.ComboBox cmbSubDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbWorkingBranch;
        private System.Windows.Forms.Label lblWorkingBranch;
        private System.Windows.Forms.GroupBox gbxSalaryMonth;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbxEmployeeDetails;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.TextBox txtSub_Department;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtToken_No;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtEPF_No;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txtNIC_No;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.GroupBox gbxSalaryAdvance;
        private System.Windows.Forms.GroupBox gdvDeductionFrom;
        private System.Windows.Forms.TextBox txtVariableIncentiveAllowance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFixedIncentiveAllowance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDayWages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalFromEPFSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRequested_Amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gdvSalaryAdvance;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnToken_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEPFNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnRequestedAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTotalFromEPFSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDayWages;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFixedIncentiveAllowance;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnVariableIncentiveAllowance;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnMonth;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpsate;
    }
}