using System;

namespace FishingBoat
{
    class Program
    {
        static void Main()
        {
            //            Тони и приятели много обичали да ходят за риба, те са толкова запалени по риболова, че решават да отидат на риболов с кораб.Цената за наема на кораба зависи от сезона и броя рибари.
            //Цената зависи от сезона:
            //•	Цената за наем на кораба през пролетта е  3000 лв.
            const double boatRentalAtSpring = 3000;
            //•	Цената за наем на кораба през лятото и есента е  4200 лв.
            const double boatRentalAtSummerOrAutumn = 4200;
            //•	Цената за наем на кораба през зимата е  2600 лв.
            const double boatRentalAtWinter = 2600;
            //В зависимост от броя си групата ползва отстъпка:
            //•	Ако групата е до 6 човека включително  –  отстъпка от 10 %.
            //•	Ако групата е от 7 до 11 човека включително  –  отстъпка от 15 %.
            //•	Ако групата е от 12 нагоре  –  отстъпка от 25 %.
            double discountDeppendingOfGroup = 0.25; // take last case >= 12 people
            //Рибарите ползват допълнително 5 % отстъпка, ако са четен брой освен ако не е есен - тогава нямат допълнителна отстъпка, която се начислява след като се приспадне отстъпката по горните критерии.
            double additionalDiscount = 0.05;
            // Напишете програма, която да пресмята дали рибарите ще съберат достатъчно пари. 

            //input
            //•	Бюджет на групата – цяло число в интервала[1…8000]
            double availiableBudget = double.Parse(Console.ReadLine());
            //•	Сезон –  текст: "Spring", "Summer", "Autumn", "Winter"
            string season = Console.ReadLine();
            //•	Брой рибари – цяло число в интервала[4…18]
            int countFisherman = int.Parse(Console.ReadLine());

            double neededBudget = 0;
            if (countFisherman <= 6)
            {
                discountDeppendingOfGroup = 0.1;
            }
            else if (countFisherman < 12)
            {
                discountDeppendingOfGroup = 0.15;
            }

            if (season == "Autumn" || countFisherman % 2 != 0)
            {
                additionalDiscount = 0;
            }

            switch (season)
            {
                case "Spring":
                    neededBudget = boatRentalAtSpring;
                    break;
                case "Summer":
                case "Autumn":
                    neededBudget = boatRentalAtSummerOrAutumn;
                    break;
                case "Winter":
                    neededBudget = boatRentalAtWinter;
                    break;
                default:
                    break;
            }

            neededBudget -= neededBudget * discountDeppendingOfGroup;
            neededBudget -= neededBudget * additionalDiscount;
            double diferenceBudget = Math.Abs(neededBudget - availiableBudget);

            //output
            // •	Ако бюджетът е достатъчен:
            if (availiableBudget >= neededBudget)
            {
                Console.WriteLine($"Yes! You have {diferenceBudget:F2} leva left.");
            }
            //"Yes! You have {останалите пари} leva left."
            //•	Ако бюджетът НЕ Е достатъчен:
            else
            {
                Console.WriteLine($"Not enough money! You need {diferenceBudget:F2} leva.");
            }
            //"Not enough money! You need {сумата, която не достига} leva."
            //Сумите трябва да са форматирани с точност до два знака след десетичната запетая.

        }
    }
}
