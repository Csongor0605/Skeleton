using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        public clsCustomerCollection()
        {
            //var for the index
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
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }

           

        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
       

        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsCustomer ThisCustomer { get; set; }
    
    }

     
}
