using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TeemaApplication.Classes;
using TeemaApplication.DataSets;

namespace TeemaApplication
{
    public partial class frmViewEmployeeDetails : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
        Employee emp = null;
        TeemaDataSet dataset = new TeemaDataSet();

        public frmViewEmployeeDetails()
        {
            InitializeComponent();
        }

        public frmViewEmployeeDetails(Employee employee)
        {
            InitializeComponent();
            emp = employee;
            EmployeeUtils.fillcmbWorkingBranch(db, cmbWorkingBranch);
            EmployeeUtils.fillcmbDepartment((Branch)cmbWorkingBranch.SelectedItem, cmbDepartment);
            EmployeeUtils.fillcmbSubDepartment((Department)cmbDepartment.SelectedItem, cmbSubDepartment);
            EmployeeUtils.fillcmbDesignation(db, cmbDesignation);
            gdvFixedIncentives.DataSource = dataset.NewFixedIncentive;
            gdvVariableIncentive.DataSource = dataset.NewVariableIncentive;
        }

        private void frmViewEmployeeDetails_Load(object sender, EventArgs e)
        {
            FillDetails();
        }

        private void FillDetails()
        {
            if (emp != null)
            {
                cmbWorkingBranch.Text = emp.SubDepartment.Department.Branch.BranchName;
                cmbDepartment.Text = emp.SubDepartment.Department.DepartmentName;
                cmbSubDepartment.Text = emp.SubDepartment.SubDepartmentName;
                cmbDesignation.Text = emp.Designation.Designation1;
                txtEmployeeName.Text = emp.Name;
                rdbGenderMale.Checked = emp.Gender.ToUpper().Equals("MALE") ? true : false;
                rdbGenderFemale.Checked = emp.Gender.ToUpper().Equals("FEMALE") ? true : false;
                txtTokenNo.Text = emp.TokenNo;
                txtEPFNo.Text = emp.EPFNo;
                txtNICNo.Text = emp.NICNo;
                dtpDateOfAppointment.Value = emp.DateOfAppointment.Value;
                cmbEmployeeCatagory.Text = emp.EmployeeCatagory;
                cmbEmployeeGrade.Text = emp.EmployeeGrade;
                chbEPFEntitled.Checked = emp.EPFEntitled.Value ? true : false;
                chbPieceRate.Checked = emp.PieceRateEntitled.Value ? true : false;
                cmbDateRateOfSalary.Text = emp.NoPayCalculataionDate.ToString();
                txtDayWagesDayRate.Text = emp.EmployeeSalaryDetail.DayWagesAmount.ToString();
                txtDayWagesTotalEPFSalary.Text = emp.EmployeeSalaryDetail.DayWagesAmount.ToString().Equals("0") ? "0" : emp.EmployeeSalaryDetail.TotalValueForEPF.ToString();
                txtBasicSalary.Text = emp.EmployeeSalaryDetail.BasicSalary.ToString();
                txtBudgetAllowance.Text = emp.EmployeeSalaryDetail.BudgetAllowance.ToString();
                txtRecrumentTotalEPF.Text = emp.EmployeeSalaryDetail.BasicSalary.ToString().Equals("0") ? "0" : emp.EmployeeSalaryDetail.TotalValueForEPF.ToString();
                txtTravellingAttendance.Text = emp.FixedIncentives.Where(f => f.IncentiveType.Equals("Traveling Attendance")).SingleOrDefault().InventiveValue.ToString();

                dataset.NewFixedIncentive.Clear();
                foreach (FixedIncentive fin in emp.FixedIncentives.Where(f => !f.IncentiveType.Equals("Traveling Attendance")))
                {
                    dataset.NewFixedIncentive.AddNewFixedIncentiveRow(fin.IncentiveType, fin.InventiveValue.Value);
                }
                gdvFixedIncentives.DataSource = dataset.NewFixedIncentive;

                txtProductionSalesPerformanceTotalValue.Text = "1000";
                txtPerformancePrecentage.Text = emp.VariableIncentives.Where(v => v.IncentiveType.Equals("Performance")).SingleOrDefault().IncentivePrecentage.ToString();
                txtSalesPrecentage.Text = emp.VariableIncentives.Where(v => v.IncentiveType.Equals("Sales")).SingleOrDefault().IncentivePrecentage.ToString();
                txtProductPrecentage.Text = emp.VariableIncentives.Where(v => v.IncentiveType.Equals("Product")).SingleOrDefault().IncentivePrecentage.ToString();
                txtWorkshopIncentivePresentage.Text = emp.VariableIncentives.Where(v => v.IncentiveType.Equals("Workshop")).SingleOrDefault().IncentivePrecentage.ToString();
                txtDownTimeMatchineBreakDownPresentage.Text = emp.VariableIncentives.Where(v => v.IncentiveType.Equals("Down Time Machine Break Down")).SingleOrDefault().IncentivePrecentage.ToString();
                txtMachievingMaintenancePresentage.Text = emp.VariableIncentives.Where(v => v.IncentiveType.Equals("Machieving Maintenance")).SingleOrDefault().IncentivePrecentage.ToString();
                txtAchievingProductionTargetsPresentage.Text = emp.VariableIncentives.Where(v => v.IncentiveType.Equals("Achieving Production Targets")).SingleOrDefault().IncentivePrecentage.ToString();
                txtMillSectionTargetsPresentage.Text = emp.VariableIncentives.Where(v => v.IncentiveType.Equals("Mill Section Targets")).SingleOrDefault().IncentivePrecentage.ToString();
                txtHawailSectionProductionPresentage.Text = emp.VariableIncentives.Where(v => v.IncentiveType.Equals("Hawail Section Production")).SingleOrDefault().IncentivePrecentage.ToString();
                txtAchievingSalesTargetsPresentage.Text = emp.VariableIncentives.Where(v => v.IncentiveType.Equals("Achieving Sales Targets")).SingleOrDefault().IncentivePrecentage.ToString();
                txtSecurityPerformanceIncentivePresentage.Text = emp.VariableIncentives.Where(v => v.IncentiveType.Equals("Security Performance Targets")).SingleOrDefault().IncentivePrecentage.ToString();

                List<string> varibleIns = new List<string>();
                varibleIns.Add("Performance");
                varibleIns.Add("Sales");
                varibleIns.Add("Product");
                varibleIns.Add("Workshop");
                varibleIns.Add("Down Time Machine Break Down");
                varibleIns.Add("Machieving Maintenance");
                varibleIns.Add("Achieving Production Targets");
                varibleIns.Add("Mill Section Targets");
                varibleIns.Add("Hawail Section Production");
                varibleIns.Add("Achieving Sales Targets");
                varibleIns.Add("Security Performance Targets");

                dataset.NewVariableIncentive.Clear();
                foreach (VariableIncentive varIns in emp.VariableIncentives)
                {
                    if (!varibleIns.Contains(varIns.IncentiveType))
                    {
                        dataset.NewVariableIncentive.AddNewVariableIncentiveRow(varIns.IncentiveType, varIns.IncentivePrecentage.Value);
                    }
                }
                gdvVariableIncentive.DataSource = dataset.NewVariableIncentive;
            }
        }

        private void cmbWorkingBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbDepartment((Branch)cmbWorkingBranch.SelectedItem, cmbDepartment);
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeUtils.fillcmbSubDepartment((Department)cmbDepartment.SelectedItem, cmbSubDepartment);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FillDetails();
        }

        #region ButtonLeave

        private void txtDayWagesDayRate_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtDayWagesDayRate);
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

        private void txtRecrumentTotalEPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRecrumentTotalEPF_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtRecrumentTotalEPF);
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

        private void txtProductPrecentage_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtProductPrecentage);
        }

        private void txtWorkshopIncentivePresentage_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtWorkshopIncentivePresentage);
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

        private void txtIncentivePrecentage_Leave(object sender, EventArgs e)
        {
            EmployeeUtils.checkIfEmpty(txtIncentivePrecentage);
        }

        #endregion

        private void calculateVaribleIncentiveValues()
        {
            double ProductionSalesPerformanceTotal = EmployeeUtils.getVariableIncentiveValue(txtProductionSalesPerformanceTotalValue);
            double performPrecentage = EmployeeUtils.getVariableIncentiveValue(txtPerformancePrecentage) / 100.0;
            double salesPrecentage = EmployeeUtils.getVariableIncentiveValue(txtSalesPrecentage) / 100.0;
            double productPrecentage = EmployeeUtils.getVariableIncentiveValue(txtProductPrecentage) / 100.0;

            double performValue = ProductionSalesPerformanceTotal * performPrecentage;
            double salesValue = ProductionSalesPerformanceTotal * salesPrecentage;
            double productValue = ProductionSalesPerformanceTotal * productPrecentage;

            txtPerformValue.Text = performValue.ToString("0");
            txtSalesValue.Text = salesValue.ToString("0");
            txtProductValue.Text = productValue.ToString("0");
        }

        private void txtProductionSalesPerformanceTotalValue_TextChanged(object sender, EventArgs e)
        {
            calculateVaribleIncentiveValues();
        }

        private void txtPerformancePrecentage_TextChanged(object sender, EventArgs e)
        {
            calculateVaribleIncentiveValues();
        }

        private void txtSalesPrecentage_TextChanged(object sender, EventArgs e)
        {
            calculateVaribleIncentiveValues();
        }

        private void txtProductPrecentage_TextChanged(object sender, EventArgs e)
        {
            calculateVaribleIncentiveValues();
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

        private void btnAddVari_Incentive_Click(object sender, EventArgs e)
        {
            double incentivePrecentage = 0;

            if (double.TryParse(txtIncentivePrecentage.Text, out incentivePrecentage))
            {
                dataset.NewVariableIncentive.AddNewVariableIncentiveRow(txtIncentiveType.Text, incentivePrecentage);
                txtIncentiveType.Focus();
            }
            else
            {
                ShowMessageBox.ShowError("Please enter numaric value for Incentive Precentage.");
                txtWorkshopIncentivePresentage.Focus();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
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
                int employeeID = emp.EmployeeID;
                emp = db.Employees.Where(em => em.EmployeeID == employeeID).SingleOrDefault();

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

                    emp.TokenNo = txtTokenNo.Text;
                    emp.EnrolmentID = EmployeeUtils.getIntNumaricValue("Token No", txtTokenNo.Text);
                    emp.Name = txtEmployeeName.Text;
                    emp.Gender = Gender;
                    emp.DateOfAppointment = dtpDateOfAppointment.Value;
                    emp.EPFNo = txtEPFNo.Text;
                    emp.NICNo = txtNICNo.Text;
                    emp.EmployeeCatagory = cmbEmployeeCatagory.Text;
                    emp.EmployeeGrade = cmbEmployeeGrade.Text;
                    emp.NoPayCalculataionDate = EmployeeUtils.getIntNumaricValue("No Pay Calculation Date", cmbDateRateOfSalary.Text);
                    emp.PieceRateEntitled = chbPieceRate.Checked;
                    emp.EPFEntitled = chbEPFEntitled.Checked;
                    emp.Designation = designation;
                    emp.SubDepartment = subDepartment;
                    emp.ModifiedBy = 1;
                    emp.ModifiedDate = DateTime.Now;

                    double EPFValue = 0;
                    if (cmbEmployeeCatagory.Text.Trim().Equals("Day Wages"))
                    {
                        EPFValue = EmployeeUtils.getDoubleNumaricValue("EPF ETF Total Salary", txtDayWagesTotalEPFSalary.Text);
                    }
                    else
                    {
                        EPFValue = EmployeeUtils.getDoubleNumaricValue("Total For EPF ETF", txtRecrumentTotalEPF.Text);
                    }

                    emp.EmployeeSalaryDetail.BudgetAllowance = EmployeeUtils.getDoubleNumaricValue("Budget Allowance", txtBudgetAllowance.Text);
                    emp.EmployeeSalaryDetail.DayWagesAmount = EmployeeUtils.getDoubleNumaricValue("Day Wages Amount", txtDayWagesDayRate.Text);
                    emp.EmployeeSalaryDetail.TotalValueForEPF = EPFValue;
                    emp.EmployeeSalaryDetail.BasicSalary = EmployeeUtils.getDoubleNumaricValue("Basic Salary", txtBasicSalary.Text);
                    emp.EmployeeSalaryDetail.ModifiedBy = 1;
                    emp.EmployeeSalaryDetail.ModifiedDate = DateTime.Now;

                    db.FixedIncentives.DeleteAllOnSubmit(emp.FixedIncentives);
                    db.SubmitChanges();

                    FixedIncentive travelingIncentive = new FixedIncentive
                    {
                        IncentiveType = "Traveling Attendance",
                        InventiveValue = EmployeeUtils.getDoubleNumaricValue("Traveling And Attendance Incentive", txtTravellingAttendance.Text),
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now,
                        ModifiedBy = 1,
                        ModifiedDate = DateTime.Now,
                        Employee = emp
                    };
                    db.FixedIncentives.InsertOnSubmit(travelingIncentive);

                    foreach (DataGridViewRow x in gdvFixedIncentives.Rows)
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
                            Employee = emp
                        };

                        db.FixedIncentives.InsertOnSubmit(addedIncentive);
                        db.SubmitChanges();
                    }

                    db.VariableIncentives.DeleteAllOnSubmit(emp.VariableIncentives);
                    db.SubmitChanges();

                    db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive("Performance", txtPerformancePrecentage.Text, emp));
                    db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive("Sales", txtSalesPrecentage.Text, emp));
                    db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive("Product", txtProductPrecentage.Text, emp));
                    db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive("Workshop", txtWorkshopIncentivePresentage.Text, emp));
                    db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive("Down Time Machine Break Down", txtDownTimeMatchineBreakDownPresentage.Text, emp));
                    db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive("Machieving Maintenance", txtMachievingMaintenancePresentage.Text, emp));
                    db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive("Achieving Production Targets", txtAchievingProductionTargetsPresentage.Text, emp));
                    db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive("Mill Section Targets", txtMillSectionTargetsPresentage.Text, emp));
                    db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive("Hawail Section Production", txtHawailSectionProductionPresentage.Text, emp));
                    db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive("Achieving Sales Targets", txtAchievingSalesTargetsPresentage.Text, emp));
                    db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive("Security Performance Targets", txtSecurityPerformanceIncentivePresentage.Text, emp));

                    foreach (DataGridViewRow x in gdvVariableIncentive.Rows)
                    {
                        string variableIncentiveType = x.Cells[0].Value.ToString();
                        string variableIncentivePrecentage = x.Cells[1].Value.ToString();

                        db.VariableIncentives.InsertOnSubmit(EmployeeUtils.getVariableIncentive(variableIncentiveType, variableIncentivePrecentage, emp));
                    }

                    db.SubmitChanges();

                    ShowMessageBox.ShowSuccess("Successfully inserted employee details to the database.");
                    FillDetails();
                }
                catch (Exception ex)
                {
                    ShowMessageBox.ShowError("Something went wrong while saving details in to the database. " + ex.Message);
                }
            }
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

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
