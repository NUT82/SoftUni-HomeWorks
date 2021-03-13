using CollectionHierarchy.Contracts;
using CollectionHierarchy.Models;
using System;
using System.Collections.Generic;

namespace CollectionHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int number = int.Parse(Console.ReadLine());

            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();
            
            Console.WriteLine(string.Join(" ", addCollection.Add(input)));
            Console.WriteLine(string.Join(" ", addRemoveCollection.Add(input)));
            Console.WriteLine(string.Join(" ", myList.Add(input)));

            for (int i = 0; i < number; i++)
            {
                Console.Write(addRemoveCollection.Remove() + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < number; i++)
            {
                Console.Write(myList.Remove() + " ");
            }
        }
    }
}
