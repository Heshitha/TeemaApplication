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
            EmployeeUtils.fillcmbWorkingBranch(db, cmbWorkingBranch);
            EmployeeUtils.fillcmbDepartment((Branch)cmbWorkingBranch.SelectedItem, cmbDepartment);
            EmployeeUtils.fillcmbSubDepartment((Department)cmbDepartment.SelectedItem, cmbSubDepartment);
            EmployeeUtils.fillcmbDesignation(db, cmbDesignation);
        }

        private void btnAddFixedIncentive_Click(object sender, EventArgs e)
        {
            double incentiveValue = 0;
            if (double.TryParse(txtFixedIncentiveValue.Text, out incentiveValue))
            {
                dataset.NewFixedIncentive.AddNewFixedIncentiveRow(txtFixedIncentiveType.Text, incentiveValue);
                txtFixedIncentiveType.Focus();
            }
            else
            {
                ShowMessageBox.ShowError("Please enter numaric value for Incentive Value.");
                txtFixedIncentiveValue.Focus();
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
                txtVariableIncentiveType.Focus();
            }
            else
            {
                ShowMessageBox.ShowError("Please enter numaric value for Incentive Precentage.");
                txtWorkshopIncentivePresentage.Focus();
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

        private void cmbWorkingBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbDepartment((Branch)cmbWorkingBranch.SelectedItem, cmbDepartment);
        }

        private void cmbSubDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbSubDepartment((Department)cmbDepartment.SelectedItem, cmbSubDepartment);
        }

        private string getEmptyInputsBeforeSubmit()
        {
            string EmptyTextBoxNames = string.Empty;

            EmptyTextBoxNames += EmployeeUtils.checkIfContainText(cmbWorkingBranch) ? string.Empty : "Working Branch, ";
            EmptyTextBoxNames += EmployeeUtils.checkIfContainText(cmbDepartment) ? string.Empty : "Department, ";
            EmptyTextBoxNames += EmployeeUtils.checkIfContainText(cmbSubDepartment) ? string.Empty : "Sub Branch, ";
            EmptyTextBoxNames += EmployeeUtils.checkIfContainText(txtEmployeeName) ? string.Empty : "Employee Name, ";
            EmptyTextBoxNames += EmployeeUtils.checkIfContainText(cmbDesignation) ? string.Empty : "Designation, ";
            EmptyTextBoxNames += EmployeeUtils.checkIfContainText(txtTokenNo) ? string.Empty : "Token No, ";
            EmptyTextBoxNames += EmployeeUtils.checkIfContainText(txtEPFNo) ? string.Empty : "EPF No, ";
            EmptyTextBoxNames += EmployeeUtils.checkIfContainText(txtNICNo) ? string.Empty : "NIC No, ";
            EmptyTextBoxNames += EmployeeUtils.checkIfContainText(cmbEmployeeCatagory) ? string.Empty : "Employee Catagory, ";
            EmptyTextBoxNames += EmployeeUtils.checkIfContainText(cmbEmployeeGrade) ? string.Empty : "Employee Grade, ";
            EmptyTextBoxNames += EmployeeUtils.checkIfContainText(cmbDateRateOfSalary) ? string.Empty : "Date Rate Of Salary, ";

            return EmptyTextBoxNames;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string emptyInputs = getEmptyInputsBeforeSubmit();
            
            if (emptyInputs != string.Empty)
            {
                emptyInputs = emptyInputs.Remove(emptyInputs.Length - 2, 2);
                ShowMessageBox.ShowError("Please provide following values before submiting. " + emptyInputs + ".");
            }
            else
            {
                try
                {
                    Branch branch = null;
                    if (!EmployeeUtils.isBranchExist(db, cmbWorkingBranch))
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
                    if (!EmployeeUtils.isDepartmentExist(branch, cmbDepartment))
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
                    if (!EmployeeUtils.isSubDepartmentExist(department, cmbSubDepartment))
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
                    if (!EmployeeUtils.isDesignationExist(db, cmbDesignation))
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
                        EnrolmentID = EmployeeUtils.getIntNumaricValue("Token No", txtTokenNo.Text),
                        Name = txtEmployeeName.Text,
                        Gender = Gender,
                        DateOfAppointment = dtpDateOfAppointment.Value,
                        EPFNo = txtEPFNo.Text,
                        NICNo = txtNICNo.Text,
                        EmployeeCatagory = cmbEmployeeCatagory.Text,
                        EmployeeGrade = cmbEmployeeGrade.Text,
                        NoPayCalculataionDate = EmployeeUtils.getIntNumaricValue("No Pay Calculation Date", cmbDateRateOfSalary.Text),
                        PieceRateEntitled = chbPieceRate.Checked,
                        EPFEntitled = chbEPFEntitled.Checked,
                        Designation = designation,
                        SubDepartment = subDepartment,
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now,
                        ModifiedBy = 1,
                        ModifiedDate = DateTime.Now
                    };

                    db.Employees.InsertOnSubmit(employee);
                    db.SubmitChanges();

                    double EPFValue = 0;
                    if (cmbEmployeeCatagory.Text.Trim().Equals("Day Wages"))
                    {
                        EPFValue = EmployeeUtils.getDoubleNumaricValue("EPF ETF Total Salary", txtDayWagesTotalEPFSalary.Text);
                    }
                    else
                    {
                        EPFValue = EmployeeUtils.getDoubleNumaricValue("Total For EPF ETF", txtRecrumentTotalEPF.Text);
                    }

                    EmployeeSalaryDetail sal = new EmployeeSalaryDetail
                    {
                        Employee = employee,
                        BudgetAllowance = EmployeeUtils.getDoubleNumaricValue("Budget Allowance", txtBudgetAllowance.Text),
                        DayWagesAmount = EmployeeUtils.getDoubleNumaricValue("Day Wages Amount", txtDayWagesDayRate.Text),
                        TotalValueForEPF = EPFValue,
                        BasicSalary = EmployeeUtils.getDoubleNumaricValue("Basic Salary", txtBasicSalary.Text),
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
                        InventiveValue = EmployeeUtils.getDoubleNumaricValue("Traveling And Attendance Incentive", txtTravellingAttendance.Text),
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now,
                        ModifiedBy = 1,
                        ModifiedDate = DateTime.Now,
                        Employee = employee
                    };
                    db.FixedIncentives.InsertOnSubmit(travelingIncentive);
                    db.SubmitChanges();

                    foreach (DataGridViewRow x in dgvFixedIncentives.Rows)
                    {
                        string fixedIncentiveType = x.Cells[0].Value.ToString();
                        double fixedIncentiveValue = (double)x.Cells[1].Value;

                        FixedIncentive addedIncentive = new FixedIncentive
                        {
                            IncentiveType = fixedIncentiveType,
                            InventiveValue = fixedIncentiveValue,
                            CreatedBy = 1,
                            CreatedDate = DateTime.Now,
                            ModifiedBy = 1,
                            ModifiedDate = DateTime.Now,
                            Employee = employee
                        };

                        db.FixedIncentives.InsertOnSubmit(addedIncentive);
                        db.SubmitChanges();
                    }

                    db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive("Performance", txtPerformancePrecentage.Text, employee));
                    db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive("Sales", txtSalesPrecentage.Text, employee));
                    db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive("Product", txtProductPrecentage.Text, employee));
                    db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive("Workshop", txtWorkshopIncentivePresentage.Text, employee));
                    db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive("Down Time Machine Break Down", txtDownTimeMatchineBreakDownPresentage.Text, employee));
                    db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive("Machieving Maintenance", txtMachievingMaintenancePresentage.Text, employee));
                    db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive("Achieving Production Targets", txtAchievingProductionTargetsPresentage.Text, employee));
                    db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive("Mill Section Targets", txtMillSectionTargetsPresentage.Text, employee));
                    db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive("Hawail Section Production", txtHawailSectionProductionPresentage.Text, employee));
                    db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive("Achieving Sales Targets", txtAchievingSalesTargetsPresentage.Text, employee));
                    db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive("Security Performance Targets", txtSecurityPerformanceIncentivePresentage.Text, employee));

                    foreach (DataGridViewRow x in dgvVariableIncentive.Rows)
                    {
                        string variableIncentiveType = x.Cells[0].Value.ToString();
                        string variableIncentivePrecentage = x.Cells[1].Value.ToString();

                        db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive(variableIncentiveType, variableIncentivePrecentage, employee));
                    }

                    db.SubmitChanges();

                    ShowMessageBox.ShowSuccess("Successfully inserted employee details to the database.");
                    resetForm();
                }
                catch (Exception ex)
                {
                    ShowMessageBox.ShowError("Something went wrong while saving details in to the database. " + ex.Message);
                }
            }
        }

        private void calculateVaribleIncentiveValues()
        {
            double ProductionSalesPerformanceTotal = EmployeeUtils.getDoubleValueFromTextBox(txtProductionSalesPerformanceTotalValue);
            double performPrecentage = EmployeeUtils.getDoubleValueFromTextBox(txtPerformancePrecentage) / 100.0;
            double salesPrecentage = EmployeeUtils.getDoubleValueFromTextBox(txtSalesPrecentage) / 100.0;
            double productPrecentage = EmployeeUtils.getDoubleValueFromTextBox(txtProductPrecentage) / 100.0;

            double performValue = ProductionSalesPerformanceTotal * performPrecentage;
            double salesValue = ProductionSalesPerformanceTotal * salesPrecentage;
            double productValue = ProductionSalesPerformanceTotal * productPrecentage;

            txtPerformValue.Text = performValue.ToString("0");
            txtSalesValue.Text = salesValue.ToString("0");
            txtProductValue.Text = productValue.ToString("0");
        }

        private void chbEPFEntitled_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtProductionSalesPerformanceTotalValue_TextChanged(object sender, EventArgs e)
        {
            calculateVaribleIncentiveValues();
        }

        private void txtProductPrecentage_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtProductPrecentage);
        }

        private void txtDayWagesDayRate_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtDayWagesDayRate);
        }

        private void txtDayWagesTotalEPFSalary_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBasicSalary_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBudgetAllowance_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtRecrumentTotalEPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDayWagesTotalEPFSalary_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtDayWagesTotalEPFSalary);
        }

        private void txtBasicSalary_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtBasicSalary);
        }

        private void txtBudgetAllowance_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtBudgetAllowance);
        }

        private void txtRecrumentTotalEPF_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtRecrumentTotalEPF);
        }

        private void txtTravellingAttendance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTravellingAttendance_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtTravellingAttendance);
        }

        private void txtFixedIncentiveValue_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtFixedIncentiveValue);
        }

        private void txtProductionSalesPerformanceTotalValue_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtProductionSalesPerformanceTotalValue);
        }

        private void txtPerformancePrecentage_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtPerformancePrecentage);
        }

        private void txtSalesPrecentage_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtSalesPrecentage);
        }

        private void txtWorkshopIncentivePresentage_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtWorkshopIncentivePresentage);
        }

        private void txtDownTimeMatchineBreakDownPresentage_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtDownTimeMatchineBreakDownPresentage);
        }

        private void txtMachievingMaintenancePresentage_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtMachievingMaintenancePresentage);
        }

        private void txtAchievingProductionTargetsPresentage_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtAchievingProductionTargetsPresentage);
        }

        private void txtMillSectionTargetsPresentage_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtMillSectionTargetsPresentage);
        }

        private void txtHawailSectionProductionPresentage_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtHawailSectionProductionPresentage);
        }

        private void txtAchievingSalesTargetsPresentage_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtAchievingSalesTargetsPresentage);
        }

        private void txtSecurityPerformanceIncentivePresentage_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtSecurityPerformanceIncentivePresentage);
        }

        private void txtVariableIncentivePrecentage_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtVariableIncentivePrecentage);
        }

        private void txtHawailSectionProductionPresentage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void resetForm()
        {
            frmAddNewEmployee_Load(this, new EventArgs());
            txtEmployeeName.Text = string.Empty;
            rdbGenderMale.Checked = true;
            txtTokenNo.Text = string.Empty;
            txtEPFNo.Text = string.Empty;
            txtNICNo.Text = string.Empty;
            cmbDesignation.Text = string.Empty;
            dtpDateOfAppointment.Value = DateTime.Today;
            cmbEmployeeCatagory.SelectedIndex = -1;
            cmbEmployeeGrade.SelectedIndex = -1;
            chbEPFEntitled.Checked = false;
            chbPieceRate.Checked = false;
            cmbDateRateOfSalary.SelectedIndex = -1;
            txtDayWagesDayRate.Text = "0";
            txtDayWagesTotalEPFSalary.Text = "0";
            txtBasicSalary.Text = "0";
            txtBudgetAllowance.Text = "0";
            txtRecrumentTotalEPF.Text = "0";
            txtTravellingAttendance.Text = "0";
            txtFixedIncentiveType.Text = string.Empty;
            txtFixedIncentiveValue.Text = "0";
            txtProductionSalesPerformanceTotalValue.Text = "0";
            txtPerformancePrecentage.Text = "0";
            txtSalesPrecentage.Text = "0";
            txtProductPrecentage.Text = "0";
            txtWorkshopIncentivePresentage.Text = "0";
            txtDownTimeMatchineBreakDownPresentage.Text = "0";
            txtMachievingMaintenancePresentage.Text = "0";
            txtAchievingProductionTargetsPresentage.Text = "0";
            txtMillSectionTargetsPresentage.Text = "0";
            txtHawailSectionProductionPresentage.Text = "0";
            txtAchievingSalesTargetsPresentage.Text = "0";
            txtSecurityPerformanceIncentivePresentage.Text = "0";
            txtVariableIncentiveType.Text = string.Empty;
            txtVariableIncentivePrecentage.Text = "0";
            dataset.NewVariableIncentive.Rows.Clear();
            dataset.NewFixedIncentive.Rows.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //DataSets.EmployeeDetailsRepoartDataset ds = new DataSets.EmployeeDetailsRepoartDataset();
            //ds.EmployeeDetails.AddEmployeeDetailsRow("Kottawa", "Malapalla", "Pasal Sanwardhana Samithiya");

            //Report.EmployeeDetails rpt = new Report.EmployeeDetails();
            //rpt.SetDataSource(ds);

            //rpt.PrintToPrinter(1, false, 1, 1);
        }
    }
}