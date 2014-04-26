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

        private string getEmptyInputBeforeSubmit()
        {
            string EmptyTextBoxName = string.Empty;

            EmptyTextBoxName += EmployeeUtils.getIntNumaricValue(" Requested Amount ",txtRequested_Amount.Text,true);
            EmptyTextBoxName += EmployeeUtils.getIntNumaricValue(" Deduction Amount In Month ", txtDeductionAmountinMonth.Text, true);
            EmptyTextBoxName += EmployeeUtils.getIntNumaricValue(" Number of month ", txtNumber_of_Month.Text, true);
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
                try
                {
                    string tokenNo = gdvLoanDetails.SelectedRows[0].Cells[0].Value.ToString();
                    Employee emp = db.Employees.Where(em => em.TokenNo.Equals(tokenNo)).SingleOrDefault();

                    bool hasUnfinishedLoan = false;
                    int unfinishedLoanId = 0;

                    foreach (SalaryLoan sl in (from x in emp.SalaryLoans where x.IsApproved.Value == true select x))
                    {
                        double installmentTotal = (from x in sl.SalaryLoanInstallments select x.Amount).Sum().Value;
                        if (installmentTotal < sl.RequestedAmount)
                        {
                            hasUnfinishedLoan = true;
                            unfinishedLoanId = sl.SalaryLoanID;
                        }
                    }

                    if (hasUnfinishedLoan)
                    {
                        ShowMessageBox.ShowError("You have unfinshed loan. Loan No : " + unfinishedLoanId + ".\r\nYou can only have one loan at a time. So please finish unfinished loans and request another loan.");
                    }
                    else
                    {
                        SalaryLoan salLoan = new SalaryLoan
                        {
                            Employee = emp,
                            RequestedAmount = EmployeeUtils.getDoubleValueFromTextBox(txtRequested_Amount),
                            RequestedDate = dtpStarting_Date.Value,
                            NoOfInstallment = EmployeeUtils.getIntValueFromTextBox(txtNumber_of_Month),
                            DayWagesAmount = EmployeeUtils.getDoubleValueFromTextBox(txtDayWages),
                            TotalFromEPFSalary = EmployeeUtils.getDoubleValueFromTextBox(txtTotalFromEPFSalary),
                            FixedIncentiveAmount = EmployeeUtils.getDoubleValueFromTextBox(txtFixedIncentiveAllowance),
                            IsApproved = false,
                            CreatedBy = 1,
                            CreatedDate = DateTime.Now,
                            ModifiedBy = 1,
                            ModifiedDate = DateTime.Now,
                        };

                        db.SalaryLoans.InsertOnSubmit(salLoan);
                        db.SubmitChanges();
                        ShowMessageBox.ShowSuccess("Successfully requested a loan.");
                    }
                }
                catch (Exception)
                {
                    ShowMessageBox.ShowError("Plese search for employees and select one from the list.");
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            fillLoanGridView();
        }

        private void fillLoanGridView()
        {
            bool Approved = chbApproved.Checked;
            bool Finished = chbFinished.Checked;
            bool unApproved = chbUnApproved.Checked;
            bool unFinished = chbUnFinished.Checked;

            if (!Approved && !unApproved && !unFinished && !Finished)
            {
                ShowMessageBox.ShowInformation("You haven't checked any filters before search. This will give you the employees who didn't requested any loans. If you want employees who have loans, Please check the check boxes.");
            }

            SubDepartment subDept = (SubDepartment)cmbSubDepartment.SelectedItem;
            DataTable dt = new DataTable();
            dt.Columns.Add("TokenNo");
            dt.Columns.Add("Name");
            dt.Columns.Add("LoanID");
            dt.Columns.Add("RequestedAmount");
            dt.Columns.Add("DeductionAmount");
            dt.Columns.Add("NumberOfMonth");
            dt.Columns.Add("IsApproved");

            foreach (Employee emp in subDept.Employees)
            {
                var salLoans = emp.SalaryLoans;
                if (salLoans.Count == 0)
                {
                    dt.Rows.Add(emp.TokenNo, emp.Name, "No Loan Requested.", "", "", "", "");
                }
                else
                {
                    foreach (SalaryLoan sl in salLoans)
                    {
                        bool isSlApproved = sl.IsApproved.Value;
                        bool isSlFinished = sl.RequestedAmount.Value <= (from x in sl.SalaryLoanInstallments select x.Amount).Sum().Value ? true : false;

                        double installmentAmount = (sl.TotalFromEPFSalary + sl.DayWagesAmount + sl.FixedIncentiveAmount).Value;

                        if (Approved && isSlApproved)
                        {
                            if (Finished && isSlFinished)
                            {
                                dt.Rows.Add(emp.TokenNo, emp.Name, sl.SalaryLoanID, sl.RequestedAmount, installmentAmount, sl.NoOfInstallment.Value, "True");
                            }
                            if (unFinished && !isSlFinished)
                            {
                                dt.Rows.Add(emp.TokenNo, emp.Name, sl.SalaryLoanID, sl.RequestedAmount, installmentAmount, sl.NoOfInstallment.Value, "True");
                            }
                        }

                        if (unApproved && !isSlApproved)
                        {
                            if (unFinished && !isSlFinished)
                            {
                                dt.Rows.Add(emp.TokenNo, emp.Name, sl.SalaryLoanID, sl.RequestedAmount, installmentAmount, sl.NoOfInstallment.Value, "False");
                            }
                        }
                    }
                }
            }

            gdvLoanDetails.DataSource = dt;
        }

        private void gdvLoanDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string tokenNo = gdvLoanDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                Employee emp = db.Employees.Where(em => em.TokenNo.Equals(tokenNo)).SingleOrDefault();

                if (emp != null)
                {
                    txtEmployeeName.Text = emp.Name;
                    txtDesignation.Text = emp.Designation.Designation1;
                    txtNIC_No.Text = emp.NICNo;
                    txtEPF_No.Text = emp.EPFNo;
                    txtToken_No.Text = emp.TokenNo;

                    if (!gdvLoanDetails.Rows[e.RowIndex].Cells[2].Value.ToString().Equals("No Loan Requested."))
                    {
                        int loanID = Convert.ToInt32(gdvLoanDetails.Rows[e.RowIndex].Cells[2].Value.ToString());
                        SalaryLoan salLoan = emp.SalaryLoans.Where(sl => sl.SalaryLoanID == loanID).SingleOrDefault();

                        txtCSLLoanID.Text = salLoan.SalaryLoanID.ToString();
                        txtCSLRequestedAmount.Text = salLoan.RequestedAmount.Value.ToString("0.00");
                        txtCSLStartingDate.Text = salLoan.RequestedDate.Value.ToString("dd-MM-yyyy");
                        txtCSLEpfSalary.Text = salLoan.TotalFromEPFSalary.Value.ToString("0.00");
                        txtCSLDayWages.Text = salLoan.DayWagesAmount.Value.ToString("0.00");
                        txtCSLFixedIncentiveAllowance.Text = salLoan.FixedIncentiveAmount.Value.ToString("0.00");
                        txtCSLInstallmentAmount.Text = (salLoan.TotalFromEPFSalary + salLoan.DayWagesAmount + salLoan.FixedIncentiveAmount).Value.ToString("0.00");
                        txtCSLNumberOfMonths.Text = salLoan.NoOfInstallment.Value.ToString();
                    }
                    else
                    {
                        resetCSLTextBoxes();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void resetCSLTextBoxes()
        {
            txtCSLLoanID.Text = string.Empty;
            txtCSLRequestedAmount.Text = string.Empty;
            txtCSLStartingDate.Text = string.Empty;
            txtCSLEpfSalary.Text = "0";
            txtCSLDayWages.Text = "0";
            txtCSLFixedIncentiveAllowance.Text = "0";
            txtCSLInstallmentAmount.Text = "0";
            txtCSLNumberOfMonths.Text = "0";
        }

        private void calculateInstallmentAmount()
        {
            try
            {
                double requestedAmount = EmployeeUtils.getDoubleValueFromTextBox(txtRequested_Amount);
                double fromEPFSalary = EmployeeUtils.getDoubleValueFromTextBox(txtTotalFromEPFSalary);
                double dayWages = EmployeeUtils.getDoubleValueFromTextBox(txtDayWages);
                double fixedIncentive = EmployeeUtils.getDoubleValueFromTextBox(txtFixedIncentiveAllowance);

                double totalDeduction = fromEPFSalary + dayWages + fixedIncentive;
                double realNoOfInstallment = requestedAmount / totalDeduction;
                int noOfInstallment = Convert.ToInt32(Math.Ceiling(realNoOfInstallment));

                txtDeductionAmountinMonth.Text = totalDeduction.ToString("0.00");
                txtNumber_of_Month.Text = noOfInstallment.ToString();
            }
            catch (Exception)
            {
                txtNumber_of_Month.Text = "0";
            }
        }

        private void txtTotalFromEPFSalary_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double FromEpfSalary = EmployeeUtils.getDoubleValueFromTextBox(txtTotalFromEPFSalary);

                string tokenNo = gdvLoanDetails.SelectedRows[0].Cells[0].Value.ToString();
                Employee emp = db.Employees.Where(em => em.TokenNo.Equals(tokenNo)).SingleOrDefault();

                if (emp.EmployeeSalaryDetail.TotalValueForEPF.Value < FromEpfSalary)
                {
                    ShowMessageBox.ShowError("You can not have deduction from EPF salary more than your current EPF salary. Maximum value you can have is " + emp.EmployeeSalaryDetail.TotalValueForEPF.Value.ToString("0.00"));
                    txtTotalFromEPFSalary.Text = emp.EmployeeSalaryDetail.TotalValueForEPF.Value.ToString();
                }

                calculateInstallmentAmount();
            }
            catch (Exception)
            {
                ShowMessageBox.ShowError("Plese search for employees and select one from the list.");
            }
        }

        private void txtRequested_Amount_TextChanged(object sender, EventArgs e)
        {
            calculateInstallmentAmount();
        }

        private void txtDayWages_TextChanged(object sender, EventArgs e)
        {
            calculateInstallmentAmount();
        }

        private void txtFixedIncentiveAllowance_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double fromFixedIncentive = EmployeeUtils.getDoubleValueFromTextBox(txtDayWages);

                string tokenNo = gdvLoanDetails.SelectedRows[0].Cells[0].Value.ToString();
                Employee emp = db.Employees.Where(em => em.TokenNo.Equals(tokenNo)).SingleOrDefault();

                double fixedIncentiveTotal = (from x in emp.FixedIncentives select x.InventiveValue).Sum().Value;
                if (fromFixedIncentive > fixedIncentiveTotal)
                {
                    ShowMessageBox.ShowError("You can not have deduction from fixed incentives more than your current fixed incentives. Maximum value you can have is " + fixedIncentiveTotal.ToString("0.00"));
                    txtFixedIncentiveAllowance.Text = fixedIncentiveTotal.ToString("0.00");
                }
                calculateInstallmentAmount();
            }
            catch (Exception)
            {
                ShowMessageBox.ShowError("Plese search for employees and select one from the list.");
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void resetForm()
        {
            chbApproved.Checked = true;
            chbFinished.Checked = true;
            chbUnApproved.Checked = true;
            chbUnFinished.Checked = true;

            txtEmployeeName.Text = string.Empty;
            txtDesignation.Text = string.Empty;
            txtNIC_No.Text = string.Empty;
            txtEPF_No.Text = string.Empty;
            txtToken_No.Text = string.Empty;

            resetCSLTextBoxes();

            txtRequested_Amount.Text = "0";
            txtTotalFromEPFSalary.Text = "0";
            txtDayWages.Text = "0";
            txtFixedIncentiveAllowance.Text = "0";
            txtDeductionAmountinMonth.Text = "0";
            txtNumber_of_Month.Text = "0";

            fillLoanGridView();
        }
    }
}
