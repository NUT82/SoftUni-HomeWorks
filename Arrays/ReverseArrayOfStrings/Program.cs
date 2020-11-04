using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read an array of strings (space separated values), reverse it and print its elements:
            string[] arrayOfStrings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
            foreach (var item in arrayOfStrings)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
