using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Runtime.CompilerServices;



namespace BusinessLayer
{
    public class clsAdmin
    {
        public enum enMode { AddNew = 0, Update = 1};
        public enMode Mode = enMode.AddNew;

        public static clsAdmin CurrentAdmin;

        public int AdminID { set; get; }
        public string Name { set; get; }
        public string Username { set; get; }
        public int EmployeeID { set; get; }
        public string Password { set; get; }

        public string ImagePath { set; get; }

        public clsAdmin()
        {
            this.AdminID = -1;
            this.Name = "";
            this.Username = "";
            this.EmployeeID = -1;
            this.Password = "";
            this.ImagePath = "";

            CurrentAdmin = this;
            Mode = enMode.AddNew;
        }

        private clsAdmin(int adminID, string name, string username, int employeeID, string password, string ImagePath)
        {
            this.AdminID = adminID;
            this.Name = name;
            this.Username = username;
            this.EmployeeID = employeeID;
            this.Password = password;
            this.ImagePath = ImagePath;

            CurrentAdmin = this;
            Mode = enMode.Update;
        }
        
        public static clsAdmin Find(string Username, string Password)
        {
            int ID = -1, EmployeeID = -1;
            string Name = "", ImagePath = "";

            if (clsAdminData.GetAdminInfoByUsernameAndPassword(ref ID, ref Name, Username, ref EmployeeID, Password, ref ImagePath)) 
            {
                return new clsAdmin(ID, Name, Username, EmployeeID, Password, ImagePath);
            }
            else
                return null;

        }

    }
}
