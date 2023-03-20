using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property 
            ACustomer.Active = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.Active, TestData);
        }
        [TestMethod]
        public void CustomerRegPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.CustomerReg = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerReg, TestData);
        }
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;

            //assign the data to the property

            ACustomer.CustomerID = TestData;

            //test to see that the two values are the same

            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }
        [TestMethod]

        public void CustomerAddressPropertyOK()
        {
            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property

            string TestData = "7 Random Street";

            //assign the data to the property

            ACustomer.CustomerAddress = TestData;

            //test to see that the two values are the same

            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }
        [TestMethod]

        public void CustomerEmailOK()

        {
            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property

            string TestData = "kevinhart@gmail.com";

            //assign the data to the property

            ACustomer.CustomerEmail = TestData;

            //test to see that the two values are the same

            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }
        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property

            string TestData = "Kevin";

            //assign the data to the property

            ACustomer.CustomerName = TestData;

            //test to see that the two values are the same

            Assert.AreEqual(ACustomer.CustomerName, TestData);
        }
        [TestMethod]

        public void CustomerOrderMadeOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            ACustomer.CustomerOrderMade = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.CustomerOrderMade, TestData);
        }
        [TestMethod]

        public void CustomerPasswordOK()

        {
            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property

            string TestData = "Password123";

            //assign the data to the property

            ACustomer.CustomerPassword = TestData;

            //test to see that the two values are the same

            Assert.AreEqual(ACustomer.CustomerPassword, TestData);
        }


    }
}
