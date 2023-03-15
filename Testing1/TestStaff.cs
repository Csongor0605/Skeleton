using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class TestStaff
    {
        [TestMethod]
        public void TestConstructor()
        {
            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", "3f8a0b394", "aljvbkejbvkjrbveb", 'b', new DateTime(2023, 03, 01));
            Assert.IsNotNull(staff);
        }

        [TestMethod]
        public void TestDateStarted()
        {
            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", "3f8a0b394", "aljvbkejbvkjrbveb", 'b', new DateTime(2023, 03, 01));
            Assert.AreEqual(staff.GetStartDate(), new DateTime(2023, 03, 01));
        }

        [TestMethod]
        public void TestName() {

            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", "3f8a0b394", "aljvbkejbvkjrbveb", 'b', new DateTime(2023, 03, 01));
            Assert.AreEqual(staff.Name, "Name Nameson");
        }

        [TestMethod]
        public void TestEmail() {

            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", "3f8a0b394", "aljvbkejbvkjrbveb", 'b', new DateTime(2023, 03, 01));
            Assert.AreEqual(staff.Email, "NNameson@example.co.uk");
        }

        [TestMethod]
        public void TestLoginID() {

            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", "3f8a0b394", "aljvbkejbvkjrbveb", 'b', new DateTime(2023, 03, 01));
            Assert.AreEqual(staff.LoginID, "3f8a0b394");
        }

        [TestMethod]
        public void TestPassword() {
            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", "3f8a0b394", "aljvbkejbvkjrbveb", 'b', new DateTime(2023, 03, 01));
            Assert.AreEqual(staff.Password, "aljvbkejbvkjrbveb");
        }

        [TestMethod]
        public void TestPermissionLvl() {
            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", "3f8a0b394", "aljvbkejbvkjrbveb", 'b', new DateTime(2023, 03, 01));
            Assert.AreEqual(staff.PermissionLvl, 'b');
        }

    }
}
