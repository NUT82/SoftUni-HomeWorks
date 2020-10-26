using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double distanceInM = double.Parse(Console.ReadLine());
            double timeInSecForOneM = double.Parse(Console.ReadLine());

            double distaceinSeconds = distanceInM * timeInSecForOneM;
            double resistance = Math.Floor(distanceInM / 15) * 12.5;

            double SumTime = distaceinSeconds + resistance;

            if (SumTime < recordInSec)
            {
                string time = ($"{SumTime:f2}");
                Console.WriteLine($"Yes, he succeeded! The new world record is {time} seconds.");
            }
            else
            {
                double secondsLower = SumTime - recordInSec;
                string time = ($"{secondsLower:f2}");
                Console.WriteLine($"No, he failed! He was {time} seconds slower.");
            }

        }
    }
}