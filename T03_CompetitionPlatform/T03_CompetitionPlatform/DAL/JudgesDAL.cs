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
    public class JudgesDAL
    {
        private IConfiguration Configuration { get; }
        private SqlConnection conn;

        //Constructor
        public JudgesDAL()
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

        public List<Judge> GetAllJudges()
        {

            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            //Specify the SELECT SQL statement
            cmd.CommandText = @"SELECT * FROM Judge ORDER BY JudgeID";
            //Open a database connection
            conn.Open();
            //Execute the SELECT SQL through a DataReader
            SqlDataReader reader = cmd.ExecuteReader();
            //Read all records until the end, save data into a staff list
            List<Judge> judgesList = new List<Judge>();
            while (reader.Read())
            {
                judgesList.Add(
                new Judge
                {
                    JudgeID = reader.GetInt32(0),  //0: 1st column and + 1 per column 
                    JudgeName = reader.GetString(1),
                    Salutation = reader.GetString(2),
                    AreaInterestID = reader.GetInt32(3),
                    EmailAddr = reader.GetString(4),
                    Password = reader.GetString(5),
                }
                );
            }
            //Close DataReader
            reader.Close();
            //Close the database connection
            conn.Close();
            return judgesList;
        }

        public bool checkIfJudgeExists(int judgeId)
        {

            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            //Specify the SELECT SQL statement
            cmd.CommandText = @"SELECT * FROM Judge ORDER BY JudgeID";
            //Open a database connection
            conn.Open();
            //Execute the SELECT SQL through a DataReader
            SqlDataReader reader = cmd.ExecuteReader();
            //Read all records until the end, save data into a staff list
            List<Judge> judgeList = new List<Judge>();
            while (reader.Read())
            {
                judgeList.Add(
                new Judge
                {
                    JudgeID = reader.GetInt32(0), //0: 1st column and + 1 per column 
                    AreaInterestID = reader.GetInt32(3),
                }
                );
            }
            //Close DataReader
            reader.Close();
            //Close the database connection
            conn.Close();

            bool itExists = false;
            foreach (Judge judges in judgeList)
            {
                if (judges.AreaInterestID == judgeId)
                {
                    itExists = true;
                }
            }

            return itExists;
        }
    }
}
