using System;

namespace FuelTank1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която познава дали резервоара на едно превозно средство има нужда от презареждане на горивото или не. От конзолата се четат два реда – текст и реално число, на първия ред се чете типа на горивото – текст с възможности: "Diesel", "Gasoline" или "Gas", а на втория литрите гориво, които има в резервоара. Ако литрите гориво са повече или равни на 25, на конзолата да се отпечата "You have enough {вида на горивото}.", ако са по-малко от 25, да се отпечата "Fill your tank with {вида на горивото}!". В случай, че бъде въведено гориво, различно от посоченото, да се отпечата "Invalid fuel!".
            const int enoughLitres = 25;

            //input
            string typeOfFuel = Console.ReadLine();
            double litresInTank = double.Parse(Console.ReadLine());

            //calculations
            bool isEnough = litresInTank >= enoughLitres;
            bool validFuel = false;
            if (typeOfFuel == "Diesel")
            {
                validFuel = true;
                typeOfFuel = "diesel";
            }
            else if (typeOfFuel == "Gasoline")
            {
                validFuel = true;
                typeOfFuel = "gasoline";
            }
            else if (typeOfFuel == "Gas")
            {
                validFuel = true;
                typeOfFuel = "gas";
            }


            //Output
            if (validFuel)
            {
                if (isEnough)
                {
                    Console.WriteLine($"You have enough {typeOfFuel}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {typeOfFuel}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
