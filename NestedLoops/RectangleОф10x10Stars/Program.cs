using System;

namespace RectangleOf10x10Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чертае на конзолата правоъгълник от 10 x 10 звездички.
            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < 10; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
