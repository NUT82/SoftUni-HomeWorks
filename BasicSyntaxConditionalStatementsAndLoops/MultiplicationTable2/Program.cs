using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int startMultiplier = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{number} X {startMultiplier} = {number * startMultiplier}");
                startMultiplier++;
            } while (startMultiplier <= 10);
        }
    }
}

