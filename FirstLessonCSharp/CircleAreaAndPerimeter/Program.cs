using System;

namespace CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата число r и пресмята и отпечатва лицето и периметъра на кръг / окръжност с радиус r, като форматирате изхода в следния вид: "<calculated area>"
            //"<calculated parameter>".Форматирайте изходните данни до втория знак след десетичната запетая.
            double radius = double.Parse(Console.ReadLine());

            //Calculations with formulas: P=π.d=2.π.r ; S=π.r2
            double calculatedArea = Math.PI * Math.Pow(radius,2);
            double calculatedPerimeter = Math.PI * radius * 2;

            //Output
            Console.WriteLine($"{calculatedArea:F2}");
            Console.WriteLine($"{calculatedPerimeter:F2}");

        }
    }
}
