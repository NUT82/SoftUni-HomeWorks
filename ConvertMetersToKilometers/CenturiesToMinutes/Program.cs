using System;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write program to enter an integer number of centuries and convert it to years, days, hours and minutes.
            const double daysInYear = 365.2422;
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(years * daysInYear);
            long hours = days * 24L;
            long minutes = hours * 60L;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
