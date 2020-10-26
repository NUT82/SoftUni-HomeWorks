using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read three real numbers and sort them in descending order. Print each number on a new line.
            const int countOfInputNumber = 3;
            int maxNumber = int.MinValue;
            int[] allNumbers = new int[countOfInputNumber];

            for (int i = 0; i < countOfInputNumber; i++)
            {
                allNumbers[i] = int.Parse(Console.ReadLine());
            }
            //sort descending
            for (int i = 0; i < allNumbers.Length - 1; i++)
            {
                for (int j = i + 1; j < allNumbers.Length; j++)
                {
                    if (allNumbers[i] < allNumbers[j])
                    {
                        int currNumber = allNumbers[i];
                        allNumbers[i] = allNumbers[j];
                        allNumbers[j] = currNumber;
                    }
                }
            }
            for (int i = 0; i < countOfInputNumber; i++)
            {
                Console.WriteLine(allNumbers[i]);
            }
        }
    }
}
