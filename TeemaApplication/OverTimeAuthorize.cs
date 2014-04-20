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
    public partial class frmOverTimeAuthorize : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
        public frmOverTimeAuthorize()
        {
            InitializeComponent();
        }

        private void frmOverTimeAuthorize_Load(object sender, EventArgs e)
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

        private void FillOvertimeGridView()
        {
            try
            {
                SubDepartment subDept = (SubDepartment)cmbSubDepartment.SelectedItem;

                DataTable dt = new DataTable();
                dt.Columns.Add("Authorize", typeof(bool));
                dt.Columns.Add("Approve");
                dt.Columns.Add("TokenNo");
                dt.Columns.Add("EPFNo");
                dt.Columns.Add("EmployeeName");
                dt.Columns.Add("Date", typeof(DateTime));
                dt.Columns.Add("Type");
                dt.Columns.Add("OTHours");

                foreach (Employee emp in subDept.Employees)
                {
                    List<OverTime> OverTimeList;
                    if (chbUnAuthorizedOnly.Checked)
                    {
                        OverTimeList = emp.OverTimes.Where(ot => ot.OverTImeAuthorizedDept == null && ot.OverTimeApprovedDept != null).ToList();
                    }
                    else
                    {
                        OverTimeList = emp.OverTimes.Where(ot => ot.OverTimeApprovedDept != null).ToList();
                    }

                    foreach (OverTime ot in OverTimeList)
                    {
                        TimeSpan ts = ot.OverTimeTo.Value.Subtract(ot.OverTImeFrom.Value);

                        bool isAuthorized = ot.OverTImeAuthorizedDept == null ? false : true;

                        dt.Rows.Add(isAuthorized, ot.OverTimeApprovedDept, emp.TokenNo, emp.EPFNo, emp.Name, ot.OverTimeDate.Value, ot.OverTimeCategory.Value, ts.Hours.ToString("0.00"));
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillOvertimeGridView();
        }

        private void gdvOver_Time_Request_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string tokenNo = gdvOver_Time_Request.Rows[e.RowIndex].Cells[2].Value.ToString();
                DateTime overtimeDate = Convert.ToDateTime(gdvOver_Time_Request.Rows[e.RowIndex].Cells[5].Value);

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
            catch (Exception)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in gdvOver_Time_Request.Rows)
                {
                    DataGridViewCheckBoxCell checkCell = row.Cells[0] as DataGridViewCheckBoxCell;
                    bool IsAuthorized = (checkCell != null && checkCell.Value != null && true == (bool)checkCell.Value);

                    string tokenNo = row.Cells[2].Value.ToString();
                    DateTime overtimeDate = Convert.ToDateTime(row.Cells[5].Value);

                    Employee emp = db.Employees.Where(em => em.TokenNo.Equals(tokenNo)).SingleOrDefault();
                    OverTime overtime = emp.OverTimes.Where(ot => ot.OverTimeDate.Equals(overtimeDate)).SingleOrDefault();

                    if (IsAuthorized)
                    {
                        overtime.OverTImeAuthorizedDept = 1;
                    }
                    else
                    {
                        overtime.OverTImeAuthorizedDept = null;
                    }
                    db.SubmitChanges();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
