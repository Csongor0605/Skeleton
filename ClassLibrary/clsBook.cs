using System;

namespace ClassLibrary
{
    public class clsBook
    {
        // BookID private member variable
        private int pBookID;
        // BookID public property
        public int BookID
        {
            get
            {
                // this sends data out of the property
                return pBookID;
            }
            set
            {
                // this allows data into the property
                pBookID = value;
            }

        }

        // Title private member variable
        private string pTitle;
        // Title public property
        public string Title
        {
            get
            {
                // this sends data out of the property
                return pTitle;
            }
            set
            {
                // this allows data into the property
                pTitle = value;
            }

        }

        // Author private member variable
        private string pAuthor;
        // Author public property
        public string Author
        {
            get
            {
                // this sends data out of the property
                return pAuthor;
            }
            set
            {
                // this allows data into the property
                pAuthor = value;
            }

        }

        // Genre private member variable
        private string pGenre;
        // Genre public property
        public string Genre
        {
            get
            {
                // this sends data out of the property
                return pGenre;
            }
            set
            {
                // this allows data into the property
                pGenre = value;
            }

        }

        // Quantity private member variable
        private int pQuantity;
        // BookID public property
        public int Quantity
        {
            get
            {
                // this sends data out of the property
                return pQuantity;
            }
            set
            {
                // this allows data into the property
                pQuantity = value;
            }

        }

        // RestockOrdered private member variable
        private Boolean pRestockOrdered;
        // RestockOrdered public property
        public Boolean RestockOrdered
        {
            get
            {
                // this sends data out of the property
                return pRestockOrdered;
            }
            set
            {
                // this allows data into the property
                pRestockOrdered = value;
            }

        }

        // Restock_date private member variable
        private DateTime pRestock_DOA;
        // Restock_date public property
        public DateTime Restock_DOA
        {
            get
            {
                // this sends data out of the property
                return pRestock_DOA;
            }
            set
            {
                // this allows data into the property
                pRestock_DOA = value;
            }

        }

        // RestockOrder_Quantity private member variable
        private int pRestockOrder_Quantity;
        // RestockOrder_Quantity public property
        public int RestockOrder_Quantity
        {
            get
            {
                // this sends data out of the property
                return pRestockOrder_Quantity;
            }
            set
            {
                // this allows data into the property
                pRestockOrder_Quantity = value;
            }

        }

       



        public bool Find(int BookID)
        {
            //create instance of data connection
            clsDataConnection DB = new clsDataConnection();
            // add parameter for BookID to search for
            DB.AddParameter("@BookID", BookID);
            //execute stored procedure
            DB.Execute("dbo.Select_all_from_Book");
            // if one record is found (should be 1 or 0)
            if (DB.Count == 1)
            {
                // Copy data from Db to private data members
                pBookID = Convert.ToInt32(DB.DataTable.Rows[0]["BookID"]);
                pTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                pAuthor = Convert.ToString(DB.DataTable.Rows[0]["Author"]);
                pGenre = Convert.ToString(DB.DataTable.Rows[0]["Genre"]);
                pQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                pRestockOrdered = Convert.ToBoolean(DB.DataTable.Rows[0]["RestockOrdered"]);
                pRestock_DOA = Convert.ToDateTime(DB.DataTable.Rows[0]["Restock_DOA"]);
                pRestockOrder_Quantity = Convert.ToInt32(DB.DataTable.Rows[0]["RestockOrder_Quantity"]);
                // return everything worked OK
                return true;
            }
            // if not record was found
            else
            {
                // return false indicates a problem
                return false;
            }
        }
    }
}