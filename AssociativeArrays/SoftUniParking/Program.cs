using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingLot = new Dictionary<string, string>();
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();
                string username = command[1];
                switch (command[0])
                {
                    case "register":
                        string licensePlateNumber = command[2];
                        if (parkingLot.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {parkingLot[username]}");
                        }
                        else
                        {
                            parkingLot.Add(username, licensePlateNumber);
                            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                        }
                        break;
                    case "unregister":
                        if (parkingLot.ContainsKey(username))
                        {
                            parkingLot.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        break;
                    default:
                        break;
                }
            }

            foreach (var item in parkingLot)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
