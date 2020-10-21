using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Мария иска да купи подарък на сина си. Тя работи в магазин за цветя. В магазина идва поръчка за цветя. Напишете програма, която пресмята сумата от поръчката и дали печалбата е достатъчна за подаръка. Цветята имат следните цени:
            //•	Магнолии – 3.25 лева
            //•	Зюмбюли – 4 лева
            //•	Рози – 3.50 лева
            //•	Кактуси – 8 лева
            //От общата сума, Мария трябва да плати 5% данъци.
            const double priceOfMagnolias = 3.25;
            const double priceOfHyacinths = 4;
            const double priceOfRoses = 3.50;
            const double priceOfCacti = 8;
            const double taxes = 0.05;

            //Input
            //•	Брой магнолии – цяло число в интервала [0 … 50]
            int magnolias = int.Parse(Console.ReadLine());
            //•	Брой зюмбюли – цяло число в интервала [0 … 50]
            int hyacinths = int.Parse(Console.ReadLine());
            //•	Брой рози – цяло число в интервала [0 … 50]
            int roses = int.Parse(Console.ReadLine());
            //•	Брой кактуси – цяло число в интервала [0 … 50]
            int cacti = int.Parse(Console.ReadLine());
            //•	Цена на подаръка – реално число в интервала [0.00 … 500.00]
            double priceOfPresent = double.Parse(Console.ReadLine());

            //Calculations
            double priceOfOrder = magnolias * priceOfMagnolias + hyacinths * priceOfHyacinths + roses * priceOfRoses + cacti * priceOfCacti;
            priceOfOrder = priceOfOrder - priceOfOrder * taxes;
            double moneyDiference = Math.Abs(priceOfOrder - priceOfPresent);

            //Output
            if (priceOfOrder >= priceOfPresent)
            {
                //•	Ако парите СА стигнали: "She is left with {останали} leva." – сумата трябва да е закръглена към по-малко цяло число (пр. 1.90 -> 1).
                Console.WriteLine($"She is left with {Math.Floor(moneyDiference)} leva.");
            }
            else
            {
                //•	Ако парите НЕ достигат: "She will have to borrow {останали} leva." – сумата трябва да е закръглена към по-голямо цяло число (пр. 1.10 -> 2).
                Console.WriteLine($"She will have to borrow {Math.Ceiling(moneyDiference)} leva.");
            }
        }
    }
}
