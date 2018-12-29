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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            bool state = false, unitAdmin = false;
            Employee employee;

            if (txtName.Text == "" || txtSurname.Text == "" || txtAge.Text == "" || txtGender.Text == "" || cboxDepartment.Text == "")
                MessageBox.Show("Do not leave free space!");
            else
            {
                if (Convert.ToInt32(txtAge.Text) < 1)
                    MessageBox.Show("Age should be greater than zero.");
                else
                {
                    using (ERPEntities db = new ERPEntities())
                    {

                        employee = new Employee();
                        employee.Name = txtName.Text;
                        employee.Surname = txtSurname.Text;
                        employee.Gender = txtGender.Text;
                        employee.Age = Convert.ToInt32(txtAge.Text);
                        employee.Startofwork = dTimeStartofwork.Text;
                        employee.Birthday = dTimeBirthday.Text;
                        employee.Department = cboxDepartment.SelectedItem.ToString();

                        if (checkBoxLogin.Checked == true)
                        {
                            if (txtUserName.Text != "" && txtPassword.Text != "")
                            {
                                employee.userName = txtUserName.Text;
                                employee.password = txtPassword.Text;
                                db.Employee.Add(employee);
                                db.SaveChanges();

                                setNullText();

                                state = true;
                                unitAdmin = true;

                                MessageBox.Show("Employee successfully added.");
                            }
                            else
                                MessageBox.Show("Please enter username and password.");

                        }
                        else
                        {
                            if (employee.Department == "Purchasing Specialist")
                            {
                                MessageBox.Show("The purchase authority must have a username and password.");
                            }
                            else
                            {
                                db.Employee.Add(employee);
                                db.SaveChanges();

                                setNullText();
                                
                                MessageBox.Show("Employee successfully added.");
                                state = true;
                            }

                        }

                    }



                    if (state == true)
                    {
                        if (unitAdmin == true)
                        {
                            using (ERPEntities dbEntity = new ERPEntities())
                            {
                                Event mEvent = new Event();
                                mEvent.eventName = "Unit Admin Employee ID:" + employee.employeeID + ", Name:" + employee.Name + " added to system.";
                                mEvent.eventDate = DateTime.Now.ToString();
                                dbEntity.Event.Add(mEvent);
                                dbEntity.SaveChanges();

                                setNullText();

                                state = false;
                                unitAdmin = false;
                            }
                        }
                        else
                        {
                            using (ERPEntities dbEntity2 = new ERPEntities())
                            {
                                Event mEvent = new Event();
                                mEvent.eventName = "Employee ID:" + employee.employeeID + ", Name:" + employee.Name + " added to system.";
                                mEvent.eventDate = DateTime.Now.ToString();
                                dbEntity2.Event.Add(mEvent);
                                dbEntity2.SaveChanges();
                                state = false;
                            }
                        }
                    }
                }
            }
           
        }

        private void checkBoxLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLogin.Checked == true)
            {
                lblUserName.Visible = true;
                lblPassword.Visible = true;
                txtUserName.Visible = true;
                txtPassword.Visible = true;
            }
            else
            {
                txtUserName.Text = "";
                txtPassword.Text = "";
                lblUserName.Visible = false;
                lblPassword.Visible = false;
                txtUserName.Visible = false;
                txtPassword.Visible = false;
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

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

        private void txtGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
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

        private void txtSurname_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txtSurname.Text == "")
            {
                errorSurname.SetError(txtSurname, "This field is empty.");
            }
            else
                errorSurname.Clear();
        }

        private void txtGender_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txtGender.Text == "")
            {
                errorGender.SetError(txtGender, "This field is empty.");
            }
            else
                errorGender.Clear();
        }

        private void txtAge_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txtAge.Text == "")
            {
                errorAge.SetError(txtAge, "This field is empty.");
            }
            else
                errorAge.Clear();
        }

        private void cboxDepartment_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (cboxDepartment.Text == "")
            {
                errorDepartmen.SetError(cboxDepartment, "This field is empty.");
            }
            else
                errorDepartmen.Clear();
        }

        private void txtUserName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txtUserName.Text == "")
            {
                errorID.SetError(txtUserName, "This field is empty.");
            }
            else
                errorID.Clear();
        }

        private void txtPassword_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txtPassword.Text == "")
            {
                errorPassword.SetError(txtPassword, "This field is empty.");
            }
            else
                errorPassword.Clear();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
        public void setNullText()
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtGender.Text = "";
            txtAge.Text = "";
            cboxDepartment.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
    }
}
