using System;

namespace TimeAdd15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете час и минути от 24-часово денонощие, въведени от потребителя и изчислява колко ще е часът след 15 минути. Резултатът да се отпечата във формат часове:минути. Часовете винаги са между 0 и 23, а минутите винаги са между 0 и 59. Часовете се изписват с една или две цифри. Минутите се изписват винаги с по две цифри, с водеща нула, когато е необходимо. 
            int inputHours = int.Parse(Console.ReadLine());
            int inputMinutes = int.Parse(Console.ReadLine());

            int newMinutes = inputMinutes + 15;
            int newHours = inputHours;

            if (newMinutes > 59)
            {
                newHours += 1;
                newMinutes -= 60;
            }
            if (newHours > 23)
            {
                newHours -= 24;
            }

            if (newMinutes < 10)
            {
                Console.WriteLine($"{newHours}:0{newMinutes}");
            }
            else
            {
                Console.WriteLine($"{newHours}:{newMinutes}");
            }
        }
    }
}
