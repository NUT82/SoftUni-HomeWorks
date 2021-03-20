using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    public class Student
    {
        public string Name { get; set; }

        public int Points { get; set; }

        public int TotalPoints { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<Student>> data = new Dictionary<string, List<Student>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "no more time")
                {
                    break;
                }

                string[] parts = line.Split(" -> ").ToArray();

                string name = parts[0];
                string contest = parts[1];
                int points = int.Parse(parts[2]);

                int totalPoints = 0;

                Student student = new Student()
                {
                    Name = name,
                    Points = points,
                    TotalPoints = totalPoints
                };

                if (!data.ContainsKey(contest))
                {
                    data.Add(contest, new List<Student>());
                    data[contest].Add(student);
                    student.TotalPoints += points;
                }

                else
                {
                    if (!data[contest].Any(n => n.Name == name))
                    {
                        data[contest].Add(student);
                        student.TotalPoints += points;
                    }
                    else
                    {
                        if (data[contest].First(n => n.Name == name).Points < points)
                        {
                            int oldPoints = data[contest].First(n => n.Name == name).Points;

                            data[contest].First(n => n.Name == name).Points = points;
                            int diff = points - oldPoints;
                            student.TotalPoints += diff;

                            // studentsByPoints.Add(name, diff);
                            // totalPoints += points;
                        }

                        continue;
                    }
                }
            }

            Dictionary<string, int> studentsPoints = new Dictionary<string, int>();

            foreach (var contest in data)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count()} participants");

                int position = 1;

                foreach (var student in contest.Value.OrderByDescending(x => x.Points).ThenBy(n => n.Name))
                {

                    Console.WriteLine($"{position}. {student.Name} <::> {student.Points}");
                    position += 1;

                    //make new Dictionary - studentName, pointsAllContests
                    if (!studentsPoints.ContainsKey(student.Name))
                    {
                        studentsPoints.Add(student.Name, student.Points);
                    }
                    else
                    {
                        studentsPoints[student.Name] += student.Points;
                    }
                }

                position = 0;
            }

            Console.WriteLine("Individual standings:");

            int number = 1;
            foreach (var student in studentsPoints.OrderByDescending(p => p.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{number}. {student.Key} -> {student.Value}");
                number++;
            }
        }
    }

}
