using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> forceBook = new SortedDictionary<string, List<string>>();
            string command = Console.ReadLine();
            while (command != "Lumpawaroo")
            {
                string forceUser = "";
                string forceSide = "";
                string currCommand = "";
                if (command.Contains("->"))
                {
                    forceUser = command.Split(" -> ")[0];
                    forceSide = command.Split(" -> ")[1];
                    currCommand = "->";
                }
                else
                {
                    forceSide = command.Split(" | ")[0];
                    forceUser = command.Split(" | ")[1];
                    currCommand = "|";
                }
                switch (currCommand)
                {
                    case "|":
                        if (forceBook.ContainsKey(forceSide))
                        {
                            if (forceBook[forceSide].Contains(forceUser) == false)
                            {
                                forceBook[forceSide].Add(forceUser);
                            }
                        }
                        else
                        {
                            bool isFound = false;
                            foreach (var item in forceBook)
                            {
                                if (item.Value.Contains(forceUser))
                                {
                                    isFound = true;
                                    break;
                                }
                            }
                            if (isFound == false)
                            {
                                forceBook.Add(forceSide, new List<string>() { forceUser });
                            }
                        }
                        break;
                    case "->":
                        foreach (var item in forceBook)
                        {
                            if (item.Value.Contains(forceUser))
                            {
                                string currForceSide = item.Key;
                                forceBook[currForceSide].Remove(forceUser);
                                break;
                            }
                        }

                        if (forceBook.ContainsKey(forceSide))
                        {
                            forceBook[forceSide].Add(forceUser);
                        }
                        else
                        {
                            forceBook.Add(forceSide, new List<string>() { forceUser });
                        }

                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                        break;
                }

                command = Console.ReadLine();
            }

            foreach (var item in forceBook.OrderByDescending(c => c.Value.Count).Where(c => c.Value.Count != 0))
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                foreach (var user in item.Value.OrderBy(n => n))
                {
                    Console.WriteLine(string.Join(Environment.NewLine, $"! {user}"));
                }
            }
        }
    }
}
