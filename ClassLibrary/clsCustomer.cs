using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //CustomerID private member variable

        private Int32 mCustomerID;

        //CustomerID public property

        public bool Active { get; set; }


        //dateadded private member variable
        private DateTime mDateAdded;
        //DateAdded public property
        public DateTime DateAdded
        {

            get

            {

                return mDateAdded;

            }

            set

            {

                mDateAdded = value;

            }

        }


        public Int32 CustomerID
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerID = value;
            }
        }

        //private data member for the customer address property
        private string mCustomerAddress;
        //public property for the address number
        public string CustomerAddress
        {

            get

            {

                //return the private data

                return mCustomerAddress;

            }

            set

            {

                //set the value of the private data member



                mCustomerAddress = value;

            }

        }
        //CustomerEmail private member variable

        private string mCustomerEmail;

        //CustomerEmail public property
        public string CustomerEmail
        {

            get

            {

                //this line of code sends data out of the property

                return mCustomerEmail;

            }

            set

            {

                //this line of code allows data into the property

                mCustomerEmail = value;

            }

        }

        //dateAdded private member variable
        private DateTime mCustomerReg;
        //dateadded public property
        public DateTime CustomerReg
        {
            get
            {
                return mCustomerReg;
            }
            set
            {
                mCustomerReg = value;
            }

        }
        //private data member for the CustomerName property

        private string mCustomerName;

        //public property for the customer name
        public string CustomerName
        {

            get

            {

                //return the private data

                return mCustomerName;

            }

            set

            {

                //set the value of the private data member

                mCustomerName = value;

            }

        }
        //private data for OrderMade

        private Boolean mCustomerOrderMade;

        //public property for OrderMade
        public bool CustomerOrderMade
        {

            get

            {

                //return the private data

                return mCustomerOrderMade;

            }

            set

            {

                //set the private data

                mCustomerOrderMade = value;

            }

        }
        //private data member for the CustomerPassword property

        private string mCustomerPassword;

        //public property for the CustomerPassword
        public string CustomerPassword
        {

            get

            {

                //return the private data

                return mCustomerPassword;

            }

            set

            {

                //set the value of the private data member



                mCustomerPassword = value;

            }

        }


        public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Customer ID number to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be euther one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerPassword = Convert.ToString(DB.DataTable.Rows[0]["CustomerPassword"]);
                mCustomerOrderMade = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerOrderMade"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mCustomerReg = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerReg"]);
                //return that everything worked
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string CustomerName, string CustomerEmail, string CustomerPassword, string CustomerAddress, string CustomerReg)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the error
            DateTime DateTemp;
            //if the CustomerName is blank
            if (CustomerName.Length == 0)
            {
                //record the error
                Error = Error + "The customer name may not be blank : ";
            }
            //if the customer name is greater than 6 characters
            if (CustomerName.Length > 50)
            {
                Error = Error + "The CustomerName must be less than 50 characters : ";
            }
            try
            {
                //copy the CustomerReg value to the DateTemp variable
                DateTemp = Convert.ToDateTime(CustomerReg);

                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error 
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //return any error messages
                return Error + "The date was not a valid date : ";
            }
            //is the post code blank
            if (CustomerAddress.Length == 0)
            {
                //record the error
                Error = Error + "The post code may not be blank : ";
            }
            //if the post code is too long
            if (CustomerAddress.Length > 50)
            {
                //record the error
                Error = Error + "The post code must be less than 50 characters : ";
            }

            //is the Email blank
            if (CustomerEmail.Length == 0)
            {
                //record the error
                Error = Error + "The Email may not be blank : ";
            }
            //if the street is too long
            if (CustomerEmail.Length > 50)
            {
                //record the error
                Error = Error + "The Password must be less than 50 characters : ";
            }
            //is the town blank
            if (CustomerPassword.Length == 0)
            {
                //record the error
                Error = Error + "The Password may not be blank : ";
            }
            //if the town is too long
            if (CustomerPassword.Length > 50)
            {
                //record the error
                Error = Error + "The Password must be less than 50 characters : ";
            }
            //return any error messages
            return Error;

        }


    }
}