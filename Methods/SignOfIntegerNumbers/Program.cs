using System;

namespace SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());
            PrintSignOfInt(numberN);
        }

        static void PrintSignOfInt(int numberN)
        {
            if (numberN < 0)
            {
                Console.WriteLine($"The number {numberN} is negative.");
            }
            else if (numberN > 0)
            {
                Console.WriteLine($"The number {numberN} is positive.");
            }
            else
            {
                Console.WriteLine($"The number {numberN} is zero.");
            }
        }
    }
}
