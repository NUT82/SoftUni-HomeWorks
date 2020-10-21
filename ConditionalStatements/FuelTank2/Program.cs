using System;

namespace FuelTank2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която да изчислява, колко ще струва на един шофьор да напълни резервоара на автомобила си, като знаете – какъв тип гориво зарежда, каква е цената за литър гориво и дали разполага с карта за отстъпки. Цените на горивата са както следва: 
            //•	Бензин – 2.22 лева за един литър,
            double gasolinePrice = 2.22;
            //•	Дизел – 2.33 лева за един литър
            double dieselPrice = 2.33;
            //•	Газ – 0.93 лева за литър
            double gasPrice = 0.93;
            //Ако водача има карта за отстъпки,  той се възползва от следните намаления за литър гориво: 18 ст. за литър бензин, 12 ст. за литър дизел и 8 ст. за литър газ. 
            double gasolinePriceWithDiscount = gasolinePrice - 0.18;
            double dieselPriceWithDiscount = dieselPrice - 0.12;
            double gasPriceWithDiscount = gasPrice - 0.08;
            //Ако шофьора е заредил между 20 и 25 литра включително, той получава 8 процента отстъпка от крайната цена, при повече от 25 литра гориво, той получава 10 процента отстъпка от крайната цена.
            const double discountOver25Litres = 0.1;
            const double discount20To25Litres = 0.08;

            //Input
            //•	Типа на горивото – текст с възможности: "Gas", "Gasoline" или "Diesel"
            string typeOfFuel = Console.ReadLine();
            //•	Количество гориво – реално число в интервала [1.00 … 50.00]
            double litresInTank = double.Parse(Console.ReadLine());
            //•	Притежание на клубна карта – текст с възможности: "Yes" или "No"
            string clubCard = Console.ReadLine();

            //calculations

            //Calculate discount from amount of fuel
            double discount = 0;
            if (litresInTank > 25)
            {
                discount = discountOver25Litres;
            }
            else if (litresInTank >= 20)
            {
                discount = discount20To25Litres;
            }

            //Calculate price depending on whether he has a club card
            double priceOfFuel = 0;
            if (clubCard == "Yes")
            {
                gasPrice = gasPriceWithDiscount;
                gasolinePrice = gasolinePriceWithDiscount;
                dieselPrice = dieselPriceWithDiscount;
            }

            //Calculate price depending on type of fuel
            if (typeOfFuel == "Gas")
            {
                priceOfFuel = litresInTank * gasPrice;
            }
            else if (typeOfFuel == "Gasoline")
            {
                priceOfFuel = litresInTank * gasolinePrice;
            }
            else if (typeOfFuel == "Diesel")
            {
                priceOfFuel = litresInTank * dieselPrice;
            }
            priceOfFuel = priceOfFuel - priceOfFuel * discount;
            //output
            //На конзолата трябва да се отпечата един ред.
            //•	"{крайната цена на горивото} lv."
            //Цената на горивото да бъде форматираната до втората цифра след десетичния знак.
            Console.WriteLine($"{priceOfFuel:F2} lv.");
        }
    }
}
