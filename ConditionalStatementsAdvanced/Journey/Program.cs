using System;
using System.Xml;

namespace Journey
{
    class Program
    {
        static void Main()
        {
            //Странно, но повечето хора си плануват от рано почивката. Млад програмист разполага с определен бюджет и свободно време в даден сезон. Напишете програма, която да приема на входа бюджета и сезона, а на изхода да изкарва, къде ще почива програмиста и колко ще похарчи.
            //Бюджета определя дестинацията, а сезона определя колко от бюджета ще изхарчи. Ако е лято ще почива на къмпинг, а зимата в хотел. Ако е в Европа, независимо от сезона ще почива в хотел. Всеки къмпинг или хотел, според дестинацията, има собствена цена която отговаря на даден процент от бюджета: 
            //•	При 100лв.или по-малко – някъде в България
            //o   Лято – 30 % от бюджета
            //o   Зима – 70 % от бюджета
            //•	При 1000лв.или по малко – някъде на Балканите
            //o   Лято – 40 % от бюджета
            //o   Зима – 80 % от бюджета
            //•	При повече от 1000лв. – някъде из Европа
            //o   При пътуване из Европа, независимо от сезона ще похарчи 90 % от бюджета.
            string destination = "Europe";
            double percentOfBudget = 0.9;

            //•	Първи ред – Бюджет, реално число в интервала[10.00...5000.00].
            double availiableBudget = double.Parse(Console.ReadLine());
            //•	Втори ред –  Един от двата възможни сезона: „summer” или “winter”
            string season = Console.ReadLine();

            if (availiableBudget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    percentOfBudget = 0.3;
                }
                else
                {
                    percentOfBudget = 0.7;
                }
            }
            else if (availiableBudget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    percentOfBudget = 0.4;
                }
                else
                {
                    percentOfBudget = 0.8;
                }
            }

            double ammountSpent = availiableBudget * percentOfBudget;
            string typeOfVacation = "Camp";
            if (season == "winter" || destination == "Europe")
            {
                typeOfVacation = "Hotel";
            }

            //output
            //•	Първи ред – „Somewhere in [дестинация]“ измежду “Bulgaria", "Balkans” и ”Europe”
            //•	Втори ред – “{ Вид почивка} – { Похарчена сума}“
            //o Почивката може да е между „Camp” и „Hotel”
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfVacation} - {ammountSpent:F2}");
            //o Сумата трябва да е закръглена с точност до вторият знак след запетаята.


        }
    }
}
