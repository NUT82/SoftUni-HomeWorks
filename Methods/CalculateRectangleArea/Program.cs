using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());

            double rectArea = GetRectangleArea(numberOne, numberTwo);
            Console.WriteLine(rectArea);
        }

        static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
