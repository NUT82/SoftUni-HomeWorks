using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededXP = double.Parse(Console.ReadLine()); //0.00 ... 400000.00
            int battlesCount = int.Parse(Console.ReadLine()); // 0 ... 500
            int battles = 0;
            bool win = false;

            for (int i = 1; i <= battlesCount; i++)
            {
                double currXP = double.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    currXP += currXP * 0.15;
                }

                if (i % 5 == 0)
                {
                    currXP -= currXP * 0.1;
                }

                if (i % 15 == 0)
                {
                    currXP += currXP * 0.05;
                }

                neededXP -= currXP;
                if (neededXP <= 0)
                {
                    battles = i;
                    win = true;
                    break;
                }
            }

            if (win)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {battles} battles.");
            }
            else
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {neededXP:F2} more needed.");
            }

        }
    }
}
