using System;
using System.Linq;
using System.Text;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program which creates 2 arrays. You will be given an integer n. On the next n lines you get 2 integers. Form 2 arrays as shown below.
            int numbersOfLines = int.Parse(Console.ReadLine());
            int[] firstArray = new int[numbersOfLines];
            int[] secondArray = new int[numbersOfLines];

            for (int i = 0; i < numbersOfLines; i++)
            {
                int[] currLineArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    firstArray[i] = currLineArray[0];
                    secondArray[i] = currLineArray[1];
                }
                else
                {
                    firstArray[i] = currLineArray[1];
                    secondArray[i] = currLineArray[0];
                }
            }
            
            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
