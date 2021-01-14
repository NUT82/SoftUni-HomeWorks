using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbersStack = new Stack<int>(numbers);
            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                if (command.Contains("add"))
                {
                    numbersStack.Push(int.Parse(command.Split()[1]));
                    numbersStack.Push(int.Parse(command.Split()[2]));
                }
                else if (command.Contains("remove"))
                {
                    int numsToRemove = int.Parse(command.Split()[1]);
                    if (numsToRemove <= numbersStack.Count)
                    {
                        for (int i = 0; i < numsToRemove; i++)
                        {
                            numbersStack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Sum: " + numbersStack.Sum());
        }
    }
}
