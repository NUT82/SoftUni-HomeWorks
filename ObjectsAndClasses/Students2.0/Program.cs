using System;
using System.Collections.Generic;
using System.Linq;

namespace Students2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] currLine = command.Split();
                string firstName = currLine[0];
                string lastName = currLine[1];
                int age = int.Parse(currLine[2]);
                string hometown = currLine[3];
                bool isExist = false;
                foreach (var student in students)
                {
                    if (student.FirstName == firstName && student.LastName == lastName)
                    {
                        student.Age = age;
                        student.Hometown = hometown;
                        isExist = true;
                    }
                }

                if (!isExist)
                {
                    Student currStudent = new Student(firstName, lastName, age, hometown);
                    students.Add(currStudent);
                }

                command = Console.ReadLine();
            }

            string nameOfCity = Console.ReadLine();
            foreach (var student in students.Where(x => x.Hometown == nameOfCity))
            {
                Console.WriteLine(student.ToSpecialFormat());
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }

        public Student(string firstName, string lastName, int age, string hometown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Hometown = hometown;
        }

        internal string ToSpecialFormat()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
        }
    }
}
