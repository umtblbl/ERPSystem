using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ERP
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLoginAdministrator_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Do not leave free space!");
            else
            {

                if (txtID.Text.ToLower() == "admin" && txtPassword.Text.ToLower() == "password")
                {
                    MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
                    Panel mainPanel = mainForm.Controls["mainPanel"] as Panel;
                    mainPanel.Controls.Clear();

                    AdminForm adminForm = new AdminForm();
                    adminForm.TopLevel = false;
                    mainPanel.Controls.Add(adminForm);
                    adminForm.Show();
                    adminForm.Dock = DockStyle.Fill;
                }
                else
                    MessageBox.Show("The user name or password is invalid.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnLoginPurchasingAdmin_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Do not leave free space!");
            else
            {
                bool login = false;

                using (var erpEntities = new ERPEntities())
                {
                    var employee = (from emp in erpEntities.Employee select new { emp.userName, emp.password, emp.Department }).ToList();

                    foreach (var item in employee.ToList())
                    {
                        if (item.userName != null && item.password != null)
                        {
                            if (txtID.Text == item.userName.TrimEnd() && txtPassword.Text == item.password.TrimEnd() && item.Department == "Purchasing Specialist")
                                login = true;
                        }

                    }
                }
                if (login == true)
                {
                    login = false;

                    MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
                    Panel mainPanel = mainForm.Controls["mainPanel"] as Panel;
                    mainPanel.Controls.Clear();

                    PurchasingAdminForm purchasingAdminForm = new PurchasingAdminForm();
                    purchasingAdminForm.TopLevel = false;
                    mainPanel.Controls.Add(purchasingAdminForm);
                    purchasingAdminForm.Show();
                    purchasingAdminForm.Dock = DockStyle.Fill;
                }
                else
                    MessageBox.Show("The user name or password is invalid.");
            }
        }

        private void btnLoginUnitAdmin_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Do not leave free space!");
            else
            {

                bool login2 = false;

                using (var erpEntities2 = new ERPEntities())
                {
                    var employee = (from emp in erpEntities2.Employee select new { emp.userName, emp.password, emp.Department }).ToList();

                    foreach (var item in employee.ToList())
                    {
                        if (item.userName != null && item.password != null)
                        {
                            if (txtID.Text == item.userName.TrimEnd() && txtPassword.Text == item.password.TrimEnd() && item.Department != "Purchasing Specialist")
                                login2 = true;
                        }
                    }
                }
                if (login2 == true)
                {
                    login2 = false;

                    MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
                    Panel mainPanel = mainForm.Controls["mainPanel"] as Panel;
                    mainPanel.Controls.Clear();

                    ListingReportForm listingReportForm = new ListingReportForm();
                    listingReportForm.TopLevel = false;
                    mainPanel.Controls.Add(listingReportForm);
                    listingReportForm.Show();
                    listingReportForm.Dock = DockStyle.Fill;
                }
                else
                    MessageBox.Show("You do not have access authorization!");
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manisa Celal Bayar University - Software Testing Project\n\nDeveloped by Ramazan Ümit Bülbül & Muhammed Can Çiçek.\n");
        }

        private void txtID_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txtID.Text == "")
            {
                errorProvider1.SetError(txtID, "This field is empty.");
            }
            else
                errorProvider1.Clear();
        }

        private void txtPassword_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txtPassword.Text == "")
            {
                errorProvider2.SetError(txtID, "This field is empty.");
            }
            else
                errorProvider2.Clear();
        }
    }
}