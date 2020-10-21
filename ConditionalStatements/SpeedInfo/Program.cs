using System;

namespace SpeedInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете скорост (реално число), въведена от потребителя и отпечатва информация за скоростта. При скорост до 10 (включително) отпечатайте “slow”. При скорост над 10 и до 50 отпечатайте “average”. При скорост над 50 и до 150 отпечатайте “fast”. При скорост над 150 и до 1000 отпечатайте “ultra fast”. При по-висока скорост отпечатайте “extremely fast”. 

            double speed = double.Parse(Console.ReadLine());
            string infoSpeed = "slow";
            if (speed > 1000)
            {
                infoSpeed = "extremely fast";
            }
            else if (speed > 150)
            {
                infoSpeed = "ultra fast";
            }
            else if (speed > 50)
            {
                infoSpeed = "fast";
            }
            else if (speed > 10)
            {
                infoSpeed = "average";
            }
            Console.WriteLine(infoSpeed);
        }
    }
}
