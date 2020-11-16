using System;

namespace sixthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int locationCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < locationCount; i++)
            {
                double avgGoldPerDay = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                double goldPerCurrDay = 0;
                for (int j = 0; j < days; j++)
                {
                    goldPerCurrDay += double.Parse(Console.ReadLine());
                }

                double avgGoldPerCurrDay = goldPerCurrDay / days;
                if (avgGoldPerCurrDay >= avgGoldPerDay)
                {
                    Console.WriteLine($"Good job! Average gold per day: {avgGoldPerCurrDay:F2}.");
                }
                else
                {
                    Console.WriteLine($"You need {avgGoldPerDay - avgGoldPerCurrDay:F2} gold.");
                }
            }
        }
    }
}
