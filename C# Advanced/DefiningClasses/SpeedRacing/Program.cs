using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionFor1km = double.Parse(input[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);
                cars.Add(model, car);
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] splitCommand = command.Split();
                string carModel = splitCommand[1];
                int amountOfKm = int.Parse(splitCommand[2]);

                cars[carModel].Drive(amountOfKm);

                command = Console.ReadLine();
            }

            foreach (var currCar in cars)
            {
                Console.WriteLine($"{currCar.Key} {currCar.Value.FuelAmount:F2} {currCar.Value.DistanceTraveled}");
            }
        }
    }
}
