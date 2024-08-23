using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsCountry
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int ID { get; set; }
        public string Name { get; set; }   

        public clsCountry()
        {
            this.ID = -1;
            this.Name = "";
            Mode = enMode.AddNew;
        }

        public clsCountry(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;

            Mode = enMode.Update;
        }

        public static DataTable GetAllCountries()
        {
            return CountriesData.GetAllCountriesData();
        }

        public static clsCountry Find(int ID)
        {
            string Name = "";

            if (CountriesData.GetCountryInfoByID(ID, ref Name))
            {
                return new clsCountry(ID, Name);
            }
            else
                return null;
        }

        public static clsCountry Find(string Name)
        {
            int ID = -1;    

            if (CountriesData.GetCountryInfoByName(ref ID, Name))
            {
                return new clsCountry(ID, Name);
            }
            else
                return null;
        }
    }
}
