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
            Allcustomers.BirukList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Allcustomers.BirukList, TestList);

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
            AllCustomers.BirukList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerOrderMade = true;
            TestItem.CustomerID = 5;
            TestItem.CustomerName = "John See";
            TestItem.CustomerEmail = "JohnSee@gmail.com";
            TestItem.CustomerPassword = "JohnSee123";
            TestItem.CustomerAddress = "26 London Road LE1 6JH";
            TestItem.CustomerReg = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record 
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerOrderMade = true;
            TestItem.CustomerID = 5;
            TestItem.CustomerName = "John See";
            TestItem.CustomerEmail = "JohnSee@gmail.com";
            TestItem.CustomerPassword = "JohnSee123";
            TestItem.CustomerAddress = "26 London Road LE1 6JH";
            TestItem.CustomerReg = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.CustomerOrderMade = false;
            TestItem.CustomerID = 6;
            TestItem.CustomerName = "John Dee";
            TestItem.CustomerEmail = "JohnDee@gmail.com";
            TestItem.CustomerPassword = "JohnDee123";
            TestItem.CustomerAddress = "27 London Road LE1 6JH";
            TestItem.CustomerReg = DateTime.Now.Date;
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer matches the test data 
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerOrderMade = false;
            TestItem.CustomerID = 6;
            TestItem.CustomerName = "John Dee";
            TestItem.CustomerEmail = "JohnDee@gmail.com";
            TestItem.CustomerPassword = "JohnDee123";
            TestItem.CustomerAddress = "27 London Road LE1 6JH";
            TestItem.CustomerReg = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }
        [TestMethod]

        public void ReportByCustomerEmailOK()

        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomers.ReportByCustomerEmail("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);

        }
        [TestMethod]
        public void ReportByCustomerEmailNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a customer email that does not exist
            FilteredCustomers.ReportByCustomerEmail("xxxxxx@gmail.com");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }
        [TestMethod]

        public void ReportByCustomersEmailDataFound()

        {

            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a customer email that doesn't exist
            FilteredCustomers.ReportByCustomerEmail("somebody@gmail.com");
            //check to see that the correct number of records are found
            if (FilteredCustomers.Count == 2)

            {

                //check that the first record is ID 10
                if (FilteredCustomers.BirukList[0].CustomerID != 1006)

                {

                    OK = false;

                }

                //check that the first record is ID 11

                if (FilteredCustomers.BirukList[1].CustomerID != 1007)

                {

                    OK = false;

                }

                else

                {

                    OK = false;

                }

                //test to see that there are no records

                Assert.IsTrue(OK);

            }

        }
    }
}
