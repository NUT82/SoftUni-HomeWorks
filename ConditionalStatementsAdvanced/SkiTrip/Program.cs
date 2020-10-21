using System;

namespace SkiTrip
{
    class Program
    {
        static void Main()
        {
            //Атанас решава да прекара отпуската си в Банско и да кара ски. Преди да отиде обаче, трябва да резервира хотел и да изчисли колко ще му струва престоя. Съществуват следните видове помещения, със следните цени за престой:
            //	"room for one person" – 18.00 лв за нощувка
            const double roomForOnePersonPricePerNight = 18;
            //	"apartment" – 25.00 лв за нощувка 
            const double apartmenPricePerNight = 25;
            //	"president apartment" – 35.00 лв за нощувка
            const double presidentApartmenPricePerNight = 35;
            //Според броят на дните, в които ще остане в хотела (пример: 11 дни = 10 нощувки) и видът на помещението, което ще избере, той може да ползва различно намаление. Намаленията са както следва:
            //вид помещение	        по-малко от 10 дни	    между 10 и 15 дни	    повече от 15 дни
            //room for one person	не ползва намаление	    не ползва намаление	    не ползва намаление
            //apartment	            30% от крайната цена	35% от крайната цена	50% от крайната цена
            //president apartment	10% от крайната цена	15% от крайната цена	20% от крайната цена
            //След престоя, оценката на Атанас за услугите на хотела може да е позитивна (positive) или негативна (negative) . Ако оценката му е позитивна, към цената с вече приспаднатото намаление Атанас добавя 25% от нея. Ако оценката му е негативна приспада от цената 10%.
            double evalutionOfStayIndex = -0.1;
            double priceForStay = 0;
            double discount = 0;

            //input
            //•	Първи ред -дни за престой -цяло число в интервала[0...365]
            int daysToStay = int.Parse(Console.ReadLine());
            //•	Втори ред -вид помещение - "room for one person", "apartment" или "president apartment"
            string typeOfRoom = Console.ReadLine();
            //•	Трети ред -оценка - "positive"  или "negative"
            string evaluitonOfStay = Console.ReadLine();
            if (evaluitonOfStay == "positive")
            {
                evalutionOfStayIndex = 0.25;
            }

            //calc
            switch (typeOfRoom)
            {
                case "room for one person":
                    priceForStay = (daysToStay - 1) * roomForOnePersonPricePerNight;
                    discount = 0;
                    break;
                case "apartment":
                    if (daysToStay < 10)
                    {
                        discount = 0.3;
                    }
                    else if (daysToStay <= 15)
                    {
                        discount = 0.35;
                    }
                    else
                    {
                        discount = 0.5;
                    }
                    priceForStay = (daysToStay - 1) * apartmenPricePerNight;
                    break;
                case "president apartment":
                    if (daysToStay < 10)
                    {
                        discount = 0.1;
                    }
                    else if (daysToStay <= 15)
                    {
                        discount = 0.15;
                    }
                    else
                    {
                        discount = 0.2;
                    }
                    priceForStay = (daysToStay - 1) * presidentApartmenPricePerNight;
                    break;
                default:
                    break;
            }
            priceForStay -= priceForStay * discount;
            priceForStay += priceForStay * evalutionOfStayIndex;

            //output
            //•	Цената за престоят му в хотела, форматирана до втория знак след десетичната запетая.
            Console.WriteLine($"{priceForStay:F2}");
        }
    }
}
