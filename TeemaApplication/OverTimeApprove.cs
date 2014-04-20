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
    public partial class frmOver_Time_Approve : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
        public frmOver_Time_Approve()
        {
            InitializeComponent();
        }
        
        private void frmOver_Time_Approve_Load(object sender, EventArgs e)
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


        private bool checkforvalues()
        {
            String errortext = null;

            errortext += EmployeeUtils.getIntNumaricValue(" *Over Time Hours ", txtOver_Time_Hours.Text, true);

            if (!EmployeeUtils.checkIfContainText(txtReason))
            {
                errortext += " *Reason";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            checkforvalues();

            foreach (DataGridViewRow row in gdvOver_Time_Request.Rows)
            {
                DataGridViewCheckBoxCell checkCell = row.Cells[0] as DataGridViewCheckBoxCell;

                bool IsApproved = (checkCell != null && checkCell.Value != null && true == (bool)checkCell.Value);

                string tokenNo = row.Cells[1].Value.ToString();
                DateTime overtimeDate = Convert.ToDateTime(row.Cells[4].Value);

                Employee emp = db.Employees.Where(em => em.TokenNo.Equals(tokenNo)).SingleOrDefault();
                OverTime overtime = emp.OverTimes.Where(ot => ot.OverTimeDate.Equals(overtimeDate)).SingleOrDefault();

                if (IsApproved)
                {
                    overtime.OverTimeApprovedDept = 1;
                }
                else
                {
                    overtime.OverTimeApprovedDept = null;
                }
                db.SubmitChanges();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillOvertimeGridView();
        }

        private void cmbSubDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FillOvertimeGridView()
        {
            try
            {
                SubDepartment subDept = (SubDepartment)cmbSubDepartment.SelectedItem;

                DataTable dt = new DataTable();
                dt.Columns.Add("Approve", typeof(bool));
                dt.Columns.Add("TokenNo");
                dt.Columns.Add("EPFNo");
                dt.Columns.Add("EmployeeName");
                dt.Columns.Add("Date", typeof(DateTime));
                dt.Columns.Add("Type");
                dt.Columns.Add("OTHours");

                foreach (Employee emp in subDept.Employees)
                {
                    var OverTimeList = emp.OverTimes;
                    foreach (OverTime ot in OverTimeList)
                    {
                        TimeSpan ts = ot.OverTimeTo.Value.Subtract(ot.OverTImeFrom.Value);

                        bool isApproved = ot.OverTimeApprovedDept == null ? true : false;

                        dt.Rows.Add(isApproved, emp.TokenNo, emp.EPFNo, emp.Name, ot.OverTimeDate.Value, ot.OverTimeCategory.Value, ts.Hours.ToString("0.00"));
                    }
                }

                DataView dv = dt.DefaultView;
                dv.Sort = "Date desc";
                DataTable sortedDt = dv.ToTable();

                gdvOver_Time_Request.DataSource = sortedDt;
            }
            catch (Exception)
            {
                ShowMessageBox.ShowError("Something went wrong while loading. Please contact administrator.");
            }
        }

        private void gdvOver_Time_Request_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tokenNo = gdvOver_Time_Request.Rows[e.RowIndex].Cells[1].Value.ToString();
            DateTime overtimeDate = Convert.ToDateTime(gdvOver_Time_Request.Rows[e.RowIndex].Cells[4].Value);

            Employee emp = db.Employees.Where(em => em.TokenNo.Equals(tokenNo)).SingleOrDefault();
            OverTime overtime = emp.OverTimes.Where(ot => ot.OverTimeDate.Equals(overtimeDate)).SingleOrDefault();

            if (overtime != null)
            { 
                dtpOver_Time_Date.Value = overtime.OverTimeDate.Value;
                txtStartAt.Text = overtime.OverTImeFrom.Value.ToShortTimeString();
                txtEndAt.Text = overtime.OverTimeTo.Value.ToShortTimeString();
                int otType = overtime.OverTimeCategory.Value;
                if (otType == 1)
                {
                    rdbSingle.Checked = true;
                }
                else if (otType == 2)
                {
                    rdbDouble.Checked = true;
                }
                else
                {
                    rdbTreble.Checked = true;
                }
                TimeSpan ts = overtime.OverTimeTo.Value.Subtract(overtime.OverTImeFrom.Value);
                txtOver_Time_Hours.Text = ts.TotalHours.ToString("0.00");
                txtReason.Text = overtime.OverTimeReason;
            }
        }

        private void gdvOver_Time_Request_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // if (e.ColumnIndex == 0)
           // {
           //     DataGridViewCheckBoxCell checkCell = gdvOver_Time_Request.Rows[e.RowIndex].Cells[0] as DataGridViewCheckBoxCell;
           //
           //     bool IsApproved = (checkCell != null && checkCell.Value != null && true == (bool)checkCell.Value);
           //
           //     string tokenNo = gdvOver_Time_Request.Rows[e.RowIndex].Cells[1].Value.ToString();
           //     DateTime overtimeDate = Convert.ToDateTime(gdvOver_Time_Request.Rows[e.RowIndex].Cells[4].Value);
           //
           //     Employee emp = db.Employees.Where(em => em.TokenNo.Equals(tokenNo)).SingleOrDefault();
           //     OverTime overtime = emp.OverTimes.Where(ot => ot.OverTimeDate.Equals(overtimeDate)).SingleOrDefault();
           //
           //     if (IsApproved)
           //     {
           //         overtime.OverTimeApprovedDept = 1;
           //     }
           //     else
           //     {
           //         overtime.OverTimeApprovedDept = null;
           //     }
           //     db.SubmitChanges();
           // }
        }

        private void gdvOver_Time_Request_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gdvOver_Time_Request_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    if (e.ColumnIndex == 0)
            //    {
            //        DataGridViewCheckBoxCell checkCell = gdvOver_Time_Request.Rows[e.RowIndex].Cells[0] as DataGridViewCheckBoxCell;

            //        bool IsApproved = (checkCell != null && checkCell.Value != null && true == (bool)checkCell.Value);

            //        string tokenNo = gdvOver_Time_Request.Rows[e.RowIndex].Cells[1].Value.ToString();
            //        DateTime overtimeDate = Convert.ToDateTime(gdvOver_Time_Request.Rows[e.RowIndex].Cells[4].Value);

            //        Employee emp = db.Employees.Where(em => em.TokenNo.Equals(tokenNo)).SingleOrDefault();
            //        OverTime overtime = emp.OverTimes.Where(ot => ot.OverTimeDate.Equals(overtimeDate)).SingleOrDefault();

            //        if (IsApproved)
            //        {
            //            overtime.OverTimeApprovedDept = 1;
            //        }
            //        else
            //        {
            //            overtime.OverTimeApprovedDept = null;
            //        }
            //        db.SubmitChanges();
            //    }
            //}
            //catch (Exception)
            //{
                
            //}
        }
    }
}
