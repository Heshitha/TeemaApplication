﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeemaApplication
{
    public partial class AddLeaves : Form
    {

        TeemaDBDataContext db = new TeemaDBDataContext();
        public AddLeaves()
        {
            InitializeComponent();
        }

        // fill Depsrtment Search combo boxes
        private void fillcmbBranch()
        {
            cmbBranch.DisplayMember = "BranchName";
            cmbBranch.ValueMember = "BranchID";
            cmbBranch.DataSource = db.Branches; 
        }
        // fill Depsrtment Search combo boxes
        private void fillcmbDepartment(Branch branch)
        {
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "DepartmentID";
            cmbDepartment.DataSource = branch.Departments;
        }
        // fill Depsrtment Search combo boxes
        private void fillcmbSubDepartment(Department department)
        {
            cmbSubDepartment.DisplayMember = "SubDepartmentName";
            cmbSubDepartment.ValueMember = "SubDepartmentID";
            cmbSubDepartment.DataSource = department.SubDepartments;
        }

        private void AddLeaves_Load(object sender, EventArgs e)
        {
            fillcmbBranch();
            fillcmbDepartment((Branch)cmbBranch.SelectedItem);
            fillcmbSubDepartment((Department)cmbDepartment.SelectedItem);
            fillLeavesGrid((SubDepartment)cmbSubDepartment.SelectedItem);
        }


        // Fill leaves grid
        private void fillLeavesGrid(SubDepartment subdepartment)
        {
            //dgvLeaves.DataSource = subdepartment.Employees;
            //dgvLeaves.DataSource = subdepartment.Employees.Select(c => new { c.TokenNo,c.Name,c.EPFNo});

            var gridata = (from emp in db.Employees 
                          // from grntlvs in db.GrantedLeaves
                           join subd in db.SubDepartments on emp.SubDepartmentID equals subd.SubDepartmentID
                         //  join grndlvs in db.GrantedLeaves on emp.EmployeeID equals grndlvs.EmployeeID
                           where subd.SubDepartmentID == subdepartment.SubDepartmentID 
                           select new { emp.TokenNo, emp.Name, emp.EPFNo });
            dgvLeaves.DataSource = gridata;
    
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillcmbSubDepartment((Department)cmbDepartment.SelectedItem);
            
            
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillcmbDepartment((Branch)cmbBranch.SelectedItem);
           
        }

        private void cmbSubDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            fillLeavesGrid((SubDepartment)cmbSubDepartment.SelectedItem);
        }

        // fill emplyee details text boxes from selected item in grid
        private void fillEmployeeDetailsgrpbox()
        {
            cleartextbox(grpEmployeeDetails);

            String empid = Convert.ToString(dgvLeaves.SelectedRows[0].Cells[0].Value);

            var data = (from emp in db.Employees
                             where emp.TokenNo == empid
                             select new { emp.EmployeeID, emp.Name, emp.NICNo,emp.EPFNo, emp.Designation.Designation1, emp.TokenNo, emp.SubDepartment.SubDepartmentName,emp.SubDepartment.Department.DepartmentName,emp.SubDepartment.Department.Branch.BranchName });

           foreach (var e in data)
            {
               txtEmployeeName.Text = e.Name;
               txtDesignation.Text = e.Designation1;
               txtNICNo.Text = e.NICNo;
               txtEPFNO.Text = e.EPFNo;
               txtTokenNo.Text = e.TokenNo;
               txtDepartment.Text = e.DepartmentName;
               txtSubDepartment.Text = e.SubDepartmentName;
               txtBranch.Text = e.BranchName;
            }
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

        private void dgvLeaves_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillEmployeeDetailsgrpbox();
        }

        private void addLeaves()
        {
            int year = Convert.ToInt32(cmbLeaveYear.Text);
            int annual = Convert.ToInt32(txtAnnual.Text);
            int casual = Convert.ToInt32(txtCasual.Text);

            String tokenid = Convert.ToString(dgvLeaves.SelectedRows[0].Cells[0].Value);

            //Get Employee id using token number
            var varempID = (from emp in db.Employees 
                        where emp.TokenNo == tokenid
                        select new {emp.EmployeeID});

          
            // insert to  granted leaves
            GrantedLeave GLeaves = new GrantedLeave();

            int empID;

            foreach (var e in varempID)
            {
                empID = Convert.ToInt32(e.EmployeeID);
                GLeaves.EmployeeID = empID;
                GLeaves.year = year;
                GLeaves.Annual = annual;
                GLeaves.Casual = casual;
            }
 
            db.GrantedLeaves.InsertOnSubmit(GLeaves);
            db.SubmitChanges();

            //reload grid view
            fillcmbSubDepartment((Department)cmbDepartment.SelectedItem);
           
        }

        private void btnAddLeaves_Click(object sender, EventArgs e)
        {
            addLeaves();
        }
    }

}
