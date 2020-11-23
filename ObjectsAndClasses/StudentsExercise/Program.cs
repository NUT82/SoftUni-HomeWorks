using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>(countOfStudents);

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] line = Console.ReadLine().Split();
                Student currStudent = new Student(line[0], line[1], double.Parse(line[2]));
                students.Add(currStudent);
            }

            foreach (Student item in students.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:F2}";
        }
    }
}
