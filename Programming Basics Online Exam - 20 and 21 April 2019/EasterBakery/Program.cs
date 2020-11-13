using System;

namespace EasterBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double flourPrice = double.Parse(Console.ReadLine());
            double flourKg = double.Parse(Console.ReadLine());
            double sugarKg = double.Parse(Console.ReadLine());
            int eggs = int.Parse(Console.ReadLine());
            int packagesYeast = int.Parse(Console.ReadLine());

            double sugarPrice = flourPrice - flourPrice * 0.25;
            double eggsPrice = flourPrice + flourPrice * 0.1;
            double yeastPrice = sugarPrice - sugarPrice * 0.8;

            double moneyNeeded = flourKg * flourPrice + sugarKg * sugarPrice +
                                 eggs * eggsPrice + packagesYeast * yeastPrice;

            Console.WriteLine($"{moneyNeeded:F2}");
        }
    }
}
