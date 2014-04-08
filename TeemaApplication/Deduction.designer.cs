namespace TeemaApplication
{
    partial class frmDeduction
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
            this.gbxDeduction = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAddDeduction = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMisc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBankLoan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMedical_Ins = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtW_loan = new System.Windows.Forms.TextBox();
            this.txtWelfareCon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBankSaving = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWelfareShop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMeals = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStamp_Duty = new System.Windows.Forms.TextBox();
            this.txtStampDuty = new System.Windows.Forms.Label();
            this.txtPayee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gdvDeduction = new System.Windows.Forms.DataGridView();
            this.clmnTokenNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEFP_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPayee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnStampDuty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnMeals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnWelfareShop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnWelfareCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnW_loan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBankSaving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnMedical_Ins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBankLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnMisc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAddDeduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpsate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbxSalary_Month = new System.Windows.Forms.GroupBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxDepartmentDetails = new System.Windows.Forms.GroupBox();
            this.lblSubDepartment = new System.Windows.Forms.Label();
            this.cmbSubDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbWorkingBranch = new System.Windows.Forms.ComboBox();
            this.lblWorkingBranch = new System.Windows.Forms.Label();
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
            this.gbxDeduction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDeduction)).BeginInit();
            this.gbxSalary_Month.SuspendLayout();
            this.gbxDepartmentDetails.SuspendLayout();
            this.gbxEmployeeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTopic
            // 
            this.lblFormTopic.AutoSize = true;
            this.lblFormTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTopic.Location = new System.Drawing.Point(12, 9);
            this.lblFormTopic.Name = "lblFormTopic";
            this.lblFormTopic.Size = new System.Drawing.Size(137, 31);
            this.lblFormTopic.TabIndex = 1;
            this.lblFormTopic.Text = "Deduction";
            this.lblFormTopic.Click += new System.EventHandler(this.lblFormTopic_Click);
            // 
            // gbxDeduction
            // 
            this.gbxDeduction.Controls.Add(this.txtTotal);
            this.gbxDeduction.Controls.Add(this.label15);
            this.gbxDeduction.Controls.Add(this.txtAddDeduction);
            this.gbxDeduction.Controls.Add(this.label14);
            this.gbxDeduction.Controls.Add(this.txtMisc);
            this.gbxDeduction.Controls.Add(this.label13);
            this.gbxDeduction.Controls.Add(this.txtBankLoan);
            this.gbxDeduction.Controls.Add(this.label12);
            this.gbxDeduction.Controls.Add(this.txtMedical_Ins);
            this.gbxDeduction.Controls.Add(this.label11);
            this.gbxDeduction.Controls.Add(this.txtW_loan);
            this.gbxDeduction.Controls.Add(this.txtWelfareCon);
            this.gbxDeduction.Controls.Add(this.label10);
            this.gbxDeduction.Controls.Add(this.label9);
            this.gbxDeduction.Controls.Add(this.txtBankSaving);
            this.gbxDeduction.Controls.Add(this.label8);
            this.gbxDeduction.Controls.Add(this.txtWelfareShop);
            this.gbxDeduction.Controls.Add(this.label5);
            this.gbxDeduction.Controls.Add(this.txtMeals);
            this.gbxDeduction.Controls.Add(this.label4);
            this.gbxDeduction.Controls.Add(this.txtStamp_Duty);
            this.gbxDeduction.Controls.Add(this.txtStampDuty);
            this.gbxDeduction.Controls.Add(this.txtPayee);
            this.gbxDeduction.Controls.Add(this.label1);
            this.gbxDeduction.Location = new System.Drawing.Point(305, 43);
            this.gbxDeduction.Name = "gbxDeduction";
            this.gbxDeduction.Size = new System.Drawing.Size(570, 182);
            this.gbxDeduction.TabIndex = 4;
            this.gbxDeduction.TabStop = false;
            this.gbxDeduction.Text = "Deduction";
            this.gbxDeduction.Enter += new System.EventHandler(this.gbxDeduction_Enter);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(385, 149);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(176, 20);
            this.txtTotal.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(278, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Total";
            // 
            // txtAddDeduction
            // 
            this.txtAddDeduction.Location = new System.Drawing.Point(385, 123);
            this.txtAddDeduction.Name = "txtAddDeduction";
            this.txtAddDeduction.Size = new System.Drawing.Size(176, 20);
            this.txtAddDeduction.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(278, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Add Deduction";
            // 
            // txtMisc
            // 
            this.txtMisc.Location = new System.Drawing.Point(385, 97);
            this.txtMisc.Name = "txtMisc";
            this.txtMisc.Size = new System.Drawing.Size(176, 20);
            this.txtMisc.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(278, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Misc";
            // 
            // txtBankLoan
            // 
            this.txtBankLoan.Location = new System.Drawing.Point(385, 71);
            this.txtBankLoan.Name = "txtBankLoan";
            this.txtBankLoan.Size = new System.Drawing.Size(176, 20);
            this.txtBankLoan.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(278, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Bank Loan";
            // 
            // txtMedical_Ins
            // 
            this.txtMedical_Ins.Location = new System.Drawing.Point(385, 45);
            this.txtMedical_Ins.Name = "txtMedical_Ins";
            this.txtMedical_Ins.Size = new System.Drawing.Size(176, 20);
            this.txtMedical_Ins.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(278, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Medical Ins";
            // 
            // txtW_loan
            // 
            this.txtW_loan.Location = new System.Drawing.Point(96, 149);
            this.txtW_loan.Name = "txtW_loan";
            this.txtW_loan.Size = new System.Drawing.Size(176, 20);
            this.txtW_loan.TabIndex = 12;
            // 
            // txtWelfareCon
            // 
            this.txtWelfareCon.Location = new System.Drawing.Point(96, 123);
            this.txtWelfareCon.Name = "txtWelfareCon";
            this.txtWelfareCon.Size = new System.Drawing.Size(176, 20);
            this.txtWelfareCon.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "W/ loan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Welfare Con";
            // 
            // txtBankSaving
            // 
            this.txtBankSaving.Location = new System.Drawing.Point(385, 19);
            this.txtBankSaving.Name = "txtBankSaving";
            this.txtBankSaving.Size = new System.Drawing.Size(176, 20);
            this.txtBankSaving.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Bank Saving";
            // 
            // txtWelfareShop
            // 
            this.txtWelfareShop.Location = new System.Drawing.Point(96, 97);
            this.txtWelfareShop.Name = "txtWelfareShop";
            this.txtWelfareShop.Size = new System.Drawing.Size(176, 20);
            this.txtWelfareShop.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Welfare Shop";
            // 
            // txtMeals
            // 
            this.txtMeals.Location = new System.Drawing.Point(96, 71);
            this.txtMeals.Name = "txtMeals";
            this.txtMeals.Size = new System.Drawing.Size(176, 20);
            this.txtMeals.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Meals";
            // 
            // txtStamp_Duty
            // 
            this.txtStamp_Duty.Location = new System.Drawing.Point(96, 45);
            this.txtStamp_Duty.Name = "txtStamp_Duty";
            this.txtStamp_Duty.Size = new System.Drawing.Size(176, 20);
            this.txtStamp_Duty.TabIndex = 12;
            // 
            // txtStampDuty
            // 
            this.txtStampDuty.AutoSize = true;
            this.txtStampDuty.Location = new System.Drawing.Point(6, 48);
            this.txtStampDuty.Name = "txtStampDuty";
            this.txtStampDuty.Size = new System.Drawing.Size(62, 13);
            this.txtStampDuty.TabIndex = 11;
            this.txtStampDuty.Text = "Stamp Duty";
            // 
            // txtPayee
            // 
            this.txtPayee.Location = new System.Drawing.Point(96, 19);
            this.txtPayee.Name = "txtPayee";
            this.txtPayee.Size = new System.Drawing.Size(176, 20);
            this.txtPayee.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Payee";
            // 
            // gdvDeduction
            // 
            this.gdvDeduction.AllowUserToAddRows = false;
            this.gdvDeduction.AllowUserToDeleteRows = false;
            this.gdvDeduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvDeduction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnTokenNo,
            this.clmnYear,
            this.clmnMonth,
            this.clmnEFP_NO,
            this.clmnEmployeeName,
            this.clmnPayee,
            this.clmnStampDuty,
            this.clmnMeals,
            this.clmnWelfareShop,
            this.clmnWelfareCon,
            this.clmnW_loan,
            this.clmnBankSaving,
            this.clmnMedical_Ins,
            this.clmBankLoan,
            this.clmnMisc,
            this.clmnAddDeduction,
            this.clmnTotal});
            this.gdvDeduction.Location = new System.Drawing.Point(305, 260);
            this.gdvDeduction.Name = "gdvDeduction";
            this.gdvDeduction.RowHeadersVisible = false;
            this.gdvDeduction.Size = new System.Drawing.Size(570, 276);
            this.gdvDeduction.TabIndex = 5;
            // 
            // clmnTokenNo
            // 
            this.clmnTokenNo.HeaderText = "Token No";
            this.clmnTokenNo.Name = "clmnTokenNo";
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
            // clmnEFP_NO
            // 
            this.clmnEFP_NO.HeaderText = "E.P.F No";
            this.clmnEFP_NO.Name = "clmnEFP_NO";
            // 
            // clmnEmployeeName
            // 
            this.clmnEmployeeName.HeaderText = "Employee Name";
            this.clmnEmployeeName.Name = "clmnEmployeeName";
            // 
            // clmnPayee
            // 
            this.clmnPayee.HeaderText = "Payee";
            this.clmnPayee.Name = "clmnPayee";
            // 
            // clmnStampDuty
            // 
            this.clmnStampDuty.HeaderText = "Stamp Duty";
            this.clmnStampDuty.Name = "clmnStampDuty";
            // 
            // clmnMeals
            // 
            this.clmnMeals.HeaderText = "Meals";
            this.clmnMeals.Name = "clmnMeals";
            // 
            // clmnWelfareShop
            // 
            this.clmnWelfareShop.HeaderText = "Welfare Shop";
            this.clmnWelfareShop.Name = "clmnWelfareShop";
            // 
            // clmnWelfareCon
            // 
            this.clmnWelfareCon.HeaderText = "Welfare Con.";
            this.clmnWelfareCon.Name = "clmnWelfareCon";
            // 
            // clmnW_loan
            // 
            this.clmnW_loan.HeaderText = "W/ loan";
            this.clmnW_loan.Name = "clmnW_loan";
            // 
            // clmnBankSaving
            // 
            this.clmnBankSaving.HeaderText = "Bank Saving";
            this.clmnBankSaving.Name = "clmnBankSaving";
            // 
            // clmnMedical_Ins
            // 
            this.clmnMedical_Ins.HeaderText = "Medical Ins";
            this.clmnMedical_Ins.Name = "clmnMedical_Ins";
            // 
            // clmBankLoan
            // 
            this.clmBankLoan.HeaderText = "Bank Loan";
            this.clmBankLoan.Name = "clmBankLoan";
            // 
            // clmnMisc
            // 
            this.clmnMisc.HeaderText = "Misc";
            this.clmnMisc.Name = "clmnMisc";
            // 
            // clmnAddDeduction
            // 
            this.clmnAddDeduction.HeaderText = "Add Deduction";
            this.clmnAddDeduction.Name = "clmnAddDeduction";
            // 
            // clmnTotal
            // 
            this.clmnTotal.HeaderText = "Total";
            this.clmnTotal.Name = "clmnTotal";
            // 
            // btnUpsate
            // 
            this.btnUpsate.Location = new System.Drawing.Point(638, 231);
            this.btnUpsate.Name = "btnUpsate";
            this.btnUpsate.Size = new System.Drawing.Size(75, 23);
            this.btnUpsate.TabIndex = 6;
            this.btnUpsate.Text = "Update";
            this.btnUpsate.UseVisualStyleBackColor = true;
            this.btnUpsate.Click += new System.EventHandler(this.btnUpsate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(800, 231);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(719, 231);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // gbxSalary_Month
            // 
            this.gbxSalary_Month.Controls.Add(this.txtMonth);
            this.gbxSalary_Month.Controls.Add(this.label16);
            this.gbxSalary_Month.Controls.Add(this.txtYear);
            this.gbxSalary_Month.Controls.Add(this.label2);
            this.gbxSalary_Month.Location = new System.Drawing.Point(12, 162);
            this.gbxSalary_Month.Name = "gbxSalary_Month";
            this.gbxSalary_Month.Size = new System.Drawing.Size(287, 73);
            this.gbxSalary_Month.TabIndex = 31;
            this.gbxSalary_Month.TabStop = false;
            this.gbxSalary_Month.Text = "Salary Month";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(96, 40);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(177, 20);
            this.txtMonth.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Month";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(96, 14);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(177, 20);
            this.txtYear.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Year";
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
            this.gbxDepartmentDetails.Size = new System.Drawing.Size(287, 113);
            this.gbxDepartmentDetails.TabIndex = 35;
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
            this.cmbSubDepartment.FormattingEnabled = true;
            this.cmbSubDepartment.Location = new System.Drawing.Point(97, 76);
            this.cmbSubDepartment.Name = "cmbSubDepartment";
            this.cmbSubDepartment.Size = new System.Drawing.Size(176, 21);
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
            this.cmbDepartment.Location = new System.Drawing.Point(97, 46);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(176, 21);
            this.cmbDepartment.TabIndex = 2;
            // 
            // cmbWorkingBranch
            // 
            this.cmbWorkingBranch.FormattingEnabled = true;
            this.cmbWorkingBranch.Location = new System.Drawing.Point(97, 19);
            this.cmbWorkingBranch.Name = "cmbWorkingBranch";
            this.cmbWorkingBranch.Size = new System.Drawing.Size(176, 21);
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
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(224, 241);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
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
            this.gbxEmployeeDetails.Location = new System.Drawing.Point(12, 273);
            this.gbxEmployeeDetails.Name = "gbxEmployeeDetails";
            this.gbxEmployeeDetails.Size = new System.Drawing.Size(287, 265);
            this.gbxEmployeeDetails.TabIndex = 36;
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
            // frmDeduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 548);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbxEmployeeDetails);
            this.Controls.Add(this.gbxDepartmentDetails);
            this.Controls.Add(this.gbxSalary_Month);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpsate);
            this.Controls.Add(this.gdvDeduction);
            this.Controls.Add(this.gbxDeduction);
            this.Controls.Add(this.lblFormTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(13, 13);
            this.Name = "frmDeduction";
            this.Text = " ";
            this.gbxDeduction.ResumeLayout(false);
            this.gbxDeduction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDeduction)).EndInit();
            this.gbxSalary_Month.ResumeLayout(false);
            this.gbxSalary_Month.PerformLayout();
            this.gbxDepartmentDetails.ResumeLayout(false);
            this.gbxDepartmentDetails.PerformLayout();
            this.gbxEmployeeDetails.ResumeLayout(false);
            this.gbxEmployeeDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTopic;
        private System.Windows.Forms.GroupBox gbxDeduction;
        private System.Windows.Forms.TextBox txtMedical_Ins;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtW_loan;
        private System.Windows.Forms.TextBox txtWelfareCon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBankSaving;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtWelfareShop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMeals;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStamp_Duty;
        private System.Windows.Forms.Label txtStampDuty;
        private System.Windows.Forms.TextBox txtPayee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAddDeduction;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMisc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBankLoan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView gdvDeduction;
        private System.Windows.Forms.Button btnUpsate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbxSalary_Month;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTokenNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEFP_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPayee;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnStampDuty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnMeals;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnWelfareShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnWelfareCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnW_loan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBankSaving;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnMedical_Ins;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBankLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnMisc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAddDeduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTotal;
        private System.Windows.Forms.GroupBox gbxDepartmentDetails;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSubDepartment;
        private System.Windows.Forms.ComboBox cmbSubDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbWorkingBranch;
        private System.Windows.Forms.Label lblWorkingBranch;
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
    }
}