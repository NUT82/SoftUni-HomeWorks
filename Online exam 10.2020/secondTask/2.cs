using System;

namespace ANDProcessors
{
    class Program
    {
        static void Main(string[] args)
        {
            int procesorsCount = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workinfDays = int.Parse(Console.ReadLine());

            int allWorkingTime = workers * workinfDays * 8;
            int procesorsProduct = allWorkingTime / 3;

            if (procesorsProduct >= procesorsCount)
            {
                Console.WriteLine($"Profit: -> {(procesorsProduct - procesorsCount) * 110.10:F2} BGN");
            }
            else
            {
                Console.WriteLine($"Losses: -> {(procesorsProduct - procesorsCount) * 110.10:F2} BGN");
            }
        }
    }
}
