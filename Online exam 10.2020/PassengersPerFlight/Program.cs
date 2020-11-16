using System;

namespace PassengersPerFlight
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxAvgPassengers = 0;
            string nameOfAirlineWithMaxAvgPassengers = "";
            int airlines = int.Parse(Console.ReadLine());

            for (int i = 0; i < airlines; i++)
            {
                int passengersCurrAirline = 0;
                string nameOfAirline = Console.ReadLine();
                string input = Console.ReadLine();
                int counter = 0;

                while (input != "Finish")
                {
                    int currPassengers = int.Parse(input);
                    passengersCurrAirline += currPassengers;
                    counter++;
                    input = Console.ReadLine();
                }
                int avgPassengers = passengersCurrAirline / counter;
                Console.WriteLine($"{nameOfAirline}: {avgPassengers} passengers.");

                if (avgPassengers > maxAvgPassengers)
                {
                    maxAvgPassengers = avgPassengers;
                    nameOfAirlineWithMaxAvgPassengers = nameOfAirline;
                }
            }

            Console.WriteLine($"{nameOfAirlineWithMaxAvgPassengers} has most passengers per flight: {maxAvgPassengers}");
        }
    }
}
