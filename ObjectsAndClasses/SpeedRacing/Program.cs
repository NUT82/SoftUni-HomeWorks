using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>(numberOfCars);
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] line = Console.ReadLine().Split();
                Car car = new Car(line[0], double.Parse(line[1]), double.Parse(line[2]));
                cars.Add(car);
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] currCommand = command.Split();
                string modelOfCarToDrive = currCommand[1];
                double amountOfKmToDrive = double.Parse(currCommand[2]);
                bool isEnoughFuel = Car.MoveCar(cars.FirstOrDefault(x => x.Model == modelOfCarToDrive), amountOfKmToDrive);

                if (!isEnoughFuel)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                command = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }

    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKm { get; set; }
        public double TraveledDistance { get; set; }

        public Car(string model, double fuel, double consumtion)
        {
            Model = model;
            FuelAmount = fuel;
            FuelConsumptionPerKm = consumtion;
        }

        internal static bool MoveCar(Car car, double distance)
        {
            if (car.FuelAmount >= distance * car.FuelConsumptionPerKm)
            {
                car.FuelAmount -= distance * car.FuelConsumptionPerKm;
                car.TraveledDistance += distance;
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:F2} {TraveledDistance}";
        }
    }
}
