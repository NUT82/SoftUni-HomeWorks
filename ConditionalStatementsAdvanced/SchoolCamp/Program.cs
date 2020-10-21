using System;

namespace SchoolCamp
{
    class Program
    {
        static void Main()
        {
            //Частно училище организира лагери за учениците по време на ваканциите. В зависимост от вида на ваканцията (пролетна, лятна или зимна) и вида на групата (момчета/момичета или смесена) цената на нощувката в хотела е различна, както и спортът, който ще практикуват учениците.
            //	                Зимна ваканция	Пролетна ваканция	Лятна ваканция
            //момчета/момичета	    9.60	            7.20	        15
            //смесена група	        10	                9.50	        20
            //Училището получава отстъпка от крайната цена, в зависимост от броя на настанените в хотела ученици:
            //•	Ако броят на учениците е 50 или повече, училището получава 50% отстъпка
            //•	Ако броят на учениците е 20 или повече и в същото време по-малък от 50, училището получава 15% отстъпка
            //•	Ако броят на учениците е 10 или повече и в същото време по-малък от 20, училището получава 5% отстъпка
            double discount = 0.5;
            //В таблицата по-долу са дадени спортовете, които ще се практикуват в зависимост от вида на ваканцията и групата:
            //	                Зимна ваканция	Пролетна ваканция	Лятна ваканция
            //момичета	        Gymnastics	    Athletics	        Volleyball
            //момчета	        Judo	        Tennis	            Football
            //смесена група	    Ski	            Cycling	            Swimming
            //Да се напише програма, която пресмята цената, която ще заплати училището за нощувките и принтира спорта, който ще се практикува от учениците.

            //input
            //1.Сезонът – текст - “Winter”, “Spring” или “Summer”;
            string season = Console.ReadLine();
            //2.Видът на групата – текст - “boys”, “girls” или “mixed”;
            string typeOfGroup = Console.ReadLine();
            //3.Брой на учениците – цяло число в интервала[1 … 10000];
            int numberOfStudents = int.Parse(Console.ReadLine());
            if (numberOfStudents < 10)
            {
                discount = 0;
            }
            else if (numberOfStudents < 20)
            {
                discount = 0.05;
            }
            else if (numberOfStudents < 50)
            {
                discount = 0.15;
            }
            //4.Брой на нощувките – цяло число в интервала[1 … 100].
            int numberOfNights = int.Parse(Console.ReadLine());

            string typeOfSport = "";
            double priceForHotel = 0;

            switch (season)
            {
                case "Winter":
                    switch (typeOfGroup)
                    {
                        case "boys":
                            priceForHotel = numberOfNights * numberOfStudents * 9.60;
                            typeOfSport = "Judo";
                            break;
                        case "girls":
                            priceForHotel = numberOfNights * numberOfStudents * 9.60;
                            typeOfSport = "Gymnastics";
                            break;
                        case "mixed":
                            priceForHotel = numberOfNights * numberOfStudents * 10;
                            typeOfSport = "Ski";
                            break;
                        default:
                            break;
                    }
                    break;
                case "Spring":
                    switch (typeOfGroup)
                    {
                        case "boys":
                            priceForHotel = numberOfNights * numberOfStudents * 7.20;
                            typeOfSport = "Tennis";
                            break;
                        case "girls":
                            priceForHotel = numberOfNights * numberOfStudents * 7.20;
                            typeOfSport = "Athletics";
                            break;
                        case "mixed":
                            priceForHotel = numberOfNights * numberOfStudents * 9.5;
                            typeOfSport = "Cycling";
                            break;
                        default:
                            break;
                    }
                    break;
                case "Summer":
                    switch (typeOfGroup)
                    {
                        case "boys":
                            priceForHotel = numberOfNights * numberOfStudents * 15;
                            typeOfSport = "Football";
                            break;
                        case "girls":
                            priceForHotel = numberOfNights * numberOfStudents * 15;
                            typeOfSport = "Volleyball";
                            break;
                        case "mixed":
                            priceForHotel = numberOfNights * numberOfStudents * 20;
                            typeOfSport = "Swimming";
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            priceForHotel -= priceForHotel * discount;
            //output
            //•	Спортът, който са практикували учениците и цената за нощувките, която е заплатило училището, форматирана до втория знак след десетичната запетая, в следния формат: "{спортът} {цената} lv.“
            Console.WriteLine($"{typeOfSport} {priceForHotel:F2} lv.");
        }
    }
}
