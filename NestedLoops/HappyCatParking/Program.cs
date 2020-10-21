using System;

namespace HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            //Деси трябва да заведе котката си на ветеринар в клиниката "Happy Cat", но паркингът се заплаща. Напишете програма, която пресмята колко общо трябва да се плати за престоя на колата на Деси на паркинга, за да заведе котката си на ветеринар. Паркингът е различен от останалите и има разнообразен ценоразпис. За всеки четен ден и нечетен час, паркингът таксува 2.50 лева. Във всеки нечетен ден и четен час таксата е 1.25 лева, във всички останали случаи се заплаща 1 лев. Таксуването става на всеки изминал час от деня. Всеки един от изходите трябва да бъде закръглен до втория знак след десетичната запетая.

            //•	Брой дни – цяло число в интервала [1 … 5]
            int countOfDays = int.Parse(Console.ReadLine());
            //•	Брой часове за всеки един от дните - цяло число в интервала [1 … 24]
            int hoursForDay = int.Parse(Console.ReadLine());
            double parkingForAllDays = 0;

            for (int day = 1; day <= countOfDays; day++)
            {
                double parkingForCurrDay = 0;
                for (int hour = 1; hour <= hoursForDay; hour++)
                {
                    if (day % 2 == 0 && hour % 2 != 0)
                    {
                        parkingForCurrDay += 2.50;
                    }
                    else if (day % 2 != 0 && hour % 2 == 0)
                    {
                        parkingForCurrDay += 1.25;
                    }
                    else
                    {
                        parkingForCurrDay += 1;
                    }
                }
                Console.WriteLine($"Day: {day} - {parkingForCurrDay:F2} leva");
                parkingForAllDays += parkingForCurrDay;
            }
            Console.WriteLine($"Total: {parkingForAllDays:F2} leva");
            //•	За всеки изминал ден, общата сума, която трябва да се плати – "Day: {индексът на деня} – {общата сума за деня} leva"
            //•	Когато програмата приключи - "Total: {общата сума за всички дни} leva"

        }
    }
}
