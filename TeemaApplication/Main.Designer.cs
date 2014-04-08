﻿namespace TeemaApplication
{
    partial class frmMain
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
            this.btnAddNewEmployee = new System.Windows.Forms.Button();
            this.btnViewEmplyeeList = new System.Windows.Forms.Button();
            this.btnViewEmployee = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddLeaves = new System.Windows.Forms.Button();
            this.gbxOverTime = new System.Windows.Forms.GroupBox();
            this.btnOverTimeApproved = new System.Windows.Forms.Button();
            this.btnOverTimeRequest = new System.Windows.Forms.Button();
            this.gbxSalary = new System.Windows.Forms.GroupBox();
            this.btnBasicSalary = new System.Windows.Forms.Button();
            this.btnSalaryLoanRequest = new System.Windows.Forms.Button();
            this.btnSalaryLoanApproved = new System.Windows.Forms.Button();
            this.btnASalaryAdvanceRequest = new System.Windows.Forms.Button();
            this.btnSalaryAdvanceApproved = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gbxOverTime.SuspendLayout();
            this.gbxSalary.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNewEmployee
            // 
            this.btnAddNewEmployee.Location = new System.Drawing.Point(6, 19);
            this.btnAddNewEmployee.Name = "btnAddNewEmployee";
            this.btnAddNewEmployee.Size = new System.Drawing.Size(112, 23);
            this.btnAddNewEmployee.TabIndex = 0;
            this.btnAddNewEmployee.Text = "Add New Employee";
            this.btnAddNewEmployee.UseVisualStyleBackColor = true;
            this.btnAddNewEmployee.Click += new System.EventHandler(this.btnAddNewEmployee_Click);
            // 
            // btnViewEmplyeeList
            // 
            this.btnViewEmplyeeList.Location = new System.Drawing.Point(6, 49);
            this.btnViewEmplyeeList.Name = "btnViewEmplyeeList";
            this.btnViewEmplyeeList.Size = new System.Drawing.Size(112, 23);
            this.btnViewEmplyeeList.TabIndex = 1;
            this.btnViewEmplyeeList.Text = "View Employee List";
            this.btnViewEmplyeeList.UseVisualStyleBackColor = true;
            this.btnViewEmplyeeList.Click += new System.EventHandler(this.btnViewEmplyeeList_Click);
            // 
            // btnViewEmployee
            // 
            this.btnViewEmployee.Location = new System.Drawing.Point(6, 79);
            this.btnViewEmployee.Name = "btnViewEmployee";
            this.btnViewEmployee.Size = new System.Drawing.Size(112, 23);
            this.btnViewEmployee.TabIndex = 2;
            this.btnViewEmployee.Text = "View Employee";
            this.btnViewEmployee.UseVisualStyleBackColor = true;
            this.btnViewEmployee.Click += new System.EventHandler(this.btnViewEmployee_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddNewEmployee);
            this.groupBox1.Controls.Add(this.btnAddLeaves);
            this.groupBox1.Controls.Add(this.btnViewEmployee);
            this.groupBox1.Controls.Add(this.btnViewEmplyeeList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 142);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Functions";
            // 
            // btnAddLeaves
            // 
            this.btnAddLeaves.Location = new System.Drawing.Point(6, 108);
            this.btnAddLeaves.Name = "btnAddLeaves";
            this.btnAddLeaves.Size = new System.Drawing.Size(112, 23);
            this.btnAddLeaves.TabIndex = 2;
            this.btnAddLeaves.Text = "Add Leaves";
            this.btnAddLeaves.UseVisualStyleBackColor = true;
            this.btnAddLeaves.Click += new System.EventHandler(this.btnAddLeaves_Click);
            // 
            // gbxOverTime
            // 
            this.gbxOverTime.Controls.Add(this.btnOverTimeApproved);
            this.gbxOverTime.Controls.Add(this.btnOverTimeRequest);
            this.gbxOverTime.Location = new System.Drawing.Point(143, 12);
            this.gbxOverTime.Name = "gbxOverTime";
            this.gbxOverTime.Size = new System.Drawing.Size(147, 83);
            this.gbxOverTime.TabIndex = 4;
            this.gbxOverTime.TabStop = false;
            this.gbxOverTime.Text = "Over Time";
            // 
            // btnOverTimeApproved
            // 
            this.btnOverTimeApproved.Location = new System.Drawing.Point(6, 46);
            this.btnOverTimeApproved.Name = "btnOverTimeApproved";
            this.btnOverTimeApproved.Size = new System.Drawing.Size(131, 23);
            this.btnOverTimeApproved.TabIndex = 1;
            this.btnOverTimeApproved.Text = "Over Time Approved";
            this.btnOverTimeApproved.UseVisualStyleBackColor = true;
            this.btnOverTimeApproved.Click += new System.EventHandler(this.btnOverTimeApproved_Click);
            // 
            // btnOverTimeRequest
            // 
            this.btnOverTimeRequest.Location = new System.Drawing.Point(6, 17);
            this.btnOverTimeRequest.Name = "btnOverTimeRequest";
            this.btnOverTimeRequest.Size = new System.Drawing.Size(131, 23);
            this.btnOverTimeRequest.TabIndex = 0;
            this.btnOverTimeRequest.Text = "Over Time request";
            this.btnOverTimeRequest.UseVisualStyleBackColor = true;
            this.btnOverTimeRequest.Click += new System.EventHandler(this.btnOverTimeRequest_Click);
            // 
            // gbxSalary
            // 
            this.gbxSalary.Controls.Add(this.btnSalaryAdvanceApproved);
            this.gbxSalary.Controls.Add(this.btnASalaryAdvanceRequest);
            this.gbxSalary.Controls.Add(this.btnSalaryLoanApproved);
            this.gbxSalary.Controls.Add(this.btnSalaryLoanRequest);
            this.gbxSalary.Controls.Add(this.btnBasicSalary);
            this.gbxSalary.Location = new System.Drawing.Point(296, 12);
            this.gbxSalary.Name = "gbxSalary";
            this.gbxSalary.Size = new System.Drawing.Size(159, 174);
            this.gbxSalary.TabIndex = 5;
            this.gbxSalary.TabStop = false;
            this.gbxSalary.Text = "Salary";
            // 
            // btnBasicSalary
            // 
            this.btnBasicSalary.Location = new System.Drawing.Point(6, 19);
            this.btnBasicSalary.Name = "btnBasicSalary";
            this.btnBasicSalary.Size = new System.Drawing.Size(142, 23);
            this.btnBasicSalary.TabIndex = 0;
            this.btnBasicSalary.Text = "Basic Salary";
            this.btnBasicSalary.UseVisualStyleBackColor = true;
            // 
            // btnSalaryLoanRequest
            // 
            this.btnSalaryLoanRequest.Location = new System.Drawing.Point(6, 48);
            this.btnSalaryLoanRequest.Name = "btnSalaryLoanRequest";
            this.btnSalaryLoanRequest.Size = new System.Drawing.Size(142, 23);
            this.btnSalaryLoanRequest.TabIndex = 1;
            this.btnSalaryLoanRequest.Text = "Salary Loan Request";
            this.btnSalaryLoanRequest.UseVisualStyleBackColor = true;
            // 
            // btnSalaryLoanApproved
            // 
            this.btnSalaryLoanApproved.Location = new System.Drawing.Point(6, 77);
            this.btnSalaryLoanApproved.Name = "btnSalaryLoanApproved";
            this.btnSalaryLoanApproved.Size = new System.Drawing.Size(142, 23);
            this.btnSalaryLoanApproved.TabIndex = 2;
            this.btnSalaryLoanApproved.Text = "Salary Loan Approved";
            this.btnSalaryLoanApproved.UseVisualStyleBackColor = true;
            // 
            // btnASalaryAdvanceRequest
            // 
            this.btnASalaryAdvanceRequest.Location = new System.Drawing.Point(6, 106);
            this.btnASalaryAdvanceRequest.Name = "btnASalaryAdvanceRequest";
            this.btnASalaryAdvanceRequest.Size = new System.Drawing.Size(142, 23);
            this.btnASalaryAdvanceRequest.TabIndex = 3;
            this.btnASalaryAdvanceRequest.Text = "Salary Advance Request";
            this.btnASalaryAdvanceRequest.UseVisualStyleBackColor = true;
            // 
            // btnSalaryAdvanceApproved
            // 
            this.btnSalaryAdvanceApproved.Location = new System.Drawing.Point(6, 135);
            this.btnSalaryAdvanceApproved.Name = "btnSalaryAdvanceApproved";
            this.btnSalaryAdvanceApproved.Size = new System.Drawing.Size(142, 23);
            this.btnSalaryAdvanceApproved.TabIndex = 4;
            this.btnSalaryAdvanceApproved.Text = "Salary Advance Approved";
            this.btnSalaryAdvanceApproved.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(461, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 380);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxSalary);
            this.Controls.Add(this.gbxOverTime);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Choose Button For Your Window";
            this.groupBox1.ResumeLayout(false);
            this.gbxOverTime.ResumeLayout(false);
            this.gbxSalary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewEmployee;
        private System.Windows.Forms.Button btnViewEmplyeeList;
        private System.Windows.Forms.Button btnViewEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddLeaves;
        private System.Windows.Forms.GroupBox gbxOverTime;
        private System.Windows.Forms.Button btnOverTimeRequest;
        private System.Windows.Forms.Button btnOverTimeApproved;
        private System.Windows.Forms.GroupBox gbxSalary;
        private System.Windows.Forms.Button btnSalaryAdvanceApproved;
        private System.Windows.Forms.Button btnASalaryAdvanceRequest;
        private System.Windows.Forms.Button btnSalaryLoanApproved;
        private System.Windows.Forms.Button btnSalaryLoanRequest;
        private System.Windows.Forms.Button btnBasicSalary;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}