using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class TestBook
    {
        [TestMethod]
        public void TestInstance()
        {
            //create isntacne we want to test
            clsBook ABook = new clsBook();
            //test to see if it exists
            Assert.IsNotNull(ABook);
        }


        [TestMethod]
        public void TestBookID()
        {
            //create class instance
            clsBook ABook = new clsBook();
            // crate test data
            int TestData = 1;
            // Assign test data
            ABook.BookID = TestData;
            //See if they are the same
            Assert.AreEqual(ABook.BookID, TestData);
        }

        [TestMethod]
        public void TestBookTitle()
        {
            //create class instance
            clsBook ABook = new clsBook();
            // crate test data
            String TestData = "Harry Potter and the Philosophers Stone";
            // Assign test data
            ABook.BookTitle = TestData;
            //See if they are the same
            Assert.AreEqual(ABook.BookTitle, TestData);
        }

        [TestMethod]
        public void TestAuthor()
        {
            //create class instance
            clsBook ABook = new clsBook();
            // crate test data
            String TestData = "J.K Rowling";
            // Assign test data
            ABook.Author = TestData;
            //See if they are the same
            Assert.AreEqual(ABook.Author, TestData);
        }

        [TestMethod]
        public void TestGenre()
        {
            //create class instance
            clsBook ABook = new clsBook();
            // crate test data
            String TestData = "Fantasy";
            // Assign test data
            ABook.Genre = TestData;
            //See if they are the same
            Assert.AreEqual(ABook.Genre, TestData);
        }

        [TestMethod]
        public void TestQuantity()
        {
            //create class instance
            clsBook ABook = new clsBook();
            // crate test data
            int TestData = 10;
            // Assign test data
            ABook.Quantity = TestData;
            //See if they are the same
            Assert.AreEqual(ABook.Quantity, TestData);
        }

        [TestMethod]
        public void TestRestockOrdered()
        {
            //create class instance
            clsBook ABook = new clsBook();
            // crate test data
            Boolean TestData = true;
            // Assign test data
            ABook.RestockOrdered = TestData;
            //See if they are the same
            Assert.AreEqual(ABook.RestockOrdered, TestData);
        }

        [TestMethod]
        public void TestRestock_date()
        {
            //create class instance
            clsBook ABook = new clsBook();
            // crate test data
            DateTime TestData = DateTime.Now.Date;
            // Assign test data
            ABook.Restock_date = TestData;
            //See if they are the same
            Assert.AreEqual(ABook.Restock_date, TestData);
        }

        [TestMethod]
        public void TestRestockOrder_Quantity()
        {
            //create class instance
            clsBook ABook = new clsBook();
            // crate test data
            int TestData = 5;
            // Assign test data
            ABook.RestockOrder_Quantity = TestData;
            //See if they are the same
            Assert.AreEqual(ABook.RestockOrder_Quantity, TestData);
        }
    }
}