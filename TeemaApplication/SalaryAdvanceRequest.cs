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
        Employee employee;
        int year;
        int month;

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

                EmptyTextBoxNames += EmployeeUtils.getDoubleNumaricValue("Request Amount", txtRequested_Amount.Text, true);
                EmptyTextBoxNames += EmployeeUtils.getDoubleNumaricValue("Total from EPF Salary", txtTotalFromEPFSalary.Text, true);
                EmptyTextBoxNames += EmployeeUtils.getDoubleNumaricValue("Day Wages", txtDayWages.Text, true);
                EmptyTextBoxNames += EmployeeUtils.getDoubleNumaricValue("Fixed Incentive Allowance", txtFixedIncentiveAllowance.Text, true);
                EmptyTextBoxNames += EmployeeUtils.getDoubleNumaricValue("Variable Incentive Allowance", txtVariableIncentiveAllowance.Text, true);

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
                Employee emp = db.Employees.Where(em => em.TokenNo == txtToken_No.Text).SingleOrDefault();
                if (emp != null)
                {
                    SalaryAdvance salAdv = new SalaryAdvance
                    {
                        Employee = emp,
                        RequestedDate = DateTime.Today,
                        Year = Convert.ToInt32(cmbYear.Text),
                        Month = cmbMonth.SelectedIndex+1,
                        TotalFromEPFSalary = EmployeeUtils.getDoubleValueFromTextBox(txtTotalFromEPFSalary),
                        DayWagesAmount = EmployeeUtils.getDoubleValueFromTextBox(txtDayWages),
                        FixedIncentiveAmount = EmployeeUtils.getDoubleValueFromTextBox(txtFixedIncentiveAllowance),
                        VariableIncentiveAmount = EmployeeUtils.getDoubleValueFromTextBox(txtVariableIncentiveAllowance),
                        IsApproved = false,
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now,
                        ModifiedBy = 1,
                        ModifiedDate = DateTime.Now
                    };

                    db.SalaryAdvances.InsertOnSubmit(salAdv);
                    db.SubmitChanges();
                    ShowMessageBox.ShowSuccess("Successfully Requested Advance.");
                    resetFormControls();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkforsalarymonth())
            {
                FillDataGridView();
            }
        }

        private void FillDataGridView()
        {
            SubDepartment subDept = (SubDepartment)cmbSubDepartment.SelectedItem;

            DataTable dt = new DataTable();
            dt.Columns.Add("TokenNo");
            dt.Columns.Add("EmployeeName");
            dt.Columns.Add("advanceId");
            dt.Columns.Add("isApproved");
            dt.Columns.Add("RequestedAmount");

           year = Convert.ToInt32(cmbYear.Text);
           month = cmbMonth.SelectedIndex + 1;

            foreach (Employee emp in subDept.Employees)
            {
                var salAdvances = emp.SalaryAdvances.Where(sa => sa.Year == year && sa.Month == month);

                if (salAdvances.Count() != 0)
                {
                    foreach (SalaryAdvance sa in salAdvances)
                    {
                        double totalAdvance = sa.TotalFromEPFSalary.Value + sa.DayWagesAmount.Value + sa.FixedIncentiveAmount.Value + sa.VariableIncentiveAmount.Value;
                        dt.Rows.Add(emp.TokenNo, emp.Name, sa.SalaryAdvanceID, (sa.IsApproved.Value == true ? true : false).ToString(), totalAdvance);
                    }
                }
                else
                {
                    dt.Rows.Add(emp.TokenNo, emp.Name, "No Advance Requested.", "", "");
                }
            }
            gdvSalaryAdvance.DataSource = dt;
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
            try
            {
                double TotalEPFSalary = employee.EmployeeSalaryDetail.TotalValueForEPF.Value;

                SalaryLoan salLoan = employee.SalaryLoans.Where(sl => sl.IsApproved.Value == true && (sl.RequestedAmount > (from x in sl.SalaryLoanInstallments select x.Amount).Sum().Value)).SingleOrDefault();

                double loanDeductionFromEPFSalary = salLoan != null ? salLoan.TotalFromEPFSalary.Value : 0;

                double previousSalaryAdvancesValue = (from x in employee.SalaryAdvances
                                                      where x.Year == year && x.Month == month && x.IsApproved == true
                                                      select x.TotalFromEPFSalary).Sum().Value;
                double advanceTotalSalary = EmployeeUtils.getDoubleValueFromTextBox(txtTotalFromEPFSalary);

                TotalEPFSalary -= loanDeductionFromEPFSalary;

                if (TotalEPFSalary >= (advanceTotalSalary + previousSalaryAdvancesValue))
                {
                    calculateTotalRequestedAmount();
                }
                else if (TotalEPFSalary < advanceTotalSalary)
                {
                    ShowMessageBox.ShowError("Deduction value from Total EPF salary should be less than Total EPF Salary after deduction any loan installments.");
                    txtTotalFromEPFSalary.Text = "0";
                }
                else if (TotalEPFSalary < (advanceTotalSalary + previousSalaryAdvancesValue))
                {
                    double remainingFromTotalEPFSalary = TotalEPFSalary - previousSalaryAdvancesValue;
                    ShowMessageBox.ShowError("You have already deduct " + previousSalaryAdvancesValue.ToString("0.00") + " from your EPF salary. Remaining balance from EPF salary  after deduction any loan installments is " + remainingFromTotalEPFSalary.ToString("0.00"));
                    txtTotalFromEPFSalary.Text = remainingFromTotalEPFSalary.ToString();
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void txtDayWages_TextChanged(object sender, EventArgs e)
        {
            calculateTotalRequestedAmount();
        }

        private void txtFixedIncentiveAllowance_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double totalFixedIncentives = (from x in employee.FixedIncentives
                                               select x.InventiveValue).Sum().Value;

                SalaryLoan salLoan = employee.SalaryLoans.Where(sl => sl.IsApproved.Value == true && (sl.RequestedAmount > (from x in sl.SalaryLoanInstallments select x.Amount).Sum().Value)).SingleOrDefault();

                double deductionForLoanFromFixedIncentives = salLoan != null ? salLoan.DayWagesAmount.Value : 0;

                totalFixedIncentives -= deductionForLoanFromFixedIncentives;

                double previousSalaryAdvancesValue = (from x in employee.SalaryAdvances
                                                      where x.Year == year && x.Month == month && x.IsApproved == true
                                                      select x.FixedIncentiveAmount).Sum().Value;
                double advanceFixedIncentive = EmployeeUtils.getDoubleValueFromTextBox(txtFixedIncentiveAllowance);
                if (totalFixedIncentives >= (advanceFixedIncentive + previousSalaryAdvancesValue))
                {
                    calculateTotalRequestedAmount();
                }
                else if (totalFixedIncentives <= advanceFixedIncentive)
                {
                    ShowMessageBox.ShowError("Deduction value from Fixed Incentive should be less than Total Fixed Incentive Value after deduction any loan installments.");
                    txtFixedIncentiveAllowance.Text = "0";
                }
                else if (totalFixedIncentives <= (advanceFixedIncentive + previousSalaryAdvancesValue))
                {
                    double remainingFromTotalEPFSalary = totalFixedIncentives - previousSalaryAdvancesValue;
                    ShowMessageBox.ShowError("You have already deduct " + previousSalaryAdvancesValue.ToString("0.00") + " from your Fixed Incentives. Remaining balance from Fixed Incentive Total after deduction any loan installments is " + remainingFromTotalEPFSalary.ToString("0.00"));
                    txtFixedIncentiveAllowance.Text = remainingFromTotalEPFSalary.ToString();
                }
            }
            catch (Exception)
            {
                
            }
            
        }

        private void txtVariableIncentiveAllowance_TextChanged(object sender, EventArgs e)
        {
            calculateTotalRequestedAmount();
        }

        private void gdvSalaryAdvance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string tokenNo = gdvSalaryAdvance.Rows[e.RowIndex].Cells[0].Value.ToString();
                Employee emp = db.Employees.Where(em => em.TokenNo == tokenNo).SingleOrDefault();
                employee = emp;

                if (emp != null)
                {
                    txtEmployeeName.Text = emp.Name;
                    txtDesignation.Text = emp.Designation.Designation1;
                    txtNIC_No.Text = emp.NICNo;
                    txtEPF_No.Text = emp.EPFNo;
                    txtToken_No.Text = emp.TokenNo;
                }

                string salAdvID = gdvSalaryAdvance.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (salAdvID != "No Advance Requested.")
                {
                    int salaryAdvanceID = Convert.ToInt32(salAdvID);
                    SalaryAdvance salAdvance = db.SalaryAdvances.Where(sa => sa.SalaryAdvanceID == salaryAdvanceID).SingleOrDefault();

                    txtCADAdvanceID.Text = salAdvance.SalaryAdvanceID.ToString();
                    txtCADRequestedDate.Text = salAdvance.RequestedDate.Value.ToString("dd-MM-yyyy");
                    txtCADTotalFrom.Text = salAdvance.TotalFromEPFSalary.Value.ToString("0.00");
                    txtCADDayWages.Text = salAdvance.DayWagesAmount.Value.ToString("0.00");
                    txtCADFixedInceniveAllowance.Text = salAdvance.FixedIncentiveAmount.Value.ToString("0.00");
                    txtCADVariableIncentiveAllowance.Text = salAdvance.VariableIncentiveAmount.Value.ToString("0.00");
                    txtCADTotalRequestAmount.Text = (salAdvance.TotalFromEPFSalary.Value + salAdvance.DayWagesAmount.Value + salAdvance.FixedIncentiveAmount.Value + salAdvance.VariableIncentiveAmount.Value).ToString("0.00");

                }
                else
                {
                    resetCreatedAdvanceDetails();
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void resetCreatedAdvanceDetails()
        {
            txtCADAdvanceID.Text = "";
            txtCADDayWages.Text = "";
            txtCADFixedInceniveAllowance.Text = "";
            txtCADRequestedDate.Text = "";
            txtCADTotalFrom.Text = "";
            txtCADTotalRequestAmount.Text = "";
            txtCADVariableIncentiveAllowance.Text = "";
        }

        private void resetFormControls()
        {
            txtEmployeeName.Text = "";
            txtDesignation.Text = "";
            txtNIC_No.Text = "";
            txtEPF_No.Text = "";
            txtToken_No.Text = "";

            resetAddNewSalaryAdvance();
            
            resetCreatedAdvanceDetails();

            FillDataGridView();
        }

        private void resetAddNewSalaryAdvance()
        {
            txtTotalFromEPFSalary.Text = "0";
            txtDayWages.Text = "0";
            txtFixedIncentiveAllowance.Text = "0";
            txtVariableIncentiveAllowance.Text = "0";
            txtRequested_Amount.Text = "0";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetAddNewSalaryAdvance();
        }
    }
}
