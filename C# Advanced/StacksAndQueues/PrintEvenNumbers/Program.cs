using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> numbersQueue = new Queue<int>(numbers);
            List<int> result = new List<int>(numbersQueue.Count);
            while (numbersQueue.Count > 0)
            {
                if (numbersQueue.Peek() % 2 == 0)
                {
                    result.Add(numbersQueue.Dequeue());
                }
                else
                {
                    numbersQueue.Dequeue();
                }
            }
            Console.WriteLine(String.Join(", ", result));
        }
    }
}
