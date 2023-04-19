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

        [TestMethod]
        public void LoginIDExtremeMin() 
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstLogin = "-3748";

            error += staff.Valid(tstLogin,name,password,email,startDate);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void LoginIDMinMinusOne()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstLogin = "99999";

            error += staff.Valid(tstLogin, name, password, email, startDate);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void LoginIDMinInBoundary()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstLogin = "100000";

            error += staff.Valid(tstLogin, name, password, email, startDate);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LoginIDMinPlusOne()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstLogin = "100001";

            error += staff.Valid(tstLogin, name, password, email, startDate);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LoginIDMaxInBoundary()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstLogin = "999999";

            error += staff.Valid(tstLogin, name, password, email, startDate);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LoginIDMaxPlusOne()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstLogin = "1000000";

            error += staff.Valid(tstLogin, name, password, email, startDate);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void LoginIDMid()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstLogin = "555555";

            error += staff.Valid(tstLogin, name, password, email, startDate);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LoginIDExtremeMax()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstLogin = "9999999999999";

            error += staff.Valid(tstLogin, name, password, email, startDate);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void LoginIDInvalidDataType()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstLogin = "OneSevenSixFourOneTwo";

            error += staff.Valid(tstLogin, name, password, email, startDate);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NameExtremeMin()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstName = "a";

            error += staff.Valid(loginID, tstName, password, email, startDate);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NameMinMinusOne()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstName = "abc";

            error += staff.Valid(loginID, tstName, password, email, startDate);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NameMinInBoundary()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstName = "ab c";

            error += staff.Valid(loginID, tstName, password, email, startDate);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstName = "abcde";

            error += staff.Valid(loginID, tstName, password, email, startDate);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameMaxMinusOne()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            error += staff.Valid(loginID, tstName, password, email, startDate);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameMaxInBoundary()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            error += staff.Valid(loginID, tstName, password, email, startDate);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            error += staff.Valid(loginID, tstName, password, email, startDate);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            error += staff.Valid(loginID, tstName, password, email, startDate);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            error += staff.Valid(loginID, tstName, password, email, startDate);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NameInvalidDataType()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstName = "Nam3 n4me50n!";

            error += staff.Valid(loginID, tstName, password, email, startDate);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PasswordExtremeMin()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstPassword = null;

            error += staff.Valid(loginID, name, tstPassword, email, startDate);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PasswordMinMinusOne()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstPassword = "pw";

            error += staff.Valid(loginID, name, tstPassword, email, startDate);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PasswordMinInBoundary()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstPassword = "abc";

            error += staff.Valid(loginID, name, tstPassword, email, startDate);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstPassword = "pass";

            error += staff.Valid(loginID, name, tstPassword, email, startDate);

            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void PasswordMaxMinusOne()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstPassword = "passwpasswpasswpasswpasswpasswpasswpasswpasswpass";

            error += staff.Valid(loginID, name, tstPassword, email, startDate);

            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void PasswordMaxInBoundary()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstPassword = "apasswpasswpasswpasswpasswpasswpasswpasswpasswpass";

            error += staff.Valid(loginID, name, tstPassword, email, startDate);

            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstPassword = "aapasswpasswpasswpasswpasswpasswpasswpasswpasswpass";

            error += staff.Valid(loginID, name, tstPassword, email, startDate);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstPassword = "passwpasswpasswpasswpass";

            error += staff.Valid(loginID, name, tstPassword, email, startDate);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstPassword = "passwpasswpasswpapasswpasswpasswpasswpasswpasswpasswpasswpasswpasssswpasswpasswpasswpasswpasswpass";

            error += staff.Valid(loginID, name, tstPassword, email, startDate);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PasswordInvalidType()
        {
            string error = "";
            clsStaff staff = new clsStaff();

            string tstPassword = "#@######!£$%$£%^£^£";

            error += staff.Valid(loginID, name, tstPassword, email, startDate);

            Assert.AreNotEqual(error, "");
        }
    }
}
