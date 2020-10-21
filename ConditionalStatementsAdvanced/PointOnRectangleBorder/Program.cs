using System;

namespace PointOnRectangleBorder
{
    class Program
    {
        static void Main()
        {
            //Напишете програма, която проверява дали точка {x, y} се намира върху някоя от страните на правоъгълник {x1, y1} – {x2, y2}. Входните данни се четат от конзолата и се състоят от 6 реда въведени от потребителя: десетичните числа x1, y1, x2, y2, x и y (като се гарантира, че x1 < x2 и y1 < y2). Да се отпечата "Border" (точката лежи на някоя от страните) или "Inside / Outside" (в противен случай). 

            //input
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if ((x >= x1 && x <= x2) && (y == y1 || y == y2))
            {
                Console.WriteLine("Border");
            }
            else if ((y >= y1 && y <= y2) && (x == x1 || x == x2))
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
