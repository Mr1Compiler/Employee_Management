using CountriesDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessLayer
{
    public class clsEmployeesData
    {
        public static DataView GetAllEmployees()
        {
            DataTable dt = new DataTable();
            DataView EmployeesDataView;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from ShortEmployeesView";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }

            catch (Exception ex)
            {
            }

            finally
            {
                connection.Close();
            }

            EmployeesDataView = dt.DefaultView;
            return EmployeesDataView;
        }

        public static bool GetEmployeeInfoByID(int ID, ref string firstName,ref string lastName,ref string gender, ref DateTime dateOfBirth,ref string departmentName,ref string CoutnryName, ref DateTime hireDate, ref DateTime exitDate,ref decimal monthlySalary,ref double bonusPerc, ref string ImagePath)
        {
            
            bool isFound= false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from FullEmployeesDetails where ID = @ID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    firstName = (string)reader["FirstName"];
                    lastName = (string)reader["LastName"];
                    gender = (string)reader["Gendor"];
                    dateOfBirth = (DateTime)reader["DateOfBirth"];
                    departmentName = (string)reader["DepName"];
                    CoutnryName = (string)reader["CountryName"];
                    monthlySalary = (decimal)reader["MonthlySalary"];

                    if (reader["ExitDate"] != DBNull.Value)
                    {
                        exitDate = (DateTime)reader["ExitDate"];
                    }
                    else
                    {
                        exitDate = DateTime.Now;
                    }

                    if (reader["HireDate"] != DBNull.Value)
                    {
                        hireDate = (DateTime)reader["HireDate"];
                    }
                    else
                    {
                        hireDate = DateTime.Now;
                    }
                    
                    bonusPerc = (double)reader["BonusPerc"];


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

        public static bool GetEmployeeInfoByIDWithIDs(int ID, ref string firstName, ref string lastName, ref string gender, ref DateTime dateOfBirth, ref int DepartmentID, ref int CountryID, ref DateTime hireDate, ref DateTime exitDate, ref decimal monthlySalary, ref double bonusPerc, ref string ImagePath)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Employees where ID = @ID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    firstName = (string)reader["FirstName"];
                    lastName = (string)reader["LastName"];
                    gender = (string)reader["Gendor"];
                    dateOfBirth = (DateTime)reader["DateOfBirth"];
                    DepartmentID = (int)reader["DepartmentID"];
                    CountryID = (int)reader["CountryID"];
                    monthlySalary = (decimal)reader["MonthlySalary"];

                    if (reader["ExitDate"] != DBNull.Value)
                    {
                        exitDate = (DateTime)reader["ExitDate"];
                    }
                    else
                    {
                        exitDate = DateTime.Now;
                    }

                    if (reader["HireDate"] != DBNull.Value)
                    {
                        hireDate = (DateTime)reader["HireDate"];
                    }
                    else
                    {
                        hireDate = DateTime.Now;
                    }

                    bonusPerc = (double)reader["BonusPerc"];


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

        public static DataView FindEmployeeByName(string FullName)
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from AllEmployeesDetails where FullName like @FullName;";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FullName", $"{FullName}%");


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

           

                reader.Close();
            }

            catch (Exception ex)
            {
                //isFound = false;
            }

            finally
            {
                connection.Close();
            }

            DataView dv = dt.DefaultView;

            return dv;
        }


        public static bool UpdateEmployee(int ID, string firstName, string lastName, string gender, DateTime dateOfBirth, int DepartmentID, int CountryID, DateTime hireDate, DateTime exitDate, decimal monthlySalary, double bonusPerc,string FullName, string ImagePath)
        { 

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update Employees  
                            set FirstName = @firstName, 
                                LastName = @lastName, 
                                Gendor = @Gendor, 
                                dateOfBirth= @DateOfBirth, 
                                DepartmentID = @DepartmentID, 
                                CountryID = @CountryID,
                                HireDate = @hireDate,
                                ExitDate = @exitDate,
                                MonthlySalary = @monthlySalary,
                                BonusPerc = @bonusPerc,
                                FullName = @FullName,
                                ImagePath = @ImagePath
                                where ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@Gendor", gender);
            command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@HireDate", hireDate);
            command.Parameters.AddWithValue("@ExitDate", exitDate);
            command.Parameters.AddWithValue("@MonthlySalary", monthlySalary);
            command.Parameters.AddWithValue("@bonusPerc", bonusPerc);
            command.Parameters.AddWithValue("@FullName", FullName);

            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool DeleteEmployee(int ID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Employees 
                                where ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);
        }

        public static bool AddNewEmployee(string firstName, string lastName, string gender, DateTime dateOfBirth, int DepartmentID, int CountryID, DateTime hireDate, DateTime exitDate, decimal monthlySalary, double bonusPerc, string FullName, string ImagePath)
        {
            bool isAdded = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"insert into Employees (FirstName, LastName, Gendor, DateOfBirth, DepartmentID, CountryID, HireDate, ExitDate, MonthlySalary, BonusPerc, FullName, ImagePath)
                             values (@firstName, @lastName, @gender, @dateOfBirth, @DepartmentID,@CountryID, @hireDate,@exitDate, @monthlySalary, @bonusPerc, @FullName, @ImagePath);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@gender", gender);
            command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@hireDate", hireDate);
            command.Parameters.AddWithValue("@monthlySalary", monthlySalary);
            command.Parameters.AddWithValue("@bonusPerc", bonusPerc);
            command.Parameters.AddWithValue("@FullName", FullName);
            

            if(exitDate.Day == DateTime.Now.Day)
            {
                command.Parameters.AddWithValue("@exitDate", System.DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@exitDate", exitDate);

            }

            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out _))
                {
                    isAdded = true; 
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isAdded = false;
            }

            finally
            {
                connection.Close();
            }


            return isAdded;
        }
    }
}
