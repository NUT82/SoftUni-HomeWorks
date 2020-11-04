using System;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read four integer numbers. Add first to the second, divide (integer) the sum by the third number and multiply the result by the fourth number. Print the result.
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            int numberFour = int.Parse(Console.ReadLine());
            Console.WriteLine((numberOne + numberTwo) / numberThree * numberFour);
        }
    }
}
