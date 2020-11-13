using System;

namespace EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int paintingEggs = int.Parse(Console.ReadLine());
            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;
            int maxEggsOfColor = 0;
            string colorOfMaxEggs = "";

            for (int i = 0; i < paintingEggs; i++)
            {
                string color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        redEggs++;
                        if (redEggs > maxEggsOfColor)
                        {
                            maxEggsOfColor = redEggs;
                            colorOfMaxEggs = color;
                        }
                        break;
                    case "orange":
                        orangeEggs++;
                        if (orangeEggs > maxEggsOfColor)
                        {
                            maxEggsOfColor = orangeEggs;
                            colorOfMaxEggs = color;
                        }
                        break;
                    case "blue":
                        blueEggs++;
                        if (blueEggs > maxEggsOfColor)
                        {
                            maxEggsOfColor = blueEggs;
                            colorOfMaxEggs = color;
                        }
                        break;
                    case "green":
                        greenEggs++;
                        if (greenEggs > maxEggsOfColor)
                        {
                            maxEggsOfColor = greenEggs;
                            colorOfMaxEggs = color;
                        }
                        break;
                    default:
                        break;
                }

            }

            Console.WriteLine($"Red eggs: {redEggs}");
            Console.WriteLine($"Orange eggs: {orangeEggs}");
            Console.WriteLine($"Blue eggs: {blueEggs}");
            Console.WriteLine($"Green eggs: {greenEggs}");
            Console.WriteLine($"Max eggs: {maxEggsOfColor} -> {colorOfMaxEggs}");
        }
    }
}
