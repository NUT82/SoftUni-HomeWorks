using System;

namespace GraduationPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която изчислява средната оценка на ученик от цялото му обучение. На първия ред ще получите името на ученика, а на всеки следващ ред неговите годишни оценки. Ученикът преминава в следващия клас, ако годишната му оценка е по-голяма или равна на 4.00. Ако ученикът бъде скъсан повече от един път, то той бива изключен и програмата приключва, като се отпечатва името на ученика и в кой клас бива изключен.
            const double goodGrade = 4;
            // При успешно завършване на 12-ти клас да се отпечата : 
            //"{име на ученика} graduated. Average grade: {средната оценка от цялото обучение}"
            //В случай, че ученикът е изключен от училище, да се отпечата:
            //"{име на ученика} has been excluded at {класа, в който е бил изключен} grade"
            //Стойността трябва да бъде форматирана до втория знак след десетичната запетая.  

            string nameOfStudent = Console.ReadLine();
            int finishedClass = 0;
            double sumOfYearGrades = 0;
            int countOfBadYearGrades = 0;
            bool excluded = false;

            while (!excluded && finishedClass != 12)
            {
                double currYearGrade = double.Parse(Console.ReadLine());
                sumOfYearGrades += currYearGrade;
                if (currYearGrade >= goodGrade)
                {
                    finishedClass++;
                    continue;
                }
                else
                {
                    countOfBadYearGrades++;
                }
                if (countOfBadYearGrades > 1)
                {
                    excluded = true;
                    break;
                }
                else
                {
                    finishedClass++;
                }
            }

            //output
            if (excluded)
            {
                Console.WriteLine($"{nameOfStudent} has been excluded at {finishedClass} grade");
            }
            else
            {
                Console.WriteLine($"{nameOfStudent} graduated. Average grade: {sumOfYearGrades / 12:F2}");
            }
        }
    }
}
