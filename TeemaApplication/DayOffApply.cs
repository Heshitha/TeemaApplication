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
    public partial class frmDayOffApply : Form
    {
        public frmDayOffApply()
        {
            InitializeComponent();
        }

        TeemaDBDataContext db = new TeemaDBDataContext();

        Employee empdata = new Employee();

        private void searchEmployee()
        {
            if (txtKeyWord.Text != "")
            {
                String Searchkey = Convert.ToString(txtKeyWord.Text);

                if (rbtNIC.Checked)
                {

                    empdata = (from emp in db.Employees
                               where emp.NICNo == Searchkey
                               select emp).SingleOrDefault();

                    if (empdata != null && empdata.NICNo == Searchkey)
                    {
                        GrantedLeave grntslvs = (from grntdlvs in empdata.GrantedLeaves
                                                 where grntdlvs.year == Convert.ToInt32(System.DateTime.Today.Year)
                                                 select grntdlvs).SingleOrDefault();


                        txtEmployeeName.Text = empdata.Name;
                        txtEPFNO.Text = empdata.EPFNo;
                        txtBranch.Text = empdata.SubDepartment.Department.Branch.BranchName;
                        txtDepartment.Text = empdata.SubDepartment.Department.DepartmentName;
                        txtDesignation.Text = empdata.Designation.Designation1;
                        txtNICNo.Text = empdata.NICNo;
                        txtSubDepartment.Text = empdata.SubDepartment.SubDepartmentName;
                        txtTokenNo.Text = empdata.TokenNo;
                         
                    }
                    else
                    {
                        MessageBox.Show("Employee not found");
                    }

                }
                else if (rbtEPFNo.Checked)
                {

                    empdata = (from emp in db.Employees
                               where emp.EPFNo == Searchkey
                               select emp).SingleOrDefault();

                    if (empdata != null && empdata.EPFNo == Searchkey)
                    {
                        GrantedLeave grntslvs = (from grntdlvs in empdata.GrantedLeaves
                                                 where grntdlvs.year == Convert.ToInt32(System.DateTime.Today.Year)
                                                 select grntdlvs).SingleOrDefault();

                        txtEmployeeName.Text = empdata.Name;
                        txtEPFNO.Text = empdata.EPFNo;
                        txtBranch.Text = empdata.SubDepartment.Department.Branch.BranchName;
                        txtDepartment.Text = empdata.SubDepartment.Department.DepartmentName;
                        txtDesignation.Text = empdata.Designation.Designation1;
                        txtNICNo.Text = empdata.NICNo;
                        txtSubDepartment.Text = empdata.SubDepartment.SubDepartmentName;
                        txtTokenNo.Text = empdata.TokenNo;
 
                    }
                    else
                    {
                        MessageBox.Show("Employee not found");
                    }

                }
                else if (rbtTokenNo.Checked)
                {
                    empdata = (from emp in db.Employees
                               where emp.TokenNo == Searchkey
                               select emp).SingleOrDefault();

                    if (empdata != null && empdata.TokenNo == (Searchkey))
                    {
                        GrantedLeave grntslvs = (from grntdlvs in empdata.GrantedLeaves
                                                 where grntdlvs.year == Convert.ToInt32(System.DateTime.Today.Year)
                                                 select grntdlvs).SingleOrDefault();

                        txtEmployeeName.Text = empdata.Name;
                        txtEPFNO.Text = empdata.EPFNo;
                        txtBranch.Text = empdata.SubDepartment.Department.Branch.BranchName;
                        txtDepartment.Text = empdata.SubDepartment.Department.DepartmentName;
                        txtDesignation.Text = empdata.Designation.Designation1;
                        txtNICNo.Text = empdata.NICNo;
                        txtSubDepartment.Text = empdata.SubDepartment.SubDepartmentName;
                        txtTokenNo.Text = empdata.TokenNo;
    
                    }
                    else
                    {
                        MessageBox.Show("Employee not found");
                    }

                }
                else
                {
                    MessageBox.Show("Please select a search method");
                }


            }
            else
            {
                MessageBox.Show("Plese enter a Search Key to search");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtdayoffreason.Text = "";
            searchEmployee();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKeyWord.Text = "";
        }

        private void dtpLeaveDate_ValueChanged(object sender, EventArgs e)
        {
            dtpLeaveDate.MinDate = System.DateTime.Today;
        }

        private void frmDayOffApply_Load(object sender, EventArgs e)
        {
            dtpLeaveDate.MinDate = System.DateTime.Today;
        }

        private void adddayoffrequest()
        {
            if (txtTokenNo.Text != "")
            {
                empdata = (from emp in db.Employees
                           where emp.TokenNo == txtTokenNo.Text
                           select emp).SingleOrDefault();

                DayOffRecord df = new DayOffRecord();

                df.EmployeeID = empdata.EmployeeID;
                df.DayOffReason = txtdayoffreason.Text;
                df.DayOffFrom = dtpLeaveDate.Value;
                df.CreatedBy = 1;
                df.CreatedDate = System.DateTime.Today;

                db.DayOffRecords.InsertOnSubmit(df);
                db.SubmitChanges();

                MessageBox.Show("Day off request successfully applied..! ");
            }
            else
            { MessageBox.Show("Please search an employee..!"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                        adddayoffrequest();
        }
    }
}
