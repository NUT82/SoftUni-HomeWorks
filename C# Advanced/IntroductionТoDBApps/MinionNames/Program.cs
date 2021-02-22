using Microsoft.Data.SqlClient;
using System;

namespace MinionNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=.;Integrated Security=true;Database=MinionsDB";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            int input = int.Parse(Console.ReadLine());

            sqlConnection.Open();
            using (sqlConnection)
            {
                
                SqlCommand sqlCommand = new SqlCommand(@"
                SELECT v.Name AS vName, m.Name AS mName, m.Age FROM Villains v
                LEFT JOIN MinionsVillains mv ON mv.VillainId = v.Id
                LEFT JOIN Minions m ON m.Id = mv.MinionId
                WHERE v.Id = @input", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@input", input);
                string vName = (string)sqlCommand.ExecuteScalar();


                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                
                using (sqlDataReader)
                {
                    if (sqlDataReader.HasRows)
                    {
                        int count = 0;
                        Console.WriteLine($"Villain: {vName}");
                        while (sqlDataReader.Read())
                        {
                            if (!sqlDataReader.IsDBNull(1))
                            {
                                count++;
                                Console.WriteLine($"{count}. {sqlDataReader["mName"]} {sqlDataReader["Age"]}");
                            }
                        }

                        if (count == 0)
                        {
                            Console.WriteLine("(no minions)");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"No villain with ID {input} exists in the database.");
                    }
                    
                }
            }
        }
    }
}
