using System;

namespace thirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string typeOfSuvenirs = Console.ReadLine();
            int boughtSuvenirs = int.Parse(Console.ReadLine());
            bool invalidCountry = false;
            bool invalidTypeOfSuvenirs = false;
            double price = 0;
            switch (country)
            {
                case "Argentina":
                    
                    if (typeOfSuvenirs == "caps")
                    {
                        price = 7.20;
                    }
                    else if (typeOfSuvenirs == "posters")
                    {
                        price = 5.1;
                    }
                    else if (typeOfSuvenirs == "stickers")
                    {
                        price = 1.25;
                    }
                    else if (typeOfSuvenirs == "flags")
                    {
                        price = 3.25;
                    }
                    else
                    {
                        invalidTypeOfSuvenirs = true;
                    }
                    break;
                case "Brazil":
                    
                    if (typeOfSuvenirs == "caps")
                    {
                        price = 8.50;
                    }
                    else if (typeOfSuvenirs == "posters")
                    {
                        price = 5.35;
                    }
                    else if (typeOfSuvenirs == "stickers")
                    {
                        price = 1.20;
                    }
                    else if (typeOfSuvenirs == "flags")
                    {
                        price = 4.20;
                    }
                    else
                    {
                        invalidTypeOfSuvenirs = true;
                    }
                    break;
                case "Croatia":
                    
                    if (typeOfSuvenirs == "caps")
                    {
                        price = 6.90;
                    }
                    else if (typeOfSuvenirs == "posters")
                    {
                        price = 4.95;
                    }
                    else if (typeOfSuvenirs == "stickers")
                    {
                        price = 1.1;
                    }
                    else if (typeOfSuvenirs == "flags")
                    {
                        price = 2.75;
                    }
                    else
                    {
                        invalidTypeOfSuvenirs = true;
                    }
                    break;
                case "Denmark":
                    
                    if (typeOfSuvenirs == "caps")
                    {
                        price = 6.50;
                    }
                    else if (typeOfSuvenirs == "posters")
                    {
                        price = 4.80;
                    }
                    else if (typeOfSuvenirs == "stickers")
                    {
                        price = 0.90;
                    }
                    else if (typeOfSuvenirs == "flags")
                    {
                        price = 3.1;
                    }
                    else
                    {
                        invalidTypeOfSuvenirs = true;
                    }
                    break;
                default:
                    invalidCountry = true;
                    break;
            }

            if (invalidCountry)
            {
                Console.WriteLine("Invalid country!");
            }
            else if (invalidTypeOfSuvenirs)
            {
                Console.WriteLine("Invalid stock!");
            }
            else
            {
                Console.WriteLine($"Pepi bought {boughtSuvenirs} {typeOfSuvenirs} of {country} for {boughtSuvenirs * price:F2} lv.");
            }
        }
    }
}
