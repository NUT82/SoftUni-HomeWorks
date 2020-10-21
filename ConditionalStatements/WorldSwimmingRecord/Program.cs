using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            //Иван решава да подобри Световния рекорд по плуване на дълги разстояния.На конзолата се въвежда рекордът в секунди, който Иван трябва да подобри,  разстоянието в метри, което трябва да преплува и времето в секунди, за което плува разстояние от 1 м.Да се напише програма, която изчислява дали се е справил със задачата, като се има предвид, че: съпротивлението на водата го забавя на всеки 15 м.с 12.5 секунди.Когато се изчислява колко пъти Иванчо ще се забави, в резултат на съпротивлението на водата, резултатът трябва да се закръгли надолу до най - близкото цяло число.
            const double waterResistansFor15Meters = 12.5;
            //Да се изчисли времето в секунди, за което Иванчо ще преплува разстоянието и разликата спрямо Световния рекорд. 

            //input
            //1.	Рекордът в секунди – реално число в интервала [0.00 … 100000.00]
            double worldRecord = double.Parse(Console.ReadLine());
            //2.	Разстоянието в метри – реално число в интервала [0.00 … 100000.00]
            double metersOfSwiming = double.Parse(Console.ReadLine());
            //3.	Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала [0.00 … 1000.00]
            double secondsForSwimingOneMeter = double.Parse(Console.ReadLine());

            //calculations
            double waterResistans = Math.Floor(metersOfSwiming / 15) * waterResistansFor15Meters;
            double secondsOfSwimingIvan = metersOfSwiming * secondsForSwimingOneMeter + waterResistans;
            
            //output
            //•	Ако Иван е подобрил Световния рекорд отпечатваме:
            if (secondsOfSwimingIvan < worldRecord)
            {
                //o	"Yes, he succeeded! The new world record is {времето на Иван} seconds."
                Console.WriteLine($"Yes, he succeeded! The new world record is {secondsOfSwimingIvan:F2} seconds.");
            }
            //•	Ако НЕ е подобрил рекорда отпечатваме:
            else
            {
                //o	"No, he failed! He was {недостигащите секунди} seconds slower."
                Console.WriteLine($"No, he failed! He was {secondsOfSwimingIvan - worldRecord:F2} seconds slower.");
            }
        }
    }
}
