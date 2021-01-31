using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine engine = new Engine(input[0], int.Parse(input[1]));
                switch (input.Length)
                {
                    case 4:
                        engine.Displacement = input[2];
                        engine.Efficiency = input[3];
                        break;
                    case 3:
                        if (int.TryParse(input[2], out _))
                        {
                            engine.Displacement = input[2];
                        }
                        else
                        {
                            engine.Efficiency = input[2];
                        }
                        break;
                    default:
                        break;
                }
                engines.Add(engine);
            }

            List<Car> cars = new List<Car>();
            int secondNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < secondNumber; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car(input[0], engines.FirstOrDefault(e => e.Model == input[1]));
                switch (input.Length)
                {
                    case 4:
                        car.Weight = input[2];
                        car.Color = input[3];
                        break;
                    case 3:
                        if (int.TryParse(input[2], out _))
                        {
                            car.Weight = input[2];
                        }
                        else
                        {
                            car.Color = input[2];
                        }
                        break;
                    default:
                        break;
                }
                cars.Add(car);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
