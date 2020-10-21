using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            //От лозе с площ X квадратни метри се заделя 40 % от реколтата за производство на вино.От 1 кв.м лозе се изкарват Y килограма грозде.За 1 литър вино са нужни 2,5 кг.грозде.Желаното количество вино за продан е Z литра.
            //Напишете програма, която пресмята колко вино може да се произведе и дали това количество е достатъчно.Ако е достатъчно, остатъкът се разделя по равно между работниците на лозето.
            const double partForWine = 0.4;
            const double kgGrapesForOneLiterWine = 2.5;

            //Input
            //•	1ви ред: X кв.м е лозето – цяло число в интервала[10 … 5000]
            int vineyardArea = int.Parse(Console.ReadLine());
            //•	2ри ред: Y грозде за един кв.м – реално число в интервала[0.00 … 10.00]
            double grapesForSqareMeter = double.Parse(Console.ReadLine());
            //•	3ти ред: Z нужни литри вино – цяло число в интервала[10 … 600]
            int neededWine = int.Parse(Console.ReadLine());
            //•	4ти ред: брой работници – цяло число в интервала[1 … 20]
            int workersCount = int.Parse(Console.ReadLine());

            //Calculations
            double producedWine = vineyardArea * partForWine * grapesForSqareMeter / kgGrapesForOneLiterWine;
            double diferenceWine = Math.Abs(producedWine - neededWine);

            //Output

            //•	Ако произведеното вино е по-малко от нужното:
            if (producedWine < neededWine)
            {
                //o	“It will be a tough winter! More {недостигащо вино} liters wine needed.”
                //	Резултатът трябва да е закръглен към по-ниско цяло число
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(diferenceWine)} liters wine needed.");
            }
            //•	Ако произведеното вино е повече от нужното:
            else
            {
                //o	“Good harvest this year! Total wine: {общо вино} liters.”
                //	Резултатът трябва да е закръглен към по-ниско цяло число
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(producedWine)} liters.");
                //o	“{Оставащо вино} liters left -> {вино за 1 работник} liters per person.”
                //	И двата резултата трябва да са закръглени към по-високото цяло число
                Console.WriteLine($"{Math.Ceiling(diferenceWine)} liters left -> {Math.Ceiling(diferenceWine / workersCount)} liters per person.");
            }


        }
    }
}
