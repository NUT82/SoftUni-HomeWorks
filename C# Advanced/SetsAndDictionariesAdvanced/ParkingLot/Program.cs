using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carsNumbers = new HashSet<string>();
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] split = command.Split(", ");
                string carNumber = split[1];
                if (split[0] == "IN")
                {
                    carsNumbers.Add(carNumber);
                }
                else
                {
                    if (carsNumbers.Contains(carNumber))
                    {
                        carsNumbers.Remove(carNumber);
                    }
                }
                command = Console.ReadLine();
            }

            if (carsNumbers.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, carsNumbers));
            }
        }
    }
}
