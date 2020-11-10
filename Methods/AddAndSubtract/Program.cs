using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            Console.WriteLine(SumTwoNumbers(numberOne, numberTwo) - numberThree);
        }

        private static int SumTwoNumbers(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }
    }
}
