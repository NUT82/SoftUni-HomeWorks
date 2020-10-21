using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Отговаряте за логистиката на различни товари. В зависимост от теглото на товара е нужно различно превозно средство. Цената на тон, за която се превозва товара е различна за всяко превозно средство:
            //•	До 3 тона – микробус (200 лева на тон)
            //•	От 4 до 11 тона – камион (175 лева на тон)
            //•	12 и повече тона – влак (120 лева на тон)
            //Вашата задача е да изчислите средната цена на тон превозен товар, както и процента на тоновете  превозвани с всяко превозно средство, спрямо общото тегло(в тонове) на всички товари.

            //input
            //•	На първия ред – броя на товарите за превоз – цяло число в интервала [1...1000]
            int countOfGoods = int.Parse(Console.ReadLine());
            //•	За всеки един товар на отделен ред – тонажа на товара – цяло число в интервала[1...1000]
            double tonsOfAllGoods = 0;
            double tonsOfGoodsWithMinibus = 0;
            double tonsOfGoodsWithTruck = 0;
            double tonsOfGoodsWihTrain = 0;
            double priceForTransport = 0;

            for (int i = 0; i < countOfGoods; i++)
            {
                int tonsOfCurrentGoods = int.Parse(Console.ReadLine());
                tonsOfAllGoods += tonsOfCurrentGoods;
                if (tonsOfCurrentGoods <= 3)
                {
                    priceForTransport += tonsOfCurrentGoods * 200;
                    tonsOfGoodsWithMinibus += tonsOfCurrentGoods;
                }
                else if (tonsOfCurrentGoods <= 11)
                {
                    priceForTransport += tonsOfCurrentGoods * 175;
                    tonsOfGoodsWithTruck += tonsOfCurrentGoods;
                }
                else
                {
                    priceForTransport += tonsOfCurrentGoods * 120;
                    tonsOfGoodsWihTrain += tonsOfCurrentGoods;
                }
            }

            //output
            //•	Първи ред – средната цена на тон превозен товар (закръглена до втория знак след дес. запетая);
            Console.WriteLine($"{priceForTransport / tonsOfAllGoods:F2}");
            //•	Втори ред – процентът тона превозвани с микробус (процент между 0.00% и 100.00%);
            Console.WriteLine($"{tonsOfGoodsWithMinibus / tonsOfAllGoods * 100:F2}%");
            //•	Трети ред – процентът  тона превозвани с камион (процент между 0.00% и 100.00%);
            Console.WriteLine($"{tonsOfGoodsWithTruck / tonsOfAllGoods * 100:F2}%");
            //•	Четвърти ред – процентът тона превозвани с влак (процент между 0.00% и 100.00%).
            Console.WriteLine($"{tonsOfGoodsWihTrain / tonsOfAllGoods * 100:F2}%");

        }
    }
}
