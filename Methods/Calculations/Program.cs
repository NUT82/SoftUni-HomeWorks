using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    PrintSumTwoNumbers(numberOne, numberTwo);
                    break;
                case "multiply":
                    PrintMultiplyTwoNumbers(numberOne, numberTwo);
                    break;
                case "subtract":
                    PrintSubtractTwoNumbers(numberOne, numberTwo);
                    break;
                case "divide":
                    PrintDevideOfTwoNumbers(numberOne, numberTwo);
                    break;
                default:
                    break;
            }
        }

        static void PrintSubtractTwoNumbers(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne - numberTwo);
        }

        static void PrintMultiplyTwoNumbers(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne * numberTwo);
        }

        static void PrintDevideOfTwoNumbers(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne / numberTwo);
        }

        static void PrintSumTwoNumbers(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne + numberTwo);
        }
    }
}
