using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Отпечатайте на конзолата таблицата за умножение за числата от 1 до 10 във формат: 
            //"{първи множител} * {втори множител} = {резултат}".
            for (int i = 1; i <= 10; i++)
            {
                for (int a = 1; a <= 10; a++)
                {
                    Console.WriteLine($"{i} * {a} = {i * a}");
                }
            }
        }
    }
}
