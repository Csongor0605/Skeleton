using System;

namespace ClassLibrary
{

    public class clsStaff
    {
        private string name;
        private string email;
        private string loginID; //PrimaryKey
        private string password;
        private char permissionLvl;
        private bool onSite;
        private DateTime startDate;

        public clsStaff(string name,
                        string email,
                        string loginID,
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

        public clsStaff(string loginID, DateTime startDate) 
        {
            this.loginID = loginID;
            this.startDate = startDate;
        }

        public bool checkPassword(string passwordToTest) {
            return passwordToTest == this.password;
        }
        public void SetPassword(string passwordHash) { this.password = passwordHash; }
        public char PermissionLvl { get => permissionLvl; set => permissionLvl = value; }
        public bool OnSite { get => onSite; set => onSite = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }

        public string LoginID { get => loginID; }
        public string Password { get => password; }

        public DateTime GetStartDate() { return startDate; }
    }
}


