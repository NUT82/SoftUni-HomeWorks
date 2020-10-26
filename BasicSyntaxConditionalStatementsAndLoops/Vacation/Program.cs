using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            decimal totalPrice = 0;
            switch (typeOfGroup)
            {
                case "Students":
                    totalPrice = students * 10.46m;
                    if (dayOfWeek == "Friday")
                    {
                        totalPrice = students * 8.45m;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        totalPrice = students * 9.80m;
                    }
                    if (students >= 30)
                    {
                        totalPrice -= totalPrice * 0.15m;
                    }
                    break;
                case "Business":
                    if (students >= 100)
                    {
                        students -= 10;
                    }
                    totalPrice = students * 16m;
                    if (dayOfWeek == "Friday")
                    {
                        totalPrice = students * 10.90m;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        totalPrice = students * 15.60m;
                    }
                    break;
                case "Regular":
                    totalPrice = students * 22.50m;
                    if (dayOfWeek == "Friday")
                    {
                        totalPrice = students * 15m;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        totalPrice = students * 20m;
                    }
                    if (10 <= students && students <= 20)
                    {
                        totalPrice -= totalPrice * 0.05m;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
