using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsDepartment
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int ID { get; set; }
        public string Name { get; set; }

        public clsDepartment()
        {
            this.ID = -1;
            this.Name = "";
            Mode = enMode.AddNew;
        }

        private clsDepartment(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;

            Mode = enMode.Update;
        }


        public static DataTable GetAllCountries()
        {
            return DepartmentsData.GetAllDepartmentsData();
        }

        public static clsDepartment Find(int ID)
        {
            string Name = "";

            if (DepartmentsData.GetAllDepartmentsDataByID(ID, ref Name))
            {
                return new clsDepartment(ID, Name);
            }
            else
                return null;
        }

        public static clsDepartment Find(string Name)
        {
            int ID = -1;

            if (DepartmentsData.GetDepartmrntInfoByName(ref ID, Name))
            {
                return new clsDepartment(ID, Name);
            }
            else
                return null;
        }
    }
}
