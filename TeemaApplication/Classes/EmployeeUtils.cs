using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeemaApplication.Classes
{
    class EmployeeUtils
    {
        public static void fillcmbWorkingBranch(TeemaDBDataContext db, ComboBox comboBox)
        {
            comboBox.DisplayMember = "BranchName";
            comboBox.ValueMember = "BranchID";
            comboBox.DataSource = db.Branches;
        }

        public static void fillcmbDepartment(Branch branch, ComboBox comboBox)
        {
            comboBox.DisplayMember = "DepartmentName";
            comboBox.ValueMember = "DepartmentID";
            comboBox.DataSource = branch.Departments;
        }

        public static void fillcmbSubDepartment(Department department, ComboBox comboBox)
        {
            comboBox.DisplayMember = "SubDepartmentName";
            comboBox.ValueMember = "SubDepartmentID";
            comboBox.DataSource = department.SubDepartments;
        }

        public static void fillcmbDesignation(TeemaDBDataContext db, ComboBox comboBox)
        {
            comboBox.DisplayMember = "Designation1";
            comboBox.ValueMember = "Designation1";
            comboBox.DataSource = db.Designations;
        }

        public static bool checkIfContainText(Control control)
        {
            return !string.IsNullOrEmpty(control.Text);
        }

        public static void checkIfEmpty(TextBox textBox)
        {
            double value = 0;
            if (string.IsNullOrEmpty(textBox.Text) || !double.TryParse(textBox.Text, out value))
            {
                textBox.Text = "0";
            }
        }

        public static double getVariableIncentiveValue(TextBox textBox)
        {
            double value;
            if (double.TryParse(textBox.Text, out value))
            {
                return value;
            }
            else
            {
                if (!textBox.Focused)
                {
                    textBox.Text = "0";
                }
                return value;
            }
        }

        public static bool isBranchExist(TeemaDBDataContext db, ComboBox comboBox)
        {
            string BranchName = comboBox.Text;
            bool isExist = false;
            foreach (Branch b in db.Branches)
            {
                if (b.BranchName.ToUpper().Equals(BranchName.ToUpper()))
                {
                    isExist = true;
                }
            }
            return isExist;
        }

        public static double getDoubleNumaricValue(string title, string text)
        {
            double value = 0;
            if (double.TryParse(text, out value))
            {
                return value;
            }
            else
            {
                ShowMessageBox.ShowError("Please put a numaric value for " + title);
                return value;
            }
        }

        public static int getIntNumaricValue(string title, string text)
        {
            int value = 0;
            if (int.TryParse(text, out value))
            {
                return value;
            }
            else
            {
                ShowMessageBox.ShowError("Please put a numeric value for " + title);
                return value;
            }
        }

        // check text boxes filled and are with correct values (numeric or string)
        public static string getIntNumaricValue(string title, string text, bool flag)
        {
            int value = 0;
            if (int.TryParse(text, out value))
            {
                return "";
            }
            else
            {
                return title + ", ";
            }
        }

        public static VariableIncentive getVariableIncentive(string variableIncentiveType, string textBoxValue, Employee employee)
        {
            VariableIncentive variableIncentive = new VariableIncentive
            {
                IncentiveType = variableIncentiveType,
                IncentivePrecentage = getDoubleNumaricValue(variableIncentiveType, textBoxValue),
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                ModifiedBy = 1,
                ModifiedDate = DateTime.Now,
                Employee = employee
            };

            return variableIncentive;
        }

        public static bool isDepartmentExist(Branch branch, ComboBox comboBox)
        {
            string DepartmentName = comboBox.Text;
            bool isExist = false;
            foreach (Department d in branch.Departments)
            {
                if (d.DepartmentName.ToUpper().Equals(DepartmentName.ToUpper()))
                {
                    isExist = true;
                }
            }
            return isExist;
        }

        public static bool isSubDepartmentExist(Department department, ComboBox comboBox)
        {
            string SubDepartmentName = comboBox.Text;
            bool isExist = false;
            foreach (SubDepartment s in department.SubDepartments)
            {
                if (s.SubDepartmentName.ToUpper().Equals(SubDepartmentName.ToUpper()))
                {
                    isExist = true;
                }
            }
            return isExist;
        }

        public static bool isDesignationExist(TeemaDBDataContext db, ComboBox comboBox)
        {
            string designation = comboBox.Text;
            bool isExist = false;
            foreach (Designation d in db.Designations)
            {
                if (d.Designation1.ToUpper().Equals(designation.ToUpper()))
                {
                    isExist = true;
                }
            }
            return isExist;
        }
    }
}
