﻿using System;


class Program
{
    static void Main()
    {

        //Учебна зала има правоъгълен размер w на h метра, без колони във вътрешността си.Залата е разделена на две части – лява и дясна, с коридор приблизително по средата.В лявата и в дясната част има редици с бюра. В задната част на залата има голяма входна врата.В предната част на залата има катедра с подиум за преподавателя.Едно работно място заема 70 на 120 cm(маса с размер 70 на 40 cm + място за стол и преминаване с размер 70 на 80 cm).Коридорът е широк поне 100 cm.Изчислено е, че заради входната врата(която е с отвор 160 cm) се губи точно 1 работно място, а заради катедрата(която е с размер 160 на 120 cm) се губят точно 2 работни места. Напишете програма, която въвежда размери на учебната зала и изчислява броя работни места в нея при описаното разположение(вж.фигурата).

        const double lenghtOfWorkPlace = 1.20;
        const double widthOfWorkPlace = 0.70;

        //От конзолата се четат 2 числа, по едно на ред: w (дължина в метри) и h (широчина в метри).
        //Ограничения: 3 ≤ h ≤ w ≤ 100.
        double lenghtOfRoom = double.Parse(Console.ReadLine());
        double widthOfRoom = double.Parse(Console.ReadLine());

        //Calculations
        double workPlacesInColumn = lenghtOfRoom / lenghtOfWorkPlace;
        double workPlacesInRow = (widthOfRoom - 1) / widthOfWorkPlace;


        int realWorkPlaces = (int)workPlacesInColumn * (int)workPlacesInRow - 3;

        Console.WriteLine($"{realWorkPlaces}");



    }
}