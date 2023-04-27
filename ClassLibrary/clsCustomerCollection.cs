using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        //private data member for the list
        List<clsCustomer> mBirukList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        public clsCustomerCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);


            /* //var for the index
             Int32 Index = 0;
             //var to store the record count
             Int32 RecordCount = 0;
             //object for data connection
             clsDataConnection DB = new clsDataConnection();
             //execute the stored procedure
             DB.Execute("sproc_tblCustomer_SelectAll");
             //get the count of records
             RecordCount = DB.Count;
             //while there are records to process
             while (Index < RecordCount)
             {
                 //create a blank address
                 clsCustomer ACustomer = new clsCustomer();
                 //read in the fields from the current record
                 ACustomer.CustomerOrderMade = Convert.ToBoolean(DB.DataTable.Rows[Index]["CustomerOrderMade"]);
                 ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                 ACustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                 ACustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                 ACustomer.CustomerPassword = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPassword"]);
                 ACustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                 ACustomer.CustomerReg = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerReg"]);
                 //add the record to the private data member
                 mBirukList.Add(ACustomer);
                 //point at the next record
                 Index++;
             }*/
        }



        public List<clsCustomer> BirukList
        {
            get
            {
                //return the private data
                return mBirukList;
            }
            set
            {
                //set the private data
                mBirukList = value;
            }
        }


        public int Count
        {
            get
            {
                //return the count of the list
                return mBirukList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerPassword", mThisCustomer.CustomerPassword);
            DB.AddParameter("@CustomerReg", mThisCustomer.CustomerReg);
            DB.AddParameter("@CustomerOrderMade", mThisCustomer.CustomerOrderMade);
            //excecute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
           
        }

        public void Update()
        {
            //update an existing record based on the values of ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerPassword", mThisCustomer.CustomerPassword);
            DB.AddParameter("@CustomerReg", mThisCustomer.CustomerReg);
            DB.AddParameter("@CustomerOrderMade", mThisCustomer.CustomerOrderMade);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");

        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }
        public void ReportByCustomerEmail(string CustomerEmail)
        {
            //filters the records based on a full or partial Customer Email
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the CustomerEmail parameter to the database
            DB.AddParameter("@CustomerEmail", CustomerEmail);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerEmail");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)

        {

            //populate the array list based on the data table in the parameter DB

            //var for the index

            Int32 Index = 0;

            //var to store the record count

            Int32 RecordCount;

            //get the count of records

            RecordCount = DB.Count;

            //clear the private array list

            mBirukList = new List<clsCustomer>();

            //while there are records to process

            while (Index < RecordCount)

            {

                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                //read in the fileds from the current record
                ACustomer.CustomerOrderMade = Convert.ToBoolean(DB.DataTable.Rows[Index]["CustomerOrdermade"]);
                ACustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                ACustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                ACustomer.CustomerPassword = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPassword"]);
                ACustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.CustomerReg = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerReg"]);

                //add the record to the private data member

                mBirukList.Add(ACustomer);

                //point at the next record

                Index++;

            }
        }

        //public property for ThisCustomer
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }

        }
    }

     
}
