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
    public class CompetitionDAL
    {
        private IConfiguration Configuration { get; }
        private SqlConnection conn;

        //Constructor
        public CompetitionDAL()
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

        public List<Competition> GetAllCompetitions()
        {

            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            //Specify the SELECT SQL statement
            cmd.CommandText = @"SELECT * FROM Competition ORDER BY CompetitionID";
            //Open a database connection
            conn.Open();
            //Execute the SELECT SQL through a DataReader
            SqlDataReader reader = cmd.ExecuteReader();
            //Read all records until the end, save data into a staff list
            List<Competition> competitionList = new List<Competition>();
            while (reader.Read())
            {
                competitionList.Add(
                new Competition
                {
                    CompetitionID = reader.GetInt32(0), //0: 1st column and + 1 per column 
                    AreaInterestID = reader.GetInt32(1),
                    CompetitionName = reader.GetString(2),
                    StartDate = reader.GetDateTime(3),
                    EndDate = reader.GetDateTime(4),
                    ResultReleasedDate = reader.GetDateTime(5),
                }
                );
            }
            //Close DataReader
            reader.Close();
            //Close the database connection
            conn.Close();
            return competitionList;
        }

        public int Add(Competition competitions)
        {
            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            //Specify an INSERT SQL statement which will
            //return the auto-generated StaffID after insertion
            cmd.CommandText = @"INSERT INTO Competition (CompetitionName,StartDate,EndDate,ResultReleasedDate)
                                OUTPUT INSERTED.AreaInterestID
                                VALUES(@competitionName,@startDate,@endDate,@resultReleasedDate)";
            //Define the parameters used in SQL statement, value for each parameter
            //is retrieved from respective class's property.
            cmd.Parameters.AddWithValue("@competitionName", competitions.CompetitionName);
            cmd.Parameters.AddWithValue("@startDate", competitions.StartDate);
            cmd.Parameters.AddWithValue("@endDate", competitions.EndDate);
            cmd.Parameters.AddWithValue("@resultReleasedDate", competitions.ResultReleasedDate);
            //A connection to database must be opened before any operations made.
            conn.Open();
            //ExecuteScalar is used to retrieve the auto-generated
            //StaffID after executing the INSERT SQL statement
            competitions.CompetitionID = (int)cmd.ExecuteScalar();
            //A connection should be closed after operations.
            conn.Close();
            //Return id when no error occurs.
            return competitions.CompetitionID;
        }

        // For DeleteArea if ID is not null!
        public bool checkIfCompetitionExists(int theId)
        {

            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            //Specify the SELECT SQL statement
            cmd.CommandText = @"SELECT * FROM Competition ORDER BY CompetitionID";
            //Open a database connection
            conn.Open();
            //Execute the SELECT SQL through a DataReader
            SqlDataReader reader = cmd.ExecuteReader();
            //Read all records until the end, save data into a staff list
            List<Competition> competitionList = new List<Competition>();
            while (reader.Read())
            {
                competitionList.Add(
                new Competition
                {
                    CompetitionID = reader.GetInt32(0), //0: 1st column and + 1 per column 
                    AreaInterestID = reader.GetInt32(1),
                    CompetitionName = reader.GetString(2),
                }
                );
            }
            //Close DataReader
            reader.Close();
            //Close the database connection
            conn.Close();

            bool itExists = false;
            foreach (Competition competitions in competitionList)
            {
                if (competitions.AreaInterestID == theId)
                {
                    itExists = true;
                }
            }

            return itExists;
        }

        // For CreateCompetition itself!!
        public bool IsCompetitionNameExist(string name, int competitionID)
        {
            bool nameFound = false;
            //Create a SqlCommand object and specify the SQL statement
            //to get a areaInterest record with the name to be validated
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT CompetitionID FROM Competition
                                WHERE Name=@selectedName";
            cmd.Parameters.AddWithValue("@selectedName", name);
            //Open a database connection and execute the SQL statement
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            { //Records found
                while (reader.Read())
                {
                    if (reader.GetInt32(0) != competitionID)
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
