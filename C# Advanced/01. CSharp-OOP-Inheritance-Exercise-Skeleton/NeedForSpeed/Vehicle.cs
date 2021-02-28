using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }
        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public double DefaultFuelConsumption { get; set; } = 1.25;
        public virtual double FuelConsumption => DefaultFuelConsumption / 100;

        public virtual void Drive(double kilometers)
        {
            if (kilometers * FuelConsumption > Fuel)
            {
                Console.WriteLine($"Not enough fuel to drive {kilometers} kilometers!");
            }
            else
            {
                Fuel -= kilometers * FuelConsumption;
                Console.WriteLine($"{GetType().Name} drive {kilometers} kilometers!");
            }
        }

        public override string ToString()
        {
            return $"{GetType().Name} has {Fuel} l. fuel left";
        }
    }
}
