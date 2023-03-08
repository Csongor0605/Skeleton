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
            Assert.Equals(staff.GetStartDate, new DateTime(2023, 03, 01));
        }

        [TestMethod]
        public void TestName() {

            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", "3f8a0b394", "aljvbkejbvkjrbveb", 'b', new DateTime(2023, 03, 01));
            Assert.Equals(staff.name.get, "Name Nameson");
        }

        public void TestEmail() {

            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", "3f8a0b394", "aljvbkejbvkjrbveb", 'b', new DateTime(2023, 03, 01));
            Assert.Equals(staff.email.get, "NNameson@example.co.uk");
        }

        public void TestLoginID() {

            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", "3f8a0b394", "aljvbkejbvkjrbveb", 'b', new DateTime(2023, 03, 01));
            Asserts.Equals(staff.loginID.get, "3f8a0b394");
        }

        public void TestPassword() {
            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", "3f8a0b394", "aljvbkejbvkjrbveb", 'b', new DateTime(2023, 03, 01));
            Assert.Equals(staff.password.get, "aljvbkejbvkjrbveb");
        }

        public void TestPermissionLvl() {
            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", "3f8a0b394", "aljvbkejbvkjrbveb", 'b', new DateTime(2023, 03, 01));
            Assert.Equals(staff.permissionLvl.get, 'b');
        }

    }
}
