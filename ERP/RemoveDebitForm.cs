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
    public partial class RemoveDebitForm : Form
    {
        public RemoveDebitForm()
        {
            InitializeComponent();
        }

        string debitIndex="", productIndex;

        private void RemoveDebitForm_Load(object sender, EventArgs e)
        {
            ERPEntities erpEntities = new ERPEntities();
            var debit = (from emp in erpEntities.Debit
                             select new { emp.debitID, emp.productID, emp.debitPersonID, emp.debitAdminID, emp.debitDate }).ToList();
            gridDebitList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridDebitList.DataSource = debit;
        }

        private void btnRemoveDebit_Click(object sender, EventArgs e)
        {

            int mDebitIndex=0;

                if (debitIndex != "")
                    mDebitIndex = Convert.ToInt32(debitIndex);

            bool state = false;

            if (debitIndex != "" && mDebitIndex != 0)
            {
                using (var erpEntities = new ERPEntities())
                {
                    Debit debit = erpEntities.Debit.FirstOrDefault(deleted => deleted.debitID == mDebitIndex);
                    erpEntities.Debit.Remove(debit);
                    erpEntities.SaveChanges();
                    MessageBox.Show("Debit deleted succesfully.");


                    ERPEntities erpEntities2 = new ERPEntities();
                    gridDebitList.DataSource = null;
                    var debits = (from emp in erpEntities2.Debit select new { emp.debitID, emp.productID, emp.debitPersonID, emp.debitAdminID, emp.debitDate }).ToList();
                    gridDebitList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    gridDebitList.DataSource = debits;

                }

                using (var erpEntities2 = new ERPEntities())
                {
                    int mProductIndex = Convert.ToInt32(productIndex);

                    Product product = erpEntities2.Product.FirstOrDefault(updateProduct => updateProduct.productID == mProductIndex);
                    product.ProductState = 1;
                    erpEntities2.SaveChanges();
                }

                state = true;
            }
            else 
                MessageBox.Show("Please select a row.");


            if (state == true)
            {
                using (ERPEntities dbEntity = new ERPEntities())
                {
                    Event mEvent = new Event();
                    mEvent.eventName = "Debit removed. - Debit ID:" + debitIndex + ", Product ID:" + productIndex;
                    mEvent.eventDate = DateTime.Now.ToString();
                    dbEntity.Event.Add(mEvent);
                    dbEntity.SaveChanges();
                    state = false;
                    debitIndex = null;
                }
            }


        }

        private void gridDebitList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridDebitList.Rows[e.RowIndex];

                debitIndex = gridDebitList.Rows[e.RowIndex].Cells["debitID"].Value.ToString();
                productIndex = gridDebitList.Rows[e.RowIndex].Cells["productID"].Value.ToString();
                lblDebitID.Text = debitIndex;
            }

        }
    }
}
