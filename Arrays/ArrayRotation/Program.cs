using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that receives an array and number of rotations you have to perform (first element goes at the end) Print the resulting array.
            string[] line = Console.ReadLine().Split();
            int numberOfRotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfRotations; i++)
            {
                string firstElement = line[0];
                line = line.TakeLast(line.Length - 1).ToArray();
                line = line.Append(firstElement).ToArray();
            }
            Console.WriteLine(string.Join(" ", line));
        }
    }
}
