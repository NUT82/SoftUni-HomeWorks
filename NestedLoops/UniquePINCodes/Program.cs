using System;

namespace UniquePINCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която генерира трицифрени PIN кодове, като цифрите на всеки PIN код са в определен интервал. За да бъде валиден един PIN код той трябва да отговаря на следните условия:
            //•	Първата и третата цифра трябва да бъдат четни.
            //•	Втората цифра трябва да бъде просто число в диапазона [2...7].
            bool isPrime = false;
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            for (int pinFirstNumber = 2; pinFirstNumber <= number1; pinFirstNumber += 2)
            {
                for (int pinSecondNUmber = 2; pinSecondNUmber <= number2; pinSecondNUmber++)
                {
                    if (pinSecondNUmber == 2 || pinSecondNUmber == 3 || pinSecondNUmber == 5 || pinSecondNUmber == 7)
                    {
                        for (int pinThirdNumber = 2; pinThirdNumber <= number3; pinThirdNumber += 2)
                        {
                            Console.WriteLine($"{pinFirstNumber} {pinSecondNUmber} {pinThirdNumber}");
                        }
                    }

                }
            }
            //Да се отпечатат на конзолата всички валидни трицифрени PIN кодове, чиито цифри отговарят на съответните интервали.

        }
    }
}
