using System;
using System.Globalization;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете число n (2 ≤ n ≤ 100), въведено от потребителя, и печата къщичка с размер n x n:
            int n = int.Parse(Console.ReadLine());
            //•	Отпечатайте в цикъл покрива на къщичката:
            //o	Той съдържа (n + 1) / 2 реда.
            //o	На първия си ред съдържа 1 звездичка при нечетно n или 2 звездички при четно n.
            //o	На всеки следващ ред съдържа с 2 звездички повече.

            //roof
            int starsOnRoof = 1;
            if (n % 2 == 0)
            {
                starsOnRoof = 2;
            }
            for (int firstRow = 1; firstRow <= (n - starsOnRoof) / 2; firstRow++)
            {
                Console.Write("-");
            }
            for (int firstRowStars = 1; firstRowStars <= starsOnRoof; firstRowStars++)
            {
                Console.Write("*");
            }
            for (int firstRow = 1; firstRow <= (n - starsOnRoof) / 2; firstRow++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            for (int rowsRoof = 2; rowsRoof <= (n + 1) / 2; rowsRoof++)
            {
                starsOnRoof += 2;
                for (int minus = 1; minus <= (n - starsOnRoof) / 2; minus++)
                {
                    Console.Write("-");
                }
                for (int Stars = 1; Stars <= starsOnRoof; Stars++)
                {
                    Console.Write("*");
                }
                for (int minus = 1; minus <= (n - starsOnRoof) / 2; minus++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }

            //•	Отпечатайте в цикъл основата на къщичката: n / 2 реда ( при нечетно n / 2 - 1 реда).
            for (int rows = 1; rows <= n / 2; rows++)
            {
                Console.Write("|");
                for (int stars = 1; stars <= n - 2; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("|");
            }
        }
    }
}
