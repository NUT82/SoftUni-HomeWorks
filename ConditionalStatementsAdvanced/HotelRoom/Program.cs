using System;

namespace HotelRoom
{
    class Program
    {
        static void Main()
        {
            //Хотел предлага 2 вида стаи: студио и апартамент.Напишете програма, която изчислява цената за целия престой за студио и апартамент.Цените зависят от месеца на престоя:
            //Май и октомври                 Юни и септември                 Юли и август
            //Студио – 50 лв./ нощувка       Студио – 75.20 лв./ нощувка     Студио – 76 лв./ нощувка
            //Апартамент – 65 лв./ нощувка  Апартамент – 68.70 лв./ нощувка  Апартамент – 77 лв./ нощувка
            const double priceOfStudioMayOrOctober = 50;
            const double priceOfApartmentMayOrOctober = 65;
            const double priceOfStudioJuneOrSeptember = 75.20;
            const double priceOfApartmentJuneOrSeptember = 68.70;
            const double priceOfStudioJulyOrAugust = 76;
            const double priceOfApartmentJulyOrAugust = 77;
            //Предлагат се и следните отстъпки:
            //•	За студио, при повече от 7 нощувки през май и октомври: 5 % намаление.
            //•	За студио, при повече от 14 нощувки през май и октомври: 30 % намаление.
            //•	За студио, при повече от 14 нощувки през юни и септември: 20 % намаление.
            //•	За апартамент, при повече от 14 нощувки, без значение от месеца : 10 % намаление.
            double discountOfApartment = 0;
            double discountOfStudio = 0;
            //input
            //•	На първия ред е месецът – May, June, July, August, September или October
            string mounth = Console.ReadLine();
            //•	На втория ред е броят на нощувките – цяло число в интервала[0... 200]
            int countOfNights = int.Parse(Console.ReadLine());
            if (countOfNights > 14)
            {
                discountOfApartment = 0.1;
            }
            double priceForStudio = 0;
            double priceForApartment = 0;
            double priceForAllStayStudio = 0;
            double priceForAllStayApartment = 0;

            switch (mounth)
            {
                case "May":
                case "October":
                    priceForStudio = priceOfStudioMayOrOctober;
                    priceForApartment = priceOfApartmentMayOrOctober;
                    if (countOfNights > 14)
                    {
                        discountOfStudio = 0.3;
                    }
                    else if (countOfNights > 7)
                    {
                        discountOfStudio = 0.05;
                    }
                    break;
                case "June":
                case "September":
                    priceForStudio = priceOfStudioJuneOrSeptember;
                    priceForApartment = priceOfApartmentJuneOrSeptember;
                    if (countOfNights > 14)
                    {
                        discountOfStudio = 0.2;
                    }
                    break;
                case "July":
                case "August":
                    priceForStudio = priceOfStudioJulyOrAugust;
                    priceForApartment = priceOfApartmentJulyOrAugust;
                    break;
                default:
                    break;
            }
            priceForStudio -= priceForStudio * discountOfStudio;
            priceForApartment -= priceForApartment * discountOfApartment;
            priceForAllStayStudio = priceForStudio * countOfNights;
            priceForAllStayApartment = priceForApartment * countOfNights;
            //output
            //•	На първия ред: “Apartment: {цена за целият престой} lv.”
            Console.WriteLine($"Apartment: {priceForAllStayApartment:F2} lv.");
            //•	На втория ред: “Studio: {цена за целият престой} lv.“
            Console.WriteLine($"Studio: {priceForAllStayStudio:F2} lv.");
            //Цената за целия престой форматирана с точност до два знака след десетичната запетая.

        }
    }
}
