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
    public partial class frmOver_Time_Request : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
        public frmOver_Time_Request()
        {
            InitializeComponent();
        }       

        private void frmOver_Time_Request_Load(object sender, EventArgs e)
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

            errortext += EmployeeUtils.getDoubleNumaricValue(" *Over Time Hours ",txtOver_Time_Hours.Text,true);

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
                MessageBox.Show("Please Add Correct Value To "+errortext+"..!");
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            checkforvalues();

            DateTime selectedDate = dtpOver_Time_Date.Value;
            DateTime correctedDate = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day);

            SubDepartment subDept = (SubDepartment)cmbSubDepartment.SelectedItem;

            foreach (Employee emp in subDept.Employees)
            {
                OverTime overtime = emp.OverTimes.Where(ot => ot.OverTimeDate == correctedDate).SingleOrDefault();
                if (overtime != null)
                {
                    db.OverTimes.DeleteOnSubmit(overtime);
                }
            }
            db.SubmitChanges();

            int StartingHour = EmployeeUtils.getIntNumaricValue("Overtime Starting From HH", dudFromHH.Text);
            int StartingMinutes = EmployeeUtils.getIntNumaricValue("Overtime Starting From MM", dudFromMM.Text);
            int EndHour = EmployeeUtils.getIntNumaricValue("Overtime End HH", dudToHH.Text);
            int EndMinutes = EmployeeUtils.getIntNumaricValue("Overtime End MM", dudToMM.Text);

            DateTime OTStart = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, StartingHour, StartingMinutes, 0);
            DateTime OTEnd = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, EndHour, EndMinutes, 0);

            int overTimeType = 0;
            if (rdbSingle.Checked)
            {
                overTimeType = 1;
            }
            else if (rdbDouble.Checked)
            {
                overTimeType = 2;
            }
            else
            {
                overTimeType = 3;
            }

            foreach (DataGridViewRow row in gdvOver_Time_Request.Rows)
            {
                bool isEntitled = Convert.ToBoolean(row.Cells[0].Value);
                if (isEntitled)
                {
                    string tokenNo = row.Cells[1].Value.ToString();
                    Employee emp = db.Employees.Where(em => em.TokenNo.Equals(tokenNo)).SingleOrDefault();
                    OverTime overtime = new OverTime
                    {
                        Employee = emp,
                        OverTimeDate = correctedDate,
                        OverTImeFrom = OTStart,
                        OverTimeTo = OTEnd,
                        OverTimeCategory = overTimeType,
                        OverTimeReason = txtReason.Text,
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now,
                        ModifiedBy = 1,
                        ModifiedDate = DateTime.Now
                    };
                    db.OverTimes.InsertOnSubmit(overtime);
                }
            }
            db.SubmitChanges();
        }

        private void CalculateOTHours()
        {
            try
            {
                int StartingHour = EmployeeUtils.getIntNumaricValue("Overtime Starting From HH", dudFromHH.Text);
                int StartingMinutes = EmployeeUtils.getIntNumaricValue("Overtime Starting From MM", dudFromMM.Text);
                int EndHour = EmployeeUtils.getIntNumaricValue("Overtime End HH", dudToHH.Text);
                int EndMinutes = EmployeeUtils.getIntNumaricValue("Overtime End MM", dudToMM.Text);

                DateTime overtimeDate = dtpOver_Time_Date.Value;

                DateTime startingTime = new DateTime(overtimeDate.Year, overtimeDate.Month, overtimeDate.Day, StartingHour, StartingMinutes, 0);
                DateTime endTime = new DateTime(overtimeDate.Year, overtimeDate.Month, overtimeDate.Day, EndHour, EndMinutes, 0);

                TimeSpan time = endTime.Subtract(startingTime);
                TimeSpan nutralDate = new TimeSpan(0, 0, 0);

                if (time >= nutralDate)
                {
                    txtOver_Time_Hours.Text = time.TotalHours.ToString("0.00");
                }
                else
                {
                    txtOver_Time_Hours.Text = "Please select correct overtime starting and end times.";
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void dudFromHH_SelectedItemChanged(object sender, EventArgs e)
        {
            CalculateOTHours();
        }

        private void dudFromMM_SelectedItemChanged(object sender, EventArgs e)
        {
            CalculateOTHours();
        }

        private void dudToHH_SelectedItemChanged(object sender, EventArgs e)
        {
            CalculateOTHours();
        }

        private void dudToMM_SelectedItemChanged(object sender, EventArgs e)
        {
            CalculateOTHours();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpOver_Time_Date.Value;
            DateTime correctedDate = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day);

            DataTable dt = new DataTable();
            dt.Columns.Add("Entitled", typeof(bool));
            dt.Columns.Add("TokenNo");
            dt.Columns.Add("EPFNo");
            dt.Columns.Add("EmployeeName");

            SubDepartment subdepartment = (SubDepartment)cmbSubDepartment.SelectedItem;
            foreach (Employee emp in subdepartment.Employees)
            {
                OverTime overtime = emp.OverTimes.Where(ot => ot.OverTimeDate.Equals(correctedDate)).SingleOrDefault();
                if (overtime != null)
                {
                    DateTime otStart = overtime.OverTImeFrom.Value;
                    DateTime otEnd = overtime.OverTimeTo.Value;

                    dudFromHH.Text = otStart.Hour.ToString("00");
                    dudFromMM.Text = otStart.Minute.ToString("00");
                    dudToHH.Text = otEnd.Hour.ToString("00");
                    dudToMM.Text = otEnd.Minute.ToString("00");

                    string reason = overtime.OverTimeReason;
                    int overTimeType = overtime.OverTimeCategory.Value;

                    if (overTimeType == 1)
                    {
                        rdbSingle.Checked = true;
                    }
                    else if (overTimeType == 2)
                    {
                        rdbDouble.Checked = true;
                    }
                    else
                    {
                        rdbTreble.Checked = true;
                    }
                    txtReason.Text = reason;
                    dt.Rows.Add(true, emp.TokenNo, emp.EPFNo, emp.Name);
                }
                else
                {
                    dt.Rows.Add(false, emp.TokenNo, emp.EPFNo, emp.Name);
                }
            }
            gdvOver_Time_Request.DataSource = dt;
        }

        private void gdvOver_Time_Request_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string TokenNo = gdvOver_Time_Request.Rows[e.RowIndex].Cells[1].Value.ToString();

            Employee employee = db.Employees.Where(em => em.TokenNo.Equals(TokenNo)).SingleOrDefault();

            if (employee != null)
            {
                txtEmployeeName.Text = employee.Name;
                txtDesignation.Text = employee.Designation.Designation1;
                txtNIC_No.Text = employee.NICNo;
                txtEPF_No.Text = employee.EPFNo;
                txtToken_No.Text = employee.TokenNo;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
