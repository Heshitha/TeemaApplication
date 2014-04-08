namespace TeemaApplication
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
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.btnViewEmployee);
            this.groupBox1.Controls.Add(this.btnViewEmplyeeList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Functions";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 380);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Choose Button For Your Window";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewEmployee;
        private System.Windows.Forms.Button btnViewEmplyeeList;
        private System.Windows.Forms.Button btnViewEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}