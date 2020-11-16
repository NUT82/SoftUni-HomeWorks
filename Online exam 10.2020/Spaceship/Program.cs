using System;

namespace Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double widthOfShip = double.Parse(Console.ReadLine());
            double lengthOfShip = double.Parse(Console.ReadLine());
            double heightOfShip = double.Parse(Console.ReadLine());
            double avgHeightOfAstro = double.Parse(Console.ReadLine());

            double shipVolume = widthOfShip * lengthOfShip * heightOfShip;
            double volumeOfRoomForAstro = 2 * 2 * (avgHeightOfAstro + 0.4);
            int astro = (int)Math.Floor(shipVolume / volumeOfRoomForAstro);

            if (astro < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (astro > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
            else
            {
                Console.WriteLine($"The spacecraft holds {astro} astronauts.");
            }
        }
    }
}
