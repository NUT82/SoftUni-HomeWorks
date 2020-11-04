using System;

namespace RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given a program that checks if numbers in a given range [2...N] are prime. For each number is printed "{number} -> {true or false}". The code however, is not very well written. Your job is to modify it in a way that is easy to read and understand.
            int maxRange = int.Parse(Console.ReadLine());
            for (int currNumber = 2; currNumber <= maxRange; currNumber++)
            {
                bool isPrime = true;
                for (int delitel = 2; delitel < currNumber; delitel++)
                {
                    if (currNumber % delitel == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", currNumber, isPrime.ToString().ToLower());
            }

        }
    }
}
