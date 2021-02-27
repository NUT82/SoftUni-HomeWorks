using System;
using System.Collections.Generic;
using System.Linq;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> countOfSugarCubes = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();
            while (command[0] != "Mort")
            {
                int value = int.Parse(command[1]);

                switch (command[0])
                {
                    case "Add":
                        countOfSugarCubes.Add(value);
                        break;
                    case "Remove":
                        countOfSugarCubes.Remove(value);
                        break;
                    case "Replace":
                        int replacement = int.Parse(command[2]);
                        int index = countOfSugarCubes.IndexOf(value);
                        countOfSugarCubes[index] = replacement;
                        break;
                    case "Collapse":
                        countOfSugarCubes.RemoveAll(e => e < value);
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", countOfSugarCubes));
        }
    }
}
