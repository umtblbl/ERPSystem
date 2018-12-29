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
    public partial class ListingReportForm : Form
    {
        public ListingReportForm()
        {
            InitializeComponent();
        }

        ERPEntities erpEntities;

        private void ListingReportForm_Load(object sender, EventArgs e)
        {
            gridListing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnListingEvents_Click_1(object sender, EventArgs e)
        {
            erpEntities = new ERPEntities();
            var events = (from emp in erpEntities.Event select new { emp.eventID, emp.eventName, emp.eventDate }).ToList();            
            
            gridListing.DataSource = events;
        }

        private void btnListingEvent_Click(object sender, EventArgs e)
        {

            erpEntities = new ERPEntities();
            var employees = (from emp in erpEntities.Employee select new { emp.employeeID, emp.Name, emp.Surname, emp.Department, emp.Startofwork, emp.Gender, emp.Age, emp.Birthday }).ToList();
            gridListing.DataSource = employees;
        }

        private void btnListingProducts_Click(object sender, EventArgs e)
        {
            erpEntities = new ERPEntities();
            var products = (from emp in erpEntities.Product where emp.ProductState != 3 select new { emp.productID, emp.productName, emp.productType, emp.productSeller, emp.productBrand, emp.productPrice, emp.productDate, emp.ProductState }).ToList();
            gridListing.DataSource = products;
        }

        private void btnListingDebits_Click(object sender, EventArgs e)
        {
            erpEntities = new ERPEntities();
            var debits = (from emp in erpEntities.Debit
                         select new { emp.debitID, emp.productID, emp.debitPersonID, emp.debitAdminID, emp.debitDate }).ToList();
            gridListing.DataSource = debits;
        }

        private void btnListingDiscardedProducts_Click(object sender, EventArgs e)
        {
            erpEntities = new ERPEntities();
            var product = (from emp in erpEntities.Product where emp.ProductState == 3 select new { emp.productID, emp.productName, emp.productType, emp.productSeller, emp.productBrand, emp.productPrice, emp.productDate, emp.ProductState }).ToList();
            gridListing.DataSource = product;
        }

        Font head = new Font("Verdana", 12, FontStyle.Bold);
        Font body = new Font("Verdana", 12);
        SolidBrush sb = new SolidBrush(Color.Black);


        private void pDocEvents_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Events Listing", head, sb, 350, 130);
            e.Graphics.DrawString("Event ID           Event Name                                        Event Date", head, sb, 40, 170);
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------", head, sb, 40, 190);
            int deger = 220;
            using (var erpEntities = new ERPEntities())
            {
                var events2 = (from emp in erpEntities.Event select new { emp.eventID, emp.eventName, emp.eventDate }).ToList();
                foreach (var item in events2.ToList())
                {
                    e.Graphics.DrawString(item.eventID +"   "+ item.eventName + "       " + item.eventDate, head, sb, 40, deger);
                    deger += 30;
                }

            }
            deger += 20;
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------", head, sb, 40, deger);


        }

        private void btnPrintEvents_Click(object sender, EventArgs e)
        {
            pDialogEvents.ShowDialog();
        }

        private void btnPrintEmployees_Click(object sender, EventArgs e)
        {
            pDialogEmplooyes.ShowDialog();
        }

        private void pDocEmployees_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Employees Listing", head, sb, 350, 130);
            e.Graphics.DrawString("ID     Name     Surname      Department      Start of Work", head, sb, 40, 170);
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------", head, sb, 40, 190);
            int deger = 220;
            using (var erpEntities2 = new ERPEntities())
            {
                var employee2 = (from emp in erpEntities2.Employee select new { emp.employeeID, emp.Name, emp.Surname, emp.Department, emp.Startofwork }).ToList();
                foreach (var item in employee2.ToList())
                {
                    e.Graphics.DrawString(item.employeeID + "   " + item.Name + "      " + item.Surname +"     "+ item.Department+ "    " +item.Startofwork, head, sb, 40, deger);
                    deger += 30;
                }

            }
            deger += 20;
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------", head, sb, 40, deger);
        }

        private void pDocProducts_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Products Listing", head, sb, 350, 130);
            e.Graphics.DrawString("ID     Name     Type      Seller      Brand     Price", head, sb, 40, 170);
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------", head, sb, 40, 190);
            int deger = 220;
            using (var erpEntities3 = new ERPEntities())
            {
                
                var product3 = (from emp in erpEntities3.Product select new { emp.productID, emp.productName, emp.productType, emp.productSeller, emp.productBrand, emp.productPrice }).ToList();
                foreach (var item in product3.ToList())
                {
                    e.Graphics.DrawString(item.productID + "   " + item.productName + "      " + item.productType + "     " + item.productSeller + "    " + item.productBrand+ "    "+item.productPrice, head, sb, 40, deger);
                    deger += 30;
                }

            }
            deger += 20;
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------", head, sb, 40, deger);
        }

        private void btnPrintProducts_Click(object sender, EventArgs e)
        {
            pDialogProducts.ShowDialog();
        }

        private void btnPrintDebits_Click(object sender, EventArgs e)
        {
            pDialogDebits.ShowDialog();
        }

        private void pDocDebits_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Products Listing", head, sb, 350, 130);
            e.Graphics.DrawString("Debit ID     Admin ID      Person ID      Product ID      Date", head, sb, 40, 170);
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------", head, sb, 40, 190);
            int deger = 220;
            using (var erpEntities4 = new ERPEntities())
            {

                var debits = (from emp in erpEntities4.Debit select new { emp.debitID, emp.debitAdminID, emp.debitPersonID, emp.productID, emp.debitDate }).ToList();
                foreach (var item in debits.ToList())
                {
                    e.Graphics.DrawString(item.productID + "   " + item.debitID + "      " + item.debitAdminID + "     " + item.debitPersonID + "    " + item.productID + "    " + item.debitDate, head, sb, 40, deger);
                    deger += 30;
                }

            }
            deger += 20;
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------", head, sb, 40, deger);
        }

        private void pDocDiscarded_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Products Listing", head, sb, 350, 130);
            e.Graphics.DrawString("ID     Name     Type      Seller      Brand     Price", head, sb, 40, 170);
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------", head, sb, 40, 190);
            int deger = 220;
            using (var erpEntities3 = new ERPEntities())
            {

                var product3 = (from emp in erpEntities3.Product where emp.ProductState == 3 select new { emp.productID, emp.productName, emp.productType, emp.productSeller, emp.productBrand, emp.productPrice }).ToList();
                foreach (var item in product3.ToList())
                {
                    e.Graphics.DrawString(item.productID + "   " + item.productName + "      " + item.productType + "     " + item.productSeller + "    " + item.productBrand + "    " + item.productPrice, head, sb, 40, deger);
                    deger += 30;
                }

            }
            deger += 20;
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------", head, sb, 40, deger);
        }

        private void btnDiscartedProductsPrint_Click(object sender, EventArgs e)
        {
            pDialogDiscarded.ShowDialog();
        }
    }
}
