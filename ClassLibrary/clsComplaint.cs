using System;

namespace ClassLibrary
{
    public class clsComplaint
    {
        private Boolean mActive;
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        // DateAdded private member 
        private DateTime mDateAdded;

        // DateAdded public property
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

        //private data member for the order id property
        private Int32 mOrderID;

        public int OrderID
        {
            get
            {
                //sends data out of the property 
                return mOrderID;
            }
            set
            {
                //allows data into the property
                mOrderID = value;
            }
        }
        private string mName;
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        private string mSubject;
        public string Subject
        {
            get
            {
                return mSubject;
            }
            set
            {
                mSubject = value;
            }
        }
        private string mEmail;
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }
        private string mText;
        public string Text
        {
            get
            {
                return mText;
            }
            set
            {
                mText = value;
            }
        }

       

        public bool Find(int OrderID)
        {
            //set the private data members to the data test value
            mOrderID = 21;
            mDateAdded = Convert.ToDateTime("16/9/2015");
            mActive = true;
            mText = "Test Text";
            mSubject = "Test Subject";
            mEmail = "Test Email";
            mName = "Test Name";
            //always return true
            return true;
        }
    }
}