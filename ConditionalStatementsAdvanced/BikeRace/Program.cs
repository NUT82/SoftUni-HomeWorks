using System;

namespace BikeRace
{
    class Program
    {
        static void Main()
        {
            //Предстои Вело състезание за благотворителност в което участниците са разпределени в младша("juniors") и старша("seniors") група.Парите се набавят от таксата за участие на велосипедистите.Според възрастовата група и вида на трасето на което ще се провежда състезанието, таксата е различна.
            //Група     trail   cross - country   downhill      road
            //juniors    5.50       8               12.25       20
            //seniors   7           9.50            13.75       21.50
            //Ако в "cross-country" състезанието се съберат 50 или повече участника(общо младши и старши), таксата намалява с 25 %.Организаторите отделят 5 % процента от събраната сума за разходи.
            double discount = 0;
            const double amountForExpences = 0.05;

            //input
            //•	Първият ред – броят младши велосипедисти.Цяло число в интервала[1…100]
            int juniorBikers = int.Parse(Console.ReadLine());
            //•	Вторият ред – броят старши велосипедисти.Цяло число в интервала[1… 100]
            int seniorBikers = int.Parse(Console.ReadLine());
            //•	Третият ред – вид трасе – "trail", "cross-country", "downhill" или "road"
            string typeOfRoute = Console.ReadLine();

            double sumOfIncome = 0;
            switch (typeOfRoute)
            {
                case "trail":
                    sumOfIncome = juniorBikers * 5.5 + seniorBikers * 7;
                    break;
                case "cross-country":
                    if (juniorBikers + seniorBikers >= 50)
                    {
                        discount = 0.25;
                    }
                    sumOfIncome = juniorBikers * 8 + seniorBikers * 9.5;
                    sumOfIncome -= sumOfIncome * discount;
                    break;
                case "downhill":
                    sumOfIncome = juniorBikers * 12.25 + seniorBikers * 13.75;
                    break;
                case "road":
                    sumOfIncome = juniorBikers * 20 + seniorBikers * 21.5;
                    break;
                default:
                    break;
            }

            sumOfIncome -= sumOfIncome * amountForExpences;
            //output
            //Да се отпечата на конзолата едно число:
            //"{дарената сума}" - форматирана с точност до 2 знака след десетичната запетая.
            Console.WriteLine($"{sumOfIncome:F2}");
        }
    }
}
