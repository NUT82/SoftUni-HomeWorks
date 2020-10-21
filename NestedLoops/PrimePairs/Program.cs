using System;

namespace PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която генерира и принтира на конзолата четирицифрени числа, в които първата и втората двойка цифри образуват двуцифрени прости числа (пример за такова число 1723). Крайната стойност до която трябва да се генерират двойките се определя от други 2 цифри, подадени като вход, които определят с колко крайната стойност е по-голяма от началната.

            //•	На първия ред – началната стойност на първите първата двойка числа – цяло положително число в диапазона [10… 90]
            int startOfFirstPair = int.Parse(Console.ReadLine());
            //•	На втория ред – началната стойност на втората двойка числа – цяло положително число в диапазона [10… 90]
            int startOfSecondPair = int.Parse(Console.ReadLine());
            //•	На третия ред – разликата между началната и крайната стойност на  първата двойка числа – цяло положително число в диапазона [1… 9]
            int endOfFirstPair = int.Parse(Console.ReadLine()) + startOfFirstPair;
            //•	На четвъртия ред – разликата между началната и крайната стойност на  втората двойка числа – цяло положително число в диапазона [1… 9]
            int endOfSecondPair = int.Parse(Console.ReadLine()) + startOfSecondPair;

            for (int firstPair = startOfFirstPair; firstPair <= endOfFirstPair; firstPair++)
            {
                for (int secondPair = startOfSecondPair; secondPair <= endOfSecondPair; secondPair++)
                {
                    if (isPrime(firstPair) && isPrime(secondPair))
                    {
                        Console.WriteLine($"{firstPair}{secondPair}");
                    }
                }
            }

            //Да се отпечатат на конзолата четирицифрените числа, в които първите две и вторите две цифри са прости двуцифрени числа.
        }
        static bool isPrime(int number)
        {
            bool result = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
