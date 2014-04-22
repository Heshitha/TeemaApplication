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
                return true;
            }
            else
            {
                MessageBox.Show("Please Add Correct Value To " + errortext + "..!");
                return false;
            }
        } 

        private void btnApprove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gdvSalaryAdvance.Rows)
            {
                DataGridViewCheckBoxCell checkCell = row.Cells[4] as DataGridViewCheckBoxCell;
                bool IsApproved = (checkCell != null && checkCell.Value != null && true == (bool)checkCell.Value);

                int advanceID = Convert.ToInt32(row.Cells[2].Value);
                SalaryAdvance salAdv = db.SalaryAdvances.Where(sa => sa.SalaryAdvanceID == advanceID).SingleOrDefault();
                if (IsApproved)
                {
                    salAdv.IsApproved = true;
                    salAdv.ApprovedBy = 1;
                    salAdv.ApprovedDate = DateTime.Now;
                    salAdv.ModifiedBy = 1;
                    salAdv.ModifiedDate = DateTime.Now;
                }
                else
                {
                    salAdv.IsApproved = false;
                    salAdv.ApprovedBy = null;
                    salAdv.ApprovedDate = null;
                    salAdv.ModifiedBy = 1;
                    salAdv.ModifiedDate = DateTime.Now;
                }
                db.SubmitChanges();
            }
            ShowMessageBox.ShowSuccess("Successfully Saved.");
        }
                
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (checkforsalarymonth())
            {
                FillDataGridView();
            }
        }

        private void FillDataGridView()
        {
            bool unApprovedOnly = chbUnApprovedOnly.Checked;

            SubDepartment subDept = (SubDepartment)cmbSubDepartment.SelectedItem;

            DataTable dt = new DataTable();
            dt.Columns.Add("TokenNo");
            dt.Columns.Add("EmployeeName");
            dt.Columns.Add("advanceId");
            dt.Columns.Add("RequestedAmount");
            dt.Columns.Add("isApproved", typeof(bool));

            int year = Convert.ToInt32(cmbYear.Text);
            int month = cmbMonth.SelectedIndex + 1;

            foreach (Employee emp in subDept.Employees)
            {
                List<SalaryAdvance> salAdvances;

                if (unApprovedOnly)
                {
                    salAdvances = emp.SalaryAdvances.Where(sa => sa.Year == year && sa.Month == month && sa.IsApproved.Value == false).ToList();
                }
                else
                {
                    salAdvances = emp.SalaryAdvances.Where(sa => sa.Year == year && sa.Month == month).ToList();
                }

                foreach (SalaryAdvance sa in salAdvances)
                {
                    double totalAdvance = sa.TotalFromEPFSalary.Value + sa.DayWagesAmount.Value + sa.FixedIncentiveAmount.Value + sa.VariableIncentiveAmount.Value;
                    dt.Rows.Add(emp.TokenNo, emp.Name, sa.SalaryAdvanceID, totalAdvance, (sa.IsApproved.Value == true ? true : false));
                }
            }
            gdvSalaryAdvance.DataSource = dt;
        }

        private void txtRequested_Amount_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void gdvSalaryAdvance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int advanceID = Convert.ToInt32(gdvSalaryAdvance.Rows[e.RowIndex].Cells[2].Value);

                SalaryAdvance salAdv = db.SalaryAdvances.Where(sa => sa.SalaryAdvanceID == advanceID).SingleOrDefault();
                Employee emp = salAdv.Employee;

                txtEmployeeName.Text = emp.Name;
                txtDesignation.Text = emp.Designation.Designation1;
                txtNIC_No.Text = emp.NICNo;
                txtEPF_No.Text = emp.EPFNo;
                txtToken_No.Text = emp.TokenNo;

                txtCADTotalFrom.Text = salAdv.TotalFromEPFSalary.Value.ToString("0.00");
                txtCADDayWages.Text = salAdv.DayWagesAmount.Value.ToString("0.00");
                txtCADFixedInceniveAllowance.Text = salAdv.FixedIncentiveAmount.Value.ToString("0.00");
                txtCADVariableIncentiveAllowance.Text = salAdv.VariableIncentiveAmount.Value.ToString("0.00");
                txtCADRequestedDate.Text = salAdv.RequestedDate.Value.ToString("dd-MM-yyyy");
                txtCADAdvanceID.Text = salAdv.SalaryAdvanceID.ToString();
                txtCADTotalRequestAmount.Text = (salAdv.TotalFromEPFSalary.Value + salAdv.DayWagesAmount.Value + salAdv.FixedIncentiveAmount.Value + salAdv.VariableIncentiveAmount.Value).ToString("0.00");
            }
            catch (Exception)
            {
            }
        }

       
    }
}
