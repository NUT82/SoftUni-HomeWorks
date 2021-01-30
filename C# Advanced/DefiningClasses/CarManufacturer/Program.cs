﻿using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Tire[] tires = new Tire[2]
            {
                new Tire(1, 2.5),
                new Tire(2, 2.3)
            };

            Engine engine = new Engine(560, 6300);

            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires);
        }
    }
}
