using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лили вече е на N години. За всеки свой рожден ден тя получава подарък. За нечетните рождени дни (1, 3, 5...n) получава играчки, а за всеки четен (2, 4, 6...n) получава пари. За втория рожден ден получава 10.00 лв, като сумата се увеличава с 10.00 лв., за всеки следващ четен рожден ден (2 -> 10, 4 -> 20, 6 -> 30...и т.н.). През годините Лили тайно е спестявала парите. Братът на Лили, в годините, които тя получава пари, взима по 1.00 лев от тях. Лили продала играчките получени през годините, всяка за P лева и добавила сумата към спестените пари. С парите искала да си купи пералня за X лева. Напишете програма, която да пресмята, колко пари е събрала и дали ѝ стигат да си купи пералня.

            //input
            //•	Възрастта на Лили - цяло число в интервала [1...77]
            int ageOfLily = int.Parse(Console.ReadLine());
            //•	Цената на пералнята – реално число
            double priceOfWashingMashine = double.Parse(Console.ReadLine());
            //•	Цена на играчки – реално число
            double priceOfToys = double.Parse(Console.ReadLine());

            int countOfToys = 0;
            double savedMoney = 0;
            for (int i = 1; i <= ageOfLily; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += 10 * i / 2;
                    savedMoney--;
                }
                else
                {
                    countOfToys++;
                }
            }
            savedMoney += countOfToys * priceOfToys;
            double diferenceMoney = Math.Abs(priceOfWashingMashine - savedMoney);
            //output
            //•	Ако парите на Лили са достатъчни:
            if (savedMoney >= priceOfWashingMashine)
            {
                Console.WriteLine($"Yes! {diferenceMoney:F2}");
            }
            //            o   “Yes! { N}” -където N е остатъка пари след покупката
            //•	Ако парите не са достатъчни:
            else
            {
                Console.WriteLine($"No! {diferenceMoney:F2}");
            }
            //            o   “No! { М}“ -където M е сумата, която не достига
            //•	Числата N и M трябва да за форматирани до вторият знак след десетичната запетая.

        }
    }
}
