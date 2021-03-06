﻿namespace TeemaApplication
{
    partial class frmLoadAttendanceDetails
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtConnectionMode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMachineName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMachineID = new System.Windows.Forms.ComboBox();
            this.lblWorkingBranch = new System.Windows.Forms.Label();
            this.lblFormTopic = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAttendanceDetails = new System.Windows.Forms.DataGridView();
            this.clmnClock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnVerifyMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveRecords = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbSavingProgress = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceDetails)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtConnectionMode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbMachineName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbMachineID);
            this.groupBox1.Controls.Add(this.lblWorkingBranch);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fingerprint Devices";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(229, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtConnectionMode
            // 
            this.txtConnectionMode.Location = new System.Drawing.Point(105, 73);
            this.txtConnectionMode.Name = "txtConnectionMode";
            this.txtConnectionMode.ReadOnly = true;
            this.txtConnectionMode.Size = new System.Drawing.Size(199, 20);
            this.txtConnectionMode.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Connection Mode";
            // 
            // cmbMachineName
            // 
            this.cmbMachineName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMachineName.FormattingEnabled = true;
            this.cmbMachineName.Location = new System.Drawing.Point(105, 46);
            this.cmbMachineName.Name = "cmbMachineName";
            this.cmbMachineName.Size = new System.Drawing.Size(199, 21);
            this.cmbMachineName.TabIndex = 5;
            this.cmbMachineName.SelectedIndexChanged += new System.EventHandler(this.cmbMachineName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Machine Name";
            // 
            // cmbMachineID
            // 
            this.cmbMachineID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMachineID.FormattingEnabled = true;
            this.cmbMachineID.Location = new System.Drawing.Point(105, 19);
            this.cmbMachineID.Name = "cmbMachineID";
            this.cmbMachineID.Size = new System.Drawing.Size(199, 21);
            this.cmbMachineID.TabIndex = 3;
            this.cmbMachineID.SelectedIndexChanged += new System.EventHandler(this.cmbMachineID_SelectedIndexChanged);
            // 
            // lblWorkingBranch
            // 
            this.lblWorkingBranch.AutoSize = true;
            this.lblWorkingBranch.Location = new System.Drawing.Point(6, 22);
            this.lblWorkingBranch.Name = "lblWorkingBranch";
            this.lblWorkingBranch.Size = new System.Drawing.Size(62, 13);
            this.lblWorkingBranch.TabIndex = 2;
            this.lblWorkingBranch.Text = "Machine ID";
            // 
            // lblFormTopic
            // 
            this.lblFormTopic.AutoSize = true;
            this.lblFormTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTopic.Location = new System.Drawing.Point(12, 9);
            this.lblFormTopic.Name = "lblFormTopic";
            this.lblFormTopic.Size = new System.Drawing.Size(310, 31);
            this.lblFormTopic.TabIndex = 2;
            this.lblFormTopic.Text = "Load Attendance Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAttendanceDetails);
            this.groupBox2.Location = new System.Drawing.Point(12, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 341);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attendance Details";
            // 
            // dgvAttendanceDetails
            // 
            this.dgvAttendanceDetails.AllowUserToAddRows = false;
            this.dgvAttendanceDetails.AllowUserToDeleteRows = false;
            this.dgvAttendanceDetails.AllowUserToOrderColumns = true;
            this.dgvAttendanceDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendanceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendanceDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnClock,
            this.clmnDIN,
            this.clmnVerifyMode});
            this.dgvAttendanceDetails.Location = new System.Drawing.Point(6, 19);
            this.dgvAttendanceDetails.Name = "dgvAttendanceDetails";
            this.dgvAttendanceDetails.ReadOnly = true;
            this.dgvAttendanceDetails.RowHeadersVisible = false;
            this.dgvAttendanceDetails.Size = new System.Drawing.Size(298, 315);
            this.dgvAttendanceDetails.TabIndex = 0;
            // 
            // clmnClock
            // 
            this.clmnClock.DataPropertyName = "Clock";
            this.clmnClock.HeaderText = "Clock";
            this.clmnClock.Name = "clmnClock";
            this.clmnClock.ReadOnly = true;
            // 
            // clmnDIN
            // 
            this.clmnDIN.DataPropertyName = "DIN";
            this.clmnDIN.HeaderText = "DIN";
            this.clmnDIN.Name = "clmnDIN";
            this.clmnDIN.ReadOnly = true;
            // 
            // clmnVerifyMode
            // 
            this.clmnVerifyMode.DataPropertyName = "VerifyMode";
            this.clmnVerifyMode.HeaderText = "Verify Mode";
            this.clmnVerifyMode.Name = "clmnVerifyMode";
            this.clmnVerifyMode.ReadOnly = true;
            // 
            // btnSaveRecords
            // 
            this.btnSaveRecords.Location = new System.Drawing.Point(229, 570);
            this.btnSaveRecords.Name = "btnSaveRecords";
            this.btnSaveRecords.Size = new System.Drawing.Size(93, 23);
            this.btnSaveRecords.TabIndex = 4;
            this.btnSaveRecords.Text = "Save Records";
            this.btnSaveRecords.UseVisualStyleBackColor = true;
            this.btnSaveRecords.Click += new System.EventHandler(this.btnSaveRecords_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pbSavingProgress);
            this.groupBox3.Location = new System.Drawing.Point(13, 527);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 37);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Progress";
            // 
            // pbSavingProgress
            // 
            this.pbSavingProgress.Location = new System.Drawing.Point(6, 15);
            this.pbSavingProgress.Name = "pbSavingProgress";
            this.pbSavingProgress.Size = new System.Drawing.Size(297, 14);
            this.pbSavingProgress.TabIndex = 0;
            // 
            // frmLoadAttendanceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 605);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSaveRecords);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblFormTopic);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLoadAttendanceDetails";
            this.Text = "Load Attendance Details";
            this.Load += new System.EventHandler(this.frmLoadAttendanceDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceDetails)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFormTopic;
        private System.Windows.Forms.ComboBox cmbMachineName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMachineID;
        private System.Windows.Forms.Label lblWorkingBranch;
        private System.Windows.Forms.TextBox txtConnectionMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAttendanceDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnClock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnVerifyMode;
        private System.Windows.Forms.Button btnSaveRecords;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar pbSavingProgress;
    }
}