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
    public partial class frmSalaryAdvanceRequest : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
        public frmSalaryAdvanceRequest()
        {
            InitializeComponent();
        }

       
        private void frmSalaryAdvanceRequest_Load(object sender, EventArgs e)
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
                errortext += EmployeeUtils.getIntNumaricValue(" *Year ", cmbYear.Text,true);

                if (!EmployeeUtils.checkIfContainText(cmbMonth))
                {
                    errortext +=" *Month";
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

                EmptyTextBoxNames += EmployeeUtils.getIntNumaricValue("Request Amount",txtRequested_Amount.Text,true);
                EmptyTextBoxNames += EmployeeUtils.getIntNumaricValue("Total from EPF Salary", txtTotalFromEPFSalary.Text, true);
                EmptyTextBoxNames += EmployeeUtils.getIntNumaricValue("Day Wages", txtDayWages.Text, true);
                EmptyTextBoxNames += EmployeeUtils.getIntNumaricValue("Fixed Incentive Allowance", txtFixedIncentiveAllowance.Text, true);
                EmptyTextBoxNames += EmployeeUtils.getIntNumaricValue("Variable Incentive Allowance",txtVariableIncentiveAllowance.Text, true);

                return EmptyTextBoxNames;
            }
        

        private void btnUpsate_Click(object sender, EventArgs e)
        {
            string emptyInput = getEmptyInputsBeforeSubmit();
            if (emptyInput != string.Empty)
            {
                emptyInput = emptyInput.Remove(emptyInput.Length - 2, 2);
                ShowMessageBox.ShowError("Please Enter Correct Value " + emptyInput + ".");
            }
            else
            {
                MessageBox.Show("Done");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkforsalarymonth())
            {
                SubDepartment subDept = (SubDepartment)cmbSubDepartment.SelectedItem;

                DataTable dt = new DataTable();
                dt.Columns.Add("TokenNo");
                dt.Columns.Add("EPFNo");
                dt.Columns.Add("EmployeeName");
                dt.Columns.Add("RequestedAmount");

                int year = Convert.ToInt32(cmbYear.Text);
                int month = cmbMonth.SelectedIndex + 1;

                foreach (Employee emp in subDept.Employees)
                {
                    var salAdvances = emp.SalaryAdvances.Where(sa => sa.Year == year && sa.Month == month);

                    if (salAdvances.Count() != 0)
                    {
                        foreach (SalaryAdvance sa in salAdvances)
                        {
                            double totalAdvance = sa.TotalFromEPFSalary.Value + sa.DayWagesAmount.Value + sa.FixedIncentiveAmount.Value + sa.VariableIncentiveAmount.Value;
                            dt.Rows.Add(emp.TokenNo, emp.EPFNo, emp.Name, totalAdvance);
                        }
                    }
                    else
                    {
                        dt.Rows.Add(emp.TokenNo, emp.EPFNo, emp.Name, "No Advance Requested.");
                    }
                }
                gdvSalaryAdvance.DataSource = dt;
            }
        }

        private void calculateTotalRequestedAmount()
        {
            double epfSalary = EmployeeUtils.getDoubleValueFromTextBox(txtTotalFromEPFSalary);
            double dayWages = EmployeeUtils.getDoubleValueFromTextBox(txtDayWages);
            double fixedIncentive = EmployeeUtils.getDoubleValueFromTextBox(txtFixedIncentiveAllowance);
            double variableIncentive = EmployeeUtils.getDoubleValueFromTextBox(txtVariableIncentiveAllowance);

            double totalRequestedAmount = epfSalary + dayWages + fixedIncentive + variableIncentive;
            txtRequested_Amount.Text = totalRequestedAmount.ToString("0.00");
        }

        private void txtTotalFromEPFSalary_TextChanged(object sender, EventArgs e)
        {
            calculateTotalRequestedAmount();
        }

        private void txtDayWages_TextChanged(object sender, EventArgs e)
        {
            calculateTotalRequestedAmount();
        }

        private void txtFixedIncentiveAllowance_TextChanged(object sender, EventArgs e)
        {
            calculateTotalRequestedAmount();
        }

        private void txtVariableIncentiveAllowance_TextChanged(object sender, EventArgs e)
        {
            calculateTotalRequestedAmount();
        }
    }
}
