using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете цяло число n, въведено от потребителя, и отпечатва пирамида от числа като в примерите:
            int number = int.Parse(Console.ReadLine());
            int row = 1;
            int i = 1;
            while (i <= number)
            {
                for (int a = 0; a < row; a++)
                {
                    if (i <= number)
                    {
                        Console.Write(i + " ");
                        i++;
                    }
                }
                Console.WriteLine();
                row += 1;
            }
        }
    }
}
