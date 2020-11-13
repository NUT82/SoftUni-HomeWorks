using System;

namespace EasterGuests
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            int neededEasterBread = (int)Math.Ceiling(guests / 3.0);
            double easterBreadsPrice = neededEasterBread * 4;
            int neededEggs = guests * 2;
            double egsPrice = neededEggs * 0.45;
            double neededBudget = easterBreadsPrice + egsPrice;

            if (budget >= neededBudget)
            {
                Console.WriteLine($"Lyubo bought {neededEasterBread} Easter bread and {neededEggs} eggs.");
                Console.WriteLine($"He has {budget - neededBudget:F2} lv. left.");
            }
            else
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {neededBudget - budget:F2} lv. more.");
            }
        }
    }
}
