using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing1
{
    [TestClass]
    public class TestStaffCollection
    {
        string name = "Name Nameson";
        string email = "NNameson@example.co.uk";
        string loginID = "123456";
        string password = "aljvbkejbvkjrbveb";
        string startDate = DateTime.Today.AddMonths(3).ToShortDateString();

        [TestMethod]
        public void InstanceOK() 
        {
            clsStaffCollection staffCollection = new clsStaffCollection();
            Assert.IsNotNull(staffCollection);
        }

        [TestMethod]
        public void StaffListOK() 
        {
            clsStaffCollection staffCollection = new clsStaffCollection();
            List<clsStaff> tstList = new List<clsStaff>();

            clsStaff tstItem = new clsStaff(name,email,loginID,password,'a',startDate);

            tstList.Add(tstItem);

            staffCollection.StaffList = tstList;

            Assert.AreEqual(staffCollection.StaffList,tstList);
        }

        //[TestMethod]
        //public void CountOk() 
        //{
        //    clsStaffCollection staffCollection = new clsStaffCollection();
        //    int someCount = 0;

        //}

        [TestMethod]

        public void ThisStaffPropertyOK() 
        {
            clsStaffCollection staffCollection = new clsStaffCollection();
            List<clsStaff> tstList = new List<clsStaff>();

            clsStaff tstItem = new clsStaff(name, email, loginID, password, 'a', startDate);

            staffCollection.thisStaff = tstItem;

            Assert.AreEqual(staffCollection.thisStaff, tstItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection staffCollection = new clsStaffCollection();
            List<clsStaff> tstList = new List<clsStaff>();

            clsStaff tstItem = new clsStaff(name, email, loginID, password, 'a', startDate);

            tstList.Add(tstItem);

            staffCollection.StaffList = tstList;

            Assert.AreEqual(staffCollection.Count, tstList.Count);
        }
    }
}
