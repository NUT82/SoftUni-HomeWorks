using System;

namespace Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            const double maxPoints = 20;
            string country = Console.ReadLine();
            string device = Console.ReadLine();
            double pointsForDifficulty = 0;
            double pointsForExecution = 0;
            switch (country)
            {
                case "Russia":
                    pointsForDifficulty = 9.6;
                    pointsForExecution = 9;
                    if (device == "ribbon")
                    {
                        pointsForDifficulty = 9.1;
                        pointsForExecution = 9.4;
                    }
                    else if (device == "hoop")
                    {
                        pointsForDifficulty = 9.3;
                        pointsForExecution = 9.8;
                    }
                    break;
                case "Bulgaria":
                    pointsForDifficulty = 9.5;
                    pointsForExecution = 9.4;
                    if (device == "ribbon")
                    {
                        pointsForDifficulty = 9.6;
                        pointsForExecution = 9.4;
                    }
                    else if (device == "hoop")
                    {
                        pointsForDifficulty = 9.55;
                        pointsForExecution = 9.75;
                    }
                    break;
                case "Italy":
                    pointsForDifficulty = 9.7;
                    pointsForExecution = 9.15;
                    if (device == "ribbon")
                    {
                        pointsForDifficulty = 9.2;
                        pointsForExecution = 9.5;
                    }
                    else if (device == "hoop")
                    {
                        pointsForDifficulty = 9.45;
                        pointsForExecution = 9.35;
                    }
                    break;

                default: // wrong country
                    break;
            }

            //output
            Console.WriteLine($"The team of {country} get {pointsForDifficulty + pointsForExecution:F3} on {device}.");
            double percent = (maxPoints - (pointsForDifficulty + pointsForExecution)) / maxPoints *100;
            Console.WriteLine($"{percent:F2}%");
        }
    }
}
