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
    public partial class frmDayOffApprove : Form
    {

        TeemaDBDataContext db = new TeemaDBDataContext();

        public frmDayOffApprove()
        {
            InitializeComponent();
        }

        private void frmDayOffApprove_Load(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbWorkingBranch(db, cmbBranch);
            EmployeeUtils.fillcmbDepartment((Branch)cmbBranch.SelectedItem, cmbDepartment);
            EmployeeUtils.fillcmbSubDepartment((Department)cmbDepartment.SelectedItem, cmbSubDepartment);
            setcurrentyear();
            setcurrentmonth();
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbDepartment((Branch)cmbBranch.SelectedItem, cmbDepartment);
            EmployeeUtils.fillcmbSubDepartment((Department)cmbDepartment.SelectedItem, cmbSubDepartment);
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbSubDepartment((Department)cmbDepartment.SelectedItem, cmbSubDepartment);
        }

        private void setcurrentyear()
        {
            int currentyear = Convert.ToInt32(System.DateTime.Now.Year);

            int indexval = currentyear - 2014;

            cmbYear.SelectedIndex = indexval;
        }

        private void setcurrentmonth()
        {
            int currentmonth = (Convert.ToInt32(System.DateTime.Now.Month)) - 1;

            cmbMonth.SelectedIndex = currentmonth;
        }

        private void loaddayoffsgrid()
        {

            SubDepartment subdept = (SubDepartment)cmbSubDepartment.SelectedItem;

            DataTable dt = new DataTable();
            dt.Columns.Add("TokenID");
            dt.Columns.Add("Name");
            dt.Columns.Add("DayOffID");
             dt.Columns.Add("LeaveDate");
            dt.Columns.Add("Approve", typeof(bool));

            foreach (Employee em in subdept.Employees)
            {
                foreach (DayOffRecord pe in em.DayOffRecords.Where(pl => pl.DayOffFrom .Value.Year == Convert.ToInt32(cmbYear.SelectedItem) && pl.DayOffFrom.Value.Month <= (cmbMonth.SelectedIndex) + 1))
                {
                    if (chbUnApprovedOnly.Checked)
                    {
                        if (pe.ApprovedBy  == null)
                        {
                            dt.Rows.Add(em.TokenNo, em.Name , pe.DayOffID,pe.DayOffFrom.Value.ToString("dd-MM-yyyy"), false);
                        }

                    }
                    else
                    {
                        bool isapproved = pe.ApprovedBy != null ? true : false;
                        dt.Rows.Add(em.TokenNo, em.Name, pe.DayOffID,  pe.DayOffFrom.Value.ToString("dd-MM-yyyy"), isapproved);
                    }
                }

            }
            dgvLeavesapplied.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loaddayoffsgrid();
        }

        private void fillEmployeeDetailsgrpbox()
        {

            String tokenid = Convert.ToString(dgvLeavesapplied.SelectedRows[0].Cells[0].Value);

            Employee data = (from emp in db.Employees
                             where emp.TokenNo == tokenid
                             select emp).SingleOrDefault();


            txtEmployeeName.Text = data.Name;
            txtDesignation.Text = data.Designation.Designation1;
            txtNICNo.Text = data.NICNo;
            txtEPFNO.Text = data.EPFNo;
            txtTokenNo.Text = data.TokenNo;

            // fill leave deatails textboxes

            int id = Convert.ToInt32(dgvLeavesapplied.SelectedRows[0].Cells[2].Value);

            DayOffRecord pre = (from en in db.DayOffRecords
                                       where en.DayOffID == id
                                       select en).SingleOrDefault();

            txtLeaveAppliedDate.Text = pre.CreatedDate.Value.ToString("dd-MM-yyyy");
            txtLeaveDate.Text = pre.DayOffFrom.Value.ToString("dd-MM-yyyy");
            txtLeaveReason.Text = pre.DayOffReason;
        }

        private void dgvLeavesapplied_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fillEmployeeDetailsgrpbox();
        }

        private void submitapproval()
        {
            try
            {
                foreach (DataGridViewRow row in dgvLeavesapplied.Rows)
                {
                    DataGridViewCheckBoxCell checkCell = row.Cells[4] as DataGridViewCheckBoxCell;
                    bool IsApproved = (checkCell != null && checkCell.Value != null && true == (bool)checkCell.Value);

                    int leaveID = Convert.ToInt32(row.Cells[2].Value);
                    DayOffRecord perslvrec = db.DayOffRecords.Where(sa => sa.DayOffID == leaveID).SingleOrDefault();
                    if (IsApproved)
                    {
                        perslvrec.ApprovedBy = 1;
                        perslvrec.ModifiedBy = 1;
                        perslvrec.ModifiedDate = DateTime.Now;
                    }
                    else
                    {
                        perslvrec.ApprovedBy = null;
                        perslvrec.ModifiedBy = 1;
                        perslvrec.ModifiedDate = DateTime.Now;
                    }
                    db.SubmitChanges();
                }
                ShowMessageBox.ShowSuccess("Successfully Saved.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Please select a request to approve");

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            submitapproval();
            loaddayoffsgrid();

        }
 
    }
}
