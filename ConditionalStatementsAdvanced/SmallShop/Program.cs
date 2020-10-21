using System;

namespace SmallShop
{
    class Program
    {
        static void Main()
        {
            //Предприемчив българин отваря квартални магазинчета в няколко града и продава на различни цени според града:
            //град / продукт	coffee	water	beer	sweets	peanuts
            //Sofia	0.50	0.80	1.20	1.45	1.60
            //Plovdiv	0.40	0.70	1.15	1.30	1.50
            //Varna	0.45	0.70	1.10	1.35	1.55
            //Напишете програма, която чете продукт (низ), град (низ) и количество (десетично число), въведени от потребителя, и пресмята и отпечатва колко струва съответното количество от избрания продукт в посочения град. 
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            switch (product)
            {
                case "coffee":
                    if (town == "Sofia")
                    {
                        Console.WriteLine(amount * 0.5);
                    }
                    else if (town == "Plovdiv")
                    {
                        Console.WriteLine(amount * 0.4);
                    }
                    else if (town == "Varna")
                    {
                        Console.WriteLine(amount * 0.45);
                    }
                    break;
                case "water":
                    if (town == "Sofia")
                    {
                        Console.WriteLine(amount * 0.8);
                    }
                    else if (town == "Plovdiv")
                    {
                        Console.WriteLine(amount * 0.7);
                    }
                    else if (town == "Varna")
                    {
                        Console.WriteLine(amount * 0.7);
                    }
                    break;
                case "beer":
                    if (town == "Sofia")
                    {
                        Console.WriteLine(amount * 1.2);
                    }
                    else if (town == "Plovdiv")
                    {
                        Console.WriteLine(amount * 1.15);
                    }
                    else if (town == "Varna")
                    {
                        Console.WriteLine(amount * 1.10);
                    }
                    break;
                case "sweets":
                    if (town == "Sofia")
                    {
                        Console.WriteLine(amount * 1.45);
                    }
                    else if (town == "Plovdiv")
                    {
                        Console.WriteLine(amount * 1.3);
                    }
                    else if (town == "Varna")
                    {
                        Console.WriteLine(amount * 1.35);
                    }
                    break;
                case "peanuts":
                    if (town == "Sofia")
                    {
                        Console.WriteLine(amount * 1.6);
                    }
                    else if (town == "Plovdiv")
                    {
                        Console.WriteLine(amount * 1.5);
                    }
                    else if (town == "Varna")
                    {
                        Console.WriteLine(amount * 1.55);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
