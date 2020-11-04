using System;

namespace PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read n numbers and print them in reverse order. 
            int countOfNumbers = int.Parse(Console.ReadLine());
            int[] numberArray = new int[countOfNumbers];
            for (int i = 0; i < countOfNumbers; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = countOfNumbers - 1; i >= 0; i--)
            {
                Console.Write(numberArray[i] + " ");
            }
        }
    }
}
