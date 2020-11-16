using System;

namespace moon
{
    class Program
    {
        static void Main(string[] args)
        {
            double avgSpeed = double.Parse(Console.ReadLine());
            double litresPer100Km = double.Parse(Console.ReadLine());

            double timeForGoAndBack = Math.Ceiling(768800 / avgSpeed) + 3;
            double litres = (litresPer100Km * 768800) / 100;

            Console.WriteLine($"{timeForGoAndBack}");
            Console.WriteLine($"{litres}");
        }
    }
}
