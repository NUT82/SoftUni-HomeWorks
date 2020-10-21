using System;

namespace CarToGo
{
    class Program
    {
        static void Main()
        {
            //Напишете програма, която спрямо даден бюджет и сезон да пресмята цената, типа и класа на кола под наем.
            //Сезоните са лято и зима – "Summer" и "Winter". Типа коли са кабрио и джип – "Cabrio" и "Jeep". 
            //•	При бюджет по-малък или равен от 100лв.:
            //o	Класът ще е - "Economy class"
            //o	Според сезона колата и цената ще са:
            //	Лято – Кабрио – 35% от бюджета
            //	Зима – Джип – 65% от бюджета
            //•	При бюджет по-голям от 100лв. и по-малък или равен от 500лв.:
            //o	Класът ще е - "Compact class"
            //o	Според сезона колата и цената ще са:
            //	Лято – Кабрио – 45% от бюджета
            //	Зима – Джип – 80% от бюджета
            //•	При бюджет по-голям от 500лв.:
            //o	Класът ще е – "Luxury class"
            //o	За всеки сезон колата ще е джип и цената ще е:
            //	90% от бюджета
            string typeOfCarClass = "Luxury class";
            string typeOfCar = "Jeep";
            double percentPerRentOfCar = 0.9;

            //input
            //•	Първи ред – Бюджет – реално число в интервала [10.00...10000.00]
            double setBudget = double.Parse(Console.ReadLine());
            //•	Втори ред –  Сезон – текст "Summer" или "Winter"
            string season = Console.ReadLine();

            if (setBudget <= 100)
            {
                typeOfCarClass = "Economy class";
                if (season == "Summer")
                {
                    typeOfCar = "Cabrio";
                    percentPerRentOfCar = 0.35;
                }
                else
                {
                    typeOfCar = "Jeep";
                    percentPerRentOfCar = 0.65;
                }
            }
            else if (setBudget <= 500)
            {
                typeOfCarClass = "Compact class";
                if (season == "Summer")
                {
                    typeOfCar = "Cabrio";
                    percentPerRentOfCar = 0.45;
                }
                else
                {
                    typeOfCar = "Jeep";
                    percentPerRentOfCar = 0.8;
                }
            }

            double rentOfCar = percentPerRentOfCar * setBudget;
            //output
            //•	Първи ред – "{Вид на класа}"
            //o	"Economy class", "Compact class" или "Luxury class"
            Console.WriteLine(typeOfCarClass);
            //•	Втори ред – "{Вид на колата} - {цена на колата}"
            //o	Видът на колата – "Cabrio" или "Jeep"
            Console.WriteLine($"{typeOfCar} - {rentOfCar:F2}");
            //o	Цената трябва да е форматирана до втория знак след запетаята

        }
    }
}
