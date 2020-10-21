using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която да пресмята колко литра боя е нужна за боядисването на къщa.Като за стените се използва зелена боя, а за покрива – червена.Разхода на зелената боя е 1 литър за 3.4 м2, а на червената – 1 литър за 4.3 м2.
            const double consOfGreenPainPerLiter = 3.4;
            const double consOfRedPainPerLiter = 4.3;
            //Стените имат следните размери:
            //•	Предната и задната стена са квадрати със страна „x“
            //o на предната стена има правоъгълна врата с широчина 1.2м и височина 2м
            const double frontDoorArea = 1.2 * 2;
            //•	Страничните стени са правоъгълници със страни „x“ и „y“
            //o и на двете странични стени има по един квадратен прозорец със страна 1.5м
            const double sideWindowArea = 1.5 * 1.5;
            //Покривът има следните размери:
            //•	Два правоъгълника със страни „x“ и „y“
            //•	Два равностранни триъгълника със страна „x“ и височина „h“
            //Трябва да пресметнете площта на всички страни и площта на покрива, за да
            //намерите колко литра от всяка боя ще са нужни.

            //1.x – височината на къщата – реално число в интервала[2...100]
            double heightOfHouse = double.Parse(Console.ReadLine());
            //2.y – дължината на страничната стена – реално число в интервала[2...100]
            double lengthOfSideWall = double.Parse(Console.ReadLine());
            //3.h – височината на триъгълната стена на прокрива – реално число в интервала[2...100]
            double heightOfTriangleRoofWall = double.Parse(Console.ReadLine());

            //Calculations
            double areaOfWalls = (heightOfHouse * heightOfHouse * 2) - frontDoorArea + (heightOfHouse * lengthOfSideWall * 2) - (sideWindowArea * 2);
            double areaOfRoof = (heightOfHouse * lengthOfSideWall * 2) + (heightOfHouse * heightOfTriangleRoofWall / 2 * 2);


            double litersOfGreenPaintNeeded = areaOfWalls / consOfGreenPainPerLiter;
            double litersOfRedPaintNeeded = areaOfRoof / consOfRedPainPerLiter;


            //Да се отпечатат на конзолата две числа всяко на нов ред:
            //•	Литрите зелена боя
            //•	Литритe червена боя
            //Форматирани до вторият знак след десетичната запетая.
            Console.WriteLine($"{litersOfGreenPaintNeeded:F2}");
            Console.WriteLine($"{litersOfRedPaintNeeded:F2}");

        }
    }
}
