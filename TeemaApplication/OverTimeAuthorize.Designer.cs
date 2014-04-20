namespace TeemaApplication
{
    partial class frmOverTimeAuthorize
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gdvOver_Time_Request = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbxOver_Time_Details = new System.Windows.Forms.GroupBox();
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndAt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartAt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxDepartmentDetails = new System.Windows.Forms.GroupBox();
            this.chbUnAuthorizedOnly = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSubDepartment = new System.Windows.Forms.Label();
            this.cmbSubDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbWorkingBranch = new System.Windows.Forms.ComboBox();
            this.lblWorkingBranch = new System.Windows.Forms.Label();
            this.lblFormTopic = new System.Windows.Forms.Label();
            this.clmnAuthorize = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnApprove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnToken_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEPF_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmployee_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnOTHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvOver_Time_Request)).BeginInit();
            this.gbxOver_Time_Details.SuspendLayout();
            this.gbxOver_Time_Type.SuspendLayout();
            this.gbxTime.SuspendLayout();
            this.gbxDepartmentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gdvOver_Time_Request);
            this.groupBox2.Location = new System.Drawing.Point(12, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(848, 261);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employees Who Requested For Overtime";
            // 
            // gdvOver_Time_Request
            // 
            this.gdvOver_Time_Request.AllowUserToAddRows = false;
            this.gdvOver_Time_Request.AllowUserToDeleteRows = false;
            this.gdvOver_Time_Request.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvOver_Time_Request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvOver_Time_Request.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnAuthorize,
            this.clmnApprove,
            this.clmnToken_no,
            this.clmnEPF_No,
            this.clmnEmployee_Name,
            this.clmnDate,
            this.clmnType,
            this.clmnOTHours});
            this.gdvOver_Time_Request.Location = new System.Drawing.Point(6, 19);
            this.gdvOver_Time_Request.Name = "gdvOver_Time_Request";
            this.gdvOver_Time_Request.RowHeadersVisible = false;
            this.gdvOver_Time_Request.Size = new System.Drawing.Size(836, 235);
            this.gdvOver_Time_Request.TabIndex = 9;
            this.gdvOver_Time_Request.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvOver_Time_Request_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(789, 473);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbxOver_Time_Details
            // 
            this.gbxOver_Time_Details.Controls.Add(this.txtOver_Time_Hours);
            this.gbxOver_Time_Details.Controls.Add(this.label8);
            this.gbxOver_Time_Details.Controls.Add(this.txtReason);
            this.gbxOver_Time_Details.Controls.Add(this.dtpOver_Time_Date);
            this.gbxOver_Time_Details.Controls.Add(this.gbxOver_Time_Type);
            this.gbxOver_Time_Details.Controls.Add(this.label5);
            this.gbxOver_Time_Details.Controls.Add(this.gbxTime);
            this.gbxOver_Time_Details.Controls.Add(this.label1);
            this.gbxOver_Time_Details.Location = new System.Drawing.Point(377, 48);
            this.gbxOver_Time_Details.Name = "gbxOver_Time_Details";
            this.gbxOver_Time_Details.Size = new System.Drawing.Size(483, 152);
            this.gbxOver_Time_Details.TabIndex = 33;
            this.gbxOver_Time_Details.TabStop = false;
            this.gbxOver_Time_Details.Text = "Over Time Details";
            // 
            // txtOver_Time_Hours
            // 
            this.txtOver_Time_Hours.Location = new System.Drawing.Point(297, 19);
            this.txtOver_Time_Hours.Name = "txtOver_Time_Hours";
            this.txtOver_Time_Hours.ReadOnly = true;
            this.txtOver_Time_Hours.Size = new System.Drawing.Size(178, 20);
            this.txtOver_Time_Hours.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Over Time Hours";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(297, 45);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.ReadOnly = true;
            this.txtReason.Size = new System.Drawing.Size(178, 101);
            this.txtReason.TabIndex = 10;
            // 
            // dtpOver_Time_Date
            // 
            this.dtpOver_Time_Date.Enabled = false;
            this.dtpOver_Time_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOver_Time_Date.Location = new System.Drawing.Point(42, 19);
            this.dtpOver_Time_Date.Name = "dtpOver_Time_Date";
            this.dtpOver_Time_Date.Size = new System.Drawing.Size(155, 20);
            this.dtpOver_Time_Date.TabIndex = 5;
            // 
            // gbxOver_Time_Type
            // 
            this.gbxOver_Time_Type.Controls.Add(this.rdbTreble);
            this.gbxOver_Time_Type.Controls.Add(this.rdbDouble);
            this.gbxOver_Time_Type.Controls.Add(this.rdbSingle);
            this.gbxOver_Time_Type.Location = new System.Drawing.Point(6, 100);
            this.gbxOver_Time_Type.Name = "gbxOver_Time_Type";
            this.gbxOver_Time_Type.Size = new System.Drawing.Size(191, 45);
            this.gbxOver_Time_Type.TabIndex = 4;
            this.gbxOver_Time_Type.TabStop = false;
            this.gbxOver_Time_Type.Text = "Over Time Type";
            // 
            // rdbTreble
            // 
            this.rdbTreble.AutoSize = true;
            this.rdbTreble.Enabled = false;
            this.rdbTreble.Location = new System.Drawing.Point(131, 19);
            this.rdbTreble.Name = "rdbTreble";
            this.rdbTreble.Size = new System.Drawing.Size(55, 17);
            this.rdbTreble.TabIndex = 2;
            this.rdbTreble.Text = "Treble";
            this.rdbTreble.UseVisualStyleBackColor = true;
            // 
            // rdbDouble
            // 
            this.rdbDouble.AutoSize = true;
            this.rdbDouble.Enabled = false;
            this.rdbDouble.Location = new System.Drawing.Point(66, 19);
            this.rdbDouble.Name = "rdbDouble";
            this.rdbDouble.Size = new System.Drawing.Size(59, 17);
            this.rdbDouble.TabIndex = 1;
            this.rdbDouble.Text = "Double";
            this.rdbDouble.UseVisualStyleBackColor = true;
            // 
            // rdbSingle
            // 
            this.rdbSingle.AutoSize = true;
            this.rdbSingle.Checked = true;
            this.rdbSingle.Enabled = false;
            this.rdbSingle.Location = new System.Drawing.Point(6, 19);
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
            this.label5.Location = new System.Drawing.Point(203, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Reason";
            // 
            // gbxTime
            // 
            this.gbxTime.Controls.Add(this.label4);
            this.gbxTime.Controls.Add(this.txtEndAt);
            this.gbxTime.Controls.Add(this.label2);
            this.gbxTime.Controls.Add(this.txtStartAt);
            this.gbxTime.Location = new System.Drawing.Point(6, 45);
            this.gbxTime.Name = "gbxTime";
            this.gbxTime.Size = new System.Drawing.Size(191, 49);
            this.gbxTime.TabIndex = 2;
            this.gbxTime.TabStop = false;
            this.gbxTime.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "To";
            // 
            // txtEndAt
            // 
            this.txtEndAt.Location = new System.Drawing.Point(131, 19);
            this.txtEndAt.Name = "txtEndAt";
            this.txtEndAt.ReadOnly = true;
            this.txtEndAt.Size = new System.Drawing.Size(55, 20);
            this.txtEndAt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "From";
            // 
            // txtStartAt
            // 
            this.txtStartAt.Location = new System.Drawing.Point(44, 19);
            this.txtStartAt.Name = "txtStartAt";
            this.txtStartAt.ReadOnly = true;
            this.txtStartAt.Size = new System.Drawing.Size(55, 20);
            this.txtStartAt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // gbxDepartmentDetails
            // 
            this.gbxDepartmentDetails.BackColor = System.Drawing.SystemColors.Control;
            this.gbxDepartmentDetails.Controls.Add(this.chbUnAuthorizedOnly);
            this.gbxDepartmentDetails.Controls.Add(this.btnSearch);
            this.gbxDepartmentDetails.Controls.Add(this.lblSubDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbSubDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.lblDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbWorkingBranch);
            this.gbxDepartmentDetails.Controls.Add(this.lblWorkingBranch);
            this.gbxDepartmentDetails.Location = new System.Drawing.Point(12, 48);
            this.gbxDepartmentDetails.Name = "gbxDepartmentDetails";
            this.gbxDepartmentDetails.Size = new System.Drawing.Size(359, 136);
            this.gbxDepartmentDetails.TabIndex = 32;
            this.gbxDepartmentDetails.TabStop = false;
            this.gbxDepartmentDetails.Text = "Department Details";
            // 
            // chbUnAuthorizedOnly
            // 
            this.chbUnAuthorizedOnly.AutoSize = true;
            this.chbUnAuthorizedOnly.Location = new System.Drawing.Point(159, 104);
            this.chbUnAuthorizedOnly.Name = "chbUnAuthorizedOnly";
            this.chbUnAuthorizedOnly.Size = new System.Drawing.Size(117, 17);
            this.chbUnAuthorizedOnly.TabIndex = 7;
            this.chbUnAuthorizedOnly.Text = "Un Authorized Only";
            this.chbUnAuthorizedOnly.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(278, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.cmbSubDepartment.Size = new System.Drawing.Size(257, 21);
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
            this.cmbDepartment.Size = new System.Drawing.Size(257, 21);
            this.cmbDepartment.TabIndex = 2;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // cmbWorkingBranch
            // 
            this.cmbWorkingBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkingBranch.FormattingEnabled = true;
            this.cmbWorkingBranch.Location = new System.Drawing.Point(96, 19);
            this.cmbWorkingBranch.Name = "cmbWorkingBranch";
            this.cmbWorkingBranch.Size = new System.Drawing.Size(257, 21);
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
            this.lblFormTopic.Size = new System.Drawing.Size(262, 31);
            this.lblFormTopic.TabIndex = 31;
            this.lblFormTopic.Text = "Over Time Authorize";
            // 
            // clmnAuthorize
            // 
            this.clmnAuthorize.DataPropertyName = "Authorize";
            this.clmnAuthorize.FalseValue = "False";
            this.clmnAuthorize.HeaderText = "Authorize";
            this.clmnAuthorize.Name = "clmnAuthorize";
            this.clmnAuthorize.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnAuthorize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmnAuthorize.TrueValue = "True";
            // 
            // clmnApprove
            // 
            this.clmnApprove.DataPropertyName = "Approve";
            this.clmnApprove.HeaderText = "Approve By";
            this.clmnApprove.Name = "clmnApprove";
            this.clmnApprove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnApprove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmnToken_no
            // 
            this.clmnToken_no.DataPropertyName = "TokenNo";
            this.clmnToken_no.HeaderText = "Token No.";
            this.clmnToken_no.Name = "clmnToken_no";
            // 
            // clmnEPF_No
            // 
            this.clmnEPF_No.DataPropertyName = "EPFNo";
            this.clmnEPF_No.HeaderText = "E.P.F No.";
            this.clmnEPF_No.Name = "clmnEPF_No";
            // 
            // clmnEmployee_Name
            // 
            this.clmnEmployee_Name.DataPropertyName = "EmployeeName";
            this.clmnEmployee_Name.HeaderText = "Employee Name";
            this.clmnEmployee_Name.Name = "clmnEmployee_Name";
            // 
            // clmnDate
            // 
            this.clmnDate.DataPropertyName = "Date";
            this.clmnDate.HeaderText = "Date";
            this.clmnDate.Name = "clmnDate";
            // 
            // clmnType
            // 
            this.clmnType.DataPropertyName = "Type";
            this.clmnType.HeaderText = "Type";
            this.clmnType.Name = "clmnType";
            // 
            // clmnOTHours
            // 
            this.clmnOTHours.DataPropertyName = "OTHours";
            this.clmnOTHours.HeaderText = "OT Hours";
            this.clmnOTHours.Name = "clmnOTHours";
            // 
            // frmOverTimeAuthorize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 507);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxOver_Time_Details);
            this.Controls.Add(this.gbxDepartmentDetails);
            this.Controls.Add(this.lblFormTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOverTimeAuthorize";
            this.Text = "Over Time Authorize";
            this.Load += new System.EventHandler(this.frmOverTimeAuthorize_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvOver_Time_Request)).EndInit();
            this.gbxOver_Time_Details.ResumeLayout(false);
            this.gbxOver_Time_Details.PerformLayout();
            this.gbxOver_Time_Type.ResumeLayout(false);
            this.gbxOver_Time_Type.PerformLayout();
            this.gbxTime.ResumeLayout(false);
            this.gbxTime.PerformLayout();
            this.gbxDepartmentDetails.ResumeLayout(false);
            this.gbxDepartmentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gdvOver_Time_Request;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbxOver_Time_Details;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEndAt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStartAt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxDepartmentDetails;
        private System.Windows.Forms.CheckBox chbUnAuthorizedOnly;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSubDepartment;
        private System.Windows.Forms.ComboBox cmbSubDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbWorkingBranch;
        private System.Windows.Forms.Label lblWorkingBranch;
        private System.Windows.Forms.Label lblFormTopic;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnAuthorize;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnApprove;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnToken_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEPF_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployee_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnOTHours;
    }
}