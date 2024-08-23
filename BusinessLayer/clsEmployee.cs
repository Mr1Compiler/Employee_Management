using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsEmployee
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }
        public int DepartmentID { get; set; }

        public string DepartmentName { get; set; }

        public int CountryID { get; set; }

        public string CountryName { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime ExitDate { get; set; }
        public decimal MonthlySalary {  get; set; }
        public double BonusPerc { get; set; }
        public string FullName { get; set; }

        public string ImagePath { get; set; }

        public clsEmployee()
        {
            this.ID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Gender = "";
            this.DateOfBirth = DateTime.Now;
            this.DepartmentID = -1;
            this.CountryID = -1;
            this.DepartmentID = -1;
            this.HireDate = DateTime.Now;
            this.ExitDate = DateTime.Now;
            this.MonthlySalary = 0;
            this.BonusPerc = 0;
            this.FullName = "";
            this.ImagePath = "";

            Mode = enMode.AddNew;
        }

        private clsEmployee(int iD, string firstName, string lastName, string gender, DateTime dateOfBirth, string departmentName,string CountryName ,DateTime hireDate, DateTime exitDate, decimal monthlySalary, double bonusPerc, string ImagePath)
        {
            this.ID = iD;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.CountryName = CountryName;
            this.DepartmentName= departmentName;
            this.HireDate = hireDate;
            this.ExitDate = exitDate;
            this.MonthlySalary = monthlySalary;
            this.BonusPerc = bonusPerc;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }

        private clsEmployee(int iD, string firstName, string lastName, string gender, DateTime dateOfBirth, string departmentName, string CountryName, DateTime hireDate, DateTime exitDate, decimal monthlySalary, double bonusPerc,string FullName, string ImagePath)
        {
            this.ID = iD;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.CountryName = CountryName;
            this.DepartmentName = departmentName;
            this.HireDate = hireDate;
            this.ExitDate = exitDate;
            this.MonthlySalary = monthlySalary;
            this.BonusPerc = bonusPerc;
            this.ImagePath = ImagePath;
            this.FullName = FullName;

            Mode = enMode.Update;
        }

        private clsEmployee(int iD, string firstName, string lastName, string gender, DateTime dateOfBirth, int DepartmentID, int CountryID, DateTime hireDate, DateTime exitDate, decimal monthlySalary, double bonusPerc, string ImagePath)
        {
            this.ID = iD;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.CountryID = CountryID;
            this.DepartmentID = DepartmentID;
            this.HireDate = hireDate;
            this.ExitDate = exitDate;
            this.MonthlySalary = monthlySalary;
            this.BonusPerc = bonusPerc;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }
        public static DataView GetAllEmployees()
        {
            return clsEmployeesData.GetAllEmployees();
        }

        public static clsEmployee FindEmpolyeeByID(int ID)
        {
            string FirstName = "", LastName = "", Gendor = "", CountryName= "", DepartmentName = "", ImagePath = "";
            DateTime dateOfBirth = DateTime.Now, HireDate = DateTime.Now, ExitDate = DateTime.Now;
            decimal MonthlySalary = 0;
            double bonusPerc = 0;

            if (clsEmployeesData.GetEmployeeInfoByID(ID, ref FirstName, ref LastName, ref Gendor, ref dateOfBirth, ref DepartmentName, ref CountryName, ref HireDate, ref ExitDate, ref MonthlySalary, ref bonusPerc, ref ImagePath))
            {
                return new clsEmployee(ID, FirstName, LastName, Gendor, dateOfBirth, DepartmentName, CountryName, HireDate, ExitDate, MonthlySalary, bonusPerc, ImagePath);
            }

            else
                return null;
        }

        public static clsEmployee FindEmpolyeeByIDWithIDs(int ID)
        {
            string FirstName = "", LastName = "", Gendor = "", ImagePath = "";
            DateTime dateOfBirth = DateTime.Now, HireDate = DateTime.Now, ExitDate = DateTime.Now;
            decimal MonthlySalary = 0;
            double bonusPerc = 0;
            int CountryID = -1, DepartmentID = -1;

            if (clsEmployeesData.GetEmployeeInfoByIDWithIDs(ID, ref FirstName, ref LastName, ref Gendor, ref dateOfBirth, ref DepartmentID, ref CountryID, ref HireDate, ref ExitDate, ref MonthlySalary, ref bonusPerc, ref ImagePath))
            {
                return new clsEmployee(ID, FirstName, LastName, Gendor, dateOfBirth, DepartmentID, CountryID, HireDate, ExitDate, MonthlySalary, bonusPerc, ImagePath);
            }

            else
                return null;
        }

        public static DataView FindEmployeesByName(string FullName)
        {          
            return clsEmployeesData.FindEmployeeByName(FullName);
        }

        private bool _UpdateEmployee()
        {
            return clsEmployeesData.UpdateEmployee(this.ID, this.FirstName, this.LastName, this.Gender, this.DateOfBirth, this.DepartmentID, this.CountryID, this.HireDate, this.ExitDate, this.MonthlySalary, this.BonusPerc,this.FullName, this.ImagePath);
        }

        private bool _AddNewEmployee()
        {
            return clsEmployeesData.AddNewEmployee(this.FirstName, this.LastName, this.Gender, this.DateOfBirth, this.DepartmentID, this.CountryID, this.HireDate, this.ExitDate, this.MonthlySalary, this.BonusPerc, this.FullName, this.ImagePath);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewEmployee())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false; 
                    }

                case enMode.Update:
                    return _UpdateEmployee();
            }

            return false;
        }

        public static bool DeleteEmployee(int ID)
        {
            return clsEmployeesData.DeleteEmployee(ID);
        }
    }
}
