namespace TeemaApplication
{
    partial class frmSalary_Advance_Approve
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
            this.btnApprove = new System.Windows.Forms.Button();
            this.gbxSalaryMonth = new System.Windows.Forms.GroupBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chbUnApprovedOnly = new System.Windows.Forms.CheckBox();
            this.gbxEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.txtToken_No = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txtEPF_No = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.txtNIC_No = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.gbxCreatedAdvance = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCADAdvanceID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCADRequestedDate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCADTotalRequestAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCADVariableIncentiveAllowance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCADFixedInceniveAllowance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCADDayWages = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCADTotalFrom = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gdvSalaryAdvance = new System.Windows.Forms.DataGridView();
            this.clmnToken_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAdvanceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnRequestedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnApproved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gbxDepartmentDetails.SuspendLayout();
            this.gbxSalaryMonth.SuspendLayout();
            this.gbxEmployeeDetails.SuspendLayout();
            this.gbxCreatedAdvance.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSalaryAdvance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTopic
            // 
            this.lblFormTopic.AutoSize = true;
            this.lblFormTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTopic.Location = new System.Drawing.Point(12, 9);
            this.lblFormTopic.Name = "lblFormTopic";
            this.lblFormTopic.Size = new System.Drawing.Size(312, 31);
            this.lblFormTopic.TabIndex = 1;
            this.lblFormTopic.Text = "Salary Advance Approve";
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
            this.gbxDepartmentDetails.Location = new System.Drawing.Point(12, 48);
            this.gbxDepartmentDetails.Name = "gbxDepartmentDetails";
            this.gbxDepartmentDetails.Size = new System.Drawing.Size(285, 103);
            this.gbxDepartmentDetails.TabIndex = 4;
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
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(810, 506);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(73, 23);
            this.btnApprove.TabIndex = 12;
            this.btnApprove.Text = "Submit";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // gbxSalaryMonth
            // 
            this.gbxSalaryMonth.Controls.Add(this.cmbMonth);
            this.gbxSalaryMonth.Controls.Add(this.cmbYear);
            this.gbxSalaryMonth.Controls.Add(this.label10);
            this.gbxSalaryMonth.Controls.Add(this.label2);
            this.gbxSalaryMonth.Location = new System.Drawing.Point(12, 157);
            this.gbxSalaryMonth.Name = "gbxSalaryMonth";
            this.gbxSalaryMonth.Size = new System.Drawing.Size(285, 80);
            this.gbxSalaryMonth.TabIndex = 20;
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
            this.btnSearch.Location = new System.Drawing.Point(222, 243);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // chbUnApprovedOnly
            // 
            this.chbUnApprovedOnly.AutoSize = true;
            this.chbUnApprovedOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbUnApprovedOnly.Location = new System.Drawing.Point(103, 247);
            this.chbUnApprovedOnly.Name = "chbUnApprovedOnly";
            this.chbUnApprovedOnly.Size = new System.Drawing.Size(113, 17);
            this.chbUnApprovedOnly.TabIndex = 33;
            this.chbUnApprovedOnly.Text = "Un Approved Only";
            this.chbUnApprovedOnly.UseVisualStyleBackColor = true;
            // 
            // gbxEmployeeDetails
            // 
            this.gbxEmployeeDetails.Controls.Add(this.txtToken_No);
            this.gbxEmployeeDetails.Controls.Add(this.label44);
            this.gbxEmployeeDetails.Controls.Add(this.txtEPF_No);
            this.gbxEmployeeDetails.Controls.Add(this.label45);
            this.gbxEmployeeDetails.Controls.Add(this.txtNIC_No);
            this.gbxEmployeeDetails.Controls.Add(this.label46);
            this.gbxEmployeeDetails.Controls.Add(this.txtDesignation);
            this.gbxEmployeeDetails.Controls.Add(this.label47);
            this.gbxEmployeeDetails.Controls.Add(this.txtEmployeeName);
            this.gbxEmployeeDetails.Controls.Add(this.label48);
            this.gbxEmployeeDetails.Location = new System.Drawing.Point(12, 272);
            this.gbxEmployeeDetails.Name = "gbxEmployeeDetails";
            this.gbxEmployeeDetails.Size = new System.Drawing.Size(285, 160);
            this.gbxEmployeeDetails.TabIndex = 34;
            this.gbxEmployeeDetails.TabStop = false;
            this.gbxEmployeeDetails.Text = "Employee Details";
            // 
            // txtToken_No
            // 
            this.txtToken_No.Location = new System.Drawing.Point(97, 124);
            this.txtToken_No.Name = "txtToken_No";
            this.txtToken_No.ReadOnly = true;
            this.txtToken_No.Size = new System.Drawing.Size(176, 20);
            this.txtToken_No.TabIndex = 23;
            this.txtToken_No.TabStop = false;
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
            this.txtEPF_No.ReadOnly = true;
            this.txtEPF_No.Size = new System.Drawing.Size(176, 20);
            this.txtEPF_No.TabIndex = 18;
            this.txtEPF_No.TabStop = false;
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
            this.txtNIC_No.ReadOnly = true;
            this.txtNIC_No.Size = new System.Drawing.Size(176, 20);
            this.txtNIC_No.TabIndex = 16;
            this.txtNIC_No.TabStop = false;
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
            this.txtDesignation.ReadOnly = true;
            this.txtDesignation.Size = new System.Drawing.Size(176, 20);
            this.txtDesignation.TabIndex = 14;
            this.txtDesignation.TabStop = false;
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
            this.txtEmployeeName.ReadOnly = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(176, 20);
            this.txtEmployeeName.TabIndex = 9;
            this.txtEmployeeName.TabStop = false;
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
            // gbxCreatedAdvance
            // 
            this.gbxCreatedAdvance.Controls.Add(this.groupBox4);
            this.gbxCreatedAdvance.Controls.Add(this.groupBox2);
            this.gbxCreatedAdvance.Controls.Add(this.groupBox3);
            this.gbxCreatedAdvance.Location = new System.Drawing.Point(303, 48);
            this.gbxCreatedAdvance.Name = "gbxCreatedAdvance";
            this.gbxCreatedAdvance.Size = new System.Drawing.Size(580, 149);
            this.gbxCreatedAdvance.TabIndex = 35;
            this.gbxCreatedAdvance.TabStop = false;
            this.gbxCreatedAdvance.Text = "Created Advance Details";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCADAdvanceID);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtCADRequestedDate);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(294, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(281, 70);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            // 
            // txtCADAdvanceID
            // 
            this.txtCADAdvanceID.Location = new System.Drawing.Point(172, 44);
            this.txtCADAdvanceID.Name = "txtCADAdvanceID";
            this.txtCADAdvanceID.ReadOnly = true;
            this.txtCADAdvanceID.Size = new System.Drawing.Size(103, 20);
            this.txtCADAdvanceID.TabIndex = 24;
            this.txtCADAdvanceID.TabStop = false;
            this.txtCADAdvanceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Advance ID";
            // 
            // txtCADRequestedDate
            // 
            this.txtCADRequestedDate.Location = new System.Drawing.Point(122, 18);
            this.txtCADRequestedDate.Name = "txtCADRequestedDate";
            this.txtCADRequestedDate.ReadOnly = true;
            this.txtCADRequestedDate.Size = new System.Drawing.Size(153, 20);
            this.txtCADRequestedDate.TabIndex = 22;
            this.txtCADRequestedDate.TabStop = false;
            this.txtCADRequestedDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Requested Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCADTotalRequestAmount);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(294, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 50);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // txtCADTotalRequestAmount
            // 
            this.txtCADTotalRequestAmount.Location = new System.Drawing.Point(172, 19);
            this.txtCADTotalRequestAmount.Name = "txtCADTotalRequestAmount";
            this.txtCADTotalRequestAmount.ReadOnly = true;
            this.txtCADTotalRequestAmount.Size = new System.Drawing.Size(103, 20);
            this.txtCADTotalRequestAmount.TabIndex = 20;
            this.txtCADTotalRequestAmount.TabStop = false;
            this.txtCADTotalRequestAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Total Requested Amount";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCADVariableIncentiveAllowance);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtCADFixedInceniveAllowance);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtCADDayWages);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtCADTotalFrom);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 125);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Deduction From";
            // 
            // txtCADVariableIncentiveAllowance
            // 
            this.txtCADVariableIncentiveAllowance.Location = new System.Drawing.Point(173, 99);
            this.txtCADVariableIncentiveAllowance.Name = "txtCADVariableIncentiveAllowance";
            this.txtCADVariableIncentiveAllowance.ReadOnly = true;
            this.txtCADVariableIncentiveAllowance.Size = new System.Drawing.Size(103, 20);
            this.txtCADVariableIncentiveAllowance.TabIndex = 19;
            this.txtCADVariableIncentiveAllowance.TabStop = false;
            this.txtCADVariableIncentiveAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Variable Incentive Allowance";
            // 
            // txtCADFixedInceniveAllowance
            // 
            this.txtCADFixedInceniveAllowance.Location = new System.Drawing.Point(173, 73);
            this.txtCADFixedInceniveAllowance.Name = "txtCADFixedInceniveAllowance";
            this.txtCADFixedInceniveAllowance.ReadOnly = true;
            this.txtCADFixedInceniveAllowance.Size = new System.Drawing.Size(103, 20);
            this.txtCADFixedInceniveAllowance.TabIndex = 17;
            this.txtCADFixedInceniveAllowance.TabStop = false;
            this.txtCADFixedInceniveAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fixed Incentive Allowance";
            // 
            // txtCADDayWages
            // 
            this.txtCADDayWages.Location = new System.Drawing.Point(173, 47);
            this.txtCADDayWages.Name = "txtCADDayWages";
            this.txtCADDayWages.ReadOnly = true;
            this.txtCADDayWages.Size = new System.Drawing.Size(103, 20);
            this.txtCADDayWages.TabIndex = 15;
            this.txtCADDayWages.TabStop = false;
            this.txtCADDayWages.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Day Wages";
            // 
            // txtCADTotalFrom
            // 
            this.txtCADTotalFrom.Location = new System.Drawing.Point(173, 21);
            this.txtCADTotalFrom.Name = "txtCADTotalFrom";
            this.txtCADTotalFrom.ReadOnly = true;
            this.txtCADTotalFrom.Size = new System.Drawing.Size(103, 20);
            this.txtCADTotalFrom.TabIndex = 13;
            this.txtCADTotalFrom.TabStop = false;
            this.txtCADTotalFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Total From EPF Salary";
            // 
            // gdvSalaryAdvance
            // 
            this.gdvSalaryAdvance.AllowUserToAddRows = false;
            this.gdvSalaryAdvance.AllowUserToDeleteRows = false;
            this.gdvSalaryAdvance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvSalaryAdvance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvSalaryAdvance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnToken_No,
            this.clmnEmployeeName,
            this.clmnAdvanceId,
            this.clmnRequestedAmount,
            this.clmnApproved});
            this.gdvSalaryAdvance.Location = new System.Drawing.Point(303, 203);
            this.gdvSalaryAdvance.Name = "gdvSalaryAdvance";
            this.gdvSalaryAdvance.RowHeadersVisible = false;
            this.gdvSalaryAdvance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvSalaryAdvance.Size = new System.Drawing.Size(580, 297);
            this.gdvSalaryAdvance.TabIndex = 36;
            this.gdvSalaryAdvance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvSalaryAdvance_CellClick);
            // 
            // clmnToken_No
            // 
            this.clmnToken_No.DataPropertyName = "TokenNo";
            this.clmnToken_No.HeaderText = "Token No";
            this.clmnToken_No.Name = "clmnToken_No";
            // 
            // clmnEmployeeName
            // 
            this.clmnEmployeeName.DataPropertyName = "EmployeeName";
            this.clmnEmployeeName.HeaderText = "Employee Name";
            this.clmnEmployeeName.Name = "clmnEmployeeName";
            // 
            // clmnAdvanceId
            // 
            this.clmnAdvanceId.DataPropertyName = "advanceId";
            this.clmnAdvanceId.HeaderText = "Advance ID";
            this.clmnAdvanceId.Name = "clmnAdvanceId";
            // 
            // clmnRequestedAmount
            // 
            this.clmnRequestedAmount.DataPropertyName = "RequestedAmount";
            this.clmnRequestedAmount.HeaderText = "Requested Amount";
            this.clmnRequestedAmount.Name = "clmnRequestedAmount";
            // 
            // clmnApproved
            // 
            this.clmnApproved.DataPropertyName = "isApproved";
            this.clmnApproved.FalseValue = "False";
            this.clmnApproved.HeaderText = "Is Approved";
            this.clmnApproved.Name = "clmnApproved";
            this.clmnApproved.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnApproved.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmnApproved.TrueValue = "True";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(731, 506);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(73, 23);
            this.btnPrint.TabIndex = 37;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmSalary_Advance_Approve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 540);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gdvSalaryAdvance);
            this.Controls.Add(this.gbxCreatedAdvance);
            this.Controls.Add(this.gbxEmployeeDetails);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.chbUnApprovedOnly);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbxSalaryMonth);
            this.Controls.Add(this.gbxDepartmentDetails);
            this.Controls.Add(this.lblFormTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSalary_Advance_Approve";
            this.Text = "Salary Advance Approve";
            this.Load += new System.EventHandler(this.frmSalary_Advance_Load);
            this.gbxDepartmentDetails.ResumeLayout(false);
            this.gbxDepartmentDetails.PerformLayout();
            this.gbxSalaryMonth.ResumeLayout(false);
            this.gbxSalaryMonth.PerformLayout();
            this.gbxEmployeeDetails.ResumeLayout(false);
            this.gbxEmployeeDetails.PerformLayout();
            this.gbxCreatedAdvance.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.GroupBox gbxSalaryMonth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chbUnApprovedOnly;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.GroupBox gbxEmployeeDetails;
        private System.Windows.Forms.TextBox txtToken_No;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtEPF_No;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txtNIC_No;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.GroupBox gbxCreatedAdvance;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCADAdvanceID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCADRequestedDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCADTotalRequestAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCADVariableIncentiveAllowance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCADFixedInceniveAllowance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCADDayWages;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCADTotalFrom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView gdvSalaryAdvance;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnToken_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAdvanceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnRequestedAmount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnApproved;
        private System.Windows.Forms.Button btnPrint;
    }
}