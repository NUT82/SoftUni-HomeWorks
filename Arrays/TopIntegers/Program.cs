using System;
using System.Linq;
using System.Text;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to find all the top integers in an array. A top integer is an integer which is bigger than all the elements to its right. 
            int[] arrayOfIntegers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < arrayOfIntegers.Length - 1; i++)
            {
                bool isBigger = true;
                for (int j = i + 1; j < arrayOfIntegers.Length; j++)
                {
                    if (arrayOfIntegers[i] <= arrayOfIntegers[j])
                    {
                        isBigger = false;
                        break;
                    }
                }
                if (isBigger)
                {
                    output.Append(arrayOfIntegers[i] + " ");
                }
            }
            output.Append(arrayOfIntegers[arrayOfIntegers.Length - 1]);
            Console.WriteLine(output);
        }
    }
}
