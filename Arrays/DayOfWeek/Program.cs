using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter a day number [1…7] and print the name (in English) or "Invalid day!"
            string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            int dayNumber = int.Parse(Console.ReadLine());
            if (0 < dayNumber && dayNumber < 8 )
            {
                Console.WriteLine(dayOfWeek[dayNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
