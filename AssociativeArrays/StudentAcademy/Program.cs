using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            int numberOfStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfStudents; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (students.ContainsKey(name))
                {
                    students[name].Add(grade);
                }
                else
                {
                    List<double> currGrade = new List<double>() { grade };

                    students.Add(name, currGrade);
                }
            }

            foreach (var item in students.OrderByDescending(g => g.Value.Average()).Where(x => x.Value.Average() >= 4.50))
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():F2}");
            }
        }
    }
}
