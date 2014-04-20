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
    public partial class frmSalary_Loan_Request : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
        public frmSalary_Loan_Request()
        {
            InitializeComponent();
        }

       

        private void frmSalary_Loan_Request_Load(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbWorkingBranch(db, cmbWorkingBranch);
            EmployeeUtils.fillcmbDepartment((Branch)cmbWorkingBranch.SelectedItem, cmbDepartment);
            EmployeeUtils.fillcmbSubDepartment((Department)cmbDepartment.SelectedItem, cmbSubDepartment);
        }

        private void cmbWorkingBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbDepartment((Branch)cmbWorkingBranch.SelectedItem, cmbDepartment);
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbSubDepartment((Department)cmbDepartment.SelectedItem, cmbSubDepartment);
        }        

        //private bool checkforValues()
        //{
        //    String erroetext = null;

        //    erroetext += getIntNumaricValue("*Requested Amount", txtRequested_Amount.Text);
        //    erroetext += getIntNumaricValue(" *Deduction Amount in Month ", txtDeductionAmountinMonth.Text);
        //    erroetext += getIntNumaricValue(" *Number of Month ", txtNumber_of_Month.Text);
        //    erroetext += getIntNumaricValue(" *Deduction Salary Period ", txtDeduction_Salary_Period.Text);

        //    if (txtTotalFromEPFSalary.Text != "")
        //    {
        //        erroetext += getIntNumaricValue(" *Toatal from EPF Salary", txtTotalFromEPFSalary.Text);
        //    }
        //    else if (txtDayWages.Text != "")
        //    {
        //        erroetext += getIntNumaricValue(" *Day Wages", txtDayWages.Text);

        //    }
        //    else if (txtFixedIncentiveAllowance.Text != "")
        //    {
        //        erroetext += getIntNumaricValue(" *Fixed Intencive Value", txtFixedIncentiveAllowance.Text);
        //    }
        //    else if (txtTotalFromEPFSalary.Text == "" && txtDayWages.Text == "" && txtFixedIncentiveAllowance.Text == "")
        //    {
        //        erroetext += getIntNumaricValue(" *Toatal from EPF Salary", txtTotalFromEPFSalary.Text);
        //        erroetext += getIntNumaricValue(" *Day Wages", txtDayWages.Text);
        //        erroetext += getIntNumaricValue(" *Fixed Intencive Value", txtFixedIncentiveAllowance.Text);
        //    }
            
        //    if (erroetext == "")
        //    {
        //        MessageBox.Show("done");
        //        return true;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please add Correct value to "+erroetext+"..!");
        //        return false;
        //    }
        //}

        private string getEmptyInputBeforeSubmit()
        {
            string EmptyTextBoxName = string.Empty;

            EmptyTextBoxName += EmployeeUtils.getIntNumaricValue(" Requested Amount ",txtRequested_Amount.Text,true);
            EmptyTextBoxName += EmployeeUtils.getIntNumaricValue(" Deduction Amount In Month ", txtDeductionAmountinMonth.Text, true);
            EmptyTextBoxName += EmployeeUtils.getIntNumaricValue(" Number of month ", txtNumber_of_Month.Text, true);
            EmptyTextBoxName += EmployeeUtils.getIntNumaricValue(" Deduction Salary Period ", txtDeduction_Salary_Period.Text, true);
            EmptyTextBoxName += EmployeeUtils.getIntNumaricValue(" Total From EPF Salary ", txtTotalFromEPFSalary.Text, true);
            EmptyTextBoxName += EmployeeUtils.getIntNumaricValue(" Day Wages ", txtDayWages.Text, true);
            EmptyTextBoxName += EmployeeUtils.getIntNumaricValue(" Fixed Incentive Allowance ", txtFixedIncentiveAllowance.Text, true);


            return EmptyTextBoxName;
        }

        private void btnUpsate_Click(object sender, EventArgs e)
        {
            string emptyInput = getEmptyInputBeforeSubmit();
            if (emptyInput != string.Empty)
            {
                emptyInput = emptyInput.Remove(emptyInput.Length - 2, 2);
                ShowMessageBox.ShowError(" Please Enter Correct Value " + emptyInput + " . ");
            }
            else
            {
                MessageBox.Show("Done");
            }
        }

      
    }
}
