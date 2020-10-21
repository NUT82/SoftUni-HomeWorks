using System;
using System.Globalization;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата две шестцифрени цели числа в диапазона от 100000 до 300000. Винаги първото въведено число ще бъде по малко от второто. На конзолата да се отпечатат на 1 ред разделени с интервал всички числа, които се намират между двете, прочетени от конзолата числа и отговарят на следното условие:
            //•	сумата от цифрите на четни и нечетни позиции да са равни. Ако няма числа, отговарящи на условието на конзолата не се извежда резултат. 
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            for (int i = number1; i <= number2; i++)
            {
                int sumOdd = 0;
                int sumEven = 0;
                string numberAsString = i + "";
                for (int a = 0; a < 6; a++)
                {
                    string oneChar = numberAsString[a] + "";
                    if (a == 0 || a == 2 || a == 4)
                    {
                        sumOdd += int.Parse(oneChar);
                    }
                    else
                    {
                        sumEven += int.Parse(oneChar);
                    }
                }
                if (sumOdd == sumEven)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
