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
    public partial class frmLeaveApply : Form
    {
        public frmLeaveApply()
        {
            InitializeComponent();
        }

        TeemaDBDataContext db = new TeemaDBDataContext();

        private void searchEmployee()
        {
            if (txtKeyWord.Text != "")
            {
                int Searchkey = Convert.ToInt32(txtKeyWord.Text);

                if (rbtNIC.Checked)
                {

                    Employee empdata = (from emp in db.Employees
                                        where emp.EmployeeID == Searchkey
                                        select emp).SingleOrDefault();

                    
                    if (empdata != null && empdata.EmployeeID == Searchkey)
                    {
                        GrantedLeave grntslvs = (from grntdlvs in empdata.GrantedLeaves
                                                 where grntdlvs.year == Convert.ToInt32(System.DateTime.Today.Year)
                                                 select grntdlvs).SingleOrDefault();

                        

                        txtEmployeeName.Text = empdata.Name;
                        txtEPFno.Text = empdata.EPFNo;
                        txtBranch.Text = empdata.SubDepartment.Department.Branch.BranchName;
                        txtDepartment.Text = empdata.SubDepartment.Department.DepartmentName;
                        txtDesignation.Text = empdata.Designation.Designation1;
                        txtNicNo.Text = empdata.NICNo;
                        txtSubDepartment.Text = empdata.SubDepartment.SubDepartmentName;
                        txtTokenNo.Text = empdata.TokenNo;

                        if (grntslvs != null && grntslvs.EmployeeID == empdata.EmployeeID)
                        {

                            txtLeavesEntitledAnnual.Text = grntslvs.Annual.ToString();
                            txtLeavesEntitledCasual.Text = grntslvs.Casual.ToString();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Employee not found");
                    }

                }
                else if (rbtEPFNo.Checked)
                {

                    Employee empdata = (from emp in db.Employees
                                        where emp.EPFNo == Convert.ToString(Searchkey)
                                        select emp).SingleOrDefault();
                     
                    if (empdata != null && empdata.EPFNo == Convert.ToString(Searchkey))
                    {
                        GrantedLeave grntslvs = (from grntdlvs in empdata.GrantedLeaves
                                                 where grntdlvs.year == Convert.ToInt32(System.DateTime.Today.Year)
                                                 select grntdlvs).SingleOrDefault();

                        txtEmployeeName.Text = empdata.Name;
                        txtEPFno.Text = empdata.EPFNo;
                        txtBranch.Text = empdata.SubDepartment.Department.Branch.BranchName;
                        txtDepartment.Text = empdata.SubDepartment.Department.DepartmentName;
                        txtDesignation.Text = empdata.Designation.Designation1;
                        txtNicNo.Text = empdata.NICNo;
                        txtSubDepartment.Text = empdata.SubDepartment.SubDepartmentName;
                        txtTokenNo.Text = empdata.TokenNo;

                        if (grntslvs != null && grntslvs.EmployeeID == empdata.EmployeeID)
                        {

                            txtLeavesEntitledAnnual.Text = grntslvs.Annual.ToString();
                            txtLeavesEntitledCasual.Text = grntslvs.Casual.ToString();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Employee not found");
                    }

                }
                else if (rbtTokenNo.Checked)
                {
                    Employee empdata = (from emp in db.Employees
                                        where emp.TokenNo == Convert.ToString(Searchkey)
                                        select emp).SingleOrDefault();
                     
                    if (empdata != null && empdata.TokenNo == Convert.ToString(Searchkey))
                    {
                        GrantedLeave grntslvs = (from grntdlvs in empdata.GrantedLeaves
                                                 where grntdlvs.year == Convert.ToInt32(System.DateTime.Today.Year)
                                                 select grntdlvs).SingleOrDefault();

                        txtEmployeeName.Text = empdata.Name;
                        txtEPFno.Text = empdata.EPFNo;
                        txtBranch.Text = empdata.SubDepartment.Department.Branch.BranchName;
                        txtDepartment.Text = empdata.SubDepartment.Department.DepartmentName;
                        txtDesignation.Text = empdata.Designation.Designation1;
                        txtNicNo.Text = empdata.NICNo;
                        txtSubDepartment.Text = empdata.SubDepartment.SubDepartmentName;
                        txtTokenNo.Text = empdata.TokenNo;

                        if (grntslvs != null && grntslvs.EmployeeID == empdata.EmployeeID)
                        {

                            txtLeavesEntitledAnnual.Text = grntslvs.Annual.ToString();
                            txtLeavesEntitledCasual.Text = grntslvs.Casual.ToString();
                        }
                         
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKeyWord.Text = "";
        }

        private void cleartextbox(Control control)
        {

            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cleartextbox(grpEmployeeDetails);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchEmployee();
        }
           
    }
}
