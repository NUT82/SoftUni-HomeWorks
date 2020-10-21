using System;

namespace Cinema
{
    class Program
    {
        static void Main()
        {
            //В една кинозала столовете са наредени в правоъгълна форма в r реда и c колони.Има три вида прожекции с билети на различни цени:
            //•	Premiere – премиерна прожекция, на цена 12.00 лева.
            const double pricePremier = 12;
            //•	Normal – стандартна прожекция, на цена 7.50 лева.
            const double priceNormal = 7.5;
            //•	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
            const double priceDiscount = 5;
            //Напишете програма, която чете тип прожекция(стринг), брой редове и брой колони в залата(цели числа), въведени от потребителя, и изчислява общите приходи от билети при пълна зала.Резултатът да се отпечата във формат като в примерите по-долу, с 2 знака след десетичната точка.  

            //input
            string typeOfProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int collumns = int.Parse(Console.ReadLine());

            //calc
            double allTicketsPrice = 0;

            switch (typeOfProjection)
            {
                case "Premiere":
                    allTicketsPrice = pricePremier * rows * collumns;
                    break;
                case "Normal":
                    allTicketsPrice = priceNormal * rows * collumns;
                    break;
                case "Discount":
                    allTicketsPrice = priceDiscount * rows * collumns;
                    break;
                default:
                    break;
            }

            //output
            Console.WriteLine($"{allTicketsPrice:F2} leva");
        }
    }
}
