using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {

            BigInteger maxSnowballValue = 0;
            ushort maxSnowballSnow = 0;
            ushort maxSnowballTime = 1;
            byte maxSnowballQuality = 0;

            //input
            //•	On the first input line you will receive N – the number of snowballs.
            byte numberOfSnowballs = byte.Parse(Console.ReadLine());
            //•	On the next N *3 input lines you will be receiving data about snowballs.
            for (int i = 0; i < numberOfSnowballs; i++)
            {
                ushort snowballSnow = ushort.Parse(Console.ReadLine());
                ushort snowballTime = ushort.Parse(Console.ReadLine());
                byte snowballQuality = byte.Parse(Console.ReadLine());
                BigInteger snowballValue = 1;
                //For each snowball you must calculate its snowballValue by the following formula:(snowballSnow / snowballTime) ^ snowballQuality
                for (int j = 0; j < snowballQuality; j++)
                {
                    snowballValue *= snowballSnow / snowballTime;
                }
                if (snowballValue > maxSnowballValue)
                {
                    maxSnowballValue = snowballValue;
                    maxSnowballSnow = snowballSnow;
                    maxSnowballTime = snowballTime;
                    maxSnowballQuality = snowballQuality;
                }
            }

            //output
            Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {maxSnowballValue} ({maxSnowballQuality})");
        }
    }
}
