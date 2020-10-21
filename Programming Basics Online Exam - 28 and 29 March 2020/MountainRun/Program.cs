using System;

namespace MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            //Георги решава да подобри рекорда за най-бързо изкачване на връх Монблан. На конзолата се въвежда рекордът в секунди, който Георги трябва да подобри, разстоянието в метри, което трябва да изкачи и времето в секунди, за което той изкачва 1 метър. Да се напише програма, която изчислява дали се е справил със задачата, като се има предвид, че: наклона на терена го забавя на всеки 50 м. с 30 секунди. Да се изчисли времето в секунди, за което Георги ще изкачи разстоянието до върха и разликата спрямо рекорда. 
            //Когато се изчислява колко пъти Георги ще се забави в резултат на наклона на терена, резултатът трябва да се закръгли надолу до най-близкото цяло число.

            //1.	Рекордът в секунди – реално число в интервала [0.00 … 100000.00]
            double recordInSeconds = double.Parse(Console.ReadLine());
            //2.	Разстоянието в метри – реално число в интервала [0.00 … 100000.00]
            double distanceInMeters = double.Parse(Console.ReadLine());
            //3.	Времето в секунди, за което изкачва 1 м. – реално число в интервала [0.00 … 1000.00]
            double timeInSecForOneMeter = double.Parse(Console.ReadLine());

            double slowsDownInSeconds = Math.Floor(distanceInMeters / 50) * 30;
            double timeOfGeorgeInSeconds = distanceInMeters * timeInSecForOneMeter + slowsDownInSeconds;

            if (timeOfGeorgeInSeconds < recordInSeconds)
            {
                Console.WriteLine($"Yes! The new record is {timeOfGeorgeInSeconds:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {timeOfGeorgeInSeconds - recordInSeconds:F2} seconds slower.");
            }

            //•	Ако Георги е подобрил рекорда отпечатваме:
            //o	" Yes! The new record is {времето на Георги} seconds."
            //•	Ако НЕ е подобрил рекорда отпечатваме:
            //o	"No! He was {недостигащите секунди} seconds slower."
            //Резултатът трябва да се форматира до втория знак след десетичната запетая.

        }
    }
}
