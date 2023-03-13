using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class TestBook
    {

        String BookID = "10";
        String Title = "Harry Potter";
        String Author = "J.K Rowling";
        String Genre = "Fantasy";
        String Quantity = "10";
        String RestockOrdered = "true";
        String Restock_DOA = DateTime.Now.Date.ToString();
        String Restock_Quantity = "50";
        
      
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
            ABook.Restock_Quantity = TestData;
            //See if they are the same
            Assert.AreEqual(ABook.Restock_Quantity, TestData);
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

            if (ABook.Restock_Quantity != 50)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        // TESTING VALID METHOD-------------------------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void TestValidMethod()
        {
            // new clsBook instance
            clsBook ABook = new clsBook();

            // run Valid method with test data 
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            // should return empty string
            Assert.AreEqual(Error, "");
        }

        // TEST VALID TITLE PARAMETER -------------

        [TestMethod]
        public void TestValidTitle_MinMinusOneF()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Title = "";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data not valid
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TestValidTitle_MinBoundary()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Title = "A";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is valid
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidTitle_MinPlusOne()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Title = "AA";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is valid
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidTitle_MaxMinusOne()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Title = Title.PadRight(49, 'A');

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is valid
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidTitle_MaxBoundary()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Title = Title.PadRight(50, 'A');

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is valid
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidTitle_MaxPlusOneF()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Title = Title.PadRight(51, 'A');

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TestValidTitle_Mid()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Title = Title.PadRight(51, 'A');

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TestValidTitle_ExtremeMaxF()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Title = Title.PadRight(500, 'A');

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }

        // TEST VALID AUTHOR PARAMETER -------------
        [TestMethod]
        public void TestValidAuthor_MinMinuseOneF()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Author = "";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TestValidAuthor_MinBoundary()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Author = "A";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data Valid
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidAuthor_MinPlusOne()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Author = "AA";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data Valid
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidAuthor_MaxMinusOne()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Author = Author.PadRight(19, 'A');

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidAuthor_MaxBoundary()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Author = Author.PadRight(20, 'A');

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidAuthor_MaxPlusOneF()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Author = Author.PadRight(21, 'A') ;

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TestValidAuthor_ExtremeMaxF()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Author = Author.PadRight(500, 'A');

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }

        // TEST VALID Genre PARAMETER -------------
        [TestMethod]
        public void TestValidGenre_MinMinuseOneF()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Author = "";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TestValidGenre_MinBoundary()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Genre = "A";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data Valid
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidGenre_MinPlusOne()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Genre = "AA";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data Valid
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidGenre_MaxMinusOne()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Genre = Genre.PadRight(9, 'A');

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidGenre_MaxBoundary()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Genre =Genre.PadRight(10, 'A');

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidGenre_MaxPlusOneF()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Genre = Genre.PadRight(11, 'A');

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TestValidGenre_Mid()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Genre = Genre.PadRight(5, 'A');

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is Valid
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidGenre_ExtremeMaxF()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Genre = Genre.PadRight(500, 'A');

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }

        // TEST VALID Quantity PARAMETER ------------------------------

        [TestMethod]
        public void TestValidQuantity_ExtremeMin()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Quantity = "";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TestValidQuantity_MinMinuseOneF()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Quantity = "0";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TestValidQuantity_MinBoundary()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Quantity = "1";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data Valid
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidQuantity_MinPlusOne()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Quantity = "2";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data Valid
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidQuantity_MaxMinusOne()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Quantity = "499";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is Valid
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidQuantity_MaxBoundary()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Quantity = "500";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is VALID
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidQuantity_MaxPlusOneF()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Quantity = "501";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TestValidQuantity_Mid()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Quantity = "250";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is Valid
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidQuantity_ExtremeMaxF()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Quantity = "1000";

             //run valid method
             String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TestValidQuantity_InvalidDateType()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Quantity = "a";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }

        // TEST VALID Restock_DOA PARAMETER ----------------------
        [TestMethod]
        public void TestValidRestock_DOA_ExtremeMin()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Restock_DOA = "a";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TestValidRestock_DOA_MinMinuseOneF()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Restock_DOA = DateTime.Now.AddDays(-1).ToString();

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TestValidRestock_DOA_MinBoundary()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            // no need to change, already current date in string form

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data Valid
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidRestock_DOA_MinPlusOne()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Restock_DOA = DateTime.Now.AddDays(+1).ToString();

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data Valid
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidRestock_DOA_MaxMinusOne()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Restock_DOA = DateTime.Now.AddMonths(6).AddDays(-1).ToString();

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is Valid
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidRestock_DOA_MaxBoundary()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Restock_DOA = DateTime.Today.AddMonths(6).ToString();

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is VALID
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidRestock_DOA_MaxPlusOneF()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Restock_DOA = DateTime.Now.AddMonths(6).AddDays(1).ToString();

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TestValidRestock_DOA_Mid()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Restock_DOA = DateTime.Now.AddMonths(3).ToString();

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is Valid
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidRestock_DOA_ExtremeMaxF()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Restock_DOA = DateTime.Now.AddYears(1).ToString();

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }

        // TEST VALID Restock_Quantity PARAMETER -------------

        [TestMethod]
        public void TestValidRestock_Quantity_ExtremeMin()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Restock_Quantity = "";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TestValidRestock_Quantity_MinMinuseOneF()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Restock_Quantity = "0";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TestValidRestock_Quantity_MinBoundary()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Restock_Quantity = "1";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data Valid
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidRestock_Quantity_MinPlusOne()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Restock_Quantity = "2";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data Valid
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidRestock_Quantity_MaxMinusOne()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Restock_Quantity = "99";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is Valid
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidRestock_Quantity_MaxBoundary()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Restock_Quantity = "100";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is VALID
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidRestock_Quantity_MaxPlusOneF()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Restock_Quantity = "101";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TestValidRestock_Quantity_Mid()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Restock_Quantity = "50";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is Valid
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestValidRestock_Quantity_ExtremeMaxF()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Quantity = "999";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TestValidRestock_Quantity_InvalidDataType()
        {
            // cls Book instance
            clsBook ABook = new clsBook();

            //test data
            Quantity = "a";

            //run valid method
            String Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

            //see if test data is INVALID
            Assert.AreNotEqual(Error, "");
        }
    }

}