using System;

namespace Number100To200
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете цяло число, въведено от потребителя и проверява, дали е под 100, между 100 и 200 или над 200. Да се отпечатат съответно съобщения, като в примерите по-долу:Less than 100 / Between 100 and 200 / Greater than 200
            string outputMsg = "Between 100 and 200";
            int number = int.Parse(Console.ReadLine());

            if (number > 200)
            {
                outputMsg = "Greater than 200";
            }
            else if (number < 100)
            {
                outputMsg = "Less than 100";
            }

            Console.WriteLine(outputMsg);
        }
    }
}
