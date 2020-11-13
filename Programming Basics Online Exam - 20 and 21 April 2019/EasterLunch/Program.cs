using System;

namespace EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBread = int.Parse(Console.ReadLine());
            int eggs = int.Parse(Console.ReadLine());
            int cookies = int.Parse(Console.ReadLine());

            
            double easterBreadPrice = easterBread * 3.2;
            double egsPrice = eggs * 4.35;
            double cookiesPrice = cookies * 5.4;
            double paintForEggs = eggs * 12 * 0.15;

            double moneyNeeded = easterBreadPrice + egsPrice + cookiesPrice + paintForEggs;

            Console.WriteLine($"{moneyNeeded:F2}");
        }
    }
}
