using System;

namespace fourthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int cats = int.Parse(Console.ReadLine());
            double sumAllFood = 0;
            int firstGroup = 0;
            int secondGroup = 0;
            int thirdGroup = 0;

            for (int i = 0; i < cats; i++)
            {
                double gramsOfFood = double.Parse(Console.ReadLine());
                if (gramsOfFood < 200)
                {
                    firstGroup++;
                }
                else if (gramsOfFood < 300)
                {
                    secondGroup++;
                }
                else if (gramsOfFood <=400)
                {
                    thirdGroup++;
                }
                sumAllFood += gramsOfFood;
            }

            Console.WriteLine($"Group 1: {firstGroup} cats.");
            Console.WriteLine($"Group 2: {secondGroup} cats.");
            Console.WriteLine($"Group 3: {thirdGroup} cats.");
            Console.WriteLine($"Price for food per day: {sumAllFood / 1000 * 12.45:F2} lv.");
        }
    }
}
