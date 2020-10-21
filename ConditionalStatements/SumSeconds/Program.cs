using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //Трима спортни състезатели финишират за някакъв брой секунди(между 1 и 50). Да се напише програма, която чете времената на състезателите в секунди, въведени от потребителя и пресмята сумарното им време във формат "минути:секунди".Секундите да се изведат с водеща нула(2  "02", 7  "07", 35  "35"). 
            //input
            int timeRacer1 = int.Parse(Console.ReadLine());
            int timeRacer2 = int.Parse(Console.ReadLine());
            int timeRacer3 = int.Parse(Console.ReadLine());
            //calculation
            int sumTimeRacers = timeRacer1 + timeRacer2 + timeRacer3;
            int minutes = (int)(sumTimeRacers / 60);
            int seconds = sumTimeRacers % 60;
            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
