using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();

            string command = Console.ReadLine();
            bool party = false;
            while (command != "END")
            {
                if (command == "PARTY")
                {
                    party = true;
                    command = Console.ReadLine();
                    continue;
                }

                if (party)
                {
                    if (guests.Contains(command))
                    {
                        guests.Remove(command);
                    }
                }
                else
                {
                    guests.Add(command);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(guests.Count);
            foreach (var item in guests.Where(g => char.IsDigit(g[0])))
            {
                Console.WriteLine(item);
            }
            foreach (var item in guests.Where(g => !char.IsDigit(g[0])))
            {
                Console.WriteLine(item);
            }
        }
    }
}
