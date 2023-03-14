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
        private Boolean pRestock_Ordered;
        // RestockOrdered public property
        public Boolean Restock_Ordered
        {
            get
            {
                // this sends data out of the property
                return pRestock_Ordered;
            }
            set
            {
                // this allows data into the property
                pRestock_Ordered = value;
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
        private int pRestock_Quantity;
        // RestockOrder_Quantity public property
        public int Restock_Quantity
        {
            get
            {
                // this sends data out of the property
                return pRestock_Quantity;
            }
            set
            {
                // this allows data into the property
                pRestock_Quantity = value;
            }

        }





        public bool Find(int BookID)
        {
            //create instance of data connection
            clsDataConnection DB = new clsDataConnection();
            // add parameter for BookID to search for
            DB.AddParameter("@BookID", BookID);
            //execute stored procedure
            DB.Execute("Book_FilterByBookID");
            // if one record is found (should be 1 or 0)
            if (DB.Count == 1)
            {
                // Copy data from Db to private data members
                pBookID = Convert.ToInt32(DB.DataTable.Rows[0]["BookID"]);
                pTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                pAuthor = Convert.ToString(DB.DataTable.Rows[0]["Author"]);
                pGenre = Convert.ToString(DB.DataTable.Rows[0]["Genre"]);
                pQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                pRestock_Ordered = Convert.ToBoolean(DB.DataTable.Rows[0]["Restock_Ordered"]);
                pRestock_DOA = Convert.ToDateTime(DB.DataTable.Rows[0]["Restock_DOA"]);
                pRestock_Quantity = Convert.ToInt32(DB.DataTable.Rows[0]["Restock_Quantity"]);
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

        public string Valid(string VTitle, string VAuthor, string VGenre, string VQuantity, string VRestock_DOA, string VRestock_Quantity)
        {
            string Error = "";

            // validate title parameter
            if (VTitle.Length == 0)
            {
                Error = Error + " Please Enter a Title ;\n";
            }

            if (VTitle.Length > 50)
            {
                Error = Error + " Title can only be 50 characters long max ;\n";
            }

            // validate Author parameter
            if (VAuthor.Length == 0)
            {
                Error = Error + " Please Entor an Author ;\n";
            }

            if (VAuthor.Length > 20)
            {
                Error = Error + " Author can only be 20 characters long max ;\n";
            }

            // validate genre parameter
            if (VGenre.Length == 0)
            {
                Error = Error + " Please enter a Genre ;";
            }

            if(VGenre.Length > 10)
            {
                Error = Error + " Genre can only be 10 characters long max ;\n";
            }

            // validate quantity parameter
            try
            {
                if (int.Parse(VQuantity) == 0 || int.Parse(VQuantity) > 500)
                {
                    Error = Error + " Quantity must be between 0 and 500 ;\n";
                }
            }
            catch
            {
                Error = Error + "Please enter a valid number ;";
            }


            // validate Restock_DOA parameter
            try
            {
                DateTime DateTemp = Convert.ToDateTime(VRestock_DOA);
                if(DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "Date cannot be in the past ;\n ";
                }

                if(DateTemp > DateTime.Today.Date.AddMonths(6))
                {
                    Error = Error + "Date cannot be more than 6 months in the future ;\n";
                }

            }
            catch
            {
                Error = Error + "Please Enter a valid Date ;\n";
            }




            // validate Restock_Quantity parameter
            try
            {
                if (int.Parse(VRestock_Quantity) == 0 || int.Parse(VRestock_Quantity) > 100)
                {
                    Error = Error + " Restock Quantity must be between 0 and 100 ;\n";
                }
            }
            catch
            {
                Error = Error + "Please enter a valid number ;";
            }






            return Error;
        }
    }
}