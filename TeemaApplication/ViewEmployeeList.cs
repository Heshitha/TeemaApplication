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
    public partial class frmViewEmployeeList : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public frmViewEmployeeList()
        {
            InitializeComponent();
        }

        private void frmViewEmployeeList_Load(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbWorkingBranch(db, cmbWorkingBranch);
        }

        private void cmbWorkingBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbDepartment((Branch)cmbWorkingBranch.SelectedItem, cmbDepartment);
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbSubDepartment((Department)cmbDepartment.SelectedItem, cmbSubDepartment);
        }

        private void cmbSubDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SubDepartment subDepartment = (SubDepartment)cmbSubDepartment.SelectedItem;
            if (subDepartment != null)
            {
                var EmployeeDetails = from x in subDepartment.Employees
                                      select new
                                      {
                                          x.TokenNo,
                                          x.EPFNo,
                                          x.NICNo,
                                          x.Name,
                                          Designation = x.Designation.Designation1
                                      };

                dgvFoundEmployees.DataSource = EmployeeDetails.ToList();
            }
        }

        private void viewEmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvFoundEmployees.SelectedRows[0];
            string TokenID = row.Cells[0].Value.ToString();

            Employee emp = db.Employees.Where(em => em.TokenNo == TokenID).SingleOrDefault();
            frmViewEmployeeDetails frm = new frmViewEmployeeDetails(emp);
            frm.ShowDialog();
            this.Close();

        }

        private void dgvFoundEmployees_ContextMenuStripChanged(object sender, EventArgs e)
        {
            
        }

        private void cmsEmployeeProperties_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dgvFoundEmployees_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var Loc = dgvFoundEmployees.HitTest(e.X, e.Y);
                dgvFoundEmployees.ClearSelection();
                dgvFoundEmployees.Rows[Loc.RowIndex].Selected = true;
            }
        }

    }
}
