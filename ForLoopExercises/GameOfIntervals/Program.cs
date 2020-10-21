using System;

namespace GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която да пресмята резултата от игра. Първо получавате число, което показва колко хода ще продължи играта. После за всеки ход на играта ще получавате по едно ново число. Според интервала в който попада числото се прибавят точки. Ако числото е отрицателно или по-голямо 50, тогава то е невалидно. В началото на играта резултата е 0 и на всеки ход се прибавят точки по следният начин:

            //•	От 0 до 9  20 % от числото
            //•	От 10 до 19  30 % от числото
            //•	От 20 до 29  40 % от числото
            //•	От 30 до 39  50 точки
            //•	От 40 до 50  100 точки
            //•	Невалидно число  резултата се дели на 2
            double numbersFrom0To9 = 0;
            double numbersFrom10To19 = 0;
            double numbersFrom20To29 = 0;
            double numbersFrom30To39 = 0;
            double numbersFrom40To50 = 0;
            double numbersInvalid = 0;


            //Освен резултата програмата трябва да изкарва статистика за проценти числа в дадените интервали.

            //input
            //•	Първи ред - колко хода ще има по време на играта – цяло число в интервала [1...100]
            int moves = int.Parse(Console.ReadLine());
            //•	За всеки ход – числата, които се проверяват в кой интервал са – цели числа в интервала[-100...100]
            double finalResult = 0;
            for (int i = 0; i < moves; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());
                if (currNumber < 0)
                {
                    numbersInvalid++;
                    finalResult /= 2;
                }
                else if (currNumber < 10)
                {
                    numbersFrom0To9++;
                    finalResult += currNumber * 0.2;
                }
                else if (currNumber < 20)
                {
                    numbersFrom10To19++;
                    finalResult += currNumber * 0.3;
                }
                else if (currNumber < 30)
                {
                    numbersFrom20To29++;
                    finalResult += currNumber * 0.4;
                }
                else if (currNumber < 40)
                {
                    numbersFrom30To39++;
                    finalResult += 50;
                }
                else if (currNumber <= 50)
                {
                    numbersFrom40To50++;
                    finalResult += 100;
                }
                else
                {
                    numbersInvalid++;
                    finalResult /= 2;
                }
            }

            //output
            //•	1ви ред: "{Краен резултат}"
            Console.WriteLine($"{finalResult:F2}");
            //•	2ри ред: "From 0 to 9: {процент в интервала}%"
            Console.WriteLine($"From 0 to 9: {numbersFrom0To9 / moves * 100:F2}%");
            //•	3ти ред: "From 10 to 19: {процент в интервала}%"
            Console.WriteLine($"From 10 to 19: {numbersFrom10To19 / moves * 100:F2}%");
            //•	4ти ред: "From 20 to 29: {процент в интервала}%"
            Console.WriteLine($"From 20 to 29: {numbersFrom20To29 / moves * 100:F2}%");
            //•	5ти ред: "From 30 to 39: {процент в интервала}%"
            Console.WriteLine($"From 30 to 39: {numbersFrom30To39 / moves * 100:F2}%");
            //•	6ти ред: "From 40 to 50: {процент в интервала}%"
            Console.WriteLine($"From 40 to 50: {numbersFrom40To50 / moves * 100:F2}%");
            //•	7ми ред: "Invalid numbers: {процент в интервала}%"
            Console.WriteLine($"Invalid numbers: {numbersInvalid / moves * 100:F2}%");
            //Всички числа трябва да са форматирана до вторият знак след запетаята.

        }
    }
}
