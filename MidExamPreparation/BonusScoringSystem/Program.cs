using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine()); //0..50
            int lecturesCount = int.Parse(Console.ReadLine()); //0..50
            int initialBonus = int.Parse(Console.ReadLine()); //0..100
            int maxBonus = 0;
            int studentAttendances = 0;
            if (lecturesCount != 0)
            {
                for (int i = 0; i < studentsCount; i++)
                {
                    int currStudentAttendance = int.Parse(Console.ReadLine());
                    double totalBonus = Math.Ceiling(currStudentAttendance * 1.0 / lecturesCount * (5 + initialBonus));
                    if (totalBonus > maxBonus)
                    {
                        maxBonus = (int)totalBonus;
                        studentAttendances = currStudentAttendance;
                    }
                }
            }

            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {studentAttendances} lectures.");
        }
    }
}
