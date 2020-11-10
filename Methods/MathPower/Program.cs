using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double realNumber = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(GetNumberRaisedToPower(realNumber, power));
        }

        static double GetNumberRaisedToPower(double realNumber, int power)
        {
            return Math.Pow(realNumber, power);
        }
    }
}
