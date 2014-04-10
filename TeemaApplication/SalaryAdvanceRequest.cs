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
    public partial class frmSalaryAdvanceRequest : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
        public frmSalaryAdvanceRequest()
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
        private void frmSalaryAdvanceRequest_Load(object sender, EventArgs e)
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

            private bool checkforsalarymonth()
            {
                String errortext = null;
                errortext += getIntNumaricValue(" *Year ", cmbYear.Text);

                if (cmbMonth.Text.Equals(string.Empty))
                {
                    errortext +=" *Month";
                }


                if (errortext == "")
                {
                    MessageBox.Show("done");
                    return true;
                }
                else
                {
                    MessageBox.Show("Please Add Correct Value To " + errortext + "..!");
                    return false;
                }

            }

        private bool checkforValues()
        {
            String errortext = null;
            errortext += getIntNumaricValue(" *Requested Amount", txtRequested_Amount.Text);
           

            // check text boxes Deduction From

            if (txtTotalFromEPFSalary.Text != "")
            {
                errortext += getIntNumaricValue(" *Total From EPF Salary", txtTotalFromEPFSalary.Text);
            }
            else if (txtDayWages.Text != "")
            {
                errortext += getIntNumaricValue(" *Day Wages", txtDayWages.Text);
            }
            else if (txtFixedIncentiveAllowance.Text != "")
            {
                errortext += getIntNumaricValue(" *Fixed Intencive Value", txtFixedIncentiveAllowance.Text);
            }
            else if (txtVariableIncentiveAllowance.Text != "")
            {
                errortext += getIntNumaricValue(" * Variable Incentive Allowance", txtVariableIncentiveAllowance.Text);
            }
            else if (txtTotalFromEPFSalary.Text == "" && txtDayWages.Text == "" && txtFixedIncentiveAllowance.Text == "" && txtVariableIncentiveAllowance.Text == "")
            {
                errortext += getIntNumaricValue(" *Toatal from EPF Salary", txtTotalFromEPFSalary.Text);
                errortext += getIntNumaricValue(" *Day Wages", txtDayWages.Text);
                errortext += getIntNumaricValue(" *Fixed Intencive Value", txtFixedIncentiveAllowance.Text);
                errortext += getIntNumaricValue(" *Variable Incentive Allowance", txtVariableIncentiveAllowance.Text);
            }


            if (errortext == "")
            {
                MessageBox.Show("done");
                return true;
            }
            else
            {
                MessageBox.Show("Please Add Correct Value To "+errortext+"..!");
                return false;
            }

           

        }

        private void btnUpsate_Click(object sender, EventArgs e)
        {
            checkforValues();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            checkforsalarymonth();
        }
    }
}
