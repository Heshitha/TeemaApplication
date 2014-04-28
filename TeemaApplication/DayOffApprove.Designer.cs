namespace TeemaApplication
{
    partial class frmDayOffApprove
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
            this.chbUnApprovedOnly = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbxSalaryMonth = new System.Windows.Forms.GroupBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvLeavesapplied = new System.Windows.Forms.DataGridView();
            this.grpEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.txtNICNo = new System.Windows.Forms.TextBox();
            this.txtTokenNo = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtEPFNO = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.cmbSubDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTokenNumber = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNumberofdays = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLeaveto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtLeavefrom = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.clmnTokenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLeaveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnApprove = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbxSalaryMonth.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeavesapplied)).BeginInit();
            this.grpEmployeeDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbUnApprovedOnly
            // 
            this.chbUnApprovedOnly.AutoSize = true;
            this.chbUnApprovedOnly.Checked = true;
            this.chbUnApprovedOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbUnApprovedOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbUnApprovedOnly.Location = new System.Drawing.Point(103, 235);
            this.chbUnApprovedOnly.Name = "chbUnApprovedOnly";
            this.chbUnApprovedOnly.Size = new System.Drawing.Size(110, 17);
            this.chbUnApprovedOnly.TabIndex = 44;
            this.chbUnApprovedOnly.Text = "UnApproved Only";
            this.chbUnApprovedOnly.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(222, 231);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // gbxSalaryMonth
            // 
            this.gbxSalaryMonth.Controls.Add(this.cmbMonth);
            this.gbxSalaryMonth.Controls.Add(this.cmbYear);
            this.gbxSalaryMonth.Controls.Add(this.label10);
            this.gbxSalaryMonth.Controls.Add(this.label3);
            this.gbxSalaryMonth.Location = new System.Drawing.Point(12, 145);
            this.gbxSalaryMonth.Name = "gbxSalaryMonth";
            this.gbxSalaryMonth.Size = new System.Drawing.Size(287, 80);
            this.gbxSalaryMonth.TabIndex = 42;
            this.gbxSalaryMonth.TabStop = false;
            this.gbxSalaryMonth.Text = "Leave month";
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
            this.cmbMonth.Location = new System.Drawing.Point(109, 46);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(173, 21);
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
            this.cmbYear.Location = new System.Drawing.Point(109, 19);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(173, 21);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Year";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.dgvLeavesapplied);
            this.groupBox2.Location = new System.Drawing.Point(303, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 271);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Leaves";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(494, 233);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(86, 31);
            this.btnSubmit.TabIndex = 38;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // dgvLeavesapplied
            // 
            this.dgvLeavesapplied.AllowUserToAddRows = false;
            this.dgvLeavesapplied.AllowUserToDeleteRows = false;
            this.dgvLeavesapplied.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeavesapplied.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeavesapplied.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnTokenID,
            this.clmnName,
            this.clmnLeaveDate,
            this.clmnApprove});
            this.dgvLeavesapplied.Location = new System.Drawing.Point(6, 18);
            this.dgvLeavesapplied.Name = "dgvLeavesapplied";
            this.dgvLeavesapplied.RowHeadersVisible = false;
            this.dgvLeavesapplied.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeavesapplied.Size = new System.Drawing.Size(574, 208);
            this.dgvLeavesapplied.TabIndex = 3;
            // 
            // grpEmployeeDetails
            // 
            this.grpEmployeeDetails.Controls.Add(this.txtNICNo);
            this.grpEmployeeDetails.Controls.Add(this.txtTokenNo);
            this.grpEmployeeDetails.Controls.Add(this.txtDesignation);
            this.grpEmployeeDetails.Controls.Add(this.txtEPFNO);
            this.grpEmployeeDetails.Controls.Add(this.txtEmployeeName);
            this.grpEmployeeDetails.Controls.Add(this.label24);
            this.grpEmployeeDetails.Controls.Add(this.label4);
            this.grpEmployeeDetails.Controls.Add(this.label25);
            this.grpEmployeeDetails.Controls.Add(this.label28);
            this.grpEmployeeDetails.Controls.Add(this.label26);
            this.grpEmployeeDetails.Controls.Add(this.label27);
            this.grpEmployeeDetails.Location = new System.Drawing.Point(12, 260);
            this.grpEmployeeDetails.Name = "grpEmployeeDetails";
            this.grpEmployeeDetails.Size = new System.Drawing.Size(287, 157);
            this.grpEmployeeDetails.TabIndex = 39;
            this.grpEmployeeDetails.TabStop = false;
            this.grpEmployeeDetails.Text = "Employee Details";
            // 
            // txtNICNo
            // 
            this.txtNICNo.Location = new System.Drawing.Point(108, 73);
            this.txtNICNo.Name = "txtNICNo";
            this.txtNICNo.Size = new System.Drawing.Size(173, 20);
            this.txtNICNo.TabIndex = 1;
            // 
            // txtTokenNo
            // 
            this.txtTokenNo.Location = new System.Drawing.Point(108, 125);
            this.txtTokenNo.Name = "txtTokenNo";
            this.txtTokenNo.Size = new System.Drawing.Size(173, 20);
            this.txtTokenNo.TabIndex = 1;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(108, 47);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(173, 20);
            this.txtDesignation.TabIndex = 1;
            // 
            // txtEPFNO
            // 
            this.txtEPFNO.Location = new System.Drawing.Point(108, 99);
            this.txtEPFNO.Name = "txtEPFNO";
            this.txtEPFNO.Size = new System.Drawing.Size(173, 20);
            this.txtEPFNO.TabIndex = 1;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(108, 21);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(173, 20);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 27);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(0, 13);
            this.label24.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "EPF No";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(7, 50);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Designation";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 128);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(55, 13);
            this.label28.TabIndex = 0;
            this.label28.Text = "Token No";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 26);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(84, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "Employee Name";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(7, 76);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "NIC No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "Approve Day Offs";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDepartment);
            this.groupBox1.Controls.Add(this.cmbBranch);
            this.groupBox1.Controls.Add(this.cmbSubDepartment);
            this.groupBox1.Controls.Add(this.lblDepartment);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblTokenNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 96);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Department Search";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(109, 41);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(173, 21);
            this.cmbDepartment.TabIndex = 2;
            // 
            // cmbBranch
            // 
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(109, 14);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(173, 21);
            this.cmbBranch.TabIndex = 2;
            // 
            // cmbSubDepartment
            // 
            this.cmbSubDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubDepartment.FormattingEnabled = true;
            this.cmbSubDepartment.Location = new System.Drawing.Point(109, 68);
            this.cmbSubDepartment.Name = "cmbSubDepartment";
            this.cmbSubDepartment.Size = new System.Drawing.Size(173, 21);
            this.cmbSubDepartment.TabIndex = 2;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(7, 71);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(84, 13);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Sub-Department";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Department";
            // 
            // lblTokenNumber
            // 
            this.lblTokenNumber.AutoSize = true;
            this.lblTokenNumber.Location = new System.Drawing.Point(7, 19);
            this.lblTokenNumber.Name = "lblTokenNumber";
            this.lblTokenNumber.Size = new System.Drawing.Size(41, 13);
            this.lblTokenNumber.TabIndex = 0;
            this.lblTokenNumber.Text = "Branch";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNumberofdays);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtLeaveto);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtLeavefrom);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(305, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 99);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            // 
            // txtNumberofdays
            // 
            this.txtNumberofdays.Location = new System.Drawing.Point(122, 70);
            this.txtNumberofdays.Name = "txtNumberofdays";
            this.txtNumberofdays.ReadOnly = true;
            this.txtNumberofdays.Size = new System.Drawing.Size(192, 20);
            this.txtNumberofdays.TabIndex = 26;
            this.txtNumberofdays.TabStop = false;
            this.txtNumberofdays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Leave Reason";
            // 
            // txtLeaveto
            // 
            this.txtLeaveto.Location = new System.Drawing.Point(122, 44);
            this.txtLeaveto.Name = "txtLeaveto";
            this.txtLeaveto.ReadOnly = true;
            this.txtLeaveto.Size = new System.Drawing.Size(192, 20);
            this.txtLeaveto.TabIndex = 24;
            this.txtLeaveto.TabStop = false;
            this.txtLeaveto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Leave Date";
            // 
            // txtLeavefrom
            // 
            this.txtLeavefrom.Location = new System.Drawing.Point(122, 18);
            this.txtLeavefrom.Name = "txtLeavefrom";
            this.txtLeavefrom.ReadOnly = true;
            this.txtLeavefrom.Size = new System.Drawing.Size(192, 20);
            this.txtLeavefrom.TabIndex = 22;
            this.txtLeavefrom.TabStop = false;
            this.txtLeavefrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Leave Applied Date";
            // 
            // clmnTokenID
            // 
            this.clmnTokenID.HeaderText = "Token ID";
            this.clmnTokenID.Name = "clmnTokenID";
            // 
            // clmnName
            // 
            this.clmnName.HeaderText = "Name";
            this.clmnName.Name = "clmnName";
            // 
            // clmnLeaveDate
            // 
            this.clmnLeaveDate.HeaderText = "Leave Date";
            this.clmnLeaveDate.Name = "clmnLeaveDate";
            // 
            // clmnApprove
            // 
            this.clmnApprove.HeaderText = "Approve";
            this.clmnApprove.Name = "clmnApprove";
            this.clmnApprove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnApprove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmDayOffApprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 423);
            this.Controls.Add(this.chbUnApprovedOnly);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbxSalaryMonth);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpEmployeeDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDayOffApprove";
            this.Text = "DayOffApprove";
            this.Load += new System.EventHandler(this.frmDayOffApprove_Load);
            this.gbxSalaryMonth.ResumeLayout(false);
            this.gbxSalaryMonth.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeavesapplied)).EndInit();
            this.grpEmployeeDetails.ResumeLayout(false);
            this.grpEmployeeDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbUnApprovedOnly;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbxSalaryMonth;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvLeavesapplied;
        private System.Windows.Forms.GroupBox grpEmployeeDetails;
        private System.Windows.Forms.TextBox txtNICNo;
        private System.Windows.Forms.TextBox txtTokenNo;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtEPFNO;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.ComboBox cmbSubDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTokenNumber;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtNumberofdays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLeaveto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtLeavefrom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTokenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLeaveDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnApprove;
    }
}