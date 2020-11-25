using System;
using System.Collections.Generic;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> companyUsers = new SortedDictionary<string, List<string>>();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] currCommand = command.Split(" -> ");
                string companyName = currCommand[0];
                string employeeId = currCommand[1];
                if (companyUsers.ContainsKey(companyName))
                {
                    if (companyUsers[companyName].Contains(employeeId) == false)
                    {
                        companyUsers[companyName].Add(employeeId);
                    }
                }
                else
                {
                    companyUsers.Add(companyName, new List<string>() { employeeId });
                }

                command = Console.ReadLine();
            }

            foreach (var company in companyUsers)
            {
                Console.WriteLine(company.Key);
                foreach (var user in company.Value)
                {
                    Console.WriteLine(string.Join(Environment.NewLine, $"-- {user}"));
                }
            }
        }
    }
}
