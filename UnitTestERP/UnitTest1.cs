using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP;

namespace UnitTestERP
{ 
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]

        public void CreateEmployeeObjectTest()
        {
            Employee emp = new Employee();

        }

        [TestMethod]

        public void AddEmployeeTest()
        {

            AddEmployeeForm form = new AddEmployeeForm();
            Employee emp = new Employee();
            emp.Name = "Muhammed Can";
            emp.Surname = "Çiçek";
            emp.Department = "Purchasing Specialist";
            emp.Gender = "Erkek";
            emp.Age = 21;
            
        }

        [TestMethod]

        public void CreateProductObjectTest()
        {
            Product product = new Product();

        }

        [TestMethod]

        public void AddProductTest()
        {

            AddEmployeeForm form = new AddEmployeeForm();
            Product product = new Product();
            product.productName = "Mouse";
            product.productSeller = "Vatan Computer";
            product.productType = "Hardware";
            product.productPrice = 30;

        }

        [TestMethod]

        public void CreateDebitObjectTest()
        {
            Debit debit = new Debit();

        }
        [TestMethod]

        public void CreateEventObjectTest()
        {
            Event mEvent = new Event();
            mEvent.eventName = "Personell Add is Successfully.";

        }

    }
}
