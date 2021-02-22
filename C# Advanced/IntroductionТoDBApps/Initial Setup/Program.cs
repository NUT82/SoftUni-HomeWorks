using Microsoft.Data.SqlClient;
using System;

namespace Initial_Setup
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=.;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            using (sqlConnection)
            {
                SqlCommand sqlCommand = new SqlCommand("CREATE Database MinionsDB", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                string cmdText = @"
                USE MinionsDB

                CREATE TABLE Countries
                (
	                Id INT PRIMARY KEY IDENTITY,
	                Name VARCHAR(50)
                )

                CREATE TABLE Towns
                (
	                Id INT PRIMARY KEY IDENTITY,
	                Name VARCHAR(50),
	                CountryCode INT REFERENCES Countries(Id)
                )

                CREATE TABLE Minions
                (
	                Id INT PRIMARY KEY IDENTITY,
	                Name VARCHAR(50),
	                Age INT,
	                TownId INT REFERENCES Towns(Id)
                )

                CREATE TABLE EvilnessFactors
                (
	                Id INT PRIMARY KEY IDENTITY,
	                Name VARCHAR(50)
                )

                CREATE TABLE Villains
                (
	                Id INT PRIMARY KEY IDENTITY,
	                Name VARCHAR(50),
	                EvilnessFactorId INT REFERENCES EvilnessFactors(Id)
                )

                CREATE TABLE MinionsVillains
                (
	                MinionId INT REFERENCES Minions(Id),
	                VillainId INT REFERENCES Villains(Id),
                    PRIMARY KEY(MinionId, VillainId)
                )
                ";
                sqlCommand = new SqlCommand(cmdText, sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
