using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ERP
{
    public partial class AdminForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            
            adminPanel.Controls.Clear();
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.TopLevel = false;
            adminPanel.Controls.Add(addEmployeeForm);
            addEmployeeForm.Show();
            addEmployeeForm.Dock = DockStyle.Fill;
           
        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            adminPanel.Controls.Clear();
            ListingEmployeeForm listingEmployeeForm = new ListingEmployeeForm();
            listingEmployeeForm.TopLevel = false;
            adminPanel.Controls.Add(listingEmployeeForm);
            listingEmployeeForm.Show();
            listingEmployeeForm.Dock = DockStyle.Fill;


        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            adminPanel.Controls.Clear();
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.TopLevel = false;
            adminPanel.Controls.Add(addProductForm);
            addProductForm.Show();
            addProductForm.Dock = DockStyle.Fill;
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            adminPanel.Controls.Clear();
            AddDebitForm addDebitForm = new AddDebitForm();
            addDebitForm.TopLevel = false;
            adminPanel.Controls.Add(addDebitForm);
            addDebitForm.Show();
            addDebitForm.Dock = DockStyle.Fill;
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            adminPanel.Controls.Clear();
            RemoveDebitForm removeDebitForm = new RemoveDebitForm();
            removeDebitForm.TopLevel = false;
            adminPanel.Controls.Add(removeDebitForm);
            removeDebitForm.Show();
            removeDebitForm.Dock = DockStyle.Fill;
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            adminPanel.Controls.Clear();
            RemoveProductForm removeProductForm = new RemoveProductForm();
            removeProductForm.TopLevel = false;
            adminPanel.Controls.Add(removeProductForm);
            removeProductForm.Show();
            removeProductForm.Dock = DockStyle.Fill;
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            adminPanel.Controls.Clear();
            ListingReportForm listingReportForm = new ListingReportForm();
            listingReportForm.TopLevel = false;
            adminPanel.Controls.Add(listingReportForm);
            listingReportForm.Show();
            listingReportForm.Dock = DockStyle.Fill;
        }
    }
}
