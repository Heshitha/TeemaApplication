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
    public partial class frmAddNewEmployee : Form
    {
        DataSets.TeemaDataSet dataset = new DataSets.TeemaDataSet();
        TeemaDBDataContext db = new TeemaDBDataContext();

        public frmAddNewEmployee()
        {
            InitializeComponent();
            
        }

        private void frmAddNewEmployee_Load(object sender, EventArgs e)
        {
            dgvFixedIncentives.DataSource = dataset.NewFixedIncentive;
            dgvVariableIncentive.DataSource = dataset.NewVariableIncentive;
            fillcmbWorkingBranch();
            fillcmbDepartment((Branch)cmbWorkingBranch.SelectedItem);
            fillcmbSubDepartment((Department)cmbDepartment.SelectedItem);
            fillcmbDesignation();
        }

        private void btnAddFixedIncentive_Click(object sender, EventArgs e)
        {
            double incentiveValue = 0;
            if (double.TryParse(txtFixedIncentiveValue.Text, out incentiveValue))
            {
                dataset.NewFixedIncentive.AddNewFixedIncentiveRow(txtFixedIncentiveType.Text, incentiveValue);
            }
            else
            {
                ShowMessageBox.ShowError("Please enter numaric value for Incentive Value.");
            }
        }

        private void dgvFixedIncentives_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvFixedIncentives_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFixedIncentives_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvFixedIncentives_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void btnAddVari_Incentive_Click(object sender, EventArgs e)
        {
            double incentivePrecentage = 0;

            if (double.TryParse(txtVariableIncentivePrecentage.Text, out incentivePrecentage))
            {
                dataset.NewVariableIncentive.AddNewVariableIncentiveRow(txtVariableIncentiveType.Text, incentivePrecentage);
            }
            else
            {
                ShowMessageBox.ShowError("Please enter numaric value for Incentive Precentage.");
            }
        }

        private void dgvFixedIncentives_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            ShowMessageBox.ShowError("Please enter numaric value for Incentive Value.");
        }

        private void dgvVariableIncentive_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            ShowMessageBox.ShowError("Please enter numaric value for Incentive Precentage.");
        }

        private void fillcmbWorkingBranch()
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

        private void fillcmbDesignation()
        {
            cmbDesignation.DisplayMember = "Designation1";
            cmbDesignation.ValueMember = "Designation1";
            cmbDesignation.DataSource = db.Designations;
        }

        private void cmbWorkingBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillcmbDepartment((Branch)cmbWorkingBranch.SelectedItem);
        }

        private void cmbSubDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillcmbSubDepartment((Department)cmbDepartment.SelectedItem);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Branch branch = null;
            if (!isBranchExist())
            {
                branch = new Branch
                {
                    BranchName = cmbWorkingBranch.Text,
                    CreatedBy = 1,
                    CreatedDate = DateTime.Now,
                    ModifiedBy = 1,
                    ModifiedDate = DateTime.Now
                };

                db.Branches.InsertOnSubmit(branch);
                db.SubmitChanges();
            }
            else
            {
                branch = (Branch)cmbWorkingBranch.SelectedItem;
            }

            Department department = null;
            if (!isDepartmentExist(branch))
            {
                department = new Department
                {
                    DepartmentName = cmbDepartment.Text,
                    CreatedBy = 1,
                    CreatedDate = DateTime.Now,
                    ModifiedBy = 1,
                    ModifiedDate = DateTime.Now,
                    Branch = branch
                };
                db.Departments.InsertOnSubmit(department);
                db.SubmitChanges();
            }
            else
            {
                department = (Department)cmbDepartment.SelectedItem;
            }
            SubDepartment subDepartment = null;
            if (!isSubDepartmentExist(department))
            {
                subDepartment = new SubDepartment
                {
                    SubDepartmentName = cmbSubDepartment.Text,
                    CreatedBy = 1,
                    CreatedDate = DateTime.Now,
                    ModifiedBy = 1,
                    ModifiedDate = DateTime.Now,
                    Department = department,
                };
                db.SubDepartments.InsertOnSubmit(subDepartment);
                db.SubmitChanges();
            }
            else
            {
                subDepartment = (SubDepartment)cmbSubDepartment.SelectedItem;
            }

            Designation designation = null;
            if (!isDesignationExist())
            {
                designation = new Designation
                {
                    Designation1 = cmbDesignation.Text,
                    CreatedBy = 1,
                    CreatedDate = DateTime.Now,
                    ModifiedBy = 1,
                    ModifiedDate = DateTime.Now
                };
                db.Designations.InsertOnSubmit(designation);
                db.SubmitChanges();
            }
            else
            {
                designation = (Designation)cmbDesignation.SelectedItem;
            }

            string Gender = "";
            if (rdbGenderMale.Checked)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }

            Employee employee = new Employee
            {
                TokenNo = txtTokenNo.Text,
                EnrolmentID = getIntNumaricValue("Token No", txtTokenNo.Text),
                Name = txtEmployeeName.Text,
                Gender = Gender,
                DateOfAppointment = dtpDateOfAppointment.Value,
                EPFNo = txtEPFNo.Text,
                NICNo = txtNICNo.Text,
                EmployeeCatagory = cmbEmployeeCatagory.Text,
                EmployeeGrade = cmbEmployeeGrade.Text,
                NoPayCalculataionDate = getIntNumaricValue("No Pay Calculation Date", cmbDateRateOfSalary.Text),
                PieceRateEntitled = chbPieceRate.Checked,
                EPFEntitled = chbEPFEntitled.Checked,
                Designation = designation,
                SubDepartment = subDepartment
            };

            db.Employees.InsertOnSubmit(employee);
            db.SubmitChanges();

            double EPFValue = 0;
            if (cmbEmployeeCatagory.Text.Trim().Equals("Day Wages"))
            {
                EPFValue = getDoubleNumaricValue("EPF ETF Total Salary", txtDayWagesTotalEPFSalary.Text);
            }
            else
            {
                EPFValue = getDoubleNumaricValue("Total For EPF ETF", txtRecrumentTotalEPF.Text);
            }

            EmployeeSalaryDetail sal = new EmployeeSalaryDetail
            {
                Employee = employee,
                BudgetAllowance = getDoubleNumaricValue("Budget Allowance", txtBudgetAllowance.Text),
                DayWagesAmount = getDoubleNumaricValue("Day Wages Amount", txtDayWagesDayRate.Text),
                TotalValueForEPF = EPFValue,
                BasicSalary = getDoubleNumaricValue("Basic Salary", txtBasicSalary.Text),
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                ModifiedBy = 1,
                ModifiedDate = DateTime.Now
            };
            db.EmployeeSalaryDetails.InsertOnSubmit(sal);
            db.SubmitChanges();

            FixedIncentive travelingIncentive = new FixedIncentive
            {
                IncentiveType = "Traveling Attendance",
                InventiveValue = getDoubleNumaricValue("Traveling And Attendance Incentive", txtTravellingAttendance.Text),
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                ModifiedBy = 1,
                ModifiedDate = DateTime.Now
            };
            db.FixedIncentives.InsertOnSubmit(travelingIncentive);
            db.SubmitChanges();

            foreach (var x in dataset.NewFixedIncentive.Rows)
            {
                
            }


            MessageBox.Show("Done");
        }

        private bool isBranchExist()
        {
            string BranchName = cmbWorkingBranch.Text;
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

        private double getDoubleNumaricValue(string title, string text)
        {
            double value = 0;
            if (double.TryParse(text, out value))
            {
                return value;
            }
            else
            {
                ShowMessageBox.ShowError("Please put a numaric value for "+title);
                return value;
            }
        }

       
        private int getIntNumaricValue(string title, string text)
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
        private string getIntNumaricValue(string title, string text, bool flag)
        {
            int value = 0;
            if (int.TryParse(text, out value))
            {
                return "";
            }
            else
            {
               return title+", ";
            }
        }

        private bool checkForValues()
        {
            string EmptyTextBoxes = "";
            EmptyTextBoxes += getIntNumaricValue("EPF No", txtEPFNo.Text, true);

            if(EmptyTextBoxes == "")
            {
                return true;
            }
            else
            {

            }
            return true;
        }

        private bool isDepartmentExist(Branch branch)
        {
            string DepartmentName = cmbDepartment.Text;
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

        private bool isSubDepartmentExist(Department department)
        {
            string SubDepartmentName = cmbSubDepartment.Text;
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

        private bool isDesignationExist()
        {
            string designation = cmbDesignation.Text;
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

        private void chbEPFEntitled_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
