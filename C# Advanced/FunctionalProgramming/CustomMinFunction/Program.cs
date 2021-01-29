using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int, int, int> MinOfTwoNumbers = (x, y) =>
            {
                if (x < y)
                {
                    return x;
                }
                else
                {
                    return y;
                }
            };

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i + 1] = MinOfTwoNumbers(numbers[i], numbers[i + 1]);
            }

            Console.WriteLine(numbers[numbers.Length - 1]);
            
        }
    }
}
