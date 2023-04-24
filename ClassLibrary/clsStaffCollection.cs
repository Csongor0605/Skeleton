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
            int index = 0;
            int recordCnt = 0;
            clsDataConnection connection = new clsDataConnection();
            connection.Execute("select_all_from_staff");
            recordCnt = connection.Count;

            while (index < recordCnt) {

                string name = Convert.ToString(connection.DataTable.Rows[index]["Name"]);
                string email = Convert.ToString(connection.DataTable.Rows[index]["EmailAddr"]);
                string login = Convert.ToString(connection.DataTable.Rows[index]["LoginID"]);
                string password = Convert.ToString(connection.DataTable.Rows[index]["Password"]);
                string startDate = Convert.ToString(connection.DataTable.Rows[index]["StartDate"]);
                char permissions = Convert.ToChar(connection.DataTable.Rows[index]["Permissions"]);
                bool onSite = Convert.ToBoolean(connection.DataTable.Rows[index]["OnSite"]);

                clsStaff tempStaff = new clsStaff(name,email,login,password,permissions,startDate);
                tempStaff.OnSite = onSite;

                mStaffList.Add(tempStaff);

                index++;
            }

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

            return db.Execute("add_staff");

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
    }
}
