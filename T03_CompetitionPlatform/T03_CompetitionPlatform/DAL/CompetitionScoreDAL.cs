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
    public class CompetitionScoreDAL
    {

        private IConfiguration Configuration { get; }
        private SqlConnection conn;
        //Constructor
        public CompetitionScoreDAL()
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

        public List<CompetitionScore> GetAllScore()
        {

            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            //Specify the SELECT SQL statement
            cmd.CommandText = @"SELECT * FROM CompetitionScore ORDER BY CompetitionID";
            //Open a database connection
            conn.Open();
            //Execute the SELECT SQL through a DataReader
            SqlDataReader reader = cmd.ExecuteReader();
            //Read all records until the end, save data into a staff list
            List<CompetitionScore> scoreList = new List<CompetitionScore>();
            while (reader.Read())
            {
                scoreList.Add(
                new CompetitionScore
                {
                    CriteriaID = reader.GetInt32(1),
                    CompetitorID = reader.GetInt32(2),
                    CompetitionID = reader.GetInt32(3),
                    Score = reader.GetInt32(4)



                }
                );
            }
            //Close DataReader
            reader.Close();
            //Close the database connection
            conn.Close();
            return scoreList;
        }
    }
}
