using System;

namespace ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write program to enter n numbers and calculate and print their exact sum (without rounding).
            int countOfNumbers = int.Parse(Console.ReadLine());
            decimal sum = 0M;
            for (int i = 0; i < countOfNumbers; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
