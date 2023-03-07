using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing1
{
    [TestClass]
    public class TestBook
    {
        [TestMethod]
        public void TestConstructor()
        {
            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", "3f8a0b394", "aljvbkejbvkjrbveb", 'b', "03/03/2023");
            Assert.IsNotNull(staff);
            
        }

        [TestMethod]
        public void TestDateStarted()
        {
            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", "3f8a0b394", "aljvbkejbvkjrbveb", 'b', "03/03/2023");
            Assert.Equals(staff.GetStartDate, "03/03/2023");
        }

        [TestMethod]
        public void TestName() {

            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", "3f8a0b394", "aljvbkejbvkjrbveb", 'b', "03/03/2023");
            Assert.Equals(staff.name.get, "Name Nameson");
        }

        public void TestEmail() {

            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", "3f8a0b394", "aljvbkejbvkjrbveb", 'b', "03/03/2023");
            Assert.Equals(staff.email.get, "NNameson@example.co.uk");
        }

        public void TestLoginID() {

            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", "3f8a0b394", "aljvbkejbvkjrbveb", 'b', "03/03/2023");
            Asserts.Equals(staff.loginID.get, "3f8a0b394");
        }

        public void TestPassword() {
            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", "3f8a0b394", "aljvbkejbvkjrbveb", 'b', "03/03/2023");
            Assert.Equals(staff.password.get, "aljvbkejbvkjrbveb");
        }

        public void TestPermissionLvl() {
            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", "3f8a0b394", "aljvbkejbvkjrbveb", 'b', "03/03/2023");
            Assert.Equals(staff.permissionLvl).get, 'b');
        }

    }
}
