using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] currCommand = input.Split();
                switch (currCommand[0])
                {
                    case "Add":
                        integers.Add(int.Parse(currCommand[1]));
                        break;
                    case "Insert":
                        int index = int.Parse(currCommand[2]);
                        if (index < 0 || index >= integers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        integers.Insert(index, int.Parse(currCommand[1]));
                        break;
                    case "Remove":
                        index = int.Parse(currCommand[1]);
                        if (index < 0 || index >= integers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        integers.RemoveAt(index);
                        break;
                    case "Shift":
                        for (int i = 0; i < int.Parse(currCommand[2]); i++)
                        {
                            MoveListLeftOrRight(integers, currCommand[1]);
                        }
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", integers));
        }

        private static void MoveListLeftOrRight(List<int> integers, string leftOrRight)
        {
            if (leftOrRight == "left")
            {
                int firstElement = integers[0];
                integers.RemoveAt(0);
                integers.Add(firstElement);
            }
            else
            {
                int lastElement = integers[integers.Count - 1];
                integers.RemoveAt(integers.Count - 1);
                integers.Insert(0, lastElement);
            }
        }
    }
}
