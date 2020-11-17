using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> timesOfCars = Console.ReadLine().Split().Select(int.Parse).ToList();
            int count = timesOfCars.Count - 1;
            double timeLeftCar = 0;
            double timeRightCar = 0;

            for (int i = 0; i < count; i++, count--)
            {
                if (timesOfCars[i] == 0)
                {
                    timeLeftCar -= timeLeftCar * 0.2;
                }

                if (timesOfCars[count] == 0)
                {
                    timeRightCar -= timeRightCar * 0.2;
                }

                timeLeftCar += timesOfCars[i];
                timeRightCar += timesOfCars[count];
            }

            if (timeLeftCar < timeRightCar)
            {
                Console.WriteLine($"The winner is left with total time: {timeLeftCar}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {timeRightCar}");
            }
        }
    }
}
