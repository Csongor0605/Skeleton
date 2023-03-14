using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsBookCollection
    {
        List<clsBook> pBookList = new List<clsBook>();
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

        public clsBook ThisBook { get; set; }


        public clsBookCollection() //constructor gets entire table records and stores in BookList
        {
            // create data connection
            clsDataConnection DB = new clsDataConnection(); 
            // var for index
            int Index = 0;

            //execute stored procedure
            DB.Execute("Select_all_from_Book");

            // var to store record count
            int RecordCount = DB.Count;
            
            

            // while records to process
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

    }
}