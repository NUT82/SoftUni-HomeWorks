using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> parts = Console.ReadLine().Split("|").ToList();

            string command = Console.ReadLine();
            while (command != "Done")
            {
                string[] splitCommand = command.Split();
                string currCommand = splitCommand[0] + " " + splitCommand[1];

                switch (currCommand)
                {
                    case "Move Left":
                        int index = int.Parse(splitCommand[2]);
                        if (isValid(index, parts) && isValid(index - 1, parts))
                        {
                            string temp = parts[index];
                            parts[index] = parts[index - 1];
                            parts[index - 1] = temp;
                        }
                        break;
                    case "Move Right":
                        index = int.Parse(splitCommand[2]);
                        if (isValid(index, parts) && isValid(index + 1, parts))
                        {
                            string temp = parts[index];
                            parts[index] = parts[index + 1];
                            parts[index + 1] = temp;
                        }
                        break;
                    case "Check Even":
                        for (int i = 0; i < parts.Count; i += 2)
                        {
                            Console.Write(parts[i] + " ");
                        }
                        Console.WriteLine();
                        break;
                    case "Check Odd":
                        for (int i = 1; i < parts.Count; i += 2)
                        {
                            Console.Write(parts[i] + " ");
                        }
                        Console.WriteLine();
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"You crafted {string.Join("", parts)}!");
        }

        private static bool isValid(int index, List<string> parts)
        {
            if (index >= 0 && index < parts.Count)
            {
                return true;
            }

            return false;
        }
    }
}
