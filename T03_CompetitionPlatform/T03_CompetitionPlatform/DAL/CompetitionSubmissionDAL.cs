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
    // <!-- Edited this 27/6/2021 8pm Delete Judges Function-->
    public class CompetitionSubmissionDAL
    {
        private IConfiguration Configuration { get; }
        private SqlConnection conn;

        //Constructor
        public CompetitionSubmissionDAL()
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

        public List<CompetitionSubmission> GetAllSubmissions()
        {
            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            //Specify the SELECT SQL statement
            cmd.CommandText = @"SELECT * FROM CompetitionSubmission ORDER BY CompetitionID";
            //Open a database connection
            conn.Open();
            //Execute the SELECT SQL through a DataReader
            SqlDataReader reader = cmd.ExecuteReader();
            //Read all records until the end, save data into a staff list
            List<CompetitionSubmission> competitionSubmissionList = new List<CompetitionSubmission>();
            while (reader.Read())
            {
                competitionSubmissionList.Add(
                new CompetitionSubmission
                {
                    CompetitionID = reader.GetInt32(0),
                    CompetitorID = reader.GetInt32(1),
                    FileSubmitted = !reader.IsDBNull(2) ?
                    reader.GetString(2) : null,
                    DateTimeFileUpload = !reader.IsDBNull(3) ?
                    reader.GetDateTime(3) : (DateTime?)null,
                    Appeal = !reader.IsDBNull(4) ?
                    reader.GetString(4) : null,
                    VoteCount = reader.GetInt32(5),
                    Ranking = !reader.IsDBNull(6) ?
                    reader.GetInt32(6) : (int?)null
                }
                );
            }
            //Close DataReader
            reader.Close();
            //Close the database connection
            conn.Close();

            return competitionSubmissionList;
        }

        public CompetitionSubmission GetDetails(int competitionID)
        {
            CompetitionSubmission competitionSubmission = new CompetitionSubmission();
            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            //Specify the SELECT SQL statement that
            //retrieves all attributes of a staff record.
            cmd.CommandText = @"SELECT * FROM CompetitionSubmission
                    WHERE CompetitionID = @selectedCompetitionID";
            //Define the parameter used in SQL statement, value for the
            //parameter is retrieved from the method parameter “areainterestId”.
            cmd.Parameters.AddWithValue("@selectedCompetitionID", competitionID);
            //Open a database connection
            conn.Open();
            //Execute SELCT SQL through a DataReader
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                //Read the record from database
                while (reader.Read())
                {
                    // Fill staff object with values from the data reader
                    competitionSubmission.CompetitionID = competitionID;
                    competitionSubmission.CompetitorID = reader.GetInt32(1);
                    // (char) 0 - ASCII Code 0 - null value
                }
            }
            //Close data reader
            reader.Close();
            //Close database connection
            conn.Close();
            return competitionSubmission;
        }

        public int AddVote(int id, int compID)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"UPDATE CompetitionSubmission SET VoteCount = (VoteCount + 1) where (CompetitionID=@selcompID and CompetitorID=@selID)";
            cmd.Parameters.AddWithValue("@selcompID", compID);
            cmd.Parameters.AddWithValue("@selID", id);
            conn.Open();
            //ExecuteNonQuery is used for UPDATE and DELETE
            int count = cmd.ExecuteNonQuery();
            //Close the database connection
            conn.Close();
            return count;
        }

        public bool checkIfCompetitorSubmissionExists(int theId)
        {

            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            //Specify the SELECT SQL statement
            cmd.CommandText = @"SELECT * FROM CompetitionSubmission ORDER BY CompetitionID";
            //Open a database connection
            conn.Open();
            //Execute the SELECT SQL through a DataReader
            SqlDataReader reader = cmd.ExecuteReader();
            //Read all records until the end, save data into a staff list
            List<CompetitionSubmission> competitionList = new List<CompetitionSubmission>();
            while (reader.Read())
            {
                competitionList.Add(
                new CompetitionSubmission
                {
                    CompetitionID = reader.GetInt32(0), //0: 1st column and + 1 per column 
                    CompetitorID = reader.GetInt32(1),
                }
                );
            }
            //Close DataReader
            reader.Close();
            //Close the database connection
            conn.Close();

            bool itExists = false;

            foreach (CompetitionSubmission competitions in competitionList)
            {
                if (competitions.CompetitionID == theId)
                {
                    if (competitions.CompetitorID != null)
                    {
                        itExists = true;
                    }
                }
            }

            return itExists;
        }
    }
}
