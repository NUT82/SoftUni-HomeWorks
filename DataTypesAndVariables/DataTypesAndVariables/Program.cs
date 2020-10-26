using System;

namespace ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given an integer that will be distance in meters. Write a program that converts meters to kilometers formatted to the second decimal point.
            int meters = int.Parse(Console.ReadLine());
            decimal kilometers = meters / 1000.0M;
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
