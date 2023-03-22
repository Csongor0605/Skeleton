using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class TestStaff
    {
        //"Name Nameson", "NNameson@example.co.uk", 123456, "aljvbkejbvkjrbveb", 'b', new DateTime(2023, 03, 01)

        string name = "Name Nameson";
        string email = "NNameson@example.co.uk";
        string loginID = "123456";
        string password = "aljvbkejbvkjrbveb";
        string startDate = new DateTime(2023, 05, 01).ToShortDateString();


        [TestMethod]
        public void TestConstructor()
        {
            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", 123456, "aljvbkejbvkjrbveb", 'b', new DateTime(2023, 03, 01));
            Assert.IsNotNull(staff);
        }

        [TestMethod]
        public void TestDateStarted()
        {
            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", 123456, "aljvbkejbvkjrbveb", 'b', new DateTime(2023, 03, 01));
            Assert.AreEqual(staff.StartDate, new DateTime(2023, 03, 01));
        }

        [TestMethod]
        public void TestName()
        {

            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", 123456, "aljvbkejbvkjrbveb", 'b', new DateTime(2023, 03, 01));
            Assert.AreEqual(staff.Name, "Name Nameson");
        }

        [TestMethod]
        public void TestEmail()
        {

            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", 123456, "aljvbkejbvkjrbveb", 'b', new DateTime(2023, 03, 01));
            Assert.AreEqual(staff.Email, "NNameson@example.co.uk");
        }

        [TestMethod]
        public void TestLoginID()
        {

            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", 123456, "aljvbkejbvkjrbveb", 'b', new DateTime(2023, 03, 01));
            Assert.AreEqual(staff.LoginID, 123456);
        }

        [TestMethod]
        public void TestPassword()
        {
            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", 123456, "aljvbkejbvkjrbveb", 'b', new DateTime(2023, 03, 01));
            Assert.AreEqual(staff.Password, "aljvbkejbvkjrbveb");
        }

        [TestMethod]
        public void TestPermissionLvl()
        {
            clsStaff staff = new clsStaff("Name Nameson", "NNameson@example.co.uk", 123456, "aljvbkejbvkjrbveb", 'b', new DateTime(2023, 03, 01));
            Assert.AreEqual(staff.PermissionLvl, 'b');
        }

        [TestMethod]
        public void TestFindMethod()
        {
            clsStaff staff = new clsStaff(123456, new DateTime(2023, 03, 14));
            bool found = false;
            bool ok = true;
            int testKey = 123456;
            found = staff.Find(testKey);
            if (staff.LoginID != testKey)
                ok = false;
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestNameFound()
        {
            clsStaff staff = new clsStaff();

            bool found = false;
            bool ok = true;

            int tstLogin = 123456;

            found = staff.Find(tstLogin);

            if (staff.Name == "Example Exampleson")
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsStaff staff = new clsStaff();

            bool found = false;
            bool ok = true;

            int tstLogin = 123456;

            found = staff.Find(tstLogin);

            if (staff.Email == "Exampleson@Example.com")
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestLoginIDFound()
        {
            clsStaff staff = new clsStaff();

            bool found = false;
            bool ok = true;

            int tstLogin = 123456;

            found = staff.Find(tstLogin);

            if (staff.LoginID == tstLogin)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            clsStaff staff = new clsStaff();

            bool found = false;
            bool ok = true;

            int tstLogin = 123456;

            found = staff.Find(tstLogin);

            if (staff.Name == "3df81b46a898f")
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestStartDataFound()
        {
            clsStaff staff = new clsStaff();

            bool found = false;
            bool ok = true;

            int tstLogin = 123456;

            found = staff.Find(tstLogin);

            if (staff.StartDate == DateTime.Now.Date)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void TestPermissionLvlFound()
        {
            clsStaff staff = new clsStaff();

            bool found = false;
            bool ok = true;

            int tstLogin = 123456;

            found = staff.Find(tstLogin);

            if (staff.PermissionLvl == 'a')
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestOnSiteFound()
        {
            clsStaff staff = new clsStaff();

            bool found = false;
            bool ok = true;

            int tstLogin = 123456;

            found = staff.Find(tstLogin);

            if (staff.OnSite == true)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            Error = staff.Valid(loginID, name, password, email, startDate);
            Assert.AreEqual(Error, "");
        }
    }
}
