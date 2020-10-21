using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            //Учебната година вече е започнала и отговорничката на 10Б клас - Ани трябва да купи определен брой пакетчета с химикали, пакетчета с маркери, както и препарат за почистване на дъска. Тя е редовна клиентка на една книжарница, и има намаление за нея, което представлява някакъв процент от общата сума. Напишете програма, която изчислява колко пари ще трябва да събере Ани, за да плати сметката, като имате предвид следния ценоразпис: 
            //•	Пакет химикали - 5.80 лв 
            const double priceOfPens = 5.80;
            //•	Пакет маркери - 7.20 лв 
            const double priceOfMarkers = 7.20;
            //•	Препарат - 1.20 лв (за литър)
            const double priceOfCleaner = 1.20;

            //•	Първи ред - брой пакети химикали. Цяло число в интервала [0...100]
            double priceOfAllPens = double.Parse(Console.ReadLine()) * priceOfPens;
            //•	Втори ред - брой пакети маркери. Цяло число в интервала [0...100]
            double priceOfAllMarkers = double.Parse(Console.ReadLine()) * priceOfMarkers;
            //•	Трети ред - литър препарат за почистване на дъска. Реално число в интервала [0.00…50.00]
            double priceOfAllCleaner = double.Parse(Console.ReadLine()) * priceOfCleaner;
            //•	Четвърти ред - процентът намаление. Цяло число в интервала [0...100]
            int discount = int.Parse(Console.ReadLine());

            double neededMoney = priceOfAllMarkers + priceOfAllPens + priceOfAllCleaner;
            neededMoney -= neededMoney * discount / 100;

            //Да се отпечата на конзолата колко пари ще са нужни на Ани, за да си плати сметката.
            //Резултатът да се ФОРМАТИРА до третия знак след десетичната запетая.
            Console.WriteLine($"{neededMoney:F3}");
        }
    }
}
