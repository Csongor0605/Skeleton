using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {

        //good test data
        //create some test data to pass to the method
        string CustomerName = "John Lee";
        string CustomerEmail = "JohnLee@gmail.com";
        string CustomerPassword = "JohnLee123";
        string CustomerAddress = "25 London Road LE1 6JH";
        string CustomerReg = DateTime.Now.Date.ToString();
        //string DateAdded = DateTime.Now.Date.ToString();

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
            if (ACustomer.CustomerReg != Convert.ToDateTime("01/01/2020"))
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



            if (ACustomer.CustomerName != "John Lee")

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



            if (ACustomer.CustomerEmail != "JohnLee@gmail.com")

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



            if (ACustomer.CustomerPassword != "JohnLee123")

            {

                OK = false;

            }



            //test to see that the result is correct



            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "a"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = ""; 
            //create some test data to pass to the method
            string CustomerName = ""; 
            CustomerName = CustomerName.PadRight(500, 'a'); //this shoould fail
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerRegExtremeMin()
        {
            //create an instanc of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //string variable to store the test date data
            DateTime  TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string CustomerReg = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
       
        [TestMethod]
        public void CustomerRegOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string CustomerReg = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerRegMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string CustomerReg = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerRegMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string CustomerReg = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerRegExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string CustomerReg = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void CustomerRegInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string CustomerReg = "this is not a date!";
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "a"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "aaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "aaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        public void CustomerEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "aaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        public void CustomerEmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "";
            CustomerName = CustomerEmail.PadRight(500, 'a'); //this shoould fail
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void CustomerPasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerPassword = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerPasswordMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerPassword = "a"; //this should be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerPasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerPassword = "aa"; //this should be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerPasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerPassword = "a"; //this should be okay
            CustomerPassword = CustomerPassword.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerPassword = "a"; //this should be okay
            CustomerPassword = CustomerPassword.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerPasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerPassword = "a"; //this should be okay
            CustomerPassword = CustomerPassword.PadRight(51, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerPasswordMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerPassword = "a"; //this should be okay
            CustomerPassword = CustomerPassword.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void CustomerAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "a"; //this should be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "aa"; //this should be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "a"; //this should be okay
            CustomerAddress = CustomerAddress.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "a"; //this should be okay
            CustomerAddress = CustomerAddress.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "a"; //this should be okay
            CustomerAddress = CustomerAddress.PadRight(51, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "a"; //this should be okay
            CustomerAddress = CustomerAddress.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


    }
    
}
