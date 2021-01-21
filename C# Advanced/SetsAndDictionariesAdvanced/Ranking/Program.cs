using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> contestsAndPass = new Dictionary<string, string>();
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            string input = Console.ReadLine();
            while (input != "end of contests")
            {
                string contest = input.Split(":")[0];
                string pass = input.Split(":")[1];
                contestsAndPass.Add(contest, pass);
                input = Console.ReadLine();
            }

            string command = Console.ReadLine();
            while (command != "end of submissions")
            {
                string[] splitCommand = command.Split("=>");
                string contest = splitCommand[0];
                string pass = splitCommand[1];
                string username = splitCommand[2];
                int points = int.Parse(splitCommand[3]);

                if (contestsAndPass.ContainsKey(contest) && contestsAndPass[contest] == pass)
                {
                    Student student = new Student(username);
                    if (!students.ContainsKey(username))
                    {
                        students.Add(username, student);
                    }

                    if (!students[username].Contests.ContainsKey(contest))
                    {
                        students[username].Contests.Add(contest, points);
                    }
                    else if(students[username].Contests[contest] < points)
                    {
                        students[username].Contests[contest] = points;
                    }
                }

                command = Console.ReadLine();
            }
            string bestCandidate = students.OrderByDescending(p => p.Value.Contests.Values.Sum()).First().Key;
            Console.WriteLine($"Best candidate is {bestCandidate} with total {students[bestCandidate].Contests.Values.Sum()} points.");
            Console.WriteLine("Ranking:");
            foreach (var item in students.OrderBy(n => n.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var contest in item.Value.Contests.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }

        class Student
        {
            public string Username { get; set; }
            public Dictionary<string, int> Contests { get; set; }

            public Student(string username)
            {
                Username = username;
                Contests = new Dictionary<string, int>();
            }
        }
    }
}
