using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                PrintLine(number);
            }

        }

        private static void PrintLine(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
    }
}
