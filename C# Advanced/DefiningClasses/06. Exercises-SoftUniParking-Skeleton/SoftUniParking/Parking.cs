using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        public Parking(int capacity)
        {
            Cars = new Dictionary<string, Car>(capacity);
            Parking.capacity = capacity;
        }

        static int capacity;
        public Dictionary<string, Car> Cars { get; set; }

        public int Count { get; set; }

        public string AddCar(Car car)
        {
            if (Cars.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }

            if (capacity == Cars.Count)
            {
                return "Parking is full!";
            }

            Cars.Add(car.RegistrationNumber, car);
            Count++;
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string registrationNumber)
        {
            if (Cars.Remove(registrationNumber))
            {
                Count--;
                return $"Successfully removed {registrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }

        public Car GetCar(string registrationNumber)
        {
            return Cars[registrationNumber];
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (string item in registrationNumbers)
            {
                if (Cars.Remove(item))
                {
                    Count--;
                }
            }
        }
    }
}
