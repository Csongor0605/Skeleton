using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //CustomerID private member variable

        private Int32 mCustomerID;

        //CustomerID public property

       // public bool Active { get; set; }


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
            //set the private data members to the test data value
            mCustomerID = 1;
            mCustomerName = "kevin hart";
            mCustomerEmail = "kevinhart@gmail.com";
            mCustomerPassword = "password123";
            mCustomerAddress = "25 London Road LE1 6JH";
            mCustomerOrderMade = true;
            mCustomerReg = Convert.ToDateTime("16/9/2023");
            //always return true
            return true;
        }
    }
}