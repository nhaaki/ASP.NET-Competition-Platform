﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data.SqlClient;
using T03_CompetitionPlatform.Models;

namespace T03_CompetitionPlatform.DAL
{
    public class AreaInterestDAL
    {
        private IConfiguration Configuration { get; }
        private SqlConnection conn;
        //Constructor
        public AreaInterestDAL()
        {
            //Read ConnectionString from appsettings.json file
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
            string strConn = Configuration.GetConnectionString("NPBookConnectionString");
            //Instantiate a SqlConnection object with the
            //Connection String read.
            conn = new SqlConnection(strConn);
        }

        public List<AreaInterest> GetAllArea()
        {

            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            //Specify the SELECT SQL statement
            cmd.CommandText = @"SELECT * FROM AreaInterest ORDER BY AreaInterestID";
            //Open a database connection
            conn.Open();
            //Execute the SELECT SQL through a DataReader
            SqlDataReader reader = cmd.ExecuteReader();
            //Read all records until the end, save data into a staff list
            List<AreaInterest> areaList = new List<AreaInterest>();
            while (reader.Read())
            {
                areaList.Add(
                new AreaInterest
                {
                    AreaInterestID = reader.GetInt32(0), //0: 1st column
                    Name = reader.GetString(1)
                }
                );
            }
            //Close DataReader
            reader.Close();
            //Close the database connection
            conn.Close();
            return areaList;
        }

        public int Add(AreaInterest area)
        {
            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            //Specify an INSERT SQL statement which will
            //return the auto-generated StaffID after insertion
            cmd.CommandText = @"INSERT INTO AreaInterest (Name)
                                OUTPUT INSERTED.AreaInterestID
                                VALUES(@name)";
            //Define the parameters used in SQL statement, value for each parameter
            //is retrieved from respective class's property.
            cmd.Parameters.AddWithValue("@name", area.Name);
            //A connection to database must be opened before any operations made.
            conn.Open();
            //ExecuteScalar is used to retrieve the auto-generated
            //StaffID after executing the INSERT SQL statement
            area.AreaInterestID = (int)cmd.ExecuteScalar();
            //A connection should be closed after operations.
            conn.Close();
            //Return id when no error occurs.
            return area.AreaInterestID;
        }

        public bool IsAreaNameExist(string name, int areaInterestID)
        {
            bool nameFound = false;
            //Create a SqlCommand object and specify the SQL statement
            //to get a areaInterest record with the name to be validated
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT AreaInterestID FROM AreaInterest
                                WHERE Name=@selectedName";
            cmd.Parameters.AddWithValue("@selectedName", name);
            //Open a database connection and execute the SQL statement
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            { //Records found
                while (reader.Read())
                {
                    if (reader.GetInt32(0) != areaInterestID)
                        //The name is used
                        nameFound = true;
                }
            }
            else
            { //No record
                nameFound = false; // The name given does not exist
            }
            reader.Close();
            conn.Close();

            return nameFound;
        }


    }
}
