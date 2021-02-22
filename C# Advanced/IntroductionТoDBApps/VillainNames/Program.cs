using Microsoft.Data.SqlClient;
using System;

namespace VillainNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=.;Integrated Security=true;Database=MinionsDB";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            using (sqlConnection)
            {
                SqlCommand sqlCommand = new SqlCommand(@"
                SELECT v.Name, COUNT(*) AS count FROM Villains v
                JOIN MinionsVillains mv ON mv.VillainId = v.Id
                GROUP BY v.Name
                HAVING COUNT(*) >= 2
                ORDER BY count DESC", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                using (sqlDataReader)
                {
                    while (sqlDataReader.Read())
                    {
                        Console.WriteLine(sqlDataReader["Name"] + " - " + sqlDataReader["count"]);
                    }
                }
            }
        }
    }
}
