using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberÒfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>(numberÒfCars);
            for (int i = 0; i < numberÒfCars; i++)
            {
                string[] currLine = Console.ReadLine().Split();
                Engine engine = new Engine(int.Parse(currLine[1]), int.Parse(currLine[2]));
                Cargo cargo = new Cargo(int.Parse(currLine[3]), currLine[4]);
                Car car = new Car(currLine[0], engine, cargo);

                cars.Add(car);
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                Console.WriteLine(string.Join(Environment.NewLine, cars.Where(c => c.CarCargo.CargoType == command && c.CarCargo.CargoWeght < 1000)));
            }
            else // flamable
            {
                Console.WriteLine(string.Join(Environment.NewLine, cars.Where(c => c.CarCargo.CargoType == command && c.CarEngine.EnginePower > 250)));
            }
        }
    }

    public class Engine
    {
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }

        public Engine(int speed, int power)
        {
            EngineSpeed = speed;
            EnginePower = power;
        }
    }

    public class Cargo
    {
        public int CargoWeght { get; set; }
        public string CargoType { get; set; }

        public Cargo(int weight, string type)
        {
            CargoWeght = weight;
            CargoType = type;
        }
    }

    public class Car
    {
        public string Name { get; set; }
        public Engine CarEngine { get; set; }
        public Cargo CarCargo { get; set; }

        public Car(string name, Engine engine, Cargo cargo)
        {
            Name = name;
            CarEngine = engine;
            CarCargo = cargo;
        }

        public override string ToString()
        {
            return this.Name; 
        }
    }
}
