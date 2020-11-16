using System;

namespace ProgramingBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForOnePage = double.Parse(Console.ReadLine());
            double priceForOneCover = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            double priceForDesign = double.Parse(Console.ReadLine());
            int percentPayFromTeam = int.Parse(Console.ReadLine());

            double priceForAllPages = priceForOnePage * 899;
            double priceForCovers = priceForOneCover * 2;
            double priceForBook = priceForAllPages + priceForCovers;
            priceForBook -= priceForBook * (discount / 100.00);
            double neededMoney = priceForBook + priceForDesign;
            neededMoney -= neededMoney * (percentPayFromTeam / 100.00);

            Console.WriteLine($"Avtonom should pay {neededMoney:F2} BGN.");

        }
    }
}
