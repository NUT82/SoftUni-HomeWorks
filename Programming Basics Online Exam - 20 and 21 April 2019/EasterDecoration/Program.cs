using System;

namespace EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            double spendMoney = 0;
            int clients = int.Parse(Console.ReadLine());

            for (int i = 0; i < clients; i++)
            {
                double spendMoneyCurrClient = 0;
                int countOfItemsCurrClient = 0;
                string input = Console.ReadLine();

                while (input != "Finish")
                {
                    
                    switch (input)
                    {
                        case "basket":
                            spendMoneyCurrClient += 1.50;
                            countOfItemsCurrClient++;
                            break;
                        case "wreath":
                            spendMoneyCurrClient += 3.80;
                            countOfItemsCurrClient++;
                            break;
                        case "chocolate bunny":
                            spendMoneyCurrClient += 7;
                            countOfItemsCurrClient++;
                            break;
                        default:
                            break;
                    }
                    input = Console.ReadLine();
                }

                if (countOfItemsCurrClient % 2 == 0)
                {
                    spendMoneyCurrClient -= spendMoneyCurrClient * 0.2;
                }

                Console.WriteLine($"You purchased {countOfItemsCurrClient} items for {spendMoneyCurrClient:F2} leva.");
                spendMoney += spendMoneyCurrClient;
            }

            Console.WriteLine($"Average bill per client is: {spendMoney / clients:F2} leva.");
        }
    }
}
