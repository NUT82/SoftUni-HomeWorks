using System;

namespace FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            const double cardManGym = 42;
            const double cardManBoxing = 41;
            const double cardManYoga = 45;
            const double cardManZumba = 34;
            const double cardManDances = 51;
            const double cardManPilates = 39;
            const double cardWomanGym = 35;
            const double cardWomanBoxing = 37;
            const double cardWomanYoga = 42;
            const double cardWomanZumba = 31;
            const double cardWomanDances = 53;
            const double cardWomanPilates = 37;

            double discount = 0;
            double needMoney = 0;

            double moneyWeHave = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            if (age <= 19)
            {
                discount = 0.2;
            }
            string sport = Console.ReadLine();

            if (sex == "m")
            {
                switch (sport)
                {
                    case "Gym":
                        needMoney = cardManGym;
                        break;
                    case "Boxing":
                        needMoney = cardManBoxing;
                        break;
                    case "Yoga":
                        needMoney = cardManYoga;
                        break;
                    case "Zumba":
                        needMoney = cardManZumba;
                        break;
                    case "Dances":
                        needMoney = cardManDances;
                        break;
                    case "Pilates":
                        needMoney = cardManPilates;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (sport)
                {
                    case "Gym":
                        needMoney = cardWomanGym;
                        break;
                    case "Boxing":
                        needMoney = cardWomanBoxing;
                        break;
                    case "Yoga":
                        needMoney = cardWomanYoga;
                        break;
                    case "Zumba":
                        needMoney = cardWomanZumba;
                        break;
                    case "Dances":
                        needMoney = cardWomanDances;
                        break;
                    case "Pilates":
                        needMoney = cardWomanPilates;
                        break;
                    default:
                        break;
                }
            }
            needMoney -= needMoney * discount;
            if (moneyWeHave >= needMoney)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${needMoney - moneyWeHave:F2} more.");
            }
        }
    }
}
