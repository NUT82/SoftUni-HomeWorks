using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main()
        {
            //Фирма дава следните комисионни на търговците си според града, в който работят и обема на продажбите:
            //Град    0 ≤ s ≤ 500 500 < s ≤ 1 000 1 000 < s ≤ 10 000  s > 10 000
            //Sofia   5 %               7 %                 8 %         12 %
            //Varna   4.5 %             7.5 %               10 %        13 %
            //Plovdiv 5.5 %             8 %                 12 %        14.5 %
            //Напишете конзолна програма, която чете име на град(стринг) и обем на продажби(реално число) , въведени от потребителя, и изчислява и извежда размера на търговската комисионна според горната таблица.Резултатът да се изведе форматиран до 2 цифри след десетичната точка. При невалиден град или обем на продажбите(отрицателно число) да се отпечата "error".

            string town = Console.ReadLine();
            double salesVolume = double.Parse(Console.ReadLine());

            double commission = 0;
            bool error = salesVolume < 0;
            if (error)
            {
                Console.WriteLine("error");
            }
            else
            {
                switch (town)
                {
                    case "Sofia":
                        if (salesVolume <= 500)
                        {
                            commission = salesVolume * 0.05;
                        }
                        else if (salesVolume <= 1000)
                        {
                            commission = salesVolume * 0.07;
                        }
                        else if (salesVolume <= 10000)
                        {
                            commission = salesVolume * 0.08;
                        }
                        else
                        {
                            commission = salesVolume * 0.12;
                        }
                        break;
                    case "Varna":
                        if (salesVolume <= 500)
                        {
                            commission = salesVolume * 0.045;
                        }
                        else if (salesVolume <= 1000)
                        {
                            commission = salesVolume * 0.075;
                        }
                        else if (salesVolume <= 10000)
                        {
                            commission = salesVolume * 0.1;
                        }
                        else
                        {
                            commission = salesVolume * 0.13;
                        }
                        break;
                    case "Plovdiv":
                        if (salesVolume <= 500)
                        {
                            commission = salesVolume * 0.055;
                        }
                        else if (salesVolume <= 1000)
                        {
                            commission = salesVolume * 0.08;
                        }
                        else if (salesVolume <= 10000)
                        {
                            commission = salesVolume * 0.12;
                        }
                        else
                        {
                            commission = salesVolume * 0.145;
                        }
                        break;
                    default:
                        error = true;
                        break;
                }
                if (error)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    Console.WriteLine($"{commission:F2}");
                }
            }
        }
    }
}
