using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Магазин за плодове през работните дни работи на следните цени:
            //  плод banana  apple orange  grapefruit kiwi    pineapple grapes
            //цена    2.50    1.20    0.85    1.45    2.70    5.50    3.85
            //Събота и неделя магазинът работи на по - високи цени:
            //  плод banana  apple orange  grapefruit kiwi    pineapple grapes
            //цена    2.70    1.25    0.90    1.60    3.00    5.60    4.20
            //Напишете програма, която чете от конзолата плод(banana / apple / orange / grapefruit / kiwi / pineapple / grapes), ден от седмицата(Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday) и количество(реално число) , въведени от потребителя, и пресмята цената според цените от таблиците по-горе.Резултатът да се отпечата закръглен с 2 цифри след десетичната точка. При невалиден ден от седмицата или невалидно име на плод да се отпечата "error".

            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            bool error = false;
            double finalPrice = 0;
            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        finalPrice = amount * 2.5;
                        break;
                    case "apple":
                        finalPrice = amount * 1.2;
                        break;
                    case "orange":
                        finalPrice = amount * 0.85;
                        break;
                    case "grapefruit":
                        finalPrice = amount * 1.45;
                        break;
                    case "kiwi":
                        finalPrice = amount * 2.7;
                        break;
                    case "pineapple":
                        finalPrice = amount * 5.5;
                        break;
                    case "grapes":
                        finalPrice = amount * 3.85;
                        break;
                    default:
                        error = true;
                        break;
                }
            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        finalPrice = amount * 2.7;
                        break;
                    case "apple":
                        finalPrice = amount * 1.25;
                        break;
                    case "orange":
                        finalPrice = amount * 0.9;
                        break;
                    case "grapefruit":
                        finalPrice = amount * 1.6;
                        break;
                    case "kiwi":
                        finalPrice = amount * 3;
                        break;
                    case "pineapple":
                        finalPrice = amount * 5.6;
                        break;
                    case "grapes":
                        finalPrice = amount * 4.2;
                        break;
                    default:
                        error = true;
                        break;
                }
            }
            else
            {
                error = true;
            }

            if (error)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{finalPrice:F2}");
            }
        }
    }
}
