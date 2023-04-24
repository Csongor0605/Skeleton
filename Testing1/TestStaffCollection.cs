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

        [TestMethod]
        public void AddMethodOK() 
        {
            clsStaffCollection staffCollection = new clsStaffCollection();
            clsStaff tstStaff = new clsStaff(name,email,loginID,password,'a',startDate);

            staffCollection.thisStaff = tstStaff;
            int primaryKey = staffCollection.Add();

            tstStaff.LoginID = primaryKey;
            staffCollection.thisStaff.Find(primaryKey);

            Assert.AreEqual(staffCollection.thisStaff, tstStaff);
        }

        [TestMethod]
        public void UpdateMethodOK() 
        {
            clsStaffCollection staffCol = new clsStaffCollection();
            clsStaff tstItem = new clsStaff(name,email,loginID,password,'h',startDate);

            staffCol.thisStaff = tstItem;
            int primaryKey = staffCol.Add();

            tstItem.LoginID = primaryKey;

            tstItem.Name = "Notthe PreviousName";
            tstItem.Email = "tyui@qwerty.com";

            staffCol.thisStaff = tstItem;

            staffCol.Update();

            staffCol.thisStaff.Find(primaryKey);
            Assert.AreEqual(staffCol.thisStaff,tstItem);

        }
    }
}
