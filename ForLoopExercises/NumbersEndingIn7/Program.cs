using System;

namespace NumbersEndingIn7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която отпечатва числата в диапазона [1…1000], които завършват на 7.
            const int maxNumber = 1000;
            for (int i = 7; i <= maxNumber; i += 10)
            {
                Console.WriteLine(i);
            }
        }
    }
}
