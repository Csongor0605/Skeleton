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
        private string mComplaint;
        public string Complaint
        {
            get
            {
                return mComplaint;
            }
            set
            {
                mComplaint = value;
            }
        }

       

        public bool Find(int OrderID)
        {
            //create a instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order id to search for
            DB.AddParameter("@OrderID", OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblComplaint_FilterByOrderID");
            //if one record is found (there should be one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data member
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mSubject = Convert.ToString(DB.DataTable.Rows[0]["Subject"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mComplaint = Convert.ToString(DB.DataTable.Rows[0]["Complaint"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["ActiveOrder"]);
                //return that everything is ok
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}