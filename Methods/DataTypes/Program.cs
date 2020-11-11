using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "int":
                    PrintResult(int.Parse(Console.ReadLine()));
                    break;
                case "real":
                    PrintResult(double.Parse(Console.ReadLine()));
                    break;
                case "string":
                    PrintResult(Console.ReadLine());
                    break;
                default:
                    break;
            }
        }

        private static void PrintResult(int number)
        {
            Console.WriteLine(number * 2);
        }

        private static void PrintResult(double number)
        {
            Console.WriteLine($"{number * 1.5:F2}");
        }

        private static void PrintResult(string text)
        {
            Console.WriteLine($"${text}$");
        }
    }
}
