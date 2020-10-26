using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            int number = numberInput;
            int sum = 0;
            while (number > 0)
            {
                int factoriel = 1;
                int currNumber = number % 10;
                for (int i = 1; i <= currNumber; i++)
                {
                    factoriel *= i;
                }
                sum += factoriel;
                number = number / 10;
            }
            if (sum == numberInput)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
