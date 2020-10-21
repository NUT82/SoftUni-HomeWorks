using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Студент трябва да пропътува n километра. Той има избор измежду три вида транспорт:
            //•	Такси. Начална такса: 0.70 лв. Дневна тарифа: 0.79 лв. / км. Нощна тарифа: 0.90 лв. / км.
            //•	Автобус. Дневна / нощна тарифа: 0.09 лв. / км. Може да се използва за разстояния минимум 20 км.
            //•	Влак. Дневна / нощна тарифа: 0.06 лв. / км. Може да се използва за разстояния минимум 100 км.
            //Напишете програма, която въвежда броя километри n и период от деня (ден или нощ) и изчислява цената на най-евтиния транспорт.

            const double taxiInitialFee = 0.70;
            const double taxiDayRatePerKm = 0.79;
            const double taxiNightRatePerKm = 0.90;
            const double busRatePerKm = 0.09;
            const int minBusTravelDistance = 20;
            const double trainRatePerKm = 0.06;
            const int minTrainTravelDistance = 100;

            //Input

            //•	Първият ред съдържа числото n – брой километри – цяло число в интервала [1…5000]
            int travelDistance = int.Parse(Console.ReadLine());
            //•	Вторият ред съдържа дума “day” или “night” – пътуване през деня или през нощта
            string timeOfDay = Console.ReadLine();

            //Calculations
            double cheapestPrice = travelDistance * trainRatePerKm;
            if (travelDistance < minBusTravelDistance)
            {
                if (timeOfDay == "day")
                {
                    cheapestPrice = travelDistance * taxiDayRatePerKm + taxiInitialFee;
                }
                else
                {
                    cheapestPrice = travelDistance * taxiNightRatePerKm + taxiInitialFee;
                }
            }
            else if (travelDistance < minTrainTravelDistance)
            {
                cheapestPrice = travelDistance * busRatePerKm;
            }

            //Output

            //Да се отпечата на конзолата най-ниската цена за посочения брой километри, форматирана до втория знак след десетичния разделител.
            Console.WriteLine($"{cheapestPrice:F2}");
        }
    }
}
