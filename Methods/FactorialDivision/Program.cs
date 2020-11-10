using System;
using System.Numerics;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine($"{GetFactorial(numberOne) / GetFactorial(numberTwo):F2}");
        }

        private static double GetFactorial(int number)
        {
            double result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
