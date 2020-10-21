using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            //Георги ще има гости вечерта и решава да ги нагости с паламуд, сафрид и миди. Затова отива на рибната борса, за да си купи по няколко килограма.Oт конзолата се въвеждат цените в лева на скумрията и цацата.Също количеството на паламуд, сафрид и миди в килограми. Колко пари ще са му необходими, за да плати сметката си, ако цените на борсата са:
            //•	Паламуд – 60 % по - скъп от скумрията
            //•	Сафрид – 80 % по - скъп от цацата
            //•	Миди – 7.50 лв.за килограм

            const double priceMusselsPerKg = 7.50;

            //•	Първи ред – цена на скумрията на килограм.Реално число в интервала[0.00…40.00]
            double priceMackerelPerKg = double.Parse(Console.ReadLine());
            //•	Втори ред – цена на цацата на килограм.Реално число в интервала[0.00…30.00]
            double priceSpcaPerKg = double.Parse(Console.ReadLine());
            //•	Трети ред – килограма паламуд. Реално число в интервала[0.00…50.00]
            double bonitoKg = double.Parse(Console.ReadLine());
            //•	Четвърти ред – килограма сафрид. Реално число в интервала[0.00… 70.00]
            double scadKg = double.Parse(Console.ReadLine());
            //•	Пети ред – килограма миди. Цяло число в интервала[0... 100]
            int musselsKg = int.Parse(Console.ReadLine());

            //Calculations
            double priceBonitoKg = priceMackerelPerKg + priceMackerelPerKg * 0.6;
            double priceScadKg = priceSpcaPerKg + priceSpcaPerKg * 0.8;

            double sumTotal = bonitoKg * priceBonitoKg + scadKg * priceScadKg + musselsKg * priceMusselsPerKg;

            Console.WriteLine($"{sumTotal:F2}");

        }
    }
}
