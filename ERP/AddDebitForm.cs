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
    public partial class AddDebitForm : Form
    {
        public AddDebitForm()
        {
            InitializeComponent();
        }

        string selectedEmployee, selectedProduct;

        private void AddDebitForm_Load(object sender, EventArgs e)
        {

            ERPEntities erpEntities = new ERPEntities();//veri tabanı erişimi gerçekleşti
            var products = (from emp in erpEntities.Product where emp.ProductState == 1 select new { emp.productID, emp.productName, emp.productType, emp.productSeller, emp.productBrand, emp.productPrice, emp.productDate}).ToList();
            gridProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//veri tabanında erişilen veriler datagride eklendi
            gridProducts.DataSource = products;
            
            var employees = (from emp in erpEntities.Employee
                             select new { emp.employeeID, emp.Name, emp.Surname, emp.Department, emp.Startofwork, emp.Gender, emp.Age, emp.Birthday }).ToList();
            gridEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//verii tabanına erişim gerçekleşti ve enployee içindeki veriler grid ekranına listelendi
            gridEmployees.DataSource = employees;

        }

        private void btnAddDebit_Click(object sender, EventArgs e)
        {
            int employeeIndex = Convert.ToInt32(selectedEmployee);
            int productIndex = Convert.ToInt32(selectedProduct);
            bool state = false;

            if (lblEmployee.Text != "" && lblProduct.Text != "")
            {
                using (ERPEntities db = new ERPEntities())
                {

                    Debit debit = new Debit();//debit ekleme işlmei gerçeleşti
                    debit.productID = productIndex;
                    debit.debitPersonID = employeeIndex;
                    debit.debitAdminID = 1;//1 numara zinmetli
                    debit.debitDate = DateTime.Now.ToString();

                    db.Debit.Add(debit);
                    db.SaveChanges();

                    using (var erpEntities = new ERPEntities())
                    {
                        
                        Product product = erpEntities.Product.FirstOrDefault(mProduct => mProduct.productID == productIndex);
                        product.ProductState = 2;//listeyi yeniliyoruz
                        erpEntities.SaveChanges();
                        lblProduct.Text = "";
                        lblEmployee.Text = "";

                    }
                    state = true;

                    selectedEmployee = null;
                    selectedProduct = null;

                    ERPEntities erpEntities2 = new ERPEntities();
                    var products = (from emp in erpEntities2.Product where emp.ProductState == 1 select new { emp.productID, emp.productName, emp.productType, emp.productSeller, emp.productBrand, emp.productPrice, emp.productDate }).ToList();
                    gridProducts.DataSource = products;


                    MessageBox.Show("Product is embeded.");

                }
            }
            else
                MessageBox.Show("Please select product and employee index.");

            if (state == true)
            {
                using (ERPEntities dbEntity = new ERPEntities())
                {
                    Event mEvent = new Event();
                    mEvent.eventName = "Debit- Product ID:" + productIndex + ", Employee ID:" + employeeIndex + " embezzled.";
                    mEvent.eventDate = DateTime.Now.ToString();
                    dbEntity.Event.Add(mEvent);
                    dbEntity.SaveChanges();
                    state = false;
                }
            }


        }

        private void gridProducts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
                DataGridViewRow row = this.gridProducts.Rows[e.RowIndex];
                selectedProduct = gridProducts.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                lblProduct.Text = selectedProduct;

            }
        }

        private void gridEmployees_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.gridEmployees.Rows[e.RowIndex];
                selectedEmployee = gridEmployees.Rows[e.RowIndex].Cells["EmployeeID"].Value.ToString();
                lblEmployee.Text = selectedEmployee;

            }
        }
    }
}
