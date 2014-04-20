namespace TeemaApplication
{
    partial class frmOver_Time_Request
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
            this.gbxEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.txtToken_No = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEPF_No = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNIC_No = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.dudToMM = new System.Windows.Forms.DomainUpDown();
            this.dudFromMM = new System.Windows.Forms.DomainUpDown();
            this.dudToHH = new System.Windows.Forms.DomainUpDown();
            this.dudFromHH = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gdvOver_Time_Request = new System.Windows.Forms.DataGridView();
            this.clmnEntitled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnToken_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEPF_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmployee_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxDepartmentDetails.SuspendLayout();
            this.gbxEmployeeDetails.SuspendLayout();
            this.gbxOver_Time_Details.SuspendLayout();
            this.gbxOver_Time_Type.SuspendLayout();
            this.gbxTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvOver_Time_Request)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTopic
            // 
            this.lblFormTopic.AutoSize = true;
            this.lblFormTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTopic.Location = new System.Drawing.Point(13, 13);
            this.lblFormTopic.Name = "lblFormTopic";
            this.lblFormTopic.Size = new System.Drawing.Size(249, 31);
            this.lblFormTopic.TabIndex = 3;
            this.lblFormTopic.Text = "Over Time Request";
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
            this.gbxDepartmentDetails.Location = new System.Drawing.Point(12, 48);
            this.gbxDepartmentDetails.Name = "gbxDepartmentDetails";
            this.gbxDepartmentDetails.Size = new System.Drawing.Size(285, 131);
            this.gbxDepartmentDetails.TabIndex = 4;
            this.gbxDepartmentDetails.TabStop = false;
            this.gbxDepartmentDetails.Text = "Department Details";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(198, 100);
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
            this.cmbSubDepartment.Size = new System.Drawing.Size(177, 21);
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
            this.cmbDepartment.Size = new System.Drawing.Size(177, 21);
            this.cmbDepartment.TabIndex = 2;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // cmbWorkingBranch
            // 
            this.cmbWorkingBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkingBranch.FormattingEnabled = true;
            this.cmbWorkingBranch.Location = new System.Drawing.Point(96, 19);
            this.cmbWorkingBranch.Name = "cmbWorkingBranch";
            this.cmbWorkingBranch.Size = new System.Drawing.Size(177, 21);
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
            this.gbxEmployeeDetails.Location = new System.Drawing.Point(12, 185);
            this.gbxEmployeeDetails.Name = "gbxEmployeeDetails";
            this.gbxEmployeeDetails.Size = new System.Drawing.Size(285, 155);
            this.gbxEmployeeDetails.TabIndex = 5;
            this.gbxEmployeeDetails.TabStop = false;
            this.gbxEmployeeDetails.Text = "Employee Details";
            // 
            // txtToken_No
            // 
            this.txtToken_No.Location = new System.Drawing.Point(97, 124);
            this.txtToken_No.Name = "txtToken_No";
            this.txtToken_No.Size = new System.Drawing.Size(176, 20);
            this.txtToken_No.TabIndex = 23;
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
            // txtEPF_No
            // 
            this.txtEPF_No.Location = new System.Drawing.Point(97, 98);
            this.txtEPF_No.Name = "txtEPF_No";
            this.txtEPF_No.Size = new System.Drawing.Size(176, 20);
            this.txtEPF_No.TabIndex = 18;
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
            // txtNIC_No
            // 
            this.txtNIC_No.Location = new System.Drawing.Point(97, 71);
            this.txtNIC_No.Name = "txtNIC_No";
            this.txtNIC_No.Size = new System.Drawing.Size(176, 20);
            this.txtNIC_No.TabIndex = 16;
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
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(97, 45);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(176, 20);
            this.txtDesignation.TabIndex = 14;
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
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(97, 19);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(176, 20);
            this.txtEmployeeName.TabIndex = 9;
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
            this.gbxOver_Time_Details.Location = new System.Drawing.Point(303, 48);
            this.gbxOver_Time_Details.Name = "gbxOver_Time_Details";
            this.gbxOver_Time_Details.Size = new System.Drawing.Size(561, 144);
            this.gbxOver_Time_Details.TabIndex = 6;
            this.gbxOver_Time_Details.TabStop = false;
            this.gbxOver_Time_Details.Text = "Over Time Details";
            // 
            // txtOver_Time_Hours
            // 
            this.txtOver_Time_Hours.Location = new System.Drawing.Point(377, 19);
            this.txtOver_Time_Hours.Name = "txtOver_Time_Hours";
            this.txtOver_Time_Hours.Size = new System.Drawing.Size(178, 20);
            this.txtOver_Time_Hours.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Over Time Hours";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(377, 45);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(178, 93);
            this.txtReason.TabIndex = 10;
            // 
            // dtpOver_Time_Date
            // 
            this.dtpOver_Time_Date.Location = new System.Drawing.Point(104, 19);
            this.dtpOver_Time_Date.Name = "dtpOver_Time_Date";
            this.dtpOver_Time_Date.Size = new System.Drawing.Size(173, 20);
            this.dtpOver_Time_Date.TabIndex = 5;
            // 
            // gbxOver_Time_Type
            // 
            this.gbxOver_Time_Type.Controls.Add(this.rdbTreble);
            this.gbxOver_Time_Type.Controls.Add(this.rdbDouble);
            this.gbxOver_Time_Type.Controls.Add(this.rdbSingle);
            this.gbxOver_Time_Type.Location = new System.Drawing.Point(153, 45);
            this.gbxOver_Time_Type.Name = "gbxOver_Time_Type";
            this.gbxOver_Time_Type.Size = new System.Drawing.Size(124, 93);
            this.gbxOver_Time_Type.TabIndex = 4;
            this.gbxOver_Time_Type.TabStop = false;
            this.gbxOver_Time_Type.Text = "Over Time Type";
            // 
            // rdbTreble
            // 
            this.rdbTreble.AutoSize = true;
            this.rdbTreble.Location = new System.Drawing.Point(6, 65);
            this.rdbTreble.Name = "rdbTreble";
            this.rdbTreble.Size = new System.Drawing.Size(55, 17);
            this.rdbTreble.TabIndex = 2;
            this.rdbTreble.Text = "Treble";
            this.rdbTreble.UseVisualStyleBackColor = true;
            // 
            // rdbDouble
            // 
            this.rdbDouble.AutoSize = true;
            this.rdbDouble.Location = new System.Drawing.Point(6, 42);
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
            this.label5.Location = new System.Drawing.Point(283, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Reason";
            // 
            // gbxTime
            // 
            this.gbxTime.Controls.Add(this.dudToMM);
            this.gbxTime.Controls.Add(this.dudFromMM);
            this.gbxTime.Controls.Add(this.dudToHH);
            this.gbxTime.Controls.Add(this.dudFromHH);
            this.gbxTime.Controls.Add(this.label4);
            this.gbxTime.Controls.Add(this.label2);
            this.gbxTime.Location = new System.Drawing.Point(6, 45);
            this.gbxTime.Name = "gbxTime";
            this.gbxTime.Size = new System.Drawing.Size(141, 93);
            this.gbxTime.TabIndex = 2;
            this.gbxTime.TabStop = false;
            this.gbxTime.Text = "Time";
            // 
            // dudToMM
            // 
            this.dudToMM.Items.Add("00");
            this.dudToMM.Items.Add("01");
            this.dudToMM.Items.Add("02");
            this.dudToMM.Items.Add("03");
            this.dudToMM.Items.Add("04");
            this.dudToMM.Items.Add("05");
            this.dudToMM.Items.Add("06");
            this.dudToMM.Items.Add("07");
            this.dudToMM.Items.Add("08");
            this.dudToMM.Items.Add("09");
            this.dudToMM.Items.Add("10");
            this.dudToMM.Items.Add("11");
            this.dudToMM.Items.Add("12");
            this.dudToMM.Items.Add("13");
            this.dudToMM.Items.Add("14");
            this.dudToMM.Items.Add("15");
            this.dudToMM.Items.Add("16");
            this.dudToMM.Items.Add("17");
            this.dudToMM.Items.Add("18");
            this.dudToMM.Items.Add("19");
            this.dudToMM.Items.Add("20");
            this.dudToMM.Items.Add("21");
            this.dudToMM.Items.Add("22");
            this.dudToMM.Items.Add("23");
            this.dudToMM.Items.Add("24");
            this.dudToMM.Items.Add("25");
            this.dudToMM.Items.Add("26");
            this.dudToMM.Items.Add("27");
            this.dudToMM.Items.Add("28");
            this.dudToMM.Items.Add("29");
            this.dudToMM.Items.Add("30");
            this.dudToMM.Items.Add("31");
            this.dudToMM.Items.Add("32");
            this.dudToMM.Items.Add("33");
            this.dudToMM.Items.Add("34");
            this.dudToMM.Items.Add("35");
            this.dudToMM.Items.Add("36");
            this.dudToMM.Items.Add("37");
            this.dudToMM.Items.Add("38");
            this.dudToMM.Items.Add("39");
            this.dudToMM.Items.Add("40");
            this.dudToMM.Items.Add("41");
            this.dudToMM.Items.Add("42");
            this.dudToMM.Items.Add("43");
            this.dudToMM.Items.Add("44");
            this.dudToMM.Items.Add("45");
            this.dudToMM.Items.Add("46");
            this.dudToMM.Items.Add("47");
            this.dudToMM.Items.Add("48");
            this.dudToMM.Items.Add("49");
            this.dudToMM.Items.Add("50");
            this.dudToMM.Items.Add("51");
            this.dudToMM.Items.Add("52");
            this.dudToMM.Items.Add("53");
            this.dudToMM.Items.Add("54");
            this.dudToMM.Items.Add("55");
            this.dudToMM.Items.Add("56");
            this.dudToMM.Items.Add("57");
            this.dudToMM.Items.Add("58");
            this.dudToMM.Items.Add("59");
            this.dudToMM.Location = new System.Drawing.Point(90, 45);
            this.dudToMM.Name = "dudToMM";
            this.dudToMM.Size = new System.Drawing.Size(42, 20);
            this.dudToMM.TabIndex = 6;
            this.dudToMM.Text = "MM";
            this.dudToMM.SelectedItemChanged += new System.EventHandler(this.dudToMM_SelectedItemChanged);
            // 
            // dudFromMM
            // 
            this.dudFromMM.Items.Add("00");
            this.dudFromMM.Items.Add("01");
            this.dudFromMM.Items.Add("02");
            this.dudFromMM.Items.Add("03");
            this.dudFromMM.Items.Add("04");
            this.dudFromMM.Items.Add("05");
            this.dudFromMM.Items.Add("06");
            this.dudFromMM.Items.Add("07");
            this.dudFromMM.Items.Add("08");
            this.dudFromMM.Items.Add("09");
            this.dudFromMM.Items.Add("10");
            this.dudFromMM.Items.Add("11");
            this.dudFromMM.Items.Add("12");
            this.dudFromMM.Items.Add("13");
            this.dudFromMM.Items.Add("14");
            this.dudFromMM.Items.Add("15");
            this.dudFromMM.Items.Add("16");
            this.dudFromMM.Items.Add("17");
            this.dudFromMM.Items.Add("18");
            this.dudFromMM.Items.Add("19");
            this.dudFromMM.Items.Add("20");
            this.dudFromMM.Items.Add("21");
            this.dudFromMM.Items.Add("22");
            this.dudFromMM.Items.Add("23");
            this.dudFromMM.Items.Add("24");
            this.dudFromMM.Items.Add("25");
            this.dudFromMM.Items.Add("26");
            this.dudFromMM.Items.Add("27");
            this.dudFromMM.Items.Add("28");
            this.dudFromMM.Items.Add("29");
            this.dudFromMM.Items.Add("30");
            this.dudFromMM.Items.Add("31");
            this.dudFromMM.Items.Add("32");
            this.dudFromMM.Items.Add("33");
            this.dudFromMM.Items.Add("34");
            this.dudFromMM.Items.Add("35");
            this.dudFromMM.Items.Add("36");
            this.dudFromMM.Items.Add("37");
            this.dudFromMM.Items.Add("38");
            this.dudFromMM.Items.Add("39");
            this.dudFromMM.Items.Add("40");
            this.dudFromMM.Items.Add("41");
            this.dudFromMM.Items.Add("42");
            this.dudFromMM.Items.Add("43");
            this.dudFromMM.Items.Add("44");
            this.dudFromMM.Items.Add("45");
            this.dudFromMM.Items.Add("46");
            this.dudFromMM.Items.Add("47");
            this.dudFromMM.Items.Add("48");
            this.dudFromMM.Items.Add("49");
            this.dudFromMM.Items.Add("50");
            this.dudFromMM.Items.Add("51");
            this.dudFromMM.Items.Add("52");
            this.dudFromMM.Items.Add("53");
            this.dudFromMM.Items.Add("54");
            this.dudFromMM.Items.Add("55");
            this.dudFromMM.Items.Add("56");
            this.dudFromMM.Items.Add("57");
            this.dudFromMM.Items.Add("58");
            this.dudFromMM.Items.Add("59");
            this.dudFromMM.Location = new System.Drawing.Point(90, 19);
            this.dudFromMM.Name = "dudFromMM";
            this.dudFromMM.Size = new System.Drawing.Size(42, 20);
            this.dudFromMM.TabIndex = 5;
            this.dudFromMM.Text = "MM";
            this.dudFromMM.SelectedItemChanged += new System.EventHandler(this.dudFromMM_SelectedItemChanged);
            // 
            // dudToHH
            // 
            this.dudToHH.Items.Add("00");
            this.dudToHH.Items.Add("01");
            this.dudToHH.Items.Add("02");
            this.dudToHH.Items.Add("03");
            this.dudToHH.Items.Add("04");
            this.dudToHH.Items.Add("05");
            this.dudToHH.Items.Add("06");
            this.dudToHH.Items.Add("07");
            this.dudToHH.Items.Add("08");
            this.dudToHH.Items.Add("09");
            this.dudToHH.Items.Add("10");
            this.dudToHH.Items.Add("11");
            this.dudToHH.Items.Add("12");
            this.dudToHH.Items.Add("13");
            this.dudToHH.Items.Add("14");
            this.dudToHH.Items.Add("15");
            this.dudToHH.Items.Add("16");
            this.dudToHH.Items.Add("17");
            this.dudToHH.Items.Add("18");
            this.dudToHH.Items.Add("19");
            this.dudToHH.Items.Add("20");
            this.dudToHH.Items.Add("21");
            this.dudToHH.Items.Add("22");
            this.dudToHH.Items.Add("23");
            this.dudToHH.Location = new System.Drawing.Point(42, 45);
            this.dudToHH.Name = "dudToHH";
            this.dudToHH.Size = new System.Drawing.Size(42, 20);
            this.dudToHH.TabIndex = 4;
            this.dudToHH.Text = "HH";
            this.dudToHH.SelectedItemChanged += new System.EventHandler(this.dudToHH_SelectedItemChanged);
            // 
            // dudFromHH
            // 
            this.dudFromHH.Items.Add("00");
            this.dudFromHH.Items.Add("01");
            this.dudFromHH.Items.Add("02");
            this.dudFromHH.Items.Add("03");
            this.dudFromHH.Items.Add("04");
            this.dudFromHH.Items.Add("05");
            this.dudFromHH.Items.Add("06");
            this.dudFromHH.Items.Add("07");
            this.dudFromHH.Items.Add("08");
            this.dudFromHH.Items.Add("09");
            this.dudFromHH.Items.Add("10");
            this.dudFromHH.Items.Add("11");
            this.dudFromHH.Items.Add("12");
            this.dudFromHH.Items.Add("13");
            this.dudFromHH.Items.Add("14");
            this.dudFromHH.Items.Add("15");
            this.dudFromHH.Items.Add("16");
            this.dudFromHH.Items.Add("17");
            this.dudFromHH.Items.Add("18");
            this.dudFromHH.Items.Add("19");
            this.dudFromHH.Items.Add("20");
            this.dudFromHH.Items.Add("21");
            this.dudFromHH.Items.Add("22");
            this.dudFromHH.Items.Add("23");
            this.dudFromHH.Location = new System.Drawing.Point(42, 19);
            this.dudFromHH.Name = "dudFromHH";
            this.dudFromHH.Size = new System.Drawing.Size(42, 20);
            this.dudFromHH.TabIndex = 3;
            this.dudFromHH.Text = "HH";
            this.dudFromHH.SelectedItemChanged += new System.EventHandler(this.dudFromHH_SelectedItemChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OverTime Date";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(789, 198);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gdvOver_Time_Request
            // 
            this.gdvOver_Time_Request.AllowUserToAddRows = false;
            this.gdvOver_Time_Request.AllowUserToDeleteRows = false;
            this.gdvOver_Time_Request.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvOver_Time_Request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvOver_Time_Request.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnEntitled,
            this.clmnToken_no,
            this.clmnEPF_No,
            this.clmnEmployee_Name});
            this.gdvOver_Time_Request.Location = new System.Drawing.Point(303, 227);
            this.gdvOver_Time_Request.Name = "gdvOver_Time_Request";
            this.gdvOver_Time_Request.RowHeadersVisible = false;
            this.gdvOver_Time_Request.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvOver_Time_Request.Size = new System.Drawing.Size(561, 232);
            this.gdvOver_Time_Request.TabIndex = 7;
            this.gdvOver_Time_Request.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvOver_Time_Request_CellClick);
            // 
            // clmnEntitled
            // 
            this.clmnEntitled.DataPropertyName = "Entitled";
            this.clmnEntitled.HeaderText = "Entitled";
            this.clmnEntitled.Name = "clmnEntitled";
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
            // frmOver_Time_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 471);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gdvOver_Time_Request);
            this.Controls.Add(this.gbxOver_Time_Details);
            this.Controls.Add(this.gbxEmployeeDetails);
            this.Controls.Add(this.gbxDepartmentDetails);
            this.Controls.Add(this.lblFormTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOver_Time_Request";
            this.Text = "Over Time Request";
            this.Load += new System.EventHandler(this.frmOver_Time_Request_Load);
            this.gbxDepartmentDetails.ResumeLayout(false);
            this.gbxDepartmentDetails.PerformLayout();
            this.gbxEmployeeDetails.ResumeLayout(false);
            this.gbxEmployeeDetails.PerformLayout();
            this.gbxOver_Time_Details.ResumeLayout(false);
            this.gbxOver_Time_Details.PerformLayout();
            this.gbxOver_Time_Type.ResumeLayout(false);
            this.gbxOver_Time_Type.PerformLayout();
            this.gbxTime.ResumeLayout(false);
            this.gbxTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvOver_Time_Request)).EndInit();
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbxEmployeeDetails;
        private System.Windows.Forms.TextBox txtToken_No;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEPF_No;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNIC_No;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxOver_Time_Details;
        private System.Windows.Forms.DateTimePicker dtpOver_Time_Date;
        private System.Windows.Forms.GroupBox gbxOver_Time_Type;
        private System.Windows.Forms.RadioButton rdbTreble;
        private System.Windows.Forms.RadioButton rdbDouble;
        private System.Windows.Forms.RadioButton rdbSingle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbxTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOver_Time_Hours;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.DataGridView gdvOver_Time_Request;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DomainUpDown dudToHH;
        private System.Windows.Forms.DomainUpDown dudFromHH;
        private System.Windows.Forms.DomainUpDown dudToMM;
        private System.Windows.Forms.DomainUpDown dudFromMM;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnEntitled;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnToken_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEPF_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployee_Name;
    }
}