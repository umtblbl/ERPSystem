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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            Product mProduct;
            bool state = false;
            if (txtName.Text == "" || txtType.Text == "" || txtSeller.Text == "" || txtBrand.Text == "" || txtPrice.Text == "")
                MessageBox.Show("Do not leave free space!");
            else
            {
                if (Convert.ToInt32(txtPrice.Text) < 1)
                    MessageBox.Show("Price should be greater than zero.");
                else
                {
                    using (ERPEntities db = new ERPEntities())
                    {

                        Product product = new Product();
                        product.productName = txtName.Text;
                        product.productType = txtType.Text;
                        product.productSeller = txtSeller.Text;
                        product.productBrand = txtBrand.Text;
                        product.productPrice = Convert.ToInt32(txtPrice.Text);
                        product.productDate = dTime.Text;
                        product.ProductState = 1;

                        db.Product.Add(product);
                        db.SaveChanges();

                        setNullText();

                        state = true;

                        mProduct = product;

                        MessageBox.Show("Product successfully added.");
                    }

                    if (state == true)
                    {
                        using (ERPEntities dbEntity = new ERPEntities())
                        {

                            Event mEvent = new Event();
                            mEvent.eventName = "Product ID:" + mProduct.productID + ", Name:" + mProduct.productName + " added to stock.";
                            mEvent.eventDate = DateTime.Now.ToString();
                            dbEntity.Event.Add(mEvent);
                            dbEntity.SaveChanges();

                            setNullText();

                            state = false;
                        }

                    }
                }
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txtType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtSeller_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtBrand_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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

        private void txtType_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txtType.Text == "")
            {
                errorType.SetError(txtType, "This field is empty.");
            }
            else
                errorType.Clear();
        }

        private void txtSeller_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txtSeller.Text == "")
            {
                errorSeller.SetError(txtSeller, "This field is empty.");
            }
            else
                errorSeller.Clear();
        }

        private void txtBrand_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txtBrand.Text == "")
            {
                errorBrand.SetError(txtBrand, "This field is empty.");
            }
            else
                errorBrand.Clear();
        }

        private void txtPrice_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txtPrice.Text == "")
            {
                errorPrice.SetError(txtPrice, "This field is empty.");
            }
            else
                errorPrice.Clear();
        }
        public void setNullText()
        {
            txtName.Text = "";
            txtType.Text = "";
            txtSeller.Text = "";
            txtBrand.Text = "";
            txtPrice.Text = "";
        }
    }
}
