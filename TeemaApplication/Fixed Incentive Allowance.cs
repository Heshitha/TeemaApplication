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
    public partial class FrmFixed_Incentive_Allowance : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
        public FrmFixed_Incentive_Allowance()
        {
            InitializeComponent();
        }

        // fill Depsrtment Search combo boxes
        private void fillcmbBranch()
        {
            cmbWorkingBranch.DisplayMember = "BranchName";
            cmbWorkingBranch.ValueMember = "BranchID";
            cmbWorkingBranch.DataSource = db.Branches;
        }
        // fill Depsrtment Search combo boxes
        private void fillcmbDepartment(Branch branch)
        {
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "DepartmentID";
            cmbDepartment.DataSource = branch.Departments;
        }
        // fill Depsrtment Search combo boxes
        private void fillcmbSubDepartment(Department department)
        {
            cmbSubDepartment.DisplayMember = "SubDepartmentName";
            cmbSubDepartment.ValueMember = "SubDepartmentID";
            cmbSubDepartment.DataSource = department.SubDepartments;
        }

        private void FrmFixed_Incentive_Allowance_Load(object sender, EventArgs e)
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

        //check salary period combox
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

        private bool checkforsalarymonth()
        {
            String errortext = null;
            errortext += getIntNumaricValue(" *Year", cmbYear.Text);

            if (cmbMonth.Text.Equals(string.Empty))
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
                MessageBox.Show("Please Select "+errortext+"..!");
                return false;
            }
 
        }               

      

        private void btnSearch_Click(object sender, EventArgs e)
        {
            checkforsalarymonth();
        }

       
     
        
    }
}
