using System;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Котката Том обича по цял ден да спи, за негово съжаление стопанинът му си играе с него винаги когато  има свободно време. За да се наспи добре, нормата за игра на Том е 30 000  минути в година. Времето за игра на Том зависи от почивните дни на стопанина му:
            //•	Когато е на работа, стопанинът му си играе с него по 63 минути на ден.
            //•	Когато почива, стопанинът му си играе с него по 127 минути на ден.
            //Напишете програма, която въвежда броя почивни дни и отпечатва дали Том може да се наспи добре и колко е разликата от нормата за текущата година, като приемем че годината има 365 дни.
            //Пример: 20 почивни дни -> работните дни са 345(365 – 20 = 245).Реалното време за игра е 24 275 минути(345 * 63 + 20 * 127).Разликата от нормата е 5 725 минути(30 000 – 24 275 = 5 725) или 95 часа и 25 минути.

            const int playTimeWhenWorkPerDay = 63;
            const int playTimeWhenRestPerDay = 127;
            const int daysOfYear = 365;
            const int tomPlayTimeForYear = 30000;

            //Input
            //Входът се чете от конзолата и се състои от едно число – броят почивни дни – цяло число в интервала [0...365]

            int restDays = int.Parse(Console.ReadLine());

            //Calculations
            int playTimeWhenWorkPerYear = (daysOfYear - restDays) * playTimeWhenWorkPerDay;
            int playTimeWhenRestPerYear = restDays * playTimeWhenRestPerDay;
            int diferencePlayTime = Math.Abs(playTimeWhenWorkPerYear + playTimeWhenRestPerYear - tomPlayTimeForYear);
            int hours = (int)(diferencePlayTime / 60);
            int minutes = (int)(diferencePlayTime % 60);

            //Output

            //На конзолата трябва да се отпечатат два реда.
            //•	Ако времето за игра на Том е над нормата за текущата година:
            if (playTimeWhenWorkPerYear + playTimeWhenRestPerYear > tomPlayTimeForYear)
            {
                //o На първия ред отпечатайте: “Tom will run away”
                Console.WriteLine("Tom will run away");
                //o На втория ред отпечатайте разликата от нормата във формат:
                //“{H} hours and {M} minutes more for play”
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                //•	Ако времето за игра на Том е под нормата за текущата година:
                //o   На първия ред отпечатайте: “Tom sleeps well”
                Console.WriteLine("Tom sleeps well");
                //o    На втория ред отпечатайте разликата от нормата във формат:
                //“{H} hours and {M} minutes less for play”
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }

        }
    }
}
