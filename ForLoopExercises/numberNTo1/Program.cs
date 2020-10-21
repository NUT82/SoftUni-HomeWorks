using System;

namespace numberNTo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumEven = 0;
            int sumOdd = 0;
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven += int.Parse(Console.ReadLine());
                }
                else
                {
                    sumOdd += int.Parse(Console.ReadLine());
                }
            }
            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sumEven);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(sumEven - sumOdd));
            }
        }
    }
}
