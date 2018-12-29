using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class ListingEmployeeForm : Form
    {
        public ListingEmployeeForm()
        {
            InitializeComponent();
        }

        string selectedIndex;

        private void ListingEmployeeForm_Load(object sender, EventArgs e)
        {

            ERPEntities erpEntities = new ERPEntities();
            var employees = (from emp in erpEntities.Employee
                             select new { emp.employeeID, emp.Name, emp.Surname, emp.Department, emp.Startofwork, emp.Gender, emp.Age, emp.Birthday }).ToList();
            gridListingEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridListingEmployee.DataSource = employees;

        }
        


        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(selectedIndex);
            Employee employee;
            bool state = false;

            using (var erpEntities = new ERPEntities())
            {
                employee = erpEntities.Employee.FirstOrDefault(deleted => deleted.employeeID == index);

                if (selectedIndex == null)
                {
                    MessageBox.Show("Please select a row.");
                }
                else if (employee != null)
                {
                    erpEntities.Employee.Remove(employee);
                    erpEntities.SaveChanges();
                    state = true;
                    MessageBox.Show("Employee ID:"+selectedIndex + ", is deleted.");
                    selectedIndex = null;

                    gridListingEmployee.DataSource = null;
                    var employees = (from emp in erpEntities.Employee
                                     select new { emp.employeeID, emp.Name, emp.Surname, emp.Department, emp.Startofwork, emp.Gender, emp.Age, emp.Birthday }).ToList();
                    gridListingEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    gridListingEmployee.DataSource = employees;
                }
                else
                    MessageBox.Show("User not found.");
                
            }

            if (state == true)
            {
                using (ERPEntities dbEntity = new ERPEntities())
                {
                    Event mEvent = new Event();
                    mEvent.eventName = "Employee ID:" + employee.employeeID + ", Name:" + employee.Name + " removed to system.";
                    mEvent.eventDate = DateTime.Now.ToString();
                    dbEntity.Event.Add(mEvent);
                    dbEntity.SaveChanges();
                    state = false;
                }

            }
        }

        private void gridListingEmployee_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String name, surName, department; 
                DataGridViewRow row = this.gridListingEmployee.Rows[e.RowIndex];

                selectedIndex = gridListingEmployee.Rows[e.RowIndex].Cells["EmployeeID"].Value.ToString();
                name = gridListingEmployee.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                surName = gridListingEmployee.Rows[e.RowIndex].Cells["Surname"].Value.ToString();
                department = gridListingEmployee.Rows[e.RowIndex].Cells["Department"].Value.ToString();

                txtName.Text = name;
                txtSurname.Text = surName;

                cboxDepartment.SelectedText = department;
             
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtSurname.Text == "" || cboxDepartment.Text == "")
                MessageBox.Show("Do not leave free space!");
            else
            {

                string dp = Convert.ToString(cboxDepartment.SelectedItem);
                bool state = false;
                Employee employee;

                using (var erpEntities = new ERPEntities())
                {
                    int index = Convert.ToInt32(selectedIndex);

                    employee = erpEntities.Employee.FirstOrDefault(deleted => deleted.employeeID == index);

                    if (selectedIndex == null)
                    {
                        MessageBox.Show("Please select a row.");
                    }
                    else if (employee != null)
                    {
                        employee.Name = txtName.Text;
                        employee.Surname = txtSurname.Text;


                        if (employee.Department == dp) { MessageBox.Show("Department is equals."); }
                        else if (employee.Department == null) { MessageBox.Show("Department is null."); }
                        else
                        {

                            employee.Department = Convert.ToString(cboxDepartment.SelectedItem);
                        }


                        erpEntities.SaveChanges();
                        MessageBox.Show("Employee ID:" + selectedIndex + " update.");
                        selectedIndex = null;
                        state = true;

                        gridListingEmployee.DataSource = null;
                        var employees = (from emp in erpEntities.Employee
                                         select new { emp.employeeID, emp.Name, emp.Surname, emp.Department, emp.Startofwork, emp.Gender, emp.Age, emp.Birthday }).ToList();
                        gridListingEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        gridListingEmployee.DataSource = employees;
                    }
                    else
                        MessageBox.Show("User not found.");

                }
                if (state == true)
                {
                    using (ERPEntities dbEntity = new ERPEntities())
                    {
                        Event mEvent = new Event();
                        mEvent.eventName = "Update employee ID:" + employee.employeeID + ", Name:" + employee.Name + " updated from system.";
                        mEvent.eventDate = DateTime.Now.ToString();
                        dbEntity.Event.Add(mEvent);
                        dbEntity.SaveChanges();
                        state = false;
                    }

                }
            }



        }

        private void txtSurname_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txtSurname.Text == "")
            {
                errorSurname.SetError(txtSurname, "This field is empty.");
            }
            else
                errorSurname.Clear();
        }

        private void txtName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txtName.Text == "")
            {
                errorName.SetError(txtName, "This field is empty.");
            }
            else
                errorName.Clear();
        }

        private void cboxDepartment_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (cboxDepartment.Text == "")
            {
                errorDepartment.SetError(cboxDepartment, "This field is empty.");
            }
            else
                errorDepartment.Clear();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
    }
}

