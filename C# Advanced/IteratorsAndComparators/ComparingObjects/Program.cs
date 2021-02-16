using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string[] input = Console.ReadLine().Split();
            while (input[0] != "END")
            {
                string name = input[0];
                int age = int.Parse(input[1]);
                string town = input[2];
                Person person = new Person(name, age, town);
                people.Add(person);

                input = Console.ReadLine().Split();
            }

            int number = int.Parse(Console.ReadLine());
            int count = 0;
            foreach (var person in people)
            {
                if (person.Equals(people[number - 1]))
                {
                    count++;
                }
            }

            if (count <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{count} {people.Count - count} {people.Count}");
            }
        }
    }
}
