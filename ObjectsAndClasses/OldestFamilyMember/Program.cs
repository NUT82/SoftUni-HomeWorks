using System;
using System.Collections.Generic;
using System.Linq;

namespace OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeoples = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < numberOfPeoples; i++)
            {
                string[] line = Console.ReadLine().Split();
                Person person = new Person(line[0], int.Parse(line[1]));
                family.AddMember(person);
            }

            Console.WriteLine(family.GetOldestMember().ToString());
        }
    }

    public class Family
    {
        public List<Person> Peoples { get; set; }

        public Family()
        {
            List<Person> peoples = new List<Person>();
            Peoples = peoples;
        }

        public void AddMember(Person person)
        {
            Peoples.Add(person);
        }

        public Person GetOldestMember()
        {
            return Peoples.OrderByDescending(x => x.Age).FirstOrDefault();
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

        public Person()
        {

        }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
}
