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
    public partial class frmVariable_Incentive_Allowance : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
        public frmVariable_Incentive_Allowance()
        {
            InitializeComponent();
        }

      
        private void frmVariable_Incentive_Allowance_Load(object sender, EventArgs e)
        {
           EmployeeUtils.fillcmbWorkingBranch(db,cmbWorkingBranch);
            EmployeeUtils.fillcmbDepartment((Branch)cmbWorkingBranch.SelectedItem,cmbDepartment);
            EmployeeUtils.fillcmbSubDepartment((Department)cmbDepartment.SelectedItem,cmbSubDepartment);
        }

      

        private void cmbWorkingBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
           EmployeeUtils.fillcmbDepartment((Branch)cmbWorkingBranch.SelectedItem,cmbDepartment);
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
           EmployeeUtils.fillcmbSubDepartment((Department)cmbDepartment.SelectedItem,cmbSubDepartment);
        }

        private bool checkforsalarymonth()
        {
            string errortext = null;
            errortext += EmployeeUtils.getIntNumaricValue(" *Year", cmbYear.Text, true);
            if (!EmployeeUtils.checkIfContainText(cmbMonth))
            {
                errortext += " *Month";
            }
            if (errortext == "")
            {
                MessageBox.Show("Done");
                return true;
            }
            else
            {
                MessageBox.Show("Please Select " + errortext + "..!");
                return false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            checkforsalarymonth();
        }
    }
}
