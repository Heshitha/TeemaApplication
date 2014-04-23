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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            frmAddNewEmployee frm = new frmAddNewEmployee();
            frm.ShowDialog();
        }

        private void btnViewEmplyeeList_Click(object sender, EventArgs e)
        {
            frmViewEmployeeList frm = new frmViewEmployeeList();
            frm.ShowDialog();
        }

        private void btnViewEmployee_Click(object sender, EventArgs e)
        {
            frmViewEmployeeDetails frm = new frmViewEmployeeDetails();
            frm.ShowDialog();
        }

        private void btnAddLeaves_Click(object sender, EventArgs e)
        {
            frmAddLeaves frm = new frmAddLeaves();
            frm.ShowDialog();
        }

     
        private void btnOverTimeRequest_Click(object sender, EventArgs e)
        {
            frmOver_Time_Request frm = new frmOver_Time_Request();
            frm.ShowDialog();
        }

        private void btnOverTimeApproved_Click(object sender, EventArgs e)
        {
            frmOver_Time_Approve frm = new frmOver_Time_Approve();
            frm.ShowDialog();
        }

        private void btnBasicSalary_Click(object sender, EventArgs e)
        {
            BasicSalary frm = new BasicSalary();
            frm.ShowDialog();
        }

        private void btnSalaryLoanRequest_Click(object sender, EventArgs e)
        {
            frmSalary_Loan_Request frm = new frmSalary_Loan_Request();
            frm.ShowDialog();
        }

        private void btnSalaryLoanApproved_Click(object sender, EventArgs e)
        {
            frmSalaryLoanApproved frm = new frmSalaryLoanApproved();
            frm.ShowDialog();
        }

        private void btnASalaryAdvanceRequest_Click(object sender, EventArgs e)
        {
            frmSalaryAdvanceRequest frm = new frmSalaryAdvanceRequest();
            frm.ShowDialog();
        }

        private void btnSalaryAdvanceApproved_Click(object sender, EventArgs e)
        {
            frmSalary_Advance_Approve frm = new frmSalary_Advance_Approve();
            frm.ShowDialog();
        }

        private void btnFixedIncentiveAllowance_Click(object sender, EventArgs e)
        {
            FrmFixed_Incentive_Allowance frm = new FrmFixed_Incentive_Allowance();
            frm.ShowDialog();
        }

        private void btnVaribleIncentiveAllowance_Click(object sender, EventArgs e)
        {
            frmVariable_Incentive_Allowance frm = new frmVariable_Incentive_Allowance();
            frm.ShowDialog();
        }

        private void btnLeaveApply_Click(object sender, EventArgs e)
        {
            frmLeaveApply frm = new frmLeaveApply();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOverTimeAuthorize frm = new frmOverTimeAuthorize();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLeaveApplyApprove frm = new frmLeaveApplyApprove();
            frm.ShowDialog();
        }

        
    }
}
