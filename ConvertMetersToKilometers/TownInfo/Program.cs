using System;

namespace TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given 3 lines of input. On the first line you will be given the name of the town, on the second – the population and on the third the area. Use the correct data types and print the result in the following format:
            //"Town {town name} has population of {population} and area {area} square km".
            string nameOfTown = Console.ReadLine();
            uint population = uint.Parse(Console.ReadLine());
            uint area = uint.Parse(Console.ReadLine());
            Console.WriteLine($"Town {nameOfTown} has population of {population} and area {area} square km.");
        }
    }
}
