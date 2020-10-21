using System;

namespace WorkingHours
{
    class Program
    {
        static void Main()
        {
            //Да се напише програма, която чете час от денонощието(цяло число) и ден от седмицата(текст) - въведени от потребителя и проверява дали офисът на фирма е отворен, като работното време на офисът е от 10-18 часа, от понеделник до събота включително
            const int openHour = 10;
            const int closeHour = 18;

            int hour = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            if (dayOfWeek != "Sunday" && hour >= openHour && hour <= closeHour)
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
            
        }
    }
}
