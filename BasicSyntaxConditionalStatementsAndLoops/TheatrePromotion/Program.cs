using System;

namespace TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int priceOfTicket = 0;

            if (0 > age || age > 122)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                switch (typeOfDay)
                {
                    case "Weekday":
                        priceOfTicket = 12;
                        if (18 < age && age <= 64)
                        {
                            priceOfTicket = 18;
                        }
                        break;
                    case "Weekend":
                        priceOfTicket = 15;
                        if (18 < age && age <= 64)
                        {
                            priceOfTicket = 20;
                        }
                        break;
                    case "Holiday":
                        priceOfTicket = 12;
                        if (age <= 18)
                        {
                            priceOfTicket = 5;
                        }
                        else if (age > 64)
                        {
                            priceOfTicket = 10;
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine(priceOfTicket + "$");
            }
        }
    }
}
