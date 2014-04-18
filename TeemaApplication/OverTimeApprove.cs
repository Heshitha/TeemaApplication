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
        }
    }
}
