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
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method 
            Found = ACustomer.Find(CustomerID);
            //check the customer address
            if (ACustomer.CustomerID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void CustomerRegFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method 
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerReg != Convert.ToDateTime("16/09/2023"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestCustomerAddressFound()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //boolean variable to store the result of the search

            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)

            Boolean OK = true;

            //create some test data to use with the method

            Int32 CustomerID = 1;

            //invoke the method

            Found = ACustomer.Find(CustomerID);

            //check the property

            if (ACustomer.CustomerAddress != "25 London Road LE1 6JH")

            {

                OK = false;

            }

            //test to see that the result is correct

            Assert.IsTrue(OK);

        }
        [TestMethod]

        public void TestCustomerNameFound()

        {

            //create an instance of the class we want to create



            clsCustomer ACustomer = new clsCustomer();



            //boolean variable to store the result of the search



            Boolean Found = false;



            //boolean variable to record if data is OK (assume it is)



            Boolean OK = true;



            //create some test data to use with the method



            Int32 CustomerID = 1;



            //invoke the method



            Found = ACustomer.Find(CustomerID);



            //check the property



            if (ACustomer.CustomerName != "kevin hart")

            {

                OK = false;

            }



            //test to see that the result is correct



            Assert.IsTrue(OK);

        }
        [TestMethod]

        public void TestCustomerOrderMadeFound()

        {

            //create an instance of the class we want to create



            clsCustomer ACustomer = new clsCustomer();



            //boolean variable to store the result of the search



            Boolean Found = false;



            //boolean variable to record if data is OK (assume it is)



            Boolean OK = true;



            //create some test data to use with the method



            Int32 CustomerID = 1;



            //invoke the method



            Found = ACustomer.Find(CustomerID);



            //check the property



            if (ACustomer.CustomerOrderMade != true)

            {

                OK = false;

            }



            //test to see that the result is correct



            Assert.IsTrue(OK);

        }
        [TestMethod]

        public void TestCustomerEmailFound()

        {

            //create an instance of the class we want to create



            clsCustomer ACustomer = new clsCustomer();



            //boolean variable to store the result of the search



            Boolean Found = false;



            //boolean variable to record if data is OK (assume it is)



            Boolean OK = true;



            //create some test data to use with the method



            Int32 CustomerID = 1;



            //invoke the method



            Found = ACustomer.Find(CustomerID);



            //check the property



            if (ACustomer.CustomerEmail != "kevinhart@gmail.com")

            {

                OK = false;

            }



            //test to see that the result is correct



            Assert.IsTrue(OK);

        }
        [TestMethod]

        public void TestCustomerPasswordFound()

        {

            //create an instance of the class we want to create



            clsCustomer ACustomer = new clsCustomer();



            //boolean variable to store the result of the search



            Boolean Found = false;



            //boolean variable to record if data is OK (assume it is)



            Boolean OK = true;



            //create some test data to use with the method



            Int32 CustomerID = 1;



            //invoke the method



            Found = ACustomer.Find(CustomerID);



            //check the property



            if (ACustomer.CustomerPassword != "password123")

            {

                OK = false;

            }



            //test to see that the result is correct



            Assert.IsTrue(OK);

        }
    }
}
