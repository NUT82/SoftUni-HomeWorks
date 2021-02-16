using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> peopleSortedSet = new SortedSet<Person>();
            HashSet<Person> peopleHashSet = new HashSet<Person>();

            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] currRow = Console.ReadLine().Split();
                string currName = currRow[0];
                int currAge = int.Parse(currRow[1]);
                Person person = new Person(currName, currAge);
                peopleSortedSet.Add(person);
                peopleHashSet.Add(person);
            }

            Console.WriteLine(peopleSortedSet.Count);
            Console.WriteLine(peopleHashSet.Count);
        }
    }
}
