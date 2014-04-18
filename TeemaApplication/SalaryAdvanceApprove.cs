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
    public partial class frmSalary_Advance_Approve : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
        public frmSalary_Advance_Approve()
        {
            InitializeComponent();
        }           

        private void frmSalary_Advance_Load(object sender, EventArgs e)
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

        private bool checkforsalarymonth()
        {
            String errortext = null;
            errortext += EmployeeUtils.getIntNumaricValue(" *Year ", cmbYear.Text, true);

            if (!EmployeeUtils.checkIfContainText(cmbMonth))
            {
                errortext += " *Month";
            }
            if (errortext == "")
            {
                MessageBox.Show("Done");
                return true;
            }
            else
            {
                MessageBox.Show("Please Add Correct Value To " + errortext + "..!");
                return false;
            }

        }

        private string getEmptyInputsBeforeSubmit()
        {
            string EmptyTextBoxNames = string.Empty;

            EmptyTextBoxNames += EmployeeUtils.getIntNumaricValue("Request Amount", txtRequested_Amount.Text, true);
            EmptyTextBoxNames += EmployeeUtils.getIntNumaricValue("Total from EPF Salary", txtTotalFromEPFSalary.Text, true);
            EmptyTextBoxNames += EmployeeUtils.getIntNumaricValue("Day Wages", txtDayWages.Text, true);
            EmptyTextBoxNames += EmployeeUtils.getIntNumaricValue("Fixed Incentive Allowance", txtFixedIncentiveAllowance.Text, true);
            EmptyTextBoxNames += EmployeeUtils.getIntNumaricValue("Variable Incentive Allowance", txtVariableIncentiveAllowance.Text, true);

            return EmptyTextBoxNames;
        }
   

       

        private void btnApprove_Click(object sender, EventArgs e)
        {
            string emptyInput = getEmptyInputsBeforeSubmit();
            if (emptyInput != string.Empty)
            {
                emptyInput = emptyInput.Remove(emptyInput.Length - 2, 2);
                ShowMessageBox.ShowError("Please Enter Correct Value" + emptyInput + ".");
            }
            else
            {
                MessageBox.Show("Done");
            }
        }
                
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            checkforsalarymonth();

        }

       
    }
}
