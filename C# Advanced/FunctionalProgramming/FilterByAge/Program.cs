using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> peoples = new List<People>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] line = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                People people = new People(line[0], int.Parse(line[1]));
                peoples.Add(people);
            }

            string filter = Console.ReadLine();
            int ageFilter = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<People, string, int, bool> Filter = FilterByAge;
            Action<People, string> Printer = PrintPeople;

            foreach (var people in peoples.Where(p => Filter(p, filter, ageFilter)))
            {
                Printer(people, format);
            }
            
        }

        public static bool FilterByAge(People people, string filter, int age)
        {
            switch (filter)
            {
                case "younger":
                    if (people.Age < age)
                    {
                        return true;
                    }
                    break;
                case "older":
                    if (people.Age >= age)
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }

        public static void PrintPeople(People people, string format)
        {
            switch (format)
            {
                case "name age":
                    Console.WriteLine($"{people.Name} - {people.Age}");
                    break;
                case "age name":
                    Console.WriteLine($"{people.Age} - {people.Name}");
                    break;
                case "name":
                    Console.WriteLine($"{people.Name}");
                    break;
                case "age":
                    Console.WriteLine($"{people.Age}");
                    break;
            }
        }



        public class People
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public People(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
    }
}
