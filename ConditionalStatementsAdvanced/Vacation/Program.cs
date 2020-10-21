using System;

namespace Vacation
{
    class Program
    {
        static void Main()
        {
            //Напишете програма, която спрямо даден бюджет и сезон да пресмята цената, локацията и мястото на настаняване за ваканция. Сезоните са лято и зима – "Summer" и "Winter".Локациите са – "Alaska" и "Morocco".Възможните места за настаняване – "Hotel", "Hut" или "Camp".
            //•	При бюджет по - малък или равен от 1000лв.:
            //o Настаняване в "Camp"
            //o Според сезона локацията ще е една от следните и ще струва определен процент от бюджета:
            //	Лято – Аляска – 65 % от бюджета
            //	Зима – Мароко – 45 % от бюджета
            //•	При бюджет по - голям от 1000лв.и по-малък или равен от 3000лв.:
            //o Настаняване в "Hut"
            //o Според сезона локацията ще е една от следните и ще струва определен процент от бюджета:
            //	Лято – Аляска – 80 % от бюджета
            //	Зима – Мароко – 60 % от бюджета
            //•	При бюджет по - голям от 3000лв.:
            //o Настаняване в "Hotel"
            //o Според сезона локацията ще е една от следните и ще струва 90 % от бюджета:
            //	Лято – Аляска
            //	Зима – Мароко
            string location = "error";
            string place = "error";
            double percentOfBudget = 0; ;

            //input
            //•	Първи ред – Бюджет – реално число в интервала [10.00...10000.00]
            double setBudget = double.Parse(Console.ReadLine());
            //•	Втори ред –  Сезон – текст "Summer" или "Winter"
            string season = Console.ReadLine();

            if (setBudget <= 1000)
            {
                place = "Camp";
                if (season == "Summer")
                {
                    percentOfBudget = 0.65;
                    location = "Alaska";
                }
                else
                {
                    percentOfBudget = 0.45;
                    location = "Morocco";
                }
            }
            else if (setBudget <= 3000)
            {
                place = "Hut";
                if (season == "Summer")
                {
                    percentOfBudget = 0.8;
                    location = "Alaska";
                }
                else
                {
                    percentOfBudget = 0.6;
                    location = "Morocco";
                }
            }
            else
            {
                place = "Hotel";
                if (season == "Summer")
                {
                    percentOfBudget = 0.9;
                    location = "Alaska";
                }
                else
                {
                    percentOfBudget = 0.9;
                    location = "Morocco";
                }
            }
            double price = setBudget * percentOfBudget;

            //output
            //"{локацията} – {мястото за настаняване} – {цената}"
            Console.WriteLine($"{location} - {place} - {price:F2}");
            //Цената трябва да е форматирана до вторият знак след десетичната запетая.

        }
    }
}
