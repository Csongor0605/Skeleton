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
            ABook.Title = TestData;
            //See if they are the same
            Assert.AreEqual(ABook.Title, TestData);
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
            ABook.Restock_DOA = TestData;
            //See if they are the same
            Assert.AreEqual(ABook.Restock_DOA, TestData);
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


        // TEST FIND METHOD IN clsBOOK class
        [TestMethod]
        public void FindMethod()
        {
            //create class instance
            clsBook ABook = new clsBook();
            // test data
            int BookID = 10;
            //use Find method
            Boolean Found = ABook.Find(BookID);
            //See if result is true (works)
            Assert.IsTrue(Found);
        }

        // TESTING FINDING DATA (HARD CODED IN FIND METHOD)   ------------------------------------------------------------------------------------------------
        [TestMethod]
        public void TestBookIDFound()
        {
            // create clsBook instance
            clsBook ABook = new clsBook();
            // initial to true
            Boolean OK = true;
            // create test data to use with method
            int BookID = 10;
            // invoke find method
            Boolean Found = ABook.Find(BookID);
            // check property
            if(ABook.BookID != 10)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        // TEST TITLE IN FIND METHOD
        [TestMethod]
        public void TestTitleFound()
        {
            clsBook ABook = new clsBook();
            Boolean OK = true;
            int BookID = 10;
            Boolean Found = ABook.Find(BookID);

            if (ABook.Title != "Harry Potter")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        // TEST Author IN FIND METHOD
        [TestMethod]
        public void TestAuthorFound()
        {
            clsBook ABook = new clsBook();
            Boolean OK = true;
            int BookID = 10;
            Boolean Found = ABook.Find(BookID);

            if (ABook.Author != "J.K Rowling")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        // TEST Genre IN FIND METHOD
        [TestMethod]
        public void TestGenreFound()
        {
            clsBook ABook = new clsBook();
            Boolean OK = true;
            int BookID = 10;
            Boolean Found = ABook.Find(BookID);

            if (ABook.Genre != "Fantasy")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        // TEST Quantity IN FIND METHOD
        [TestMethod]
        public void TestQuantityFound()
        {
            clsBook ABook = new clsBook();
            Boolean OK = true;
            int BookID = 10;
            Boolean Found = ABook.Find(BookID);

            if (ABook.Quantity != 10)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        // TEST RestockOrdered IN FIND METHOD
        [TestMethod]
        public void TestRestockOrderedFound()
        {
            clsBook ABook = new clsBook();
            Boolean OK = true;
            int BookID = 10;
            Boolean Found = ABook.Find(BookID);

            if (ABook.RestockOrdered != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        // TEST Restock_date IN FIND METHOD
        [TestMethod]
        public void TestRestock_dateFound()
        {
            clsBook ABook = new clsBook();
            Boolean OK = true;
            int BookID = 10;
            Boolean Found = ABook.Find(BookID);

            if (ABook.Restock_DOA != Convert.ToDateTime("10/3/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        // TEST Restock_date IN FIND METHOD
        [TestMethod]
        public void TestRestockOrder_QuantityFound()
        {
            clsBook ABook = new clsBook();
            Boolean OK = true;
            int BookID = 10;
            Boolean Found = ABook.Find(BookID);

            if (ABook.RestockOrder_Quantity != 50)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        // -------------------------------------------------------------------------------------------------------------------------------------------------
    }
}