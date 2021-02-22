using Microsoft.Data.SqlClient;
using System;
using System.Linq;

namespace AddMinion
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=.;Integrated Security=true;Database=MinionsDB";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string[] input = Console.ReadLine().Split().Skip(1).ToArray();
            Minion minion = new Minion(input[0], int.Parse(input[1]), input[2]);

            string inputVillain = Console.ReadLine().Split().Skip(1).ToArray()[0];
            

            sqlConnection.Open();
            using (sqlConnection)
            {

                SqlCommand sqlCommand = new SqlCommand(@"
                SELECT COUNT(*) FROM Towns
                WHERE Name = @Town", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Town", minion.TownName);
                int count = (int)sqlCommand.ExecuteScalar();
                //If Town isnt exist
                if (count == 0)
                {
                    sqlCommand = new SqlCommand(@"
                    INSERT INTO Towns VALUES(@Town, 1)", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Town", minion.TownName);
                    sqlCommand.ExecuteNonQuery();
                    Console.WriteLine($"Town {minion.TownName} was added to the database.");
                }

                sqlCommand = new SqlCommand(@"
                SELECT COUNT(*) FROM Villains
                WHERE Name = @Name", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Name", inputVillain);
                int countVillains = (int)sqlCommand.ExecuteScalar();
                //If Villains isnt exist
                if (countVillains == 0)
                {
                    sqlCommand = new SqlCommand(@"
                    INSERT INTO Villains VALUES(@Name, 6)", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Name", inputVillain);
                    sqlCommand.ExecuteNonQuery();
                    Console.WriteLine($"Villain {inputVillain} was added to the database.");
                }

                sqlCommand = new SqlCommand(@"
                SELECT Id FROM Towns
                WHERE Name = @Town", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Town", minion.TownName);
                int IdTown = (int)sqlCommand.ExecuteScalar();

                sqlCommand = new SqlCommand(@"
                SELECT Id FROM Villains
                WHERE Name = @Name", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Name", inputVillain);
                int IdVillain = (int)sqlCommand.ExecuteScalar();

                sqlCommand = new SqlCommand(@"
                INSERT INTO Minions VALUES(@Name,@Age," + IdTown + ")", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Name", minion.Name);
                sqlCommand.Parameters.AddWithValue("@Age", minion.Age);
                sqlCommand.ExecuteNonQuery();

                sqlCommand = new SqlCommand(@"
                SELECT Id FROM Minions
                WHERE Name = @Name AND Age = @Age", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Name", minion.Name);
                sqlCommand.Parameters.AddWithValue("@Age", minion.Age);
                int IdMinion = (int)sqlCommand.ExecuteScalar();

                sqlCommand = new SqlCommand($"INSERT INTO MinionsVillains VALUES({IdMinion},{IdVillain})", sqlConnection);
                if (sqlCommand.ExecuteNonQuery() != 0)
                {
                    Console.WriteLine($"Successfully added {minion.Name} to be minion of {inputVillain}.");
                }

            }
        }
    }
}
