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
                    CriteriaID = reader.GetInt32(0),
                    CompetitorID = reader.GetInt32(1),
                    CompetitionID = reader.GetInt32(2),
                    Score = reader.GetInt32(3)



                }
                );
            }
            //Close DataReader
            reader.Close();
            //Close the database connection
            conn.Close();
            return scoreList;
        }

        public int Add(CompetitionScore score)
        {
            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            //Specify an INSERT SQL statement which will
            //return the auto-generated StaffID after insertion
            cmd.CommandText = @"INSERT INTO CompetitionScore (CriteriaID, CompetitorID, CompetitionID, Score)
            
            VALUES(@criteriaid, @competitiorid, @compid, @score)";
            //Define the parameters used in SQL statement, value for each parameter
            //is retrieved from respective class's property.
            cmd.Parameters.AddWithValue("@criteriaid", score.CriteriaID);
            cmd.Parameters.AddWithValue("@competitiorid", score.CompetitorID);
            cmd.Parameters.AddWithValue("@compid", score.CompetitionID);
            cmd.Parameters.AddWithValue("@score", score.Score);

            //A connection to database must be opened before any operations made.
            conn.Open();
            //ExecuteScalar is used to retrieve the auto-generated
            //CriteriaID after executing the INSERT SQL statement
            
            //A connection should be closed after operations.
            conn.Close();
            //Return id when no error occurs.
            return score.CriteriaID;
        }
    }

    
}
