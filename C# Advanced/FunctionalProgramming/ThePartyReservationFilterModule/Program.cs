using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            List<People> peoples = new List<People>();
            foreach (var item in input)
            {
                People people = new People(item);
                peoples.Add(people);
            }
            
            
            Func<string, string, string, bool> filtering = (people, criteria, filter) =>
            {
                switch (criteria)
                {
                    case "Starts with":
                        if (people.StartsWith(filter))
                        {
                            return true;
                        }
                        break;
                    case "Ends with":
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
                    case "Contains":
                        if (people.Contains(filter))
                        {
                            return true;
                        }
                        break;
                }
                return false;
            };
            

            string command = Console.ReadLine();
            while (command != "Print")
            {
                string[] splitCommand = command.Split(";");
                switch (splitCommand[0])
                {
                    case "Add filter":
                        peoples = peoples.Select(p =>
                        {
                            if (filtering(p.Name, splitCommand[1], splitCommand[2]))
                            {
                                p.IsDeleted = true;
                            }
                            return p;
                        }).ToList();
                        break;
                    case "Remove filter":
                        peoples = peoples.Select(p =>
                        {
                            if (filtering(p.Name, splitCommand[1], splitCommand[2]))
                            {
                                p.IsDeleted = false;
                            }
                            return p;
                        }).ToList();
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", peoples.Where(d => d.IsDeleted == false)));
        }

        class People
        {
            public string Name { get; set; }
            public bool IsDeleted { get; set; }
            public People(string name)
            {
                Name = name;
                IsDeleted = false;
            }

            public override string ToString()
            {
                return Name;
            }
        }
    }
}
