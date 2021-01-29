using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Func<int, int>> mathematicalOperation = new Dictionary<string, Func<int, int>>()
            {
                { "add", n => n + 1 },
                { "multiply", n => n * 2 },
                { "subtract", n => n - 1 }
            };
            
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "print")
                {
                    Action<int[]> Print = n => Console.WriteLine(string.Join(" ", n));
                    Print(input);
                }
                else
                {
                    Func<int, int> func = mathematicalOperation[command];
                    input = input.Select(func).ToArray();
                }
                
                command = Console.ReadLine();
            }
            
        }
    }
}
