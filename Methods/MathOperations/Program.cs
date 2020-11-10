using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int numberTwo = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculation(numberOne, command, numberTwo));

        }
        static double Calculation(int numOne, string operation, int numTwo)
        {
            switch (operation)
            {
                case "/":
                    return numOne / numTwo;
                case "*":
                    return numOne * numTwo;
                case "+":
                    return numOne + numTwo;
                case "-":
                    return numOne - numTwo;
                default:
                    return 0;
            }
            
        }
    }
}
