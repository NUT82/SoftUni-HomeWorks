using System;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете цяло число n (1 ≤ n ≤ 100), въведено от потребителя, и печата диамант с размер n като в примерите по-долу:
            int n = int.Parse(Console.ReadLine());
            int leftRight = (n - 1) / 2;
            int mid = n - 2 * leftRight - 2;
            int allRows = n - 1;
            if (n % 2 != 0)
            {
                allRows = n;
            }

            for (int rows = 1; rows <= allRows; rows++)
            {
                for (int minus = 1; minus <= Math.Abs(leftRight); minus++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                if (mid > 0)
                {
                    for (int minus = 1; minus <= mid; minus++)
                    {
                        Console.Write("-");
                    }
                }
                else if (mid == 0)
                {
                    Console.Write("*");
                }
                if (rows != 1 && rows != allRows)
                {
                Console.Write("*");
                }
                for (int minus = 1; minus <= Math.Abs(leftRight); minus++)
                {
                    Console.Write("-");
                }
                leftRight--;
                mid = n - 2 * Math.Abs(leftRight) - 2;
                Console.WriteLine();
            }
            //•	Всички редове съдържат точно по n символа.
            //•	Първият ред съдържа отляво и отдясно точно leftRight = (n - 1) / 2 тирета.
            //•	Всеки следващ ред до средния съдържа отляво и отдясно с 1 тире по-малко от предходния.
            //•	Всеки следващ ред след средния съдържа отляво и отдясно с 1 тире повече от предходния.
            //•	Всеки ред съдържа в средата си (във вътрешността на диаманта) mid = n - 2 * leftRight - 2 тирета.
            //•	Всеки ред съдържа 2 звездички, освен когато mid е отрицателно (тогава има само 1 звездичка).
            //•	За всеки ред може да се изчислят и отпечатат неговите 5 съставни части:
            //o	leftRight тиренца отляво
            //o	1 звездичка
            //o	mid тиренца в средата (когато mid >= 0)
            //o	1 звездичка (когато mid < 0)
            //o	2 звездички (когато mid = 0)
            //o	leftRight тиренца отляво

        }
    }
}
