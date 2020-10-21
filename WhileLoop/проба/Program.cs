namespace Scholarship
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double socialScholarship = Math.Floor(minSalary * 0.35);
            double scoresScholarship = Math.Floor(averageGrade * 25);
            if (income < minSalary && averageGrade >= 5.5)
            {
                if (socialScholarship > scoresScholarship)
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {scoresScholarship} BGN");
                }
            }
            else if (income < minSalary && averageGrade > 4.5)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else if (averageGrade >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scoresScholarship} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}