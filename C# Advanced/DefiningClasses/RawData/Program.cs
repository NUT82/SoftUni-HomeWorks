using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];

                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Tire[] tires = new Tire[4];
                for (int j = 0; j < 8; j+= 2)
                {
                    double pressure = double.Parse(input[j + 5]);
                    int year = int.Parse(input[j + 6]);
                    Tire tire = new Tire(pressure, year);
                    tires[j / 2] = tire;
                }

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string command = Console.ReadLine();
            Func<Car, string, bool> filter = (c, command) => c.Cargo.Type == command && c.Engine.Power > 250;
            if (command == "fragile")
            {
                filter = (c, command) => c.Cargo.Type == command && c.Tires.Any(t => t.Pressure < 1);
            }

            foreach (Car car in cars.Where(c => filter(c, command)))
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
