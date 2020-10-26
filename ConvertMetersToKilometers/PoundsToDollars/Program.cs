using System;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that converts British pounds to US dollars formatted to 3th decimal point.
            const decimal britishPoundToDollars = 1.31M;
            decimal britishPounds = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{britishPounds * britishPoundToDollars:F3}");
        }
    }
}
