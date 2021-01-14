using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> inputStack = new Stack<string>(input.Reverse());
            while (inputStack.Count > 1)
            {
                int leftNumber = int.Parse(inputStack.Pop());
                string sign = inputStack.Pop();
                int rightNumber = int.Parse(inputStack.Pop());
                if (sign == "+")
                {
                    inputStack.Push((leftNumber + rightNumber).ToString());
                }
                else
                {
                    inputStack.Push((leftNumber - rightNumber).ToString());
                }
            }

            Console.WriteLine(inputStack.Pop());
        }
    }
}
