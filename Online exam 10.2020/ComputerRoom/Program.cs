using System;

namespace ComputerRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            int hours = int.Parse(Console.ReadLine());
            int persons = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            double discount = 0;
            double discount2 = 0;
            double pricePerPerson = 0;
            double priceForVisit = 0;

            if (persons >= 4)
            {
                discount = 0.1;
            }

            if (hours >= 5)
            {
                discount2 = 0.5;
            }

            switch (mounth)
            {
                case "march":
                case "april":
                case "may":
                    pricePerPerson = 8.4;
                    if (timeOfDay == "day")
                    {
                        pricePerPerson = 10.50;
                    }
                    break;
                case "june":
                case "july":
                case "august":
                    pricePerPerson = 10.20;
                    if (timeOfDay == "day")
                    {
                        pricePerPerson = 12.60;
                    }
                    break;
                default:
                    break;
            }

            pricePerPerson -= pricePerPerson * discount;
            pricePerPerson -= pricePerPerson * discount2;
            priceForVisit = pricePerPerson * hours * persons;

            Console.WriteLine($"Price per person for one hour: {pricePerPerson:F2}");
            Console.WriteLine($"Total cost of the visit: {priceForVisit:F2}");
        }
    }
}
