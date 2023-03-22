using System;
using System.Text.RegularExpressions;

namespace ClassLibrary
{

    public class clsStaff
    {
        private string name;
        private string email;
        private int loginID; //PrimaryKey
        private string password;
        private char permissionLvl;
        private bool onSite;
        private DateTime startDate;

        public clsStaff(string name,
                        string email,
                        int loginID,
                        string password,
                        char permissionLvl,
                        DateTime startDate)
        {
            this.Name = name;
            this.Email = email;
            this.loginID = loginID;
            this.password = password;
            this.startDate = startDate;
            this.PermissionLvl = permissionLvl;
            this.onSite = false;
        }

        public clsStaff(int loginID, DateTime startDate) 
        {
            this.loginID = loginID;
            this.startDate = startDate;
            this.password = "password";
        }

        public clsStaff() { }

        public bool checkPassword(string passwordToTest) {
            return passwordToTest == this.password;
        }
        //public void SetPassword(string passwordHash) { this.password = passwordHash; }
        public char PermissionLvl { get => permissionLvl; set => permissionLvl = value; }
        public bool OnSite { get => onSite; set => onSite = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }

        public int LoginID { get => loginID; set => loginID = value; }
        public string Password { get => password; set => password = value; }

        public DateTime StartDate { get => startDate; set => startDate = value; }

        public bool Find(int loginID) {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("@LoginID", loginID);
            db.Execute("sproc_Staff_filterByLoginID");

            if (db.Count >= 1)
            {
                name = Convert.ToString(db.DataTable.Rows[0]["Name"]);
                loginID = Convert.ToInt32(db.DataTable.Rows[0]["LoginID"]);
                password = Convert.ToString(db.DataTable.Rows[0]["Password"]);
                email = Convert.ToString(db.DataTable.Rows[0]["EmailAddr"]);
                permissionLvl = Convert.ToString(db.DataTable.Rows[0]["Permissions"])[0];
                onSite = Convert.ToBoolean(db.DataTable.Rows[0]["OnSite"]);
                startDate = Convert.ToDateTime(db.DataTable.Rows[0]["StartDate"]);

                return true;
            }
            else
                return false;
        }

        public string Valid(string loginID, string name, string password, string email, string startDate)
        {
            string Error = "";
            int temp;
            if (!int.TryParse(loginID, out temp) || temp < 0 || temp > 999999)
                Error += "loginID must be six digit positive integer";

            if (password.Length >= 50 || !Regex.IsMatch(password, "([a-z][A-Z][0-9])*") || password.Length <= 3 || password == null)
                Error += "Password must be less than 50 characters, but more than 3 and contain only alphanumerical characters";

            if (!Regex.IsMatch(email, "([a-z][A-Z][0-9])*@([a-z][A-Z][0-9])*.([a-z][A-Z][0-9])*") && !(email == null || email == ""))
                Error += "Email must be formatted correctly or left blank";

            try
            {
                DateTime dateTemp = Convert.ToDateTime(startDate);
                if (dateTemp < DateTime.Now)
                    Error += "Start Date cannot in the past";
                else if (dateTemp > DateTime.Now.AddMonths(6))
                    Error += "Start date cannot be more than 6 months in the future.";
            }
            catch
            {
                Error += "Start date must be date";
            }

            if (name.Length > 100 || name.Length < 3 || name == null)
                Error += "Name must be fewer than 100 characters, longer than 3 and not null";

            return Error;
        }
    }
}
