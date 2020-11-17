using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessonsAndExercises = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while (input != "course start")
            {
                string[] currCommand = input.Split(":");
                string lesson = currCommand[1];

                switch (currCommand[0])
                {
                    case "Add":
                        if (!lessonsAndExercises.Contains(lesson))
                        {
                            lessonsAndExercises.Add(lesson);
                        }
                        break;
                    case "Insert":
                        int index = int.Parse(currCommand[2]);
                        if (!lessonsAndExercises.Contains(lesson))
                        {
                            lessonsAndExercises.Insert(index, lesson);
                        }
                        break;
                    case "Remove":
                        if (lessonsAndExercises.Contains(lesson))
                        {
                            lessonsAndExercises.Remove(lesson);
                            if (lessonsAndExercises.Contains($"{lesson}-Exercise"))
                            { 
                                lessonsAndExercises.Remove($"{lesson}-Exercise");
                            }
                        }
                        break;
                    case "Swap":
                        string secondLesson = currCommand[2];
                        if (lessonsAndExercises.Contains(lesson) && lessonsAndExercises.Contains(secondLesson))
                        {
                            string swapLesson = lesson;
                            int lessonIndex = lessonsAndExercises.IndexOf(lesson);
                            int secondLessonIndex = lessonsAndExercises.IndexOf(secondLesson);

                            lessonsAndExercises[lessonIndex] = lessonsAndExercises[secondLessonIndex];
                            lessonsAndExercises[secondLessonIndex] = swapLesson;

                            if (lessonsAndExercises.Contains($"{lesson}-Exercise"))
                            {
                                string swapExercise = $"{lesson}-Exercise";
                                lessonsAndExercises.Remove($"{lesson}-Exercise");
                                lessonsAndExercises.Insert(secondLessonIndex + 1, swapExercise);
                            }

                            if (lessonsAndExercises.Contains($"{secondLesson}-Exercise"))
                            {
                                string swapExercise = $"{secondLesson}-Exercise";
                                lessonsAndExercises.Remove($"{secondLesson}-Exercise");
                                lessonsAndExercises.Insert(lessonIndex + 1, swapExercise);
                            }
                        }
                        break;
                    case "Exercise":
                        if (!lessonsAndExercises.Contains($"{lesson}-Exercise"))
                        {
                            if (lessonsAndExercises.Contains(lesson))
                            {
                                int indexOfLesson = lessonsAndExercises.IndexOf(lesson);
                                lessonsAndExercises.Insert(indexOfLesson + 1, $"{lesson}-Exercise");
                            }
                            else
                            {
                                lessonsAndExercises.Add(lesson);
                                lessonsAndExercises.Add($"{lesson}-Exercise");
                            }
                        }
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < lessonsAndExercises.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessonsAndExercises[i]}");
            }
        }
    }
}
