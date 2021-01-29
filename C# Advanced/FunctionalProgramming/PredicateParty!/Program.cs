using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> peoples = Console.ReadLine().Split().ToList();

            Func<string, string, string, bool> filtering = (people, criteria, filter) =>
            {
                switch (criteria)
                {
                    case "StartsWith":
                        if (people.StartsWith(filter))
                        {
                            return true;
                        }
                        break;
                    case "EndsWith":
                        if (people.EndsWith(filter))
                        {
                            return true;
                        }
                        break;
                    case "Length":
                        if (people.Length == int.Parse(filter))
                        {
                            return true;
                        }
                        break;
                }
                return false;
            };

            string command = Console.ReadLine();
            while (command != "Party!")
            {
                string[] splitCommand = command.Split();
                switch (splitCommand[0])
                {
                    case "Remove":
                        peoples = peoples.Where(p => !filtering(p, splitCommand[1], splitCommand[2])).ToList();
                        break;
                    case "Double":
                        List<string> peoplesToAdd = peoples.Where(p => filtering(p, splitCommand[1], splitCommand[2])).ToList();
                        foreach (var people in peoplesToAdd)
                        {
                            peoples.Insert(peoples.IndexOf(people), people);
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }

            if (peoples.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.Write(String.Join(", ", peoples));
                Console.WriteLine(" are going to the party!");
            }
        }
    }
}
