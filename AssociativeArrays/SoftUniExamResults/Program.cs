using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Exam> exams = new List<Exam>();
            SortedDictionary<string, Exam> examResult = new SortedDictionary<string, Exam>();
            string command = Console.ReadLine();
            while (command != "exam finished")
            {
                string userName = command.Split("-")[0];
                string language = command.Split("-")[1];
                if (language == "banned")
                {
                    if (examResult.ContainsKey(userName))
                    {
                        examResult.Remove(userName);
                    }
                    command = Console.ReadLine();
                    continue;
                }
                int points = int.Parse(command.Split("-")[2]);

                if (examResult.ContainsKey(userName))
                {
                    if (examResult[userName].Points < points)
                    {
                        examResult[userName].Points = points;
                    }
                    Exam exam = new Exam(language, points);
                    exams.Add(exam);
                }
                else
                {
                    Exam exam = new Exam(language, points);
                    exams.Add(exam);
                    examResult.Add(userName, exam);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Results:");
            foreach (var item in examResult.OrderByDescending(p => p.Value.Points))
            {
                Console.WriteLine(string.Join(Environment.NewLine, $"{item.Key} | {item.Value.Points}"));
            }

            SortedDictionary<string, int> allLangs = new SortedDictionary<string, int>();
            foreach (var item in exams)
            {
                if (allLangs.ContainsKey(item.Language))
                {
                    allLangs[item.Language]++;
                }
                else
                {
                    allLangs.Add(item.Language, 1);
                }
            }

            Console.WriteLine("Submissions:");
            foreach (var item in allLangs.OrderByDescending(c => c.Value))
            {
                Console.WriteLine(string.Join(Environment.NewLine, $"{item.Key} - {item.Value}"));
            }
        }
    }

    public class Exam
    {
        public string Language { get; set; }
        public int Points { get; set; }

        public Exam(string language, int points)
        {
            Language = language;
            Points = points;
        }
    }
}
