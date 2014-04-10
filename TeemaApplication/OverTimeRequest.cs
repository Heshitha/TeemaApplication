using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeemaApplication
{
    public partial class frmOver_Time_Request : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
        public frmOver_Time_Request()
        {
            InitializeComponent();
        }

        //fill department search combo boxes
        private void fillcmbBranch()
        {
            cmbWorkingBranch.DisplayMember = "BranchName";
            cmbWorkingBranch.ValueMember = "BranchID";
            cmbWorkingBranch.DataSource = db.Branches;
        }

        private void fillcmbDepartment(Branch branch)
        {
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "DepartmentID";
            cmbDepartment.DataSource = branch.Departments;
        }

        private void fillcmbSubDepartment(Department department)
        {
            cmbSubDepartment.DisplayMember = "SubDepartmentName";
            cmbSubDepartment.ValueMember = "SubDepartmentID";
            cmbSubDepartment.DataSource = department.SubDepartments;
        }


        private void frmOver_Time_Request_Load(object sender, EventArgs e)
        {
            fillcmbBranch();
            fillcmbDepartment((Branch)cmbWorkingBranch.SelectedItem);
            fillcmbSubDepartment((Department)cmbDepartment.SelectedItem);

        }

        private void cmbWorkingBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillcmbDepartment((Branch)cmbWorkingBranch.SelectedItem);
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillcmbSubDepartment((Department)cmbDepartment.SelectedItem);
        }

        private String getIntNumaricValue(string title, string text)
        {
            int Value = 0;
            if (int.TryParse(text, out Value))
            {
                return "";
            }
            else
            {
                return title + " ";
            }
        }
        private bool checkforvalues()
        {
            String errortext = null;

            errortext += getIntNumaricValue(" *Over Time Hours ",txtOver_Time_Hours.Text);

            if (txtReason.Text.Equals(string.Empty))
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
        }
       
    }
}
