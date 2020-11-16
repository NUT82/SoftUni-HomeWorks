using System;
using System.Collections.Generic;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> names = new List<string>(numberOfCommands);

            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();
                string currName = command.Split()[0];
                if (command.Contains("not going!"))
                {
                    if (names.Contains(currName))
                    {
                        names.Remove(currName);
                    }
                    else
                    {
                        Console.WriteLine($"{currName} is not in the list!");
                    }
                }
                else
                {
                    if (names.Contains(currName))
                    {
                        Console.WriteLine($"{currName} is already in the list!");
                    }
                    else
                    {
                        names.Add(currName);
                    }
                }

            }

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
