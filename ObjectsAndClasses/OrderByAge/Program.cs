using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> peoples = new List<Person>();

            string line = Console.ReadLine();
            while (line != "End")
            {
                string[] currLine = line.Split();
                string name = currLine[0];
                string iD = currLine[1];
                int age = int.Parse(currLine[2]);

                Person person = new Person(name, iD, age);
                peoples.Add(person);

                line = Console.ReadLine();
            }

            foreach (Person person in peoples.OrderBy(x => x.Age))
            {
                Console.WriteLine(person.ToString());
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
