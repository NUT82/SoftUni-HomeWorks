using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] currCommand = command.Split(" : ");
                string courseName = currCommand[0];
                string studentName = currCommand[1];
                if (courses.ContainsKey(courseName))
                {
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses.Add(courseName, new List<string>() { studentName });
                }

                command = Console.ReadLine();
            }

            foreach (var course in courses.OrderByDescending(c => c.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value.OrderBy(n => n))
                {
                    Console.WriteLine(string.Join(Environment.NewLine, $"-- {student}"));
                }
            }
        }
    }
}
