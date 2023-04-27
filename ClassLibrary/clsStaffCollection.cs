using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        private List<clsStaff> mStaffList = new List<clsStaff>();
        private clsStaff mthisStaff;

        public clsStaffCollection() 
        {
            clsDataConnection connection = new clsDataConnection();
            connection.Execute("select_all_from_staff");
            PopulateArray(connection);
            mthisStaff = new clsStaff();
        }

        public List<clsStaff> StaffList
        {
            get { return mStaffList; }
            set { mStaffList = value; }
        }

        public int Count 
        {
            get { return mStaffList.Count; }
        }

        public clsStaff thisStaff
        {
            get { return mthisStaff; }
            set { mthisStaff = value; }
        }

        public int Add() 
        {
            clsDataConnection db = new clsDataConnection();

            db.AddParameter("@LoginID", mthisStaff.LoginID);
            db.AddParameter("@EmailAddr", mthisStaff.Email);
            db.AddParameter("@Password", mthisStaff.Password);
            db.AddParameter("@Name", mthisStaff.Name);
            db.AddParameter("@Permissions", mthisStaff.PermissionLvl);
            db.AddParameter("@OnSite",mthisStaff.OnSite);
            db.AddParameter("@StartDate", mthisStaff.StartDate);

            int key= db.Execute("add_staff");
            mthisStaff.LoginID = key;
            return key;
        }

        public void Update()
        {
            clsDataConnection db = new clsDataConnection();

            db.AddParameter("@LoginID", mthisStaff.LoginID);
            db.AddParameter("@EmailAddr", mthisStaff.Email);
            db.AddParameter("@Password", mthisStaff.Password);
            db.AddParameter("@Name", mthisStaff.Name);
            db.AddParameter("@Permissions", mthisStaff.PermissionLvl);
            db.AddParameter("@OnSite", mthisStaff.OnSite);
            db.AddParameter("@StartDate", mthisStaff.StartDate);

            db.Execute("update_Staff");
        }

        public void Delete()
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("@loginID", mthisStaff.LoginID);

            db.Execute("delete_staff");
        }

        public void ReportByName(string name)
        {
            clsDataConnection db = new clsDataConnection();
            name += '%';
            db.AddParameter("@Name",name);

            db.Execute("filter_staff_by_name");

            PopulateArray(db);
        }

        void PopulateArray(clsDataConnection db) 
        {
            int index = 0;
            int recordCount = db.Count;

            mStaffList = new List<clsStaff>();

            while (index < recordCount)
            {
                string name = Convert.ToString(db.DataTable.Rows[index]["Name"]);
                string email = Convert.ToString(db.DataTable.Rows[index]["EmailAddr"]);
                string login = Convert.ToString(db.DataTable.Rows[index]["LoginID"]);
                string password = Convert.ToString(db.DataTable.Rows[index]["Password"]);
                string startDate = Convert.ToString(db.DataTable.Rows[index]["StartDate"]);
                char permissions = Convert.ToChar(db.DataTable.Rows[index]["Permissions"]);
                bool onSite = Convert.ToBoolean(db.DataTable.Rows[index]["OnSite"]);

                clsStaff tempStaff = new clsStaff(name, email, login, password, permissions, startDate);
                tempStaff.OnSite = onSite;

                mStaffList.Add(tempStaff);

                index++;
            }
        }
    }
}
