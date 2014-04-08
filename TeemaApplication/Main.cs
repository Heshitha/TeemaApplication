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

        
    }
}
