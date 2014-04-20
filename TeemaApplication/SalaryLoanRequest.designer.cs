namespace TeemaApplication
{
    partial class frmSalary_Loan_Request
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSubDepartment = new System.Windows.Forms.Label();
            this.cmbSubDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbWorkingBranch = new System.Windows.Forms.ComboBox();
            this.lblWorkingBranch = new System.Windows.Forms.Label();
            this.gbxSalary_Loan = new System.Windows.Forms.GroupBox();
            this.dtpStarting_Date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDeduction_Salary_Period = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumber_of_Month = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDeductionAmountinMonth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gdvDeductionFrom = new System.Windows.Forms.GroupBox();
            this.txtFixedIncentiveAllowance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDayWages = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalFromEPFSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRequested_Amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpsate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clm_Token_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEPF_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnRequestedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDeduction_Amount_in_Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNumber_of_Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDeduction_Salary_Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTotal_From_EPF_Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDay_Wages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFixed_Incentive_Allowance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNIC_No = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEPF_No = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtToken_No = new System.Windows.Forms.TextBox();
            this.gbxEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.gbxDepartmentDetails.SuspendLayout();
            this.gbxSalary_Loan.SuspendLayout();
            this.gdvDeductionFrom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxEmployeeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTopic
            // 
            this.lblFormTopic.AutoSize = true;
            this.lblFormTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTopic.Location = new System.Drawing.Point(12, 9);
            this.lblFormTopic.Name = "lblFormTopic";
            this.lblFormTopic.Size = new System.Drawing.Size(267, 31);
            this.lblFormTopic.TabIndex = 2;
            this.lblFormTopic.Text = "Salary Loan Request";
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
            this.gbxDepartmentDetails.Location = new System.Drawing.Point(12, 43);
            this.gbxDepartmentDetails.Name = "gbxDepartmentDetails";
            this.gbxDepartmentDetails.Size = new System.Drawing.Size(287, 154);
            this.gbxDepartmentDetails.TabIndex = 3;
            this.gbxDepartmentDetails.TabStop = false;
            this.gbxDepartmentDetails.Text = "Department Details";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(206, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
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
            this.cmbSubDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubDepartment.FormattingEnabled = true;
            this.cmbSubDepartment.Location = new System.Drawing.Point(105, 73);
            this.cmbSubDepartment.Name = "cmbSubDepartment";
            this.cmbSubDepartment.Size = new System.Drawing.Size(176, 21);
            this.cmbSubDepartment.TabIndex = 4;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(6, 49);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "Department";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(105, 46);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(176, 21);
            this.cmbDepartment.TabIndex = 2;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // cmbWorkingBranch
            // 
            this.cmbWorkingBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkingBranch.FormattingEnabled = true;
            this.cmbWorkingBranch.Location = new System.Drawing.Point(105, 19);
            this.cmbWorkingBranch.Name = "cmbWorkingBranch";
            this.cmbWorkingBranch.Size = new System.Drawing.Size(176, 21);
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
            // gbxSalary_Loan
            // 
            this.gbxSalary_Loan.Controls.Add(this.dtpStarting_Date);
            this.gbxSalary_Loan.Controls.Add(this.label9);
            this.gbxSalary_Loan.Controls.Add(this.txtDeduction_Salary_Period);
            this.gbxSalary_Loan.Controls.Add(this.label11);
            this.gbxSalary_Loan.Controls.Add(this.txtNumber_of_Month);
            this.gbxSalary_Loan.Controls.Add(this.label10);
            this.gbxSalary_Loan.Controls.Add(this.txtDeductionAmountinMonth);
            this.gbxSalary_Loan.Controls.Add(this.label2);
            this.gbxSalary_Loan.Controls.Add(this.gdvDeductionFrom);
            this.gbxSalary_Loan.Controls.Add(this.txtRequested_Amount);
            this.gbxSalary_Loan.Controls.Add(this.label1);
            this.gbxSalary_Loan.Location = new System.Drawing.Point(305, 43);
            this.gbxSalary_Loan.Name = "gbxSalary_Loan";
            this.gbxSalary_Loan.Size = new System.Drawing.Size(679, 154);
            this.gbxSalary_Loan.TabIndex = 7;
            this.gbxSalary_Loan.TabStop = false;
            this.gbxSalary_Loan.Text = "Salary Loan";
            // 
            // dtpStarting_Date
            // 
            this.dtpStarting_Date.Location = new System.Drawing.Point(158, 45);
            this.dtpStarting_Date.Name = "dtpStarting_Date";
            this.dtpStarting_Date.Size = new System.Drawing.Size(176, 20);
            this.dtpStarting_Date.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Starting Date";
            // 
            // txtDeduction_Salary_Period
            // 
            this.txtDeduction_Salary_Period.Location = new System.Drawing.Point(158, 123);
            this.txtDeduction_Salary_Period.Name = "txtDeduction_Salary_Period";
            this.txtDeduction_Salary_Period.Size = new System.Drawing.Size(176, 20);
            this.txtDeduction_Salary_Period.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Deduction Salary Period";
            // 
            // txtNumber_of_Month
            // 
            this.txtNumber_of_Month.Location = new System.Drawing.Point(158, 97);
            this.txtNumber_of_Month.Name = "txtNumber_of_Month";
            this.txtNumber_of_Month.Size = new System.Drawing.Size(176, 20);
            this.txtNumber_of_Month.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Number of Month";
            // 
            // txtDeductionAmountinMonth
            // 
            this.txtDeductionAmountinMonth.Location = new System.Drawing.Point(158, 71);
            this.txtDeductionAmountinMonth.Name = "txtDeductionAmountinMonth";
            this.txtDeductionAmountinMonth.Size = new System.Drawing.Size(176, 20);
            this.txtDeductionAmountinMonth.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Deduction Amount in Month";
            // 
            // gdvDeductionFrom
            // 
            this.gdvDeductionFrom.Controls.Add(this.txtFixedIncentiveAllowance);
            this.gdvDeductionFrom.Controls.Add(this.label8);
            this.gdvDeductionFrom.Controls.Add(this.txtDayWages);
            this.gdvDeductionFrom.Controls.Add(this.label5);
            this.gdvDeductionFrom.Controls.Add(this.txtTotalFromEPFSalary);
            this.gdvDeductionFrom.Controls.Add(this.label4);
            this.gdvDeductionFrom.Location = new System.Drawing.Point(340, 19);
            this.gdvDeductionFrom.Name = "gdvDeductionFrom";
            this.gdvDeductionFrom.Size = new System.Drawing.Size(333, 126);
            this.gdvDeductionFrom.TabIndex = 19;
            this.gdvDeductionFrom.TabStop = false;
            this.gdvDeductionFrom.Text = "Deduction From";
            // 
            // txtFixedIncentiveAllowance
            // 
            this.txtFixedIncentiveAllowance.Location = new System.Drawing.Point(152, 71);
            this.txtFixedIncentiveAllowance.Name = "txtFixedIncentiveAllowance";
            this.txtFixedIncentiveAllowance.Size = new System.Drawing.Size(176, 20);
            this.txtFixedIncentiveAllowance.TabIndex = 17;
            this.txtFixedIncentiveAllowance.Text = "0";
            this.txtFixedIncentiveAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.txtDayWages.Location = new System.Drawing.Point(152, 45);
            this.txtDayWages.Name = "txtDayWages";
            this.txtDayWages.Size = new System.Drawing.Size(176, 20);
            this.txtDayWages.TabIndex = 15;
            this.txtDayWages.Text = "0";
            this.txtDayWages.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.txtTotalFromEPFSalary.Location = new System.Drawing.Point(152, 19);
            this.txtTotalFromEPFSalary.Name = "txtTotalFromEPFSalary";
            this.txtTotalFromEPFSalary.Size = new System.Drawing.Size(176, 20);
            this.txtTotalFromEPFSalary.TabIndex = 13;
            this.txtTotalFromEPFSalary.Text = "0";
            this.txtTotalFromEPFSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.txtRequested_Amount.Location = new System.Drawing.Point(158, 19);
            this.txtRequested_Amount.Name = "txtRequested_Amount";
            this.txtRequested_Amount.Size = new System.Drawing.Size(176, 20);
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
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(909, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(828, 203);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnUpsate
            // 
            this.btnUpsate.Location = new System.Drawing.Point(747, 203);
            this.btnUpsate.Name = "btnUpsate";
            this.btnUpsate.Size = new System.Drawing.Size(75, 23);
            this.btnUpsate.TabIndex = 15;
            this.btnUpsate.Text = "Update";
            this.btnUpsate.UseVisualStyleBackColor = true;
            this.btnUpsate.Click += new System.EventHandler(this.btnUpsate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Token_No,
            this.clmnEPF_No,
            this.clmnEmployeeName,
            this.clmnRequestedAmount,
            this.clmnDeduction_Amount_in_Month,
            this.clmnNumber_of_Month,
            this.clmnDeduction_Salary_Period,
            this.clmnTotal_From_EPF_Salary,
            this.clmnDay_Wages,
            this.clmnFixed_Incentive_Allowance});
            this.dataGridView1.Location = new System.Drawing.Point(305, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(679, 247);
            this.dataGridView1.TabIndex = 18;
            // 
            // clm_Token_No
            // 
            this.clm_Token_No.HeaderText = "Token No.";
            this.clm_Token_No.Name = "clm_Token_No";
            // 
            // clmnEPF_No
            // 
            this.clmnEPF_No.HeaderText = "E.P.F No";
            this.clmnEPF_No.Name = "clmnEPF_No";
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
            // clmnDeduction_Amount_in_Month
            // 
            this.clmnDeduction_Amount_in_Month.HeaderText = "Deduction Amount in Month";
            this.clmnDeduction_Amount_in_Month.Name = "clmnDeduction_Amount_in_Month";
            // 
            // clmnNumber_of_Month
            // 
            this.clmnNumber_of_Month.HeaderText = "Number of Month";
            this.clmnNumber_of_Month.Name = "clmnNumber_of_Month";
            // 
            // clmnDeduction_Salary_Period
            // 
            this.clmnDeduction_Salary_Period.HeaderText = "Deduction Salary Period";
            this.clmnDeduction_Salary_Period.Name = "clmnDeduction_Salary_Period";
            // 
            // clmnTotal_From_EPF_Salary
            // 
            this.clmnTotal_From_EPF_Salary.HeaderText = "Total From EPF Salary";
            this.clmnTotal_From_EPF_Salary.Name = "clmnTotal_From_EPF_Salary";
            // 
            // clmnDay_Wages
            // 
            this.clmnDay_Wages.HeaderText = "Day Wages";
            this.clmnDay_Wages.Name = "clmnDay_Wages";
            // 
            // clmnFixed_Incentive_Allowance
            // 
            this.clmnFixed_Incentive_Allowance.HeaderText = "Fixed Incentive Allowance";
            this.clmnFixed_Incentive_Allowance.Name = "clmnFixed_Incentive_Allowance";
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
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(97, 19);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(176, 20);
            this.txtEmployeeName.TabIndex = 9;
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
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(97, 45);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(176, 20);
            this.txtDesignation.TabIndex = 14;
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
            // txtNIC_No
            // 
            this.txtNIC_No.Location = new System.Drawing.Point(97, 71);
            this.txtNIC_No.Name = "txtNIC_No";
            this.txtNIC_No.Size = new System.Drawing.Size(176, 20);
            this.txtNIC_No.TabIndex = 16;
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
            // txtEPF_No
            // 
            this.txtEPF_No.Location = new System.Drawing.Point(97, 98);
            this.txtEPF_No.Name = "txtEPF_No";
            this.txtEPF_No.Size = new System.Drawing.Size(176, 20);
            this.txtEPF_No.TabIndex = 18;
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
            // txtToken_No
            // 
            this.txtToken_No.Location = new System.Drawing.Point(97, 124);
            this.txtToken_No.Name = "txtToken_No";
            this.txtToken_No.Size = new System.Drawing.Size(176, 20);
            this.txtToken_No.TabIndex = 23;
            // 
            // gbxEmployeeDetails
            // 
            this.gbxEmployeeDetails.Controls.Add(this.txtToken_No);
            this.gbxEmployeeDetails.Controls.Add(this.label13);
            this.gbxEmployeeDetails.Controls.Add(this.txtEPF_No);
            this.gbxEmployeeDetails.Controls.Add(this.label12);
            this.gbxEmployeeDetails.Controls.Add(this.txtNIC_No);
            this.gbxEmployeeDetails.Controls.Add(this.label7);
            this.gbxEmployeeDetails.Controls.Add(this.txtDesignation);
            this.gbxEmployeeDetails.Controls.Add(this.label6);
            this.gbxEmployeeDetails.Controls.Add(this.txtEmployeeName);
            this.gbxEmployeeDetails.Controls.Add(this.label3);
            this.gbxEmployeeDetails.Location = new System.Drawing.Point(12, 203);
            this.gbxEmployeeDetails.Name = "gbxEmployeeDetails";
            this.gbxEmployeeDetails.Size = new System.Drawing.Size(287, 167);
            this.gbxEmployeeDetails.TabIndex = 4;
            this.gbxEmployeeDetails.TabStop = false;
            this.gbxEmployeeDetails.Text = "Employee Details";
            // 
            // frmSalary_Loan_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 491);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpsate);
            this.Controls.Add(this.gbxSalary_Loan);
            this.Controls.Add(this.gbxEmployeeDetails);
            this.Controls.Add(this.gbxDepartmentDetails);
            this.Controls.Add(this.lblFormTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSalary_Loan_Request";
            this.Text = "Salary Loan Request";
            this.Load += new System.EventHandler(this.frmSalary_Loan_Request_Load);
            this.gbxDepartmentDetails.ResumeLayout(false);
            this.gbxDepartmentDetails.PerformLayout();
            this.gbxSalary_Loan.ResumeLayout(false);
            this.gbxSalary_Loan.PerformLayout();
            this.gdvDeductionFrom.ResumeLayout(false);
            this.gdvDeductionFrom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxEmployeeDetails.ResumeLayout(false);
            this.gbxEmployeeDetails.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbxSalary_Loan;
        private System.Windows.Forms.TextBox txtDeduction_Salary_Period;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumber_of_Month;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDeductionAmountinMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gdvDeductionFrom;
        private System.Windows.Forms.TextBox txtFixedIncentiveAllowance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDayWages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalFromEPFSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRequested_Amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpsate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Token_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEPF_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnRequestedAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDeduction_Amount_in_Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNumber_of_Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDeduction_Salary_Period;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTotal_From_EPF_Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDay_Wages;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFixed_Incentive_Allowance;
        private System.Windows.Forms.DateTimePicker dtpStarting_Date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNIC_No;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEPF_No;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtToken_No;
        private System.Windows.Forms.GroupBox gbxEmployeeDetails;
    }
}