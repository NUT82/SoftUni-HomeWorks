using System;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която прочита едно цяло число N и генерира всички възможни "щастливи" и различни 4-цифрени числа(всяка цифра от числото е в интервала [1...9]). 
            //Числото трябва да отговаря на следните условия: 
            //Щастливо число е 4-цифрено число, на което сбора от първите две цифри е равен на сбора от последните две. Числото N трябва да се дели без остатък от сбора на първите две цифри на "щастливото" число.

            //Входът се чете от конзолата и се състои от едно цяло число в интервала [2...10000]
            int number = int.Parse(Console.ReadLine());
            for (int firstPosition = 1; firstPosition <= 9; firstPosition++)
            {
                for (int secondPosition = 1; secondPosition <= 9; secondPosition++)
                {
                    for (int thirdPosition = 1; thirdPosition <= 9; thirdPosition++)
                    {
                        for (int fourthPosition = 1; fourthPosition <= 9; fourthPosition++)
                        {
                            if (firstPosition + secondPosition == thirdPosition + fourthPosition && number % (firstPosition + secondPosition) == 0)
                            {
                                string output = firstPosition.ToString() + secondPosition.ToString() + thirdPosition.ToString() + fourthPosition.ToString();
                                Console.Write(output + " ");
                            }
                        }
                    }
                }
            }

            //На конзолата трябва да се отпечатат всички "щастливи" и различни 4-цифрени числа, разделени с интервал

        }
    }
}
