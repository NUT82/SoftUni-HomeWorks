using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            long days = Math.Abs(DateModifier.DaysBetween(firstDate, secondDate));

            Console.WriteLine(days);
        }
    }
}
