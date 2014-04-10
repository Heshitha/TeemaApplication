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
    public partial class frmSalaryLoanApproved : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
        public frmSalaryLoanApproved()
        {
            InitializeComponent();
        }

       

        private void frmSalaryLoanApproved_Load(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbWorkingBranch(db, cmbWorkingBranch);
            EmployeeUtils.fillcmbDepartment((Branch)cmbWorkingBranch.SelectedItem, cmbDepartment);
            EmployeeUtils.fillcmbSubDepartment((Department)cmbDepartment.SelectedItem, cmbSubDepartment);
        }

        private void cmbWorkingBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbDepartment((Branch)cmbWorkingBranch.SelectedItem,cmbDepartment);
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbSubDepartment((Department)cmbDepartment.SelectedItem,cmbSubDepartment);
        }

       
   
        private bool checkforValues()
        {
            String erroetext = null;

            //erroetext += getIntNumaricValue("*Requested Amount", txtRequested_Amount.Text);
            //erroetext += getIntNumaricValue(" *Deduction Amount in Month ", txtDeductionAmountinMonth.Text);
            //erroetext += getIntNumaricValue(" *Number of Month ", txtNumber_of_Month.Text);
            //erroetext += getIntNumaricValue(" *Deduction Salary Period ", txtDeduction_Salary_Period.Text);

           
            if (erroetext == "")
            {
                MessageBox.Show("done");
                return true;
            }
            else
            {
                MessageBox.Show("Please add Correct value to " + erroetext + "..!");
                return false;
            }
        }

        private void btnApproved_Click(object sender, EventArgs e)
        {
            checkforValues();
        }
    }
}
