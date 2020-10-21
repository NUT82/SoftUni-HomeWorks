using System;

namespace SuitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double allSuitcaseVolume = 0;
            int countOfSuitcases = 0;
            bool isEnd = true;

            double capacityOfPlane = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (input != "End")
            {
                double suitcaseVolume = double.Parse(input);
                allSuitcaseVolume += suitcaseVolume;
                if (allSuitcaseVolume >= capacityOfPlane)
                {
                    isEnd = false;
                    break;
                }
                countOfSuitcases++;
                input = Console.ReadLine();
            }
            if (isEnd)
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            else
            {
                Console.WriteLine("No more space!");
            }
            Console.WriteLine($"Statistic: {countOfSuitcases} suitcases loaded.");
        }
    }
}
