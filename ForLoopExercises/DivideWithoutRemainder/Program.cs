using System;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дадени са n-на брой цели числа в интервала [1…1000]. От тях някакъв процент p1 се делят без остатък на 2, друг процент p2 се делят без остатък на 3, друг процент p3 се делят без остатък на 4. Да се напише програма, която изчислява и отпечатва процентите p1, p2 и p3.
            //Пример: имаме n = 10 числа: 680, 2, 600, 200, 800, 799, 199, 46, 128, 65. Получаваме следното разпределение и визуализация:
            //Деление без остатък на:	            Числа в диапазона	            Брой числа	    Процент
            //2	                                    680, 2, 600, 200, 800, 46, 128	7	            p1 = 7.0 / 10 * 100 = 70.00%
            //3	                                    600	                            1	            p2 = 1 / 10 * 100 = 10.00%
            //4	                                    680, 600, 200, 800, 128	        5	            p3 = 5 / 10 * 100 = 50.00%

            //На първия ред от входа стои цялото число n (1 ≤ n ≤ 1000) - брой числа. На следващите n реда стои по едно цяло число в интервала [1…1000] - числата които да бъдат проверени на колко се делят.
            int countOfReadNumbers = int.Parse(Console.ReadLine());
            double countNumbersWithoutReminderOf2 = 0;
            double countNumbersWithoutReminderOf3 = 0;
            double countNumbersWithoutReminderOf4 = 0;

            for (int i = 0; i < countOfReadNumbers; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                for (int a = 2; a <= 4; a++)
                {
                    if (inputNumber % a == 0)
                    {
                        switch (a)
                        {
                            case 2: countNumbersWithoutReminderOf2++; break;
                            case 3: countNumbersWithoutReminderOf3++; break;
                            case 4: countNumbersWithoutReminderOf4++; break;
                            default:
                                break;
                        }
                    }
                }
            }
            Console.WriteLine($"{countNumbersWithoutReminderOf2 / countOfReadNumbers * 100:F2}%");
            Console.WriteLine($"{countNumbersWithoutReminderOf3 / countOfReadNumbers * 100:F2}%");
            Console.WriteLine($"{countNumbersWithoutReminderOf4 / countOfReadNumbers * 100:F2}%");
        }
    }
}
