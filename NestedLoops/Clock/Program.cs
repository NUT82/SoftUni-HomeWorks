using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която отпечатва часовете в денонощието от 0:0 до 23:59, всеки на отделен ред. Часовете трябва да се изписват във формат "{час}:{минути}".
            for (int i = 0; i < 24; i++)
            {
                for (int a = 0; a < 60; a++)
                {
                    Console.WriteLine($"{i}:{a}");
                }
            }
        }
    }
}
