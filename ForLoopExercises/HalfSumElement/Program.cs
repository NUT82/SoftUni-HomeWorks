using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете n-на брой цели числа, въведени от потребителя, и проверява дали сред тях съществува число, което е равно на сумата на всички останали. Ако има такъв елемент, печата "Yes", "Sum = "  + неговата стойност; иначе печата "No", "Diff = " + разликата между най-големия елемент и сумата на останалите (по абсолютна стойност). 
            int countOfReadNumbers = int.Parse(Console.ReadLine());
            int sumOfNumbers = 0;
            int maxOfNumbers = int.MinValue;
            int countOfMaxNumber = 1;
            for (int i = 0; i < countOfReadNumbers; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                sumOfNumbers += inputNumber;
                if (inputNumber > maxOfNumbers)
                {
                    maxOfNumbers = inputNumber;
                    //countOfMaxNumber = 1;
                }
                //else if (maxOfNumbers == inputNumber)
                //{
                //    countOfMaxNumber++;
                //}
            }
            if (sumOfNumbers - countOfMaxNumber * maxOfNumbers == maxOfNumbers)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxOfNumbers);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(maxOfNumbers - (sumOfNumbers - countOfMaxNumber * maxOfNumbers)));
            }
        }
    }
}
