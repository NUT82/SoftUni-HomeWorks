using System;

namespace TruckDriver
{
    class Program
    {
        static void Main()
        {
            //Напишете програма която пресмята колко пари ще изкара шофьор на ТИР за един сезон. На входа програмата получава през кой сезон ще работи шофьора, както и колко километра на месец ще кара.Един сезон е 4 месеца.Според зависи сезона и броя километри на месец ще му се заплаща различна сума на километър:
            const int mountsOfOneSeason = 4;
            //	                            Пролет  / Есен              Лято                Зима
            //км на месец <= 5000               0.75 лв./ км            0.90 лв./ км        1.05 лв./ км
            //5000 < км на месец <= 10000       0.95 лв./ км            1.10 лв./ км        1.25 лв./ км
            //10000 < км на месец <= 20000      1.45 лв./ км – за който и да е сезон
            double salaryPerKm = 1.45;
            //След като са извадени 10 % за данъци се отпечатват останалите пари.
            const double taxes = 0.1;
            //input
            //•	Първи ред – Сезон – текст "Spring", "Summer", "Autumn" или "Winter"
            string season = Console.ReadLine();
            //•	Втори ред –  Километри на месец – реално число в интервала[10.00...20000.00]
            double kmPerMounth = double.Parse(Console.ReadLine());

            double salary = 0;
            switch (season)
            {
                case "Spring":
                case "Autumn":
                    if (kmPerMounth <= 5000)
                    {
                        salaryPerKm = 0.75;
                    }
                    else if (kmPerMounth <= 10000)
                    {
                        salaryPerKm = 0.95;
                    }
                    break;
                case "Summer":
                    if (kmPerMounth <= 5000)
                    {
                        salaryPerKm = 0.9;
                    }
                    else if (kmPerMounth <= 10000)
                    {
                        salaryPerKm = 1.1;
                    }
                    break;
                case "Winter":
                    if (kmPerMounth <= 5000)
                    {
                        salaryPerKm = 1.05;
                    }
                    else if (kmPerMounth <= 10000)
                    {
                        salaryPerKm = 1.25;
                    }
                    break;
                default:
                    break;
            }
            salary = salaryPerKm * kmPerMounth * mountsOfOneSeason;
            salary -= salary * taxes;
            //output
            //•	Заплатата на шофьора след данъците, форматирана до втория знак след десетичната запетая.
            Console.WriteLine($"{salary:F2}");
        }
    }
}
