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
    public partial class PurchasingAdminForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public PurchasingAdminForm()
        {
            InitializeComponent();
        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            purchasingPanel.Controls.Clear();
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.TopLevel = false;
            purchasingPanel.Controls.Add(addProductForm);
            addProductForm.Show();
            addProductForm.Dock = DockStyle.Fill;
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            purchasingPanel.Controls.Clear();
            RemoveProductForm removeProductForm = new RemoveProductForm();
            removeProductForm.TopLevel = false;
            purchasingPanel.Controls.Add(removeProductForm);
            removeProductForm.Show();
            removeProductForm.Dock = DockStyle.Fill;
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            purchasingPanel.Controls.Clear();
            AddDebitForm addDebitForm = new AddDebitForm();
            addDebitForm.TopLevel = false;
            purchasingPanel.Controls.Add(addDebitForm);
            addDebitForm.Show();
            addDebitForm.Dock = DockStyle.Fill;
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            purchasingPanel.Controls.Clear();
            RemoveDebitForm removeDebitForm = new RemoveDebitForm();
            removeDebitForm.TopLevel = false;
            purchasingPanel.Controls.Add(removeDebitForm);
            removeDebitForm.Show();
            removeDebitForm.Dock = DockStyle.Fill;
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            purchasingPanel.Controls.Clear();
            ListingReportForm listingReportForm = new ListingReportForm();
            listingReportForm.TopLevel = false;
            purchasingPanel.Controls.Add(listingReportForm);
            listingReportForm.Show();
            listingReportForm.Dock = DockStyle.Fill;
        }
    }
}
