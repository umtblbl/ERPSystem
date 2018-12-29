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
    public partial class RemoveProductForm : Form
    {
        public RemoveProductForm()
        {
            InitializeComponent();
        }

        string index;

        private void RemoveProductForm_Load(object sender, EventArgs e)
        {
            ERPEntities erpEntities = new ERPEntities();
            var products = (from emp in erpEntities.Product where emp.ProductState != 3 select new { emp.productID, emp.productName, emp.productType, emp.productSeller, emp.productBrand, emp.productPrice, emp.productDate }).ToList();
            gridListingProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridListingProduct.DataSource = products;
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            int mIndex = Convert.ToInt32(index);
            Product product;
            bool state = false;

            using (var erpEntities = new ERPEntities())
            {
                product = erpEntities.Product.FirstOrDefault(deleted => deleted.productID == mIndex);

                if (index == null)
                {
                    MessageBox.Show("Please select a row.");
                }
                else if (index != null)
                {
                    if (product.ProductState == 2)
                    {
                        MessageBox.Show("Product embeded. Please first remove embedded.");
                    }
                    else
                    {
                        product.ProductState = 3;
                        erpEntities.SaveChanges();
                        MessageBox.Show("Prodoct ID:" + index + ", is deleted.");
                        index = null;
                        state = true;

                        gridListingProduct.DataSource = null;
                        var products = (from emp in erpEntities.Product where emp.ProductState != 3 select new { emp.productID, emp.productName, emp.productType, emp.productSeller, emp.productBrand, emp.productPrice, emp.productDate }).ToList();
                        gridListingProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        gridListingProduct.DataSource = products;
                    }
                    
                }
                else
                    MessageBox.Show("User not found.");

            }
            if(state == true)
            {
                using (ERPEntities dbEntity = new ERPEntities())
                {
                    Event mEvent = new Event();
                    mEvent.eventName = "Product ID:" + product.productID + ", Name:" + product.productName + " removed to stock.";
                    mEvent.eventDate = DateTime.Now.ToString();
                    dbEntity.Event.Add(mEvent);
                    dbEntity.SaveChanges();
                    state = false;
                }
            }
        }

        private void gridListingProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = this.gridListingProduct.Rows[e.RowIndex];

                index = gridListingProduct.Rows[e.RowIndex].Cells["productID"].Value.ToString();
                lblProductID.Text = index;

            }
        }
    }
}
