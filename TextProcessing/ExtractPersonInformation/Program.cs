using System;
using System.Text.RegularExpressions;

namespace ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePattern = @"@{1}(\w+)\|{1}";
            Regex nameRegex = new Regex(namePattern);
            string agePattern = @"#{1}(\d+)\*{1}";
            Regex ageRegex = new Regex(agePattern);

            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string line = Console.ReadLine();
                Person person = new Person(nameRegex.Match(line).Groups[1].Value, int.Parse(ageRegex.Match(line).Groups[1].Value));
                Console.WriteLine($"{person.Name} is {person.Age} years old.");
            }

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
