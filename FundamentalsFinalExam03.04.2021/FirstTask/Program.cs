using System;
using System.Linq;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Finish")
            {
                string[] tokens = command.Split();
                string currCommand = tokens[0];
                switch (currCommand)
                {
                    case "Replace":
                        char currentChar = tokens[1][0];
                        char newChar = tokens[2][0];
                        text = text.Replace(currentChar, newChar);
                        Console.WriteLine(text);
                        break;
                    case "Cut":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);
                        if (startIndex <= endIndex && ValidateIndex(startIndex, text) && ValidateIndex(endIndex, text))
                        {
                            text = text.Remove(startIndex, endIndex - startIndex + 1);
                            Console.WriteLine(text);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indices!");
                        }
                        break;
                    case "Make":
                        text = FlipCase(text, tokens[1]);
                        Console.WriteLine(text);
                        break;
                    case "Check":
                        if (text.Contains(tokens[1]))
                        {
                            Console.WriteLine($"Message contains {tokens[1]}");
                        }
                        else
                        {
                            Console.WriteLine($"Message doesn't contain {tokens[1]}");
                        }
                        break;
                    case "Sum":
                        startIndex = int.Parse(tokens[1]);
                        endIndex = int.Parse(tokens[2]);
                        if (startIndex <= endIndex && ValidateIndex(startIndex, text) && ValidateIndex(endIndex, text))
                        {
                            int sum = 0;
                            foreach (var symbol in text.Substring(startIndex, endIndex - startIndex + 1))
                            {
                                sum += symbol;
                            }

                            Console.WriteLine(sum);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indices!");
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
        }

        private static bool ValidateIndex(int index, string text)
        {
            if (index < 0 || index >= text.Length)
            {
                return false;
            }

            return true;
        }

        private static string FlipCase(string text, string letterCase)
        {
            if (letterCase == "Upper")
            {
                text = text.ToUpper();
            }
            else
            {
                text = text.ToLower();
            }
            return text;
        }
    }
}
