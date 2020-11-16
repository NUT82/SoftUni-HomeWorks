using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Delete":
                        integers.RemoveAll(x => x == int.Parse(command[1]));
                        break;
                    case "Insert":
                        integers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", integers));
        }
    }
}
