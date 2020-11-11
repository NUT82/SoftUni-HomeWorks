using System;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] coordinatesX = new double[4];
            double[] coordinatesY = new double[4];
            for (int i = 0; i < 4; i++)
            {
                coordinatesX[i] = double.Parse(Console.ReadLine());
                coordinatesY[i] = double.Parse(Console.ReadLine());
            }

            int longerLine = 0;
            if (GetLengthBtwTwoPoints(coordinatesX[0], coordinatesY[0], coordinatesX[1], coordinatesY[1]) < GetLengthBtwTwoPoints(coordinatesX[2], coordinatesY[2], coordinatesX[3], coordinatesY[3]))
            {
                longerLine = 2;
            }

            PrintClosestToCenterPoint(coordinatesX[0 + longerLine], coordinatesY[0 + longerLine], coordinatesX[1 + longerLine], coordinatesY[1 + longerLine]);
        }

        private static double GetLengthBtwTwoPoints(double x1, double y1, double x2, double y2)
        {
            double length = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return length;
        }

        private static void PrintClosestToCenterPoint(double x1, double y1, double x2, double y2)
        {
            double firstPointToCenter = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double secondPointToCenter = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            if (firstPointToCenter <= secondPointToCenter)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}
