using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] currCommand = command.Split().ToArray();
                switch (currCommand[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(currCommand[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(currCommand[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(currCommand[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(currCommand[2]), int.Parse(currCommand[1]));
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
