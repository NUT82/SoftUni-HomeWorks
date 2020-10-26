using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given a working code that is a solution to Problem 5. Special Numbers. However, the variables are improperly named, declared before they are needed and some of them are used for multiple things. Without using your previous solution, modify the code so that it is easy to read and understand.
            int lastNumber = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            int chekedNumber = 0;
            bool isSpecial = false;
            for (int currNumber = 1; currNumber <= lastNumber; currNumber++)
            {
                chekedNumber = currNumber;
                while (currNumber > 0)
                {
                    sumOfDigits += currNumber % 10;
                    currNumber = currNumber / 10;
                }
                isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine("{0} -> {1}", chekedNumber, isSpecial);
                sumOfDigits = 0;
                currNumber = chekedNumber;
            }

        }
    }
}
