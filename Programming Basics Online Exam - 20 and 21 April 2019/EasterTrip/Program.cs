using System;

namespace EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceForTrip = 0;

            switch (destination)
            {
                case "France":
                    priceForTrip = nights * 30;
                    if (dates == "24-27")
                    {
                        priceForTrip = nights * 35;
                    }
                    else if (dates == "28-31")
                    {
                        priceForTrip = nights * 40;
                    }
                    break;
                    case "Italy":
                    priceForTrip = nights * 28;
                    if (dates == "24-27")
                    {
                        priceForTrip = nights * 32;
                    }
                    else if (dates == "28-31")
                    {
                        priceForTrip = nights * 39;
                    }
                    break;
                    case "Germany":
                    priceForTrip = nights * 32;
                    if (dates == "24-27")
                    {
                        priceForTrip = nights * 37;
                    }
                    else if (dates == "28-31")
                    {
                        priceForTrip = nights * 43;
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Easter trip to {destination} : {priceForTrip:F2} leva.");
        }
    }
}
