using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            //1.	Доход в лева - реално число в интервала [0.00..6000.00]
            double incomeInLv = double.Parse(Console.ReadLine());
            //2.	Среден успех -  реално число в интервала [2.00...6.00]
            double averageGrade = double.Parse(Console.ReadLine());
            //3.	Минимална работна заплата - реално число в интервала [0.00..1000.00]
            double minWorkSalary = double.Parse(Console.ReadLine());

            //calculations
            double socialScholarshipFlag = 0;
            double excellentScholarshipFlag = 0;
            if (incomeInLv < minWorkSalary && averageGrade > 4.5)
            {
                socialScholarshipFlag = 1;
            }
            if (averageGrade >= 5.5)
            {
                excellentScholarshipFlag = 1;
            }
            double socialScholarship = minWorkSalary * 0.35 * socialScholarshipFlag;
            double excellentScholarship = averageGrade * 25 * excellentScholarshipFlag;

            //output
            //•	Ако ученикът няма право да получава стипендия, се извежда:
            if (socialScholarship == 0 && excellentScholarship == 0)
            {
                //"You cannot get a scholarship!"
                Console.WriteLine("You cannot get a scholarship!");
            }
            //•	Ако ученикът има право да получава само социална стипендия:
            else if (socialScholarship != 0 && excellentScholarship == 0)
            {
                //"You get a Social scholarship {стойност на стипендия} BGN"
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
            //•	Ако ученикът има право да получава само стипендия за отличен успех:
            else if (socialScholarship == 0 && excellentScholarship != 0)
            {
                //"You get a scholarship for excellent results {стойност на стипендията} BGN"
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
            }
            //•	Ако ученикът има право да получава и двата типа стипендии, ще получи по-голямата по сума, а ако са равни ще получи тази за отличен успех.
            else if (excellentScholarship >= socialScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
            }
            else
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
            //Резултатът се закръгля до по-малкото цяло число.
        }
    }
}
