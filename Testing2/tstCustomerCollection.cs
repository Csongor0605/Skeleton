using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection Allcustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerOrderMade = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "John Lee";
            TestItem.CustomerEmail = "JohnLee@gmail.com";
            TestItem.CustomerPassword = "JohnLee123";
            TestItem.CustomerAddress = "25 London Road LE1 6JH";
            TestItem.CustomerReg = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Allcustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Allcustomers.CustomerList, TestList);

        }
     
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property 
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerOrderMade = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.CustomerName = "John Lee";
            TestCustomer.CustomerEmail = "JohnLee@gmail.com";
            TestCustomer.CustomerPassword = "JohnLee123";
            TestCustomer.CustomerAddress = "25 London Road LE1 6JH";
            TestCustomer.CustomerReg = DateTime.Now.Date;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerOrderMade = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "John Lee";
            TestItem.CustomerEmail = "JohnLee@gmail.com";
            TestItem.CustomerPassword = "JohnLee123";
            TestItem.CustomerAddress = "25 London Road LE1 6JH";
            TestItem.CustomerReg = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }
       
    }
}
