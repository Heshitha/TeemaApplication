using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TeemaApplication.Classes;

namespace TeemaApplication
{
    public partial class frmManualAttendance : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
        public frmManualAttendance()
        {
            InitializeComponent();
        }

        private void frmManualAttendance_Load(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbWorkingBranch(db, cmbWorkingBranch);
            EmployeeUtils.fillcmbDepartment((Branch)cmbWorkingBranch.SelectedItem, cmbDepartment);
            EmployeeUtils.fillcmbSubDepartment((Department)cmbDepartment.SelectedItem, cmbSubDepartment);
            fillcmbTokenNo((SubDepartment)cmbSubDepartment.SelectedItem, cmbTokenNo);
            fillcmbEmployeeName((SubDepartment)cmbSubDepartment.SelectedItem, cmbEmployeeName);
        }

        private void fillcmbTokenNo(SubDepartment subDept, ComboBox comboBox)
        {
            comboBox.DisplayMember = "TokenNo";
            comboBox.ValueMember = "EmployeeID";
            comboBox.DataSource = subDept.Employees;
        }

        private void fillcmbEmployeeName(SubDepartment subDept, ComboBox comboBox)
        {
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "EmployeeID";
            comboBox.DataSource = subDept.Employees;
        }

        private void cmbWorkingBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbDepartment((Branch)cmbWorkingBranch.SelectedItem, cmbDepartment);
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbSubDepartment((Department)cmbDepartment.SelectedItem, cmbSubDepartment);
        }

        private void cmbSubDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillcmbTokenNo((SubDepartment)cmbSubDepartment.SelectedItem, cmbTokenNo);
            fillcmbEmployeeName((SubDepartment)cmbSubDepartment.SelectedItem, cmbEmployeeName);
        }

        private void cmbTokenNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee emp = (Employee)cmbTokenNo.SelectedItem;
            txtDesignation.Text = emp.Designation.Designation1;
            txtNIC_No.Text = emp.NICNo;
            txtEPF_No.Text = emp.EPFNo;
        }

        private void cmbEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee emp = (Employee)cmbEmployeeName.SelectedItem;
            txtDesignation.Text = emp.Designation.Designation1;
            txtNIC_No.Text = emp.NICNo;
            txtEPF_No.Text = emp.EPFNo;
        }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            Employee emp = (Employee)cmbEmployeeName.SelectedItem;
            DateTime dateAndTime = dtpAttendaceDate.Value;
            int hours = EmployeeUtils.getIntNumaricValue("Hour Value.", dupHour.Text);
            int mins = EmployeeUtils.getIntNumaricValue("Minutes Value.", dupMiniutes.Text);

            dateAndTime = new DateTime(dateAndTime.Year, dateAndTime.Month, dateAndTime.Day, hours, mins, 0);
            string mode = cmbMode.Text;

            EmployeeAttendance empAtt = new EmployeeAttendance
            {
                Employee = emp,
                DateAndTime = dateAndTime,
                Mode = mode,
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                ModifiedBy = 1,
                ModifiedDate = DateTime.Now,
            };

            db.EmployeeAttendances.InsertOnSubmit(empAtt);
            db.SubmitChanges();
            ShowMessageBox.ShowSuccess("Information successfully saved.");
        }
    }
}
