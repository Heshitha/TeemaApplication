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
    public partial class frmSalaryLoanApproved : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
        public frmSalaryLoanApproved()
        {
            InitializeComponent();
        }

       

        private void frmSalaryLoanApproved_Load(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbWorkingBranch(db, cmbWorkingBranch);
            EmployeeUtils.fillcmbDepartment((Branch)cmbWorkingBranch.SelectedItem, cmbDepartment);
            EmployeeUtils.fillcmbSubDepartment((Department)cmbDepartment.SelectedItem, cmbSubDepartment);
        }

        private void cmbWorkingBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbDepartment((Branch)cmbWorkingBranch.SelectedItem,cmbDepartment);
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbSubDepartment((Department)cmbDepartment.SelectedItem,cmbSubDepartment);
        }

        private string getEmptyInputsBeforeSubmit()
        {
            string EmptyTextBoxNames = string.Empty;

            EmptyTextBoxNames += EmployeeUtils.getIntNumaricValue(" Requested Amount ", txtRequested_Amount.Text, true);
            EmptyTextBoxNames += EmployeeUtils.getIntNumaricValue(" Deduction Amount in Month ", txtDeductionAmountinMonth.Text, true);
            EmptyTextBoxNames += EmployeeUtils.getIntNumaricValue(" Number of Month ", txtNumber_of_Month.Text, true);
            EmptyTextBoxNames += EmployeeUtils.getIntNumaricValue(" Deduction Salary Period ", txtDeduction_Salary_Period.Text, true);
            EmptyTextBoxNames += EmployeeUtils.getIntNumaricValue(" Total From EPF Salary ",txtTotalFromEPFSalary.Text,true);
            EmptyTextBoxNames += EmployeeUtils.getIntNumaricValue(" Day Wages ", txtDayWages.Text, true);
            EmptyTextBoxNames += EmployeeUtils.getIntNumaricValue(" Fixed Incentive Allowance ", txtFixedIncentiveAllowance.Text, true);
           

            return EmptyTextBoxNames;
        }
        
     
   
       
        private void btnApproved_Click(object sender, EventArgs e)
        {
            string emptyInput = getEmptyInputsBeforeSubmit();
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
