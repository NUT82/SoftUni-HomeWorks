using System;

namespace _006
{
    class Program
    {
        static void Main(string[] args)
        {
            int flight = int.Parse(Console.ReadLine());
            string flightName = "";
            int maxAvgPassengers = 0;
            string flighWithMaxSum = "";

            for (int i = 1; i <= flight; i++)
            {
                flightName = Console.ReadLine();

                int sum = 0;

                int count = 0;
                while (true)
                {
                    string passengers = Console.ReadLine();
                    if (passengers == "Finish")
                    {
                        break;
                    }
                    else
                    {
                        int number = int.Parse(passengers);
                        count++;
                        sum += number;
                    }
                }

                int avgPassengers = sum / count;
                Console.WriteLine($"{flightName}: {avgPassengers} passengers.");

                if (avgPassengers > maxAvgPassengers)
                {
                    maxAvgPassengers = avgPassengers;
                    flighWithMaxSum = flightName;
                }
            }

            Console.WriteLine($"{flighWithMaxSum} has most passengers per flight: {maxAvgPassengers}");
        }
    }
}
