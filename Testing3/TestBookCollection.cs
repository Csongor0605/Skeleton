using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class TestBookCollection
    {
        [TestMethod]
        public void TestclsBookCollectionInstance()
        {
            // create BookCollection instance
            clsBookCollection AllBook = new clsBookCollection();
            Assert.IsNotNull(AllBook);
        }

        [TestMethod]
        public void TestBookList()
        {
            // new book collection 
            clsBookCollection AllBooks = new clsBookCollection();
            // create data to test, needs list of object
            List<clsBook> TestList = new List<clsBook>();
            //add item to list
            clsBook TestItem = new clsBook();
            //set properties
            TestItem.BookID = 1;
            TestItem.Title = "Harry Potter";
            TestItem.Author = "J.K Rowling";
            TestItem.Genre = "Fantasy";
            TestItem.Quantity = 10;
            TestItem.Restock_Ordered = true;
            TestItem.Restock_DOA = DateTime.Now.Date;
            TestItem.Restock_Quantity = 50;

            // add testitem to property
            AllBooks.BookList = TestList;
            // test
            Assert.AreEqual(AllBooks.BookList, TestList);
        }

        
        [TestMethod]
        public void TestBookCount()
        {
            //new clsBookCollection instance
            clsBookCollection AllBooks = new clsBookCollection();

            //test data
            Int32 SomeCount = 2;

            //assign data to property
            AllBooks.Count = SomeCount;

            //test
            Assert.AreEqual(AllBooks.Count, SomeCount);
        }
        

        [TestMethod]
        public void TestThisBook()
        {
            //new clsBookCollection instance
            clsBookCollection AllBooks = new clsBookCollection();

            // create test data to assign property
            clsBook TestBook = new clsBook();

            //set properties
            TestBook.BookID = 1;
            TestBook.Title = "Harry Potter";
            TestBook.Author = "J.K Rowling";
            TestBook.Genre = "Fantasy";
            TestBook.Quantity = 10;
            TestBook.Restock_Ordered = true;
            TestBook.Restock_DOA = DateTime.Now.Date;
            TestBook.Restock_Quantity = 50;

            //Assign data to property
            AllBooks.ThisBook = TestBook;

            //test 
            Assert.AreEqual(AllBooks.ThisBook, TestBook);


        }

        [TestMethod]
        public void TestBookListAndCount()
        {
            // new book collection 
            clsBookCollection AllBooks = new clsBookCollection();
            // create data to test, needs list of object
            List<clsBook> TestList = new List<clsBook>();
            //add item to list
            clsBook TestItem = new clsBook();

            //set properties
            TestItem.BookID = 1;
            TestItem.Title = "Harry Potter";
            TestItem.Author = "J.K Rowling";
            TestItem.Genre = "Fantasy";
            TestItem.Quantity = 10;
            TestItem.Restock_Ordered = true;
            TestItem.Restock_DOA = DateTime.Now.Date;
            TestItem.Restock_Quantity = 50;

            // add item to test list
            TestList.Add(TestItem);

            // assogm data to property
            AllBooks.BookList = TestList;

            //test
            Assert.AreEqual(AllBooks.Count, TestList.Count);

        }

        // test add method
        [TestMethod]
        public void TestAddMethod()
        {
            // allbook instance
            clsBookCollection AllBooks = new clsBookCollection();
            // create item of test data
            clsBook TestItem = new clsBook();
            // store primary key
            Int32 PrimaryKey = 0;

            // set its properties
            TestItem.BookID = 5;
            TestItem.Title = "Percy Jackson";
            TestItem.Author = "Rick Riordan";
            TestItem.Genre = "Fantasy";
            TestItem.Quantity = 10;
            TestItem.Restock_Ordered = true;
            TestItem.Restock_DOA = DateTime.Now.Date;
            TestItem.Restock_Quantity = 50;

            // set thisbook to test data
            AllBooks.ThisBook = TestItem;
            // add record
            PrimaryKey = AllBooks.Add();
            // find record
            AllBooks.ThisBook.Find(PrimaryKey);
            // test if two values are equal
            Assert.AreEqual(AllBooks.ThisBook, TestItem);
        }
    }
}
