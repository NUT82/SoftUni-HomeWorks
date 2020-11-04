using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            //You have a water tank with capacity of 255 liters. On the next n lines, you will receive liters of water, which you have to pour in your tank. If the capacity is not enough, print “Insufficient capacity!” and continue reading the next line. On the last line, print the liters in the tank.
            double capacity = 255;
            
            int countOfInputLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfInputLines; i++)
            {
                double currLitters = double.Parse(Console.ReadLine());
                if (capacity >= currLitters)
                {
                    capacity -= currLitters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(255 - capacity);
        }
    }
}
