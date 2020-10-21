using System;

namespace NewHouse
{
    class Program
    {
        static void Main()
        {
            //Марин и Нели си купуват къща не далеч от София. Нели толкова много обича цветята, че Ви убеждава да напишете програма която да изчисли колко  ще им струва, да си засадят определен брой цветя и дали наличния бюджет ще им е достатъчен. Различните цветя са с различни цени. 
            const double priceOfRose = 5;
            const double priceOfDahlia = 3.8;
            const double priceOfTulip = 2.8;
            const double priceOfNarcissus = 3;
            const double priceOfGladiolus = 2.5;

            //discounts
            //•	Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 90  Далии - 15 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
            //•	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            //•	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %
            double discount = 0;

            //input
            //            •	Вид цветя -текст с възможности -"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            string typeOfFlower = Console.ReadLine();
            //•	Брой цветя -цяло число в интервала[10…1000]
            int countOfFlower = int.Parse(Console.ReadLine());
            //•	Бюджет - цяло число в интервала[50…2500]
            int availiableBudget = int.Parse(Console.ReadLine());

            double priceOfFlower = 0;
            switch (typeOfFlower)
            {
                case "Roses":
                    priceOfFlower = priceOfRose;
                    if (countOfFlower > 80)
                    {
                        discount = 0.1;
                    }
                    break;
                case "Dahlias":
                    priceOfFlower = priceOfDahlia;
                    if (countOfFlower > 90)
                    {
                        discount = 0.15;
                    }
                    break;
                case "Tulips":
                    priceOfFlower = priceOfTulip;
                    if (countOfFlower > 80)
                    {
                        discount = 0.15;
                    }
                    break;
                case "Narcissus":
                    priceOfFlower = priceOfNarcissus;
                    if (countOfFlower < 120)
                    {
                        discount = -0.15;
                    }
                    break;
                case "Gladiolus":
                    priceOfFlower = priceOfGladiolus;
                    if (countOfFlower < 80)
                    {
                        discount = -0.2;
                    }
                    break;
                default:
                    break;
            }

            double neededBudget = priceOfFlower * countOfFlower;
            neededBudget -= neededBudget * discount;
            double diferenceBudget = Math.Abs(availiableBudget - neededBudget);

            //output
            //            •	Ако бюджета им е достатъчен - "Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left."
            if (availiableBudget >= neededBudget)
            {
                Console.WriteLine($"Hey, you have a great garden with {countOfFlower} {typeOfFlower} and {diferenceBudget:F2} leva left.");
            }
            //•	Ако бюджета им е НЕ достатъчен -"Not enough money, you need {нужната сума} leva more."
            else
            {
                Console.WriteLine($"Not enough money, you need {diferenceBudget:F2} leva more.");
            }
            //Сумата да бъде форматирана до втория знак след десетичната запетая.

        }
    }
}
