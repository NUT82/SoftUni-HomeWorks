using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double coordinateX1 = double.Parse(Console.ReadLine());
            double coordinateY1 = double.Parse(Console.ReadLine());
            double coordinateX2 = double.Parse(Console.ReadLine());
            double coordinateY2 = double.Parse(Console.ReadLine());

            PrintClosestToCenterPoint(coordinateX1, coordinateY1, coordinateX2, coordinateY2);
        }

        private static void PrintClosestToCenterPoint(double coordinateX1, double coordinateY1, double coordinateX2, double coordinateY2)
        {
            double firstPointToCenter = Math.Sqrt(Math.Pow(coordinateX1, 2) + Math.Pow(coordinateY1, 2));
            double secondPointToCenter = Math.Sqrt(Math.Pow(coordinateX2, 2) + Math.Pow(coordinateY2, 2));
            if (firstPointToCenter <= secondPointToCenter)
            {
                Console.WriteLine($"({coordinateX1}, {coordinateY1})");
            }
            else
            {
                Console.WriteLine($"({coordinateX2}, {coordinateY2})");
            }
        }
    }
}
