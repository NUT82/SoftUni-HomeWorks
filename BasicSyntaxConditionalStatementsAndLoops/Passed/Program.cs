using System;

namespace Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double avvGrade = double.Parse(Console.ReadLine());

            if (avvGrade >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
