namespace TeemaApplication
{
    partial class frmViewEmployeeList
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
            this.components = new System.ComponentModel.Container();
            this.gbxDepartmentDetails = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSubDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbWorkingBranch = new System.Windows.Forms.ComboBox();
            this.lblWorkingBranch = new System.Windows.Forms.Label();
            this.lblFormTopic = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvFoundEmployees = new System.Windows.Forms.DataGridView();
            this.cmsEmployeeProperties = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewEmployeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLeaveDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLoanDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clmnTokenNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEPFNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbxDepartmentDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundEmployees)).BeginInit();
            this.cmsEmployeeProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDepartmentDetails
            // 
            this.gbxDepartmentDetails.BackColor = System.Drawing.SystemColors.Control;
            this.gbxDepartmentDetails.Controls.Add(this.btnSearch);
            this.gbxDepartmentDetails.Controls.Add(this.label2);
            this.gbxDepartmentDetails.Controls.Add(this.cmbSubDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.lblDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbWorkingBranch);
            this.gbxDepartmentDetails.Controls.Add(this.lblWorkingBranch);
            this.gbxDepartmentDetails.Location = new System.Drawing.Point(12, 43);
            this.gbxDepartmentDetails.Name = "gbxDepartmentDetails";
            this.gbxDepartmentDetails.Size = new System.Drawing.Size(731, 48);
            this.gbxDepartmentDetails.TabIndex = 13;
            this.gbxDepartmentDetails.TabStop = false;
            this.gbxDepartmentDetails.Text = "Department Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sub Department";
            // 
            // cmbSubDepartment
            // 
            this.cmbSubDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubDepartment.FormattingEnabled = true;
            this.cmbSubDepartment.Location = new System.Drawing.Point(512, 19);
            this.cmbSubDepartment.Name = "cmbSubDepartment";
            this.cmbSubDepartment.Size = new System.Drawing.Size(123, 21);
            this.cmbSubDepartment.TabIndex = 4;
            this.cmbSubDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbSubDepartment_SelectedIndexChanged);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(225, 22);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "Department";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(293, 19);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(123, 21);
            this.cmbDepartment.TabIndex = 2;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // cmbWorkingBranch
            // 
            this.cmbWorkingBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkingBranch.FormattingEnabled = true;
            this.cmbWorkingBranch.Location = new System.Drawing.Point(96, 19);
            this.cmbWorkingBranch.Name = "cmbWorkingBranch";
            this.cmbWorkingBranch.Size = new System.Drawing.Size(123, 21);
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
            this.lblFormTopic.Size = new System.Drawing.Size(250, 31);
            this.lblFormTopic.TabIndex = 12;
            this.lblFormTopic.Text = "View Employee List";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFoundEmployees);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 404);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Found Employees";
            // 
            // dgvFoundEmployees
            // 
            this.dgvFoundEmployees.AllowUserToAddRows = false;
            this.dgvFoundEmployees.AllowUserToDeleteRows = false;
            this.dgvFoundEmployees.AllowUserToResizeColumns = false;
            this.dgvFoundEmployees.AllowUserToResizeRows = false;
            this.dgvFoundEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoundEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoundEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnTokenNo,
            this.clmnEPFNo,
            this.clmnNIC,
            this.clmnName,
            this.clmnDesignation});
            this.dgvFoundEmployees.ContextMenuStrip = this.cmsEmployeeProperties;
            this.dgvFoundEmployees.Location = new System.Drawing.Point(7, 20);
            this.dgvFoundEmployees.Name = "dgvFoundEmployees";
            this.dgvFoundEmployees.RowHeadersVisible = false;
            this.dgvFoundEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoundEmployees.Size = new System.Drawing.Size(718, 378);
            this.dgvFoundEmployees.TabIndex = 0;
            this.dgvFoundEmployees.ContextMenuStripChanged += new System.EventHandler(this.dgvFoundEmployees_ContextMenuStripChanged);
            // 
            // cmsEmployeeProperties
            // 
            this.cmsEmployeeProperties.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewEmployeeDetailsToolStripMenuItem,
            this.viewLeaveDetailsToolStripMenuItem,
            this.viewLoanDetailsToolStripMenuItem});
            this.cmsEmployeeProperties.Name = "cmsEmployeeProperties";
            this.cmsEmployeeProperties.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsEmployeeProperties.ShowImageMargin = false;
            this.cmsEmployeeProperties.Size = new System.Drawing.Size(168, 92);
            this.cmsEmployeeProperties.Opening += new System.ComponentModel.CancelEventHandler(this.cmsEmployeeProperties_Opening);
            // 
            // viewEmployeeDetailsToolStripMenuItem
            // 
            this.viewEmployeeDetailsToolStripMenuItem.Name = "viewEmployeeDetailsToolStripMenuItem";
            this.viewEmployeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.viewEmployeeDetailsToolStripMenuItem.Text = "View Employee Details";
            this.viewEmployeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewEmployeeDetailsToolStripMenuItem_Click);
            // 
            // viewLeaveDetailsToolStripMenuItem
            // 
            this.viewLeaveDetailsToolStripMenuItem.Name = "viewLeaveDetailsToolStripMenuItem";
            this.viewLeaveDetailsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.viewLeaveDetailsToolStripMenuItem.Text = "View Leave Details";
            // 
            // viewLoanDetailsToolStripMenuItem
            // 
            this.viewLoanDetailsToolStripMenuItem.Name = "viewLoanDetailsToolStripMenuItem";
            this.viewLoanDetailsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.viewLoanDetailsToolStripMenuItem.Text = "View Loan Details";
            // 
            // clmnTokenNo
            // 
            this.clmnTokenNo.DataPropertyName = "TokenNo";
            this.clmnTokenNo.HeaderText = "Token No";
            this.clmnTokenNo.Name = "clmnTokenNo";
            // 
            // clmnEPFNo
            // 
            this.clmnEPFNo.DataPropertyName = "EPFNo";
            this.clmnEPFNo.HeaderText = "EPF No";
            this.clmnEPFNo.Name = "clmnEPFNo";
            // 
            // clmnNIC
            // 
            this.clmnNIC.DataPropertyName = "NICNo";
            this.clmnNIC.HeaderText = "NIC";
            this.clmnNIC.Name = "clmnNIC";
            // 
            // clmnName
            // 
            this.clmnName.DataPropertyName = "Name";
            this.clmnName.HeaderText = "Name";
            this.clmnName.Name = "clmnName";
            // 
            // clmnDesignation
            // 
            this.clmnDesignation.DataPropertyName = "Designation";
            this.clmnDesignation.HeaderText = "Designation";
            this.clmnDesignation.Name = "clmnDesignation";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(641, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmViewEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxDepartmentDetails);
            this.Controls.Add(this.lblFormTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmViewEmployeeList";
            this.Text = "View Employee List";
            this.Load += new System.EventHandler(this.frmViewEmployeeList_Load);
            this.gbxDepartmentDetails.ResumeLayout(false);
            this.gbxDepartmentDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundEmployees)).EndInit();
            this.cmsEmployeeProperties.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDepartmentDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSubDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbWorkingBranch;
        private System.Windows.Forms.Label lblWorkingBranch;
        private System.Windows.Forms.Label lblFormTopic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFoundEmployees;
        private System.Windows.Forms.ContextMenuStrip cmsEmployeeProperties;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLeaveDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLoanDetailsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTokenNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEPFNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDesignation;
        private System.Windows.Forms.Button btnSearch;
    }
}