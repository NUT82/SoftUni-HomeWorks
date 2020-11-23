using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Catalog> catalogs = new List<Catalog>();

            string inputLine = Console.ReadLine();
            
            while (inputLine != "End")
            {
                string[] currLine = inputLine.Split(" ");
                string typeOfVehicle = currLine[0];
                string modelOfVehicle = currLine[1];
                string colorOfVehicle = currLine[2];
                int horsePowerOfVehicle = int.Parse(currLine[3]);
                Catalog catalog = new Catalog();

                switch (typeOfVehicle)
                {
                    case "car":
                        Car car = new Car(modelOfVehicle, colorOfVehicle, horsePowerOfVehicle);
                        catalog = new Catalog(car);
                        break;
                    case "truck":
                        Truck truck = new Truck(modelOfVehicle, colorOfVehicle, horsePowerOfVehicle);
                        catalog = new Catalog(truck);
                        break;
                    default:
                        break;


                }

                catalogs.Add(catalog);
                inputLine = Console.ReadLine();
            }

            string searchedModel = Console.ReadLine();
            while (searchedModel != "Close the Catalogue")
            {
                foreach (Catalog catalog in catalogs.Where(x => (x.Car != null && x.Car.Model == searchedModel) || (x.Truck != null && x.Truck.Model == searchedModel)))
                {
                    
                    if (catalog.Car != null)
                    {
                        Console.WriteLine($"Type: Car");
                        catalog.Car.PrintAllProperty();
                    }
                    else
                    {
                        Console.WriteLine($"Type: Truck");
                        catalog.Truck.PrintAllProperty();
                    }
                }
                searchedModel = Console.ReadLine();
            }

            PrintAverageHorsePower("Cars", catalogs);
            PrintAverageHorsePower("Trucks", catalogs);
        }

        private static void PrintAverageHorsePower(string typeOfVehicle, List<Catalog> catalogs)
        {
            double avgHorsePower = 0;
            int count = 0;
            if (typeOfVehicle == "Cars")
            {
                foreach (Catalog catalog in catalogs.Where(x => x.Car != null))
                {
                    count++;
                    avgHorsePower += catalog.Car.HorsePower;
                }

                if (count == 0)
                {
                    count = 1;
                }
                avgHorsePower /= count;
                //avgHorsePower = Math.Round(avgHorsePower, 2);
                Console.WriteLine($"{typeOfVehicle} have average horsepower of: {avgHorsePower:F2}.");
            }
            else
            {
                foreach (Catalog catalog in catalogs.Where(x => x.Truck != null))
                {
                    count++;
                    avgHorsePower += catalog.Truck.HorsePower;
                }

                if (count == 0)
                {
                    count = 1;
                }
                avgHorsePower /= count;
                //avgHorsePower = Math.Round(avgHorsePower, 2);
                Console.WriteLine($"{typeOfVehicle} have average horsepower of: {avgHorsePower:F2}.");
            }
            
        }
    }

    class Truck
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        

        public Truck(string model, string color, int horsePower)
        {
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }

        public Truck()
        {

        }

        public void PrintAllProperty()
        {
            Console.WriteLine($"Model: {this.Model}");
            Console.WriteLine($"Color: {this.Color}");
            Console.WriteLine($"Horsepower: {this.HorsePower}");
        }
    }

    class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public Car(string model, string color, int horsePower)
        {
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }

        public Car()
        {

        }

        public void PrintAllProperty()
        {
            Console.WriteLine($"Model: {this.Model}");
            Console.WriteLine($"Color: {this.Color}");
            Console.WriteLine($"Horsepower: {this.HorsePower}");
        }
    }

    class Catalog
    {
        public Truck Truck { get; set; }
        public Car Car { get; set; }

        public Catalog(Truck truck)
        {
            this.Truck = truck;
            //this.Car = new Car();
        }

        public Catalog(Car car)
        {
            this.Car = car;
            //this.Truck = new Truck();
        }

        public Catalog()
        {
            
            
        }
    }
}
