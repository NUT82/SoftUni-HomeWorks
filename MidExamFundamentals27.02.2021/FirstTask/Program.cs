using System;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalPrice = 0;
            int orders = int.Parse(Console.ReadLine());
            for (int i = 0; i < orders; i++)
            {
                double currPricePerCapsule = double.Parse(Console.ReadLine()); //0.00 ... 1000.00
                int currDays = int.Parse(Console.ReadLine()); // 1..31
                int currCountOfCapsules = int.Parse(Console.ReadLine()); //0..2000

                double currPrice = currDays * currCountOfCapsules * currPricePerCapsule;
                totalPrice += currPrice; 
                Console.WriteLine($"The price for the coffee is: ${currPrice:F2}");
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
