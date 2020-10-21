using System;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            //Екипът на СофтУни си организира футболен турнир. Първоначално прочитаме от конзолата капацитета на стадиона и броят на всички фенове. След това за всеки фен се чете секторът, в който се намира. Феновете на първия отбор са в сектор А и Б, а на втория – В и Г. Да се напише програма, която изчислява процентите на феновете във всеки сектор, спрямо общия брой фенове на стадиона, както и общият процент на феновете за двата отбора, спрямо капацитета на стадиона. Общият брой на феновете НЕ надвишава капацитета на стадиона.

            //input
            //1.	Капацитетът на стадиона – цяло число в интервала [1 … 10000];
            int capacityOfStadium = int.Parse(Console.ReadLine());
            //2.	Броят на всички фенове – цяло число в интервала [1 … 10000].
            int allFans = int.Parse(Console.ReadLine());
            //За всеки един фен, на отделен ред се прочита:
            //1.	Секторът, на който се намира – текст – "A", "B", "V" и "G".
            double fansOnSectorA = 0;
            double fansOnSectorB = 0;
            double fansOnSectorV = 0;
            double fansOnSectorG = 0;

            for (int i = 0; i < allFans; i++)
            {
                string sector = Console.ReadLine();
                switch (sector)
                {
                    case "A":
                        fansOnSectorA++;
                        break;
                    case "B":
                        fansOnSectorB++;
                        break;
                    case "V":
                        fansOnSectorV++;
                        break;
                    case "G":
                        fansOnSectorG++;
                        break;
                    default:
                        break;
                }
            }
            //output
            //Да се отпечатат на конзолата 5 реда, всеки от които съдържа процент между 0.00% и 100.00%, форматирани до втората цифра след десетичната запетая:
            //1.	Процентът на феновете в сектор А
            Console.WriteLine($"{fansOnSectorA / allFans * 100:F2}%");
            //2.	Процентът на феновете в сектор Б
            Console.WriteLine($"{fansOnSectorB / allFans * 100:F2}%");
            //3.	Процентът на феновете в сектор В
            Console.WriteLine($"{fansOnSectorV / allFans * 100:F2}%");
            //4.	Процентът на феновете в сектор Г
            Console.WriteLine($"{fansOnSectorG / allFans * 100:F2}%");
            //5.	Процентът на всички фенове, спрямо капацитета на стадиона.
            Console.WriteLine($"{(fansOnSectorV + fansOnSectorG + fansOnSectorB + fansOnSectorA) / capacityOfStadium * 100:F2}%");

        }
    }
}
