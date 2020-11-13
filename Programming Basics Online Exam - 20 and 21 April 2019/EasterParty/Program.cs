using System;

namespace EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            double priceForOneGuest = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double discount = 0;
            if (guests >= 10 && guests <= 15)
            {
                discount = 0.15;
            }
            else if (guests > 15 && guests <= 20)
            {
                discount = 0.2;
            }
            else if (guests > 20)
            {
                discount = 0.25;
            }

            double priceForAllGuests = guests * priceForOneGuest;
            priceForAllGuests -= priceForAllGuests * discount;
            double priceForCake = budget * 0.1;
            double neededBudget = priceForAllGuests + priceForCake;

            if (budget >= neededBudget)
            {
                Console.WriteLine($"It is party time! {budget - neededBudget:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {neededBudget - budget:F2} leva needed.");
            }
        }
    }
}
