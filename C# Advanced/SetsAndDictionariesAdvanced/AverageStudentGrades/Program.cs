using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] currStudentAndGrade = Console.ReadLine().Split();
                string currStudent = currStudentAndGrade[0];
                decimal currGrade = decimal.Parse(currStudentAndGrade[1]);

                if (!studentsGrades.ContainsKey(currStudent))
                {
                    studentsGrades.Add(currStudent, new List<decimal>() { currGrade });
                }
                else
                {
                    studentsGrades[currStudent].Add(currGrade);
                }
            }

            foreach (var student in studentsGrades)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {student.Value.Average():F2})");
            }
        }
    }
}
