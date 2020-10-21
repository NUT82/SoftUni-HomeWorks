using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Петя има магазин за детски играчки. Тя получава голяма поръчка, която трябва да изпълни. С парите, които ще спечели иска да отиде на екскурзия. Да се напише програма, която пресмята печалбата от поръчката.

            //•	Пъзел - 2.60 лв.
            const double puzzlePrice = 2.60;
            //•	Говореща кукла -3 лв.
            const double talkingDollPrice = 3;
            //•	Плюшено мече -4.10 лв.
            const double tedyBearPrice = 4.10;
            //•	Миньон - 8.20 лв.
            const double minionPrice = 8.20;
            //•	Камионче - 2 лв.
            const double truckPrice = 2;

            //Input

            //1.Цена на екскурзията -реално число в интервала[1.00 … 10000.00]
            double priceOfTrip = double.Parse(Console.ReadLine());
            //2.Брой пъзели - цяло число в интервала[0… 1000]
            int puzzles = int.Parse(Console.ReadLine());
            //3.Брой говорещи кукли -цяло число в интервала[0 … 1000]
            int talkingDolls = int.Parse(Console.ReadLine());
            //4.Брой плюшени мечета -цяло число в интервала[0 … 1000]
            int tedyBears = int.Parse(Console.ReadLine());
            //5.Брой миньони - цяло число в интервала[0 … 1000]
            int minions = int.Parse(Console.ReadLine());
            //6.Брой камиончета - цяло число в интервала[0 … 1000]
            int trucks = int.Parse(Console.ReadLine());

            //Calculations

            //Ако поръчаните играчки са 50 или повече магазинът прави отстъпка 25% от общата цена. От спечелените пари Петя трябва да даде 10% за наема на магазина. Да се пресметне дали парите ще ѝ стигнат да отиде на екскурзия.
            double discount = 0;
            const double shopRental = 0.1;
            if (puzzles + talkingDolls + tedyBears + minions + trucks >= 50)
            {
                discount = 0.25;
            }
            double priceOfAllKidsToys = puzzles * puzzlePrice + talkingDolls * talkingDollPrice + tedyBears * tedyBearPrice + minions * minionPrice + trucks * truckPrice;
            double priceAfterDiscountAndShopRental = (priceOfAllKidsToys - priceOfAllKidsToys * discount) * (1 - shopRental);

            //Output

            if (priceAfterDiscountAndShopRental >= priceOfTrip)
            {
                //•	Ако парите са достатъчни се отпечатва:
                //o   "Yes! {оставащите пари} lv left."
                double remainingMoney = priceAfterDiscountAndShopRental - priceOfTrip;
                Console.WriteLine($"Yes! {remainingMoney:F2} lv left.");
            }
            else
            {
                //•	Ако парите НЕ са достатъчни се отпечатва:
                //o   "Not enough money! {недостигащите пари} lv needed."
                double deficitMoney = priceOfTrip - priceAfterDiscountAndShopRental;
                Console.WriteLine($"Not enough money! {deficitMoney:F2} lv needed.");
            }

            //Резултатът трябва да се форматира до втория знак след десетичната запетая.

        }
    }
}
