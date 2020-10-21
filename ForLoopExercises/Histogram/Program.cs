using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дадени са n цели числа в интервала [1…1000]. От тях някакъв процент p1 са под 200, друг процент p2 са от 200 до 399, друг процент p3 са от 400 до 599, друг процент p4 са от 600 до 799 и останалите p5 процента са от 800 нагоре. Да се напише програма, която изчислява и отпечатва процентите p1, p2, p3, p4 и p5.
            //Пример: имаме n = 20 числа: 53, 7, 56, 180, 450, 920, 12, 7, 150, 250, 680, 2, 600, 200, 800, 799, 199, 46, 128, 65. Получаваме следното разпределение и визуализация:
            //Диапазон	                Числа в диапазона	                                Брой числа	             Процент
            //< 200	                    53, 7, 56, 180, 12, 7, 150, 2, 199, 46, 128, 65	    12	        p1 = 12 / 20 * 100 = 60.00%
            //200 … 399	                250, 200	                                        2	        p2 = 2 / 20 * 100 = 10.00%
            //400 … 599	                450	                                                1	        p3 = 1 / 20 * 100 = 5.00%
            //600 … 799	                680, 600, 799	                                    3	        p4 = 3 / 20 * 100 = 15.00%
            //≥ 800	                    920, 800	                                        2	        p5 = 2 / 20 * 100 = 10.00%

            //input
            //На първия ред от входа стои цялото число n (1 ≤ n ≤ 1000) – брой числа. На следващите n реда стои по едно цяло число в интервала [1…1000] – числата върху които да бъде изчислена хистограмата.
            int countOfReadNumbers = int.Parse(Console.ReadLine());
            double countOfNumbersLittleThen199 = 0;
            double countOfNumbersBetween200And399 = 0;
            double countOfNumbersBetween400And599 = 0;
            double countOfNumbersBetween600And799 = 0;
            double countOfNumbersBiggerThen799 = 0;

            //output
            //Да се отпечата на конзолата хистограмата – 5 реда, всеки от които съдържа число между 0% и 100%, с точност две цифри след десетичната точка, например 25.00%, 66.67%, 57.14%.
            for (int i = 0; i < countOfReadNumbers; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                if (inputNumber < 200)
                {
                    countOfNumbersLittleThen199++;
                }
                else if (inputNumber < 400)
                {
                    countOfNumbersBetween200And399++;
                }
                else if (inputNumber < 600)
                {
                    countOfNumbersBetween400And599++;
                }
                else if (inputNumber < 800)
                {
                    countOfNumbersBetween600And799++;
                }
                else
                {
                    countOfNumbersBiggerThen799++;
                }
            }
            Console.WriteLine($"{countOfNumbersLittleThen199 / countOfReadNumbers * 100:F2}%");
            Console.WriteLine($"{countOfNumbersBetween200And399 / countOfReadNumbers * 100:F2}%");
            Console.WriteLine($"{countOfNumbersBetween400And599 / countOfReadNumbers * 100:F2}%");
            Console.WriteLine($"{countOfNumbersBetween600And799 / countOfReadNumbers * 100:F2}%");
            Console.WriteLine($"{countOfNumbersBiggerThen799 / countOfReadNumbers * 100:F2}%");
        }
    }
}
