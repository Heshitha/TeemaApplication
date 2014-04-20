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
    public partial class BasicSalary : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
        public BasicSalary()
        {
            InitializeComponent();
        }

        private void BasicSalary_Load(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbWorkingBranch(db,cmbWorkingBranch );
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

        private string getEmptyInputBeforeSubmit()
        {
            string EmptyTextBoxName = string.Empty;

            EmptyTextBoxName += EmployeeUtils.getDoubleNumaricValue(" OT Rate ", txtOTRate.Text, true);

            return EmptyTextBoxName;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string emptyInput = getEmptyInputBeforeSubmit();
            if (emptyInput != string.Empty)
            {
                emptyInput = emptyInput.Remove(emptyInput.Length - 2, 2);
                ShowMessageBox.ShowError(" Please Enter Correct Value " + emptyInput + " . ");
            }
            else
            {
                MessageBox.Show("Done");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string emptyInput = getEmptyInputBeforeSubmit();
            if (emptyInput != string.Empty)
            {
                emptyInput = emptyInput.Remove(emptyInput.Length - 2, 2);
                ShowMessageBox.ShowError(" Please Enter Correct Value " + emptyInput + " . ");
            }
            else
            {
                MessageBox.Show("Done");
            }
        }

    }
}
