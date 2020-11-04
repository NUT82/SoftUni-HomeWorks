using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which calculates the volume of n beer kegs. You will receive in total 3 * n lines. Each three lines will hold information for a single keg. First up is the model of the keg, after that is the radius of the keg, and lastly is the height of the keg.

            double biggestVolume = double.MinValue;
            string biggestKegModel = "";

            //input
            //You will receive 3 * n lines. Each group of lines will be on a new line:
            int countOfBeerKegs = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfBeerKegs; i++)
            {
                string model = Console.ReadLine(); //•	First – model – string.
                double radius = double.Parse(Console.ReadLine()); //•	Second –radius – floating-point number
                int height = int.Parse(Console.ReadLine()); //•	Third – height – integer number
                double volumeOfCurrKeg = Math.PI * Math.Pow(radius, 2) * height; //Calculate the volume using the following formula: π * r^2 * h.
                if (volumeOfCurrKeg > biggestVolume)
                {
                    biggestVolume = volumeOfCurrKeg;
                    biggestKegModel = model;
                }
            }
            Console.WriteLine(biggestKegModel); //At the end, print the model of the biggest keg.
        }
    }
}
