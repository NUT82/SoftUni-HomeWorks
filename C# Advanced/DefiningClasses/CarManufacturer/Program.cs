using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            {
                string command = Console.ReadLine();
                while (command != "No more tires")
                {
                    string[] splitCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    Tire[] currTires = new Tire[splitCommand.Length / 2];
                    for (int i = 0; i < splitCommand.Length; i+= 2)
                    {
                        int year = int.Parse(splitCommand[i]);
                        double presssure = double.Parse(splitCommand[i + 1]);
                        Tire tire = new Tire(year, presssure);
                        currTires[i / 2] = tire;
                    }

                    
                    tires.Add(currTires);

                    command = Console.ReadLine();
                }
            }

            List<Engine> engines = new List<Engine>();
            {
                string command = Console.ReadLine();
                while (command != "Engines done")
                {
                    string[] splitCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    int horsePower = int.Parse(splitCommand[0]);
                    double cubicCapacity = double.Parse(splitCommand[1]);
                    Engine engine = new Engine(horsePower, cubicCapacity);
                    engines.Add(engine);

                    command = Console.ReadLine();
                }
            }

            List<Car> cars = new List<Car>();
            {
                string command = Console.ReadLine();
                while (command != "Show special")
                {
                    string[] splitCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    Car car = new Car(splitCommand[0], splitCommand[1], int.Parse(splitCommand[2]), double.Parse(splitCommand[3]), double.Parse(splitCommand[4]), engines[int.Parse(splitCommand[5])], tires[int.Parse(splitCommand[6])]);
                        cars.Add(car);

                    command = Console.ReadLine();
                }
            }

            Func<int, int, double, bool> specialCar = (year, horsePower, pressure) =>
            {
                if (year >= 2017 && horsePower > 330 && 9 <= pressure && pressure <= 10)
                {
                    return true;
                }

                return false;
            };

            List<Car> specialCars = cars.Where(c => specialCar(c.Year, c.Engine.HorsePower, c.Tires.Sum(y => y.Pressure))).ToList();
            foreach (Car car in specialCars)
            {
                car.Drive(20);
                Console.WriteLine(car.WhoAmI());
            }

        }
    }
}
