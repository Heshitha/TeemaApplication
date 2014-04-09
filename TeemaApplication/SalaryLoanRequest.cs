using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeemaApplication
{
    public partial class frmSalary_Loan_Request : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
        public frmSalary_Loan_Request()
        {
            InitializeComponent();
        }

        // fill Depsrtment Search combo boxes
        private void fillcmbBranch()
        {
            cmbWorkingBranch.DisplayMember = "BranchName";
            cmbWorkingBranch.ValueMember = "BranchID";
            cmbWorkingBranch.DataSource = db.Branches;
        }
        // fill Depsrtment Search combo boxes
        private void fillcmbDepartment(Branch branch)
        {
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "DepartmentID";
            cmbDepartment.DataSource = branch.Departments;
        }
        // fill Depsrtment Search combo boxes
        private void fillcmbSubDepartment(Department department)
        {
            cmbSubDepartment.DisplayMember = "SubDepartmentName";
            cmbSubDepartment.ValueMember = "SubDepartmentID";
            cmbSubDepartment.DataSource = department.SubDepartments;
        }

        private void frmSalary_Loan_Request_Load(object sender, EventArgs e)
        {
            fillcmbBranch();
            fillcmbDepartment((Branch)cmbWorkingBranch.SelectedItem);
            fillcmbSubDepartment((Department)cmbDepartment.SelectedItem);
        }

        private void cmbWorkingBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillcmbDepartment((Branch)cmbWorkingBranch.SelectedItem);
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillcmbSubDepartment((Department)cmbDepartment.SelectedItem);
        }
        // check text boxes for proper values
        private String getIntNumaricValue(string title, string text)
        {
            int Value = 0;
            if (int.TryParse(text, out Value))
            {
                return "";
            }
            else
            {
                return title + " ";
            }

        }

        private bool checkforValues()
        {
            String erroetext = null;

            erroetext += getIntNumaricValue("*Requested Amount", txtRequested_Amount.Text);
            erroetext += getIntNumaricValue(" *Deduction Amount in Month ", txtDeductionAmountinMonth.Text);
            erroetext += getIntNumaricValue(" *Number of Month ", txtNumber_of_Month.Text);
            erroetext += getIntNumaricValue(" *Deduction Salary Period ", txtDeduction_Salary_Period.Text);

            if (txtTotalFromEPFSalary.Text != "")
            {
                erroetext += getIntNumaricValue(" *Toatal from EPF Salary", txtTotalFromEPFSalary.Text);
            }
            else if (txtDayWages.Text != "")
            {
                erroetext += getIntNumaricValue(" *Day Wages", txtDayWages.Text);

            }
            else if (txtFixedIncentiveAllowance.Text != "")
            {
                erroetext += getIntNumaricValue(" *Fixed Intencive Value", txtFixedIncentiveAllowance.Text);
            }
            else if (txtTotalFromEPFSalary.Text == "" && txtDayWages.Text == "" && txtFixedIncentiveAllowance.Text == "")
            {
                erroetext += getIntNumaricValue(" *Toatal from EPF Salary", txtTotalFromEPFSalary.Text);
                erroetext += getIntNumaricValue(" *Day Wages", txtDayWages.Text);
                erroetext += getIntNumaricValue(" *Fixed Intencive Value", txtFixedIncentiveAllowance.Text);
            }
            if (erroetext == "")
            {
                MessageBox.Show("done");
                return true;
            }
            else
            {
                MessageBox.Show("Please add Correct value to "+erroetext+"..!");
                return false;
            }
        }

        private void btnUpsate_Click(object sender, EventArgs e)
        {
            checkforValues();
        }

      
    }
}
