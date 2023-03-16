using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
        public void DatePropertyOK()
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
        public void TextPropertyOK ()
        {
            clsComplaint Complaint = new clsComplaint();
            string TestData = "21b";
            Complaint.Text = TestData;
            Assert.AreEqual(Complaint.Text, TestData);
        }
    }
}
