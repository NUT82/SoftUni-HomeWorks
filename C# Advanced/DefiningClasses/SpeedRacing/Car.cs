using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {

        public Car()
        {
            DistanceTraveled = 0;
        }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
            :this()
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double DistanceTraveled { get; set; }

        internal void Drive(int amountOfKm)
        {
            if (FuelAmount >= amountOfKm * FuelConsumptionPerKilometer)
            {
                DistanceTraveled += amountOfKm;
                FuelAmount -= amountOfKm * FuelConsumptionPerKilometer;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
