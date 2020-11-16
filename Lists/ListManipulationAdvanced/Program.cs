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
            bool isChanged = false;
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] currCommand = command.Split().ToArray();
                switch (currCommand[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(currCommand[1]));
                        isChanged = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(currCommand[1]));
                        isChanged = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(currCommand[1]));
                        isChanged = true;
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(currCommand[2]), int.Parse(currCommand[1]));
                        isChanged = true;
                        break;
                    case "Contains":
                        string answer = (numbers.Contains(int.Parse(currCommand[1])) ? answer = "Yes" : "No such number");
                        Console.WriteLine(answer);
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        switch (currCommand[1])
                        {
                            case "<":
                                Console.WriteLine(string.Join(" ", numbers.Where(x => x < int.Parse(currCommand[2]))));
                                break;
                            case ">":
                                Console.WriteLine(string.Join(" ", numbers.Where(x => x > int.Parse(currCommand[2]))));
                                break;
                            case ">=":
                                Console.WriteLine(string.Join(" ", numbers.Where(x => x >= int.Parse(currCommand[2]))));
                                break;
                            case "<=":
                                Console.WriteLine(string.Join(" ", numbers.Where(x => x <= int.Parse(currCommand[2]))));
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

        }
    }
}
