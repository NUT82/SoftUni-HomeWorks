using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която прочита едно число n, след това прочита n на брой цели числа и принтира средно аритметичното на тяхната сума число, форматирано до втората цифра след десетични знак.
            int sum = 0;
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{(double)(sum) / number:F2}");
        }
    }
}
