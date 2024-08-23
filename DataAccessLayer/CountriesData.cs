﻿using CountriesDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CountriesData
    {

        public static DataTable GetAllCountriesData()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Countries";


            SqlCommand command = new SqlCommand(query, connection);


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

            return dt;
        }

        public static bool GetCountryInfoByID(int ID,ref string Name)
        {
            bool isFound = false; 


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Countries where ID = @ID";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    Name = (string)reader["Name"];
                }

                else
                    isFound = false;

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

            return isFound;
        }

        public static bool GetCountryInfoByName(ref int ID, string Name)
        {
            bool isFound = false;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Countries where Name= @Name";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    ID = (int)reader["ID"];
                }

                else
                    isFound = false;

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

            return isFound;
        }
    }
}
