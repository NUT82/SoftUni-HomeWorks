using System;

namespace EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            const double priceSmallSetWatermelon = 56 * 2;
            const double priceBigSetWatermelon = 28.70 * 5;
            const double priceSmallSetMango = 36.66 * 2;
            const double priceBigSetMango = 19.60 * 5;
            const double priceSmallSetPineapple = 42.10 * 2;
            const double priceBigSetPineapple = 24.80 * 5;
            const double priceSmallSetRaspberry = 20 * 2;
            const double priceBigSetRaspberry = 15.20 * 5;
            
            string fruit = Console.ReadLine();
            string typeOfSet = Console.ReadLine();
            int countOfSets = int.Parse(Console.ReadLine());
            double discount = 0.15;
            double priceOfOrder = 0;

            switch (fruit)
            {
                case "Watermelon":
                    if (typeOfSet == "small")
                    {
                        priceOfOrder = countOfSets * priceSmallSetWatermelon;
                    }
                    else
                    {
                        priceOfOrder = countOfSets * priceBigSetWatermelon;
                    }
                    break;
                case "Mango":
                    if (typeOfSet == "small")
                    {
                        priceOfOrder = countOfSets * priceSmallSetMango;
                    }
                    else
                    {
                        priceOfOrder = countOfSets * priceBigSetMango;
                    }
                    break;
                case "Pineapple":
                    if (typeOfSet == "small")
                    {
                        priceOfOrder = countOfSets * priceSmallSetPineapple;
                    }
                    else
                    {
                        priceOfOrder = countOfSets * priceBigSetPineapple;
                    }
                    break;
                case "Raspberry":
                    if (typeOfSet == "small")
                    {
                        priceOfOrder = countOfSets * priceSmallSetRaspberry;
                    }
                    else
                    {
                        priceOfOrder = countOfSets * priceBigSetRaspberry;
                    }
                    break;
                default:
                    break;
            }
            if (priceOfOrder < 400)
            {
                discount = 0;
            }
            else if (priceOfOrder > 1000)
            {
                discount = 0.5;
            }
            priceOfOrder -= priceOfOrder * discount;
            Console.WriteLine($"{priceOfOrder:F2} lv.");
        }
    }
}
