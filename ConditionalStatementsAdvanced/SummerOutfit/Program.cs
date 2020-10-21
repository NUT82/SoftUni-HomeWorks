using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main()
        {
            //Лято е с много променливо време и Виктор има нужда от вашата помощ.Напишете програма която спрямо времето от денонощието и градусите да препоръча на Виктор какви дрехи да си облече. Вашия приятел има различни планове за всеки етап от деня, които изискват и различен външен вид, тях може да видите от таблицата.
            //От конзолата се четат точно два реда:
            //•	Градусите - цяло число в интервала[10…42]
            int degrees = int.Parse(Console.ReadLine());
            //•	Текст, време от денонощието - с възможности - "Morning", "Afternoon", "Evening"
            string partOfDay = Console.ReadLine();
            //Време от денонощието / градуси
            //Мorning                                                       Afternoon
            //10 <= градуси <= 18 Outfit = Sweatshirt   Shoes = Sneakers  Outfit = Shirt     Shoes = Moccasins
            //18 < градуси <= 24  Outfit = Shirt        Shoes = Moccasins Outfit = T-Shirt   Shoes = Sandals
            //градуси >= 25       Outfit = T - Shirt    Shoes = Sandals   Outfit = Swim Suit Shoes = Barefoot
            //Evening - Outfit = Shirt Shoes = Moccasins
            string outfit = "";
            string shoes = "";

            switch (partOfDay)
            {
                case "Morning":
                    if (degrees <= 18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (degrees <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;
                case "Afternoon":
                    if (degrees <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    break;
                case "Evening":
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    break;
                default:
                    break;
            }
            //Да се отпечата на конзолата на един ред: "It's {градуси} degrees, get your {облекло} and {обувки}."
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
