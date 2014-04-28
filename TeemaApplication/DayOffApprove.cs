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
        }

        
    }
}
