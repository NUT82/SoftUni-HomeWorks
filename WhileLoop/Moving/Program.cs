using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            //На осемнадесетия си рожден ден на Хосе взел решение, че ще се изнесе да живее на квартира. Опаковал багажа си в кашони и намерил подходяща обява за апартамент под наем. Той започва да пренася своя багаж на части, защото не може да пренесе целия наведнъж. Има ограничено свободно пространство в новото си жилище, където може да разположи вещите, така че мястото да бъде подходящо за живеене.
            //Напишете програма, която изчислява свободния обем от жилището на Хосе, който остава след като пренесе багажа си.
            //Бележка: Един кашон е с точни размери:  1m.x 1m.x 1m.

            //input
            //Потребителят въвежда следните данни на отделни редове:
            //1.	Широчина на свободното пространство - цяло число в интервала [1...1000]
            //2.	Дължина на свободното пространство - цяло число в интервала [1...1000]
            //3.	Височина на свободното пространство - цяло число в интервала [1...1000]
            //4.	На следващите редове (до получаване на команда "Done") - брой кашони, които се пренасят в квартирата - цели числа в интервала [1...10000];
            //Програмата трябва да приключи прочитането на данни при команда "Done" или ако свободното място свърши.
            int widthOfPlace = int.Parse(Console.ReadLine());
            int lenghtOfPlace = int.Parse(Console.ReadLine());
            int heightOfPlace = int.Parse(Console.ReadLine());
            int maxBoxes = widthOfPlace * lenghtOfPlace * heightOfPlace;
            int movedBoxes = 0;
            string input = Console.ReadLine();
            while (input != "Done")
            {

                movedBoxes += int.Parse(input);
                if (movedBoxes > maxBoxes)
                {
                    Console.WriteLine($"No more free space! You need {movedBoxes - maxBoxes} Cubic meters more.");
                    break;
                }
                else
                {
                    input = Console.ReadLine();
                }
            }
            if (input == "Done")
            {
                Console.WriteLine($"{maxBoxes - movedBoxes} Cubic meters left.");
            }
        }
    }
}
