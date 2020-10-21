using System;

namespace Flowers
{
    class Program
    {
        static void Main()
        {
            //Магазин за цветя предлага 3 вида цветя: хризантеми, рози и лалета.Цените зависят от сезона.
            //Сезон             Хризантеми          Рози            Лалета
            //Пролет / Лято     2.00 лв./ бр.    4.10 лв./ бр.    2.50 лв./ бр.
            //  Есен / Зима     3.75 лв./ бр.    4.50 лв./ бр.    4.15 лв./ бр.
            //В празнични дни цените на всички цветя се увеличават с 15 %.Предлагат се следните отстъпки:
            //•	За закупени повече от 7 лалета през пролетта – 5 % от цената на целият букет.
            //•	За закупени 10 или повече рози през зимата – 10 % от цената на целият букет.
            //•	За закупени повече от 20 цветя общо през всички сезони – 20 % от цената на целият букет.
            //Отстъпките се правят по така написания ред и могат да се наслагват!Всички отстъпки важат след оскъпяването за празничен ден!
            //Цената за аранжиране на букета винаги е 2лв.Напишете програма, която изчислява цената за един букет.
            const double priceArrandingBouket = 2;

            //input
            //•	На първия ред е броят на закупените хризантеми – цяло число в интервала[0... 200]
            int countOfChrysanthemums = int.Parse(Console.ReadLine());
            //•	На втория ред е броят на закупените рози – цяло число в интервала[0... 200]
            int countOfRoses = int.Parse(Console.ReadLine());
            //•	На третия ред е броят на закупените лалета – цяло число в интервала[0... 200]
            int countOfTulips = int.Parse(Console.ReadLine());
            int countOfAllFlowers = countOfChrysanthemums + countOfRoses + countOfTulips;
            //•	На четвъртия ред е посочен сезона – [Spring, Summer, Аutumn, Winter]
            string season = Console.ReadLine();
            //•	На петия ред е посочено дали денят е празник – [Y – да / N - не]
            string isHoliday = Console.ReadLine();

            double discount = 0;
            if (isHoliday == "Y")
            {
                discount = -0.15;
            }

            double priceOfBouket = 0;
            switch (season)
            {
                case "Spring":
                    priceOfBouket = countOfChrysanthemums * 2 + countOfRoses * 4.1 + countOfTulips * 2.5;
                    priceOfBouket -= priceOfBouket * discount;
                    if (countOfTulips > 7)
                    {
                        priceOfBouket -= priceOfBouket * 0.05;
                    }
                    break;
                case "Summer":
                    priceOfBouket = countOfChrysanthemums * 2 + countOfRoses * 4.1 + countOfTulips * 2.5;
                    priceOfBouket -= priceOfBouket * discount;
                    break;
                case "Autumn":
                    priceOfBouket = countOfChrysanthemums * 3.75 + countOfRoses * 4.5 + countOfTulips * 4.15;
                    priceOfBouket -= priceOfBouket * discount;
                    break;
                case "Winter":
                    priceOfBouket = countOfChrysanthemums * 3.75 + countOfRoses * 4.5 + countOfTulips * 4.15;
                    priceOfBouket -= priceOfBouket * discount;
                    if (countOfRoses >= 10)
                    {
                        priceOfBouket -= priceOfBouket * 0.1;
                    }
                    break;
                default:
                    break;
            }

            double additionalDiscount = 0;
            if (countOfAllFlowers > 20)
            {
                additionalDiscount = 0.2;
            }
            priceOfBouket -= priceOfBouket * additionalDiscount;
            priceOfBouket += priceArrandingBouket;

            //Да се отпечата на конзолата 1 число – цената на цветята, форматирана до вторият знак след десетичната запетая.
            Console.WriteLine($"{priceOfBouket:F2}");
        }
    }
}
