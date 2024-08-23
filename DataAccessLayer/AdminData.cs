using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CountriesDataAccessLayer;
using System.Web;


namespace DataAccessLayer
{
    public class clsAdminData
    {

        public static bool GetAdminInfoByUsernameAndPassword(ref int ID, ref string Name, string Username,ref int EmployeeID, string Password, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @" select Admins.AdminID,Admins.EmployeeID, Employees.FullName as Name, Employees.ImagePath as ImagePath
                             from Admins
                             inner join Employees on Admins.EmployeeID = Employees.ID
                             where Admins.UserName = @Username and Admins.Passkey = @Password";

         

                
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    ID = (int)reader["AdminID"];
                    Name = (string)reader["Name"];
                    EmployeeID = (int)reader["EmployeeID"];

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }
                }
                else
                    isFound = false;

                reader.Close();
            }

            catch (Exception ex)
            {
                isFound = false;
            }

            finally
            {
                connection.Close();
            }

            return isFound;
        }
    }
}
