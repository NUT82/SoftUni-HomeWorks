using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Фирма получава заявка за изработването на проект, за който са необходими определен брой часове. Фирмата разполага с определен брой дни. През 10% от дните служителите са на обучение и не могат да работят по проекта. Един нормален работен ден във фирмата е 8 часа. Всеки служител може да работи по проекта в извънработно време по 2 часа на ден.
            //Часовете трябва да са закръглени към по-ниско цяло число (Например –> 6.98 часа се закръглят на 6 часа).
            //Напишете програма, която изчислява дали фирмата може да завърши проекта навреме и колко часа не достигат или остават.

            const double learningTime = 0.1;
            const int workingHours = 8;
            const int workingExtraHours = 2;

            //Input

            //•	На първия ред са необходимите часовете – цяло число в интервала [0 ... 200 000]
            int neededHours = int.Parse(Console.ReadLine());
            //•	На втория ред са дните, с които фирмата разполага – цяло число в интервала [0 ... 20 000]
            int daysToComplete = int.Parse(Console.ReadLine());
            //•	На третия ред е броят на служителите, работещи извънредно – цяло число в интервала [0 ... 200]
            int workersCount = int.Parse(Console.ReadLine());

            //Calculations
            double hoursToComplete = Math.Floor((daysToComplete - daysToComplete * learningTime) * workingHours + (workersCount * workingExtraHours * daysToComplete));
            double hoursDiference = Math.Abs(Math.Floor(hoursToComplete - neededHours));

            //Output
            if (hoursToComplete >= neededHours)
            {
                //•	Ако времето е достатъчно:
                //o	“Yes!{оставащите часове} hours left.”
                Console.WriteLine($"Yes!{hoursDiference} hours left.");
            }
            else
            {
                //•	Ако  времето НЕ Е достатъчно:
                //o	“Not enough time!{недостигащите часове} hours needed.“
                Console.WriteLine($"Not enough time!{hoursDiference} hours needed.");
            }

        }
    }
}
