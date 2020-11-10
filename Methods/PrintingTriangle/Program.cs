using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumbers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= maxNumbers; i++)
            {
                PrintLineFromOneToNum(i);
            }
            for (int i = maxNumbers - 1; i >= 1; i--)
            {
                PrintLineFromOneToNum(i);
            }

        }

        static void PrintLineFromOneToNum(int maxNumber)
        {
            for (int i = 1; i <= maxNumber; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
