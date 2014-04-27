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
    public partial class frmLeaveApplyApprove : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public frmLeaveApplyApprove()
        {
            InitializeComponent();
        }

        private void txtCADAdvanceID_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLeaveApplyApprove_Load(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbWorkingBranch(db, cmbBranch);
            EmployeeUtils.fillcmbDepartment((Branch)cmbBranch.SelectedItem, cmbDepartment);
            EmployeeUtils.fillcmbSubDepartment((Department)cmbDepartment.SelectedItem, cmbSubDepartment);
            cmbYear.SelectedIndex = 5;
            setcurrentyear();
            setcurrentmonth();

        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbSubDepartment((Department)cmbDepartment.SelectedItem, cmbSubDepartment);
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbDepartment((Branch)cmbBranch.SelectedItem, cmbDepartment);
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

        private void loadleavesgrid()
        {

            SubDepartment subdept = (SubDepartment)cmbSubDepartment.SelectedItem;

            DataTable dt = new DataTable();
            dt.Columns.Add("TokenID");
            dt.Columns.Add("Name");
            dt.Columns.Add("PersonalLeaveID");
            dt.Columns.Add("LeaveType");
            dt.Columns.Add("LeaveDate");
            dt.Columns.Add("Approve", typeof(bool));

            foreach (Employee em in subdept.Employees)
            {
                foreach (PersonalLeaveRecord pe in em.PersonalLeaveRecords.Where(pl => pl.LeaveFrom.Value.Year == Convert.ToInt32(cmbYear.SelectedItem) && pl.LeaveFrom.Value.Month <= (cmbMonth.SelectedIndex) + 1))
                {
                    if (chbUnApprovedOnly.Checked)
                    {
                        if(pe.LeaveApprovedDept == null)
                        {
                            dt.Rows.Add(em.TokenNo, em.Name, pe.PersonalLeaveID, pe.LeaveType, pe.LeaveDate.Value.ToString("dd-MM-yyyy"), false );
                        }

                    }
                    else
                    {
                        bool isapproved = pe.LeaveApprovedDept != null ? true : false;
                        dt.Rows.Add(em.TokenNo, em.Name, pe.PersonalLeaveID, pe.LeaveType, pe.LeaveDate.Value.ToString("dd-MM-yyyy"),isapproved);
                    }
                }
 
            }
            dgvLeavesapplied.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadleavesgrid();
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

            PersonalLeaveRecord pre = (from en in db.PersonalLeaveRecords
                                       where en.PersonalLeaveID == id
                                       select en).SingleOrDefault();

            txtLeavefrom.Text = pre.LeaveFrom.Value.ToString("dd-MM-yyyy");

            if (pre.LeaveTo != null)
            {
                txtLeaveto.Text = pre.LeaveTo.Value.ToString("dd-MM-yyyy");
            }
            if (pre.OtherLeaveDescription != "")
            {
                txtOtherleavedescription.Text = pre.OtherLeaveDescription.ToString();
            }
            if (pre.LeaveReason != "")
            {
                txtLeaveReason.Text = pre.LeaveReason.ToString();
            }
            if (pre.IsNoPay == true)
            {
                txtPaynopay.Text = "Payed";
            }
            else if (pre.IsNoPay == false)
            {
                txtPaynopay.Text = "Nopay";
            }
            if (pre.LeaveValue == 1)
            {
                txtFullhalfday.Text = "Full Day";
            }
            else if (pre.LeaveValue == 0.5)
            {
                txtFullhalfday.Text = "Half Day";
            }


            txtSubstitueID.Text = pre.SubstituteID;
            txtSubstitutename.Text = pre.Employee.Name;

            if (pre.LeaveTo != null)
            {
                DateTime leavefrom1 = pre.LeaveFrom.Value;
                DateTime leaveto1 = pre.LeaveTo.Value;

                TimeSpan numberofdays;

                numberofdays = (leaveto1 - leavefrom1);

                int realdays = numberofdays.Days;

                txtNumberofdays.Text = Convert.ToString(realdays + 1);
            }
            else
            {
                txtNumberofdays.Text = "0.5";
            }
        }

        private void dgvLeavesapplied_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillEmployeeDetailsgrpbox();
        }

        private void submitapproval()
        {
            try
            {
                foreach (DataGridViewRow row in dgvLeavesapplied.Rows)
                {
                    DataGridViewCheckBoxCell checkCell = row.Cells[5] as DataGridViewCheckBoxCell;
                    bool IsApproved = (checkCell != null && checkCell.Value != null && true == (bool)checkCell.Value);

                    int leaveID = Convert.ToInt32(row.Cells[2].Value);
                    PersonalLeaveRecord perslvrec = db.PersonalLeaveRecords.Where(sa => sa.PersonalLeaveID == leaveID).SingleOrDefault();
                    if (IsApproved)
                    {
                        perslvrec.LeaveApprovedDept = 1;
                        perslvrec.ModifiedBy = 1;
                        perslvrec.ModifiedDate = DateTime.Now;
                    }
                    else
                    {
                        perslvrec.LeaveApprovedDept = null;
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
                loadleavesgrid(); 
        }
    }
}
