using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data.SqlClient;
using T03_CompetitionPlatform.Models;

namespace T03_CompetitionPlatform.DAL
{
    public class CompetitorDAL
    {
        private IConfiguration Configuration { get; }
        private SqlConnection conn;

        //Constructor
        public CompetitorDAL()
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

        public List<Competitor> GetAllCompetitors()
        {

            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            //Specify the SELECT SQL statement
            cmd.CommandText = @"SELECT * FROM Competitor ORDER BY CompetitorID";
            //Open a database connection
            conn.Open();
            //Execute the SELECT SQL through a DataReader
            SqlDataReader reader = cmd.ExecuteReader();
            //Read all records until the end, save data into a staff list
            List<Competitor> competitorList = new List<Competitor>();
            while (reader.Read())
            {
                competitorList.Add(
                new Competitor
                {
                    CompetitorID = reader.GetInt32(0),  //0: 1st column and + 1 per column 
                    CompetitorName = reader.GetString(1),
                    Salutation = reader.GetString(2),
                    EmailAddr = reader.GetString(3),
                    Password = reader.GetString(4),
                }
                );
            }
            //Close DataReader
            reader.Close();
            //Close the database connection
            conn.Close();
            return competitorList;
        }
    }
}
