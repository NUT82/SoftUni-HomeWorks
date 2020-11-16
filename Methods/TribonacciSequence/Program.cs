using System;

namespace TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(" ", GetNumbers(number)));
        }

        private static int[] GetNumbers(int i)
        {
            int[] numbers = new int[i];
            
            for (int j = 0; j < i; j++)
            {
                if (j == 0 || j == 1)
                {
                    numbers[j] = 1;
                }
                else if (j == 2)
                {
                    numbers[j] = 2;
                }
                else
                {
                    numbers[j] = numbers[j - 1] + numbers[j - 2] + numbers[j - 3];
                }
            }

            return numbers;
        }
    }
}
