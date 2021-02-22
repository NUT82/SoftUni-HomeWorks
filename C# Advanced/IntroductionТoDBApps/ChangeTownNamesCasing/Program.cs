using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeTownNamesCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=.;Integrated Security=true;Database=MinionsDB";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string country = Console.ReadLine();

            sqlConnection.Open();
            using (sqlConnection)
            {
                SqlCommand sqlCommand = new SqlCommand(@"
                SELECT Id FROM Countries
                WHERE Name = @Town", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Town", country);
                try
                {
                    int IdTown = (int)sqlCommand.ExecuteScalar();
                    sqlCommand = new SqlCommand($"SELECT Id, Name FROM Towns WHERE CountryCode = {IdTown}", sqlConnection);
                    Dictionary<int, string> towns = new Dictionary<int, string>();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    using (sqlDataReader)
                    {
                        if (!sqlDataReader.HasRows)
                        {
                            throw new Exception();
                        }
                        
                        while (sqlDataReader.Read())
                        {
                            towns.Add((int)sqlDataReader["Id"], ((string)sqlDataReader["Name"]).ToUpper());
                        }
                    }
                    foreach (var item in towns)
                    {
                        sqlCommand = new SqlCommand($"UPDATE Towns SET Name = '{item.Value.ToUpper()}' WHERE Id = {item.Key}", sqlConnection);
                        sqlCommand.ExecuteNonQuery();
                    }
                    Console.WriteLine($"{towns.Count} town names were affected.");
                    Console.WriteLine($"[{string.Join(", ", towns.Values)}]");
                }
                catch (Exception)
                {
                    Console.WriteLine("No town names were affected.");
                }
                
                
            }
        }
    }
}
