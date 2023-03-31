using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


internal class ShimsContext
{
}

namespace Testing5
{
    [TestClass]
    public class tstComplaints
    {
        [TestMethod]
        public void InstanceOK()
        {
            // creat an instance of the class we want to creat
            clsComplaint Complaint = new clsComplaint();
            // test to see it exsits 
            Assert.IsNotNull(Complaint);
        }
        [TestMethod]
        public void ActivePropertOK()
        {
            clsComplaint Complaint = new clsComplaint();
            Boolean TestData = true;
            Complaint.Active = TestData;
            Assert.AreEqual(Complaint.Active, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsComplaint Complaint = new clsComplaint();
            DateTime TestData = DateTime.Now.Date;
            Complaint.DateAdded = TestData;
            Assert.AreEqual(Complaint.DateAdded, TestData);
        }
        [TestMethod]
        public void OrderIDProertyOK()
        {
            clsComplaint Complaint = new clsComplaint();
            Int32 TestData = 1;
            Complaint.OrderID = TestData;
            Assert.AreEqual(Complaint.OrderID, TestData);
        }
        [TestMethod]
        public void NamePropertyOK()
        {
            clsComplaint Complaint = new clsComplaint();
            String TestData = "21b";
            Complaint.Name = TestData;
            Assert.AreEqual(Complaint.Name, TestData);
        }
        [TestMethod]
        public void SubjectPropertyOK()
        {
            clsComplaint Complaint = new clsComplaint();
            string TestData = "21b";
            Complaint.Subject = TestData;
            Assert.AreEqual(Complaint.Subject, TestData);
        }
        [TestMethod]
        public void EmailProertyOK()
        {
            clsComplaint Complaint = new clsComplaint();
            string TestData = "21b";
            Complaint.Email = TestData;
            Assert.AreEqual(Complaint.Email, TestData);
        }
        [TestMethod]
        public void TextPropertyOK()
        {
            clsComplaint Complaint = new clsComplaint();
            string TestData = "21b";
            Complaint.Complaint = TestData;
            Assert.AreEqual(Complaint.Complaint, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsComplaint Complaint = new clsComplaint();
            //boolean variable to stroe the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
            Found = Complaint.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void OrderIDNoFound()
        {
            clsComplaint Complaint = new clsComplaint();
            //Boolean
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is) 
            Boolean OK = true;
            //create some test data to use within the method
            Int32 OrderID = 21;
            //invoke the method
            Found = Complaint.Find(OrderID);
            //check the Order id
            if (Complaint.OrderID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            clsComplaint Complaint = new clsComplaint();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to test if data is ok (assume it is)
            Boolean OK = true;
            //create some test data 
            Int32 OrderID = 21;
            //invoke the method
            Found = Complaint.Find(OrderID);
            //check the property
            if (Complaint.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ActiveFound()
        {
            clsComplaint Complaint = new clsComplaint();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = Complaint.Find(OrderID);
            if (Complaint.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
