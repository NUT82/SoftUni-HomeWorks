using System;

namespace WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която при въведени градуси (реално число) принтира какво е времето, като имате предвид следната таблица:
            //Градуси Време
            //26.00 - 35.00   Hot
            //20.1 - 25.9 Warm
            //15.00 - 20.00   Mild
            //12.00 - 14.9    Cool
            //5.00 - 11.9 Cold
            //Ако се въведат градуси, различни от посочените в таблицата, да се отпечата "unknown".

            double temperature = double.Parse(Console.ReadLine());
            string whatIsTheWeather = "unknown";

            if (temperature >= 5)
            {
                whatIsTheWeather = "Cold";
            }
            if (temperature >= 12)
            {
                whatIsTheWeather = "Cool";
            }
            if (temperature >= 15)
            {
                whatIsTheWeather = "Mild";
            }
            if (temperature >= 20.1)
            {
                whatIsTheWeather = "Warm";
            }
            if (temperature >= 26)
            {
                whatIsTheWeather = "Hot";
            }
            if (temperature > 35)
            {
                whatIsTheWeather = "unknown";
            }

            Console.WriteLine(whatIsTheWeather);
        }
    }
}
