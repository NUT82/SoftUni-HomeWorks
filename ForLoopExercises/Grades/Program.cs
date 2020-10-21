using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която да пресмята статистика на оценки от изпит. В началото програмата получава броят на студентите явили се на изпита и за всеки студент неговата оценка. На края програмата трябва да изпечата процента на студенти с оценка между 2.00 и 2.99, между 3.00 и 3.99, между 4.00 и 4.99, 5.00 или повече. Също така и средният успех на изпита.

            //input
            //•	На първия ред – броя на студентите явили се на изпит – цяло число в интервала [1...1000]
            int countOfStudents = int.Parse(Console.ReadLine());
            //•	За всеки един студент на отделен ред – оценката от изпита – реално число в интервала[2.00...6.00]
            double sumAllGrades = 0;
            double countGradesLess3 = 0;
            double countGradesBetween3And4 = 0;
            double countGradesBetween4And5 = 0;
            double countGradesGreat5 = 0;
            for (int i = 0; i < countOfStudents; i++)
            {
                double currentGrade = double.Parse(Console.ReadLine());
                sumAllGrades += currentGrade;
                if (currentGrade < 3)
                {
                    countGradesLess3++;
                }
                else if (currentGrade < 4)
                {
                    countGradesBetween3And4++;
                }
                else if (currentGrade < 5)
                {
                    countGradesBetween4And5++;
                }
                else
                {
                    countGradesGreat5++;
                }
            }
            //output
            //Ред 1 -	"Top students: {процент студенти с успех 5.00 или повече}%"
            Console.WriteLine($"Top students: {countGradesGreat5 / countOfStudents * 100:F2}%");
            //Ред 2 -	"Between 4.00 and 4.99: {между 4.00 и 4.99 включително}%"
            Console.WriteLine($"Between 4.00 and 4.99: {countGradesBetween4And5 / countOfStudents * 100:F2}%");
            //Ред 3 -	"Between 3.00 and 3.99: {между 3.00 и 3.99 включително}%"
            Console.WriteLine($"Between 3.00 and 3.99: {countGradesBetween3And4 / countOfStudents * 100:F2}%");
            //Ред 4 -	"Fail: {по-малко от 3.00}%"
            Console.WriteLine($"Fail: {countGradesLess3 / countOfStudents * 100:F2}%");
            //Ред 5 -	"Average: {среден успех}"
            Console.WriteLine($"Average: {sumAllGrades / countOfStudents:F2}");

        }
    }
}
