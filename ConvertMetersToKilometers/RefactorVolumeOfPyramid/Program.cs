using System;

namespace RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given a working code that finds the volume of a pyramid. However, you should consider that the variables exceed their optimum span and have improper naming. Also, search for variables that have multiple purpose.
            Console.Write("Length: ");
            double lengthOfPiramid = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double widthOfPiramid = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double heightOfPiramid = double.Parse(Console.ReadLine());
            double volumeOfPiramid = (lengthOfPiramid * widthOfPiramid * heightOfPiramid) / 3;
            Console.Write($"Pyramid Volume: {volumeOfPiramid:f2}");
        }
    }
}
