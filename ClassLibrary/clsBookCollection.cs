using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsBookCollection
    {
        // private data member for list
        List<clsBook> pBookList = new List<clsBook>();
        // private data member thisBook
        clsBook mThisBook = new clsBook();
        public List<clsBook> BookList
        {
            get
            {
                return pBookList;
            }
            set
            {
                pBookList = value;
            }
        }

        
        public int Count
        {
            get
            {
                return pBookList.Count;
            }
            set
            {
                // later
            }
        }

        public clsBook ThisBook
        {
            get
            {
                return mThisBook;
            }
            set
            {
                mThisBook = value;
            }
        }



        public clsBookCollection() //constructor gets entire table records and stores in BookList
        {
            // create data connection
            clsDataConnection DB = new clsDataConnection(); 
            //execute stored procedure
            DB.Execute("Select_all_from_Book");

            // popualte array
            PopulateArray(DB);

            
            
           
        }


        public void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = DB.Count;
            pBookList = new List<clsBook>();

            while(Index < RecordCount)
            {
                clsBook ABook = new clsBook();

                ABook.BookID = Convert.ToInt32(DB.DataTable.Rows[Index]["BookID"]);
                ABook.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                ABook.Author = Convert.ToString(DB.DataTable.Rows[Index]["Author"]);
                ABook.Genre = Convert.ToString(DB.DataTable.Rows[Index]["Genre"]);
                ABook.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                ABook.Restock_Ordered = Convert.ToBoolean(DB.DataTable.Rows[Index]["Restock_Ordered"]);
                if (ABook.Restock_Ordered == true)
                {
                    ABook.Restock_DOA = Convert.ToDateTime(DB.DataTable.Rows[Index]["Restock_DOA"]);
                    ABook.Restock_Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Restock_Quantity"]);
                }

                pBookList.Add(ABook);
                Index++;

            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            // set parameters for stored procedures
            DB.AddParameter("@Title", mThisBook.Title);
            DB.AddParameter("@Author", mThisBook.Author);
            DB.AddParameter("@Genre", mThisBook.Genre);
            DB.AddParameter("@Quantity", mThisBook.Quantity);
            DB.AddParameter("@Restock_Ordered", mThisBook.Restock_Ordered);
            DB.AddParameter("@Restock_DOA", mThisBook.Restock_DOA);
            DB.AddParameter("@Restock_Quantity", mThisBook.Restock_Quantity);

            // for all columns in DB
            return DB.Execute("Book_AddRecord");

        }


        // update existing record based on valeus of thisBook
        public void Update()
        {
            // connec tto database
            clsDataConnection DB = new clsDataConnection();

            // set parameters for stored procedures
            DB.AddParameter("@BookID", mThisBook.BookID);
            DB.AddParameter("@Title", mThisBook.Title);
            DB.AddParameter("@Author", mThisBook.Author);
            DB.AddParameter("@Genre", mThisBook.Genre);
            DB.AddParameter("@Quantity", mThisBook.Quantity);
            DB.AddParameter("@Restock_Ordered", mThisBook.Restock_Ordered);
            DB.AddParameter("@Restock_DOA", mThisBook.Restock_DOA);
            DB.AddParameter("@Restock_Quantity", mThisBook.Restock_Quantity);

            // execute procedure
            DB.Execute("Book_UpdateRecord");
        }

        public void Delete()
        {
            // delete record pointed to by thisBook
            clsDataConnection DB = new clsDataConnection();
            // set parameters for stored procedures
            DB.AddParameter("@BookID", mThisBook.BookID);
            DB.Execute("Book_DeleteRecord");
        }


        public void FilterByAuthor(String s)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Author", s);
            DB.Execute("Book_FilterByAuthor");
            PopulateArray(DB);
        }
    }
}