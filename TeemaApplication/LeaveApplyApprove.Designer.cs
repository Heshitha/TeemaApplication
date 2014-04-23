namespace TeemaApplication
{
    partial class frmLeaveApplyApprove
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbLeaveYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.cmbSubDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTokenNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.txtSubDepartment = new System.Windows.Forms.TextBox();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNICNo = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.txtTokenNo = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtEPFNO = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLeaves = new System.Windows.Forms.DataGridView();
            this.clmnTokenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEPFNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLeaveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNumberOfDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnhalfday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnReasonForAbsence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnOtherLeaveDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSubTokenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnApprove = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.grpEmployeeDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaves)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbLeaveYear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbDepartment);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cmbBranch);
            this.groupBox1.Controls.Add(this.cmbSubDepartment);
            this.groupBox1.Controls.Add(this.lblDepartment);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblTokenNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Department Search";
            // 
            // cmbLeaveYear
            // 
            this.cmbLeaveYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLeaveYear.FormattingEnabled = true;
            this.cmbLeaveYear.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cmbLeaveYear.Location = new System.Drawing.Point(108, 19);
            this.cmbLeaveYear.Name = "cmbLeaveYear";
            this.cmbLeaveYear.Size = new System.Drawing.Size(173, 21);
            this.cmbLeaveYear.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "For the year";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(108, 73);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(173, 21);
            this.cmbDepartment.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(206, 127);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cmbBranch
            // 
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(108, 46);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(173, 21);
            this.cmbBranch.TabIndex = 2;
            // 
            // cmbSubDepartment
            // 
            this.cmbSubDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubDepartment.FormattingEnabled = true;
            this.cmbSubDepartment.Location = new System.Drawing.Point(108, 100);
            this.cmbSubDepartment.Name = "cmbSubDepartment";
            this.cmbSubDepartment.Size = new System.Drawing.Size(173, 21);
            this.cmbSubDepartment.TabIndex = 2;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(6, 103);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(84, 13);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Sub-Department";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Department";
            // 
            // lblTokenNumber
            // 
            this.lblTokenNumber.AutoSize = true;
            this.lblTokenNumber.Location = new System.Drawing.Point(6, 51);
            this.lblTokenNumber.Name = "lblTokenNumber";
            this.lblTokenNumber.Size = new System.Drawing.Size(41, 13);
            this.lblTokenNumber.TabIndex = 0;
            this.lblTokenNumber.Text = "Branch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Approve Leaves";
            // 
            // grpEmployeeDetails
            // 
            this.grpEmployeeDetails.Controls.Add(this.txtSubDepartment);
            this.grpEmployeeDetails.Controls.Add(this.txtBranch);
            this.grpEmployeeDetails.Controls.Add(this.txtDepartment);
            this.grpEmployeeDetails.Controls.Add(this.button2);
            this.grpEmployeeDetails.Controls.Add(this.txtNICNo);
            this.grpEmployeeDetails.Controls.Add(this.textBox20);
            this.grpEmployeeDetails.Controls.Add(this.txtTokenNo);
            this.grpEmployeeDetails.Controls.Add(this.txtDesignation);
            this.grpEmployeeDetails.Controls.Add(this.txtEPFNO);
            this.grpEmployeeDetails.Controls.Add(this.txtEmployeeName);
            this.grpEmployeeDetails.Controls.Add(this.label24);
            this.grpEmployeeDetails.Controls.Add(this.label30);
            this.grpEmployeeDetails.Controls.Add(this.label29);
            this.grpEmployeeDetails.Controls.Add(this.label4);
            this.grpEmployeeDetails.Controls.Add(this.label25);
            this.grpEmployeeDetails.Controls.Add(this.label28);
            this.grpEmployeeDetails.Controls.Add(this.label5);
            this.grpEmployeeDetails.Controls.Add(this.label26);
            this.grpEmployeeDetails.Controls.Add(this.label27);
            this.grpEmployeeDetails.Location = new System.Drawing.Point(12, 209);
            this.grpEmployeeDetails.Name = "grpEmployeeDetails";
            this.grpEmployeeDetails.Size = new System.Drawing.Size(287, 265);
            this.grpEmployeeDetails.TabIndex = 4;
            this.grpEmployeeDetails.TabStop = false;
            this.grpEmployeeDetails.Text = "Employee Details";
            // 
            // txtSubDepartment
            // 
            this.txtSubDepartment.Location = new System.Drawing.Point(108, 177);
            this.txtSubDepartment.Name = "txtSubDepartment";
            this.txtSubDepartment.Size = new System.Drawing.Size(173, 20);
            this.txtSubDepartment.TabIndex = 1;
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(108, 203);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(173, 20);
            this.txtBranch.TabIndex = 1;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(108, 151);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(173, 20);
            this.txtDepartment.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtNICNo
            // 
            this.txtNICNo.Location = new System.Drawing.Point(108, 73);
            this.txtNICNo.Name = "txtNICNo";
            this.txtNICNo.Size = new System.Drawing.Size(173, 20);
            this.txtNICNo.TabIndex = 1;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(108, 151);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(173, 20);
            this.textBox20.TabIndex = 1;
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
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 158);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(62, 13);
            this.label30.TabIndex = 0;
            this.label30.Text = "Department";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 184);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(84, 13);
            this.label29.TabIndex = 0;
            this.label29.Text = "Sub-Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "EPF No";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 53);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Designation";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(5, 131);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(55, 13);
            this.label28.TabIndex = 0;
            this.label28.Text = "Token No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Branch";
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
            this.label27.Location = new System.Drawing.Point(6, 79);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "NIC No";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLeaves);
            this.groupBox2.Location = new System.Drawing.Point(305, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(928, 428);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To be Approved";
            // 
            // dgvLeaves
            // 
            this.dgvLeaves.AllowUserToAddRows = false;
            this.dgvLeaves.AllowUserToDeleteRows = false;
            this.dgvLeaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnTokenID,
            this.clmnEmpName,
            this.clmnEPFNO,
            this.clmnLeaveType,
            this.clmnPay,
            this.clmnNumberOfDays,
            this.clmnhalfday,
            this.clmnReasonForAbsence,
            this.clmnOtherLeaveDescription,
            this.clmnSubTokenID,
            this.clmnSubName,
            this.btnApprove});
            this.dgvLeaves.Location = new System.Drawing.Point(6, 15);
            this.dgvLeaves.Name = "dgvLeaves";
            this.dgvLeaves.ReadOnly = true;
            this.dgvLeaves.RowHeadersVisible = false;
            this.dgvLeaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaves.Size = new System.Drawing.Size(916, 399);
            this.dgvLeaves.TabIndex = 3;
            // 
            // clmnTokenID
            // 
            this.clmnTokenID.DataPropertyName = "TokenID";
            this.clmnTokenID.HeaderText = "TokenID";
            this.clmnTokenID.Name = "clmnTokenID";
            this.clmnTokenID.ReadOnly = true;
            // 
            // clmnEmpName
            // 
            this.clmnEmpName.DataPropertyName = "Name";
            this.clmnEmpName.HeaderText = "Name";
            this.clmnEmpName.Name = "clmnEmpName";
            this.clmnEmpName.ReadOnly = true;
            // 
            // clmnEPFNO
            // 
            this.clmnEPFNO.DataPropertyName = "EPFNo";
            this.clmnEPFNO.HeaderText = "EPF No";
            this.clmnEPFNO.Name = "clmnEPFNO";
            this.clmnEPFNO.ReadOnly = true;
            // 
            // clmnLeaveType
            // 
            this.clmnLeaveType.HeaderText = "Leave Type";
            this.clmnLeaveType.Name = "clmnLeaveType";
            this.clmnLeaveType.ReadOnly = true;
            // 
            // clmnPay
            // 
            this.clmnPay.HeaderText = "Pay";
            this.clmnPay.Name = "clmnPay";
            this.clmnPay.ReadOnly = true;
            // 
            // clmnNumberOfDays
            // 
            this.clmnNumberOfDays.HeaderText = "Number of days";
            this.clmnNumberOfDays.Name = "clmnNumberOfDays";
            this.clmnNumberOfDays.ReadOnly = true;
            // 
            // clmnhalfday
            // 
            this.clmnhalfday.HeaderText = "Half Day";
            this.clmnhalfday.Name = "clmnhalfday";
            this.clmnhalfday.ReadOnly = true;
            // 
            // clmnReasonForAbsence
            // 
            this.clmnReasonForAbsence.HeaderText = "Reason for absence";
            this.clmnReasonForAbsence.Name = "clmnReasonForAbsence";
            this.clmnReasonForAbsence.ReadOnly = true;
            // 
            // clmnOtherLeaveDescription
            // 
            this.clmnOtherLeaveDescription.HeaderText = "Other leave description";
            this.clmnOtherLeaveDescription.Name = "clmnOtherLeaveDescription";
            this.clmnOtherLeaveDescription.ReadOnly = true;
            // 
            // clmnSubTokenID
            // 
            this.clmnSubTokenID.HeaderText = "Substitute token ID";
            this.clmnSubTokenID.Name = "clmnSubTokenID";
            this.clmnSubTokenID.ReadOnly = true;
            // 
            // clmnSubName
            // 
            this.clmnSubName.HeaderText = "Substitue Name";
            this.clmnSubName.Name = "clmnSubName";
            this.clmnSubName.ReadOnly = true;
            // 
            // btnApprove
            // 
            this.btnApprove.HeaderText = "Approve";
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.ReadOnly = true;
            // 
            // frmLeaveApplyApprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpEmployeeDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLeaveApplyApprove";
            this.Text = "Approve Applied Leaves";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpEmployeeDetails.ResumeLayout(false);
            this.grpEmployeeDetails.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbLeaveYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.ComboBox cmbSubDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTokenNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpEmployeeDetails;
        private System.Windows.Forms.TextBox txtSubDepartment;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNICNo;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox txtTokenNo;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtEPFNO;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvLeaves;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTokenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEPFNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLeaveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNumberOfDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnhalfday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnReasonForAbsence;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnOtherLeaveDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSubTokenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSubName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn btnApprove;
    }
}