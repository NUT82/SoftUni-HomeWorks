using System;

namespace CinemaTicket
{
    class Program
    {
        static void Main()
        {
            //Да се напише програма която чете ден от седмицата (текст) – въведен от потребителя и принтира на конзолата цената на билет за кино според деня от седмицата:
            string dayOfWeek = Console.ReadLine();
            int priceOfTicket = 0;

            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    priceOfTicket = 12;
                    break;
                case "Wednesday":
                case "Thursday":
                    priceOfTicket = 14;
                    break;
                case "Saturday":
                case "Sunday":
                    priceOfTicket = 16;
                    break;
                default:
                    break;
            }
            Console.WriteLine(priceOfTicket);
        }
    }
}
