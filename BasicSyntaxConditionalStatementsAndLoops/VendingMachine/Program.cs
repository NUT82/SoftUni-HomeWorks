using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coins = Console.ReadLine();
            double sumAllCoins = 0;
            while (coins != "Start")
            {
                double currCoin = double.Parse(coins);
                bool availiableCurrCoin =   (currCoin == 0.1) || 
                                            (currCoin == 0.2) || 
                                            (currCoin == 0.5) || 
                                            (currCoin == 1) || 
                                            (currCoin == 2);
                if (availiableCurrCoin)
                {
                    sumAllCoins += currCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currCoin}");
                }
                coins = Console.ReadLine();
            }
            string product = Console.ReadLine();
            while (product != "End")
            {
                double currProductPrice = 0;
                switch (product) //“Nuts”, “Water”, “Crisps”, “Soda”, “Coke”. The prices are: 2.0, 0.7, 1.5, 0.8, 1.0 respectively
                {
                    case "Nuts":
                        currProductPrice = 2;
                        break;
                    case "Water":
                        currProductPrice = 0.7;
                        break;
                    case "Crisps":
                        currProductPrice = 1.5;
                        break;
                    case "Soda":
                        currProductPrice = 0.8;
                        break;
                    case "Coke":
                        currProductPrice = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        product = Console.ReadLine();
                        continue;
                }
                if (currProductPrice > sumAllCoins)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    sumAllCoins -= currProductPrice;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sumAllCoins:F2}");
        }
    }
}
