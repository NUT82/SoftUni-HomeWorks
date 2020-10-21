using System;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма която да пресмята средният разход за месец на семейство за даден период време. За всеки месец разходите са следните:
            //•	За ток – всеки месец е различен, ще се чете от конзолата
            //•	за вода – 20 лв.
            const double payForWater = 20;
            //•	за интернет – 15 лв.
            const double payForInternet = 15;
            //•	за други – събират се тока, водата и интернета за месеца и към сумата се прибавят 20%.
            double otherPayPercent = 0.2;
            //За всеки разход трябва да се пресметне колко общо е платено за всички месеци.

            //input
            //•	Първи ред – месеците за които се търси средният разход – цяло число в интервала [1...100]
            int mounts = int.Parse(Console.ReadLine());
            //•	За всеки месец – сметката за ток – реално число в интервала[1.00...1000.00]
            
            double payForOther = 0;
            double payForElectricityAll = 0;

            for (int i = 0; i < mounts; i++)
            {
                double payForElectricity = double.Parse(Console.ReadLine());
                payForElectricityAll += payForElectricity;
                payForOther += (payForWater + payForInternet + payForElectricity) * (1 + otherPayPercent);
            }
            double payForAll = payForWater * mounts + payForInternet * mounts + payForElectricityAll + payForOther;
            //output
            //•	1ви ред: "Electricity: {ток за всички месеци} lv"
            Console.WriteLine($"Electricity: {payForElectricityAll:F2} lv");
            //•	2ри ред: "Water: {вода за всички месеци} lv"
            Console.WriteLine($"Water: {payForWater * mounts:F2} lv");
            //•	3ти ред: "Internet: {интернет за всички месеци} lv"
            Console.WriteLine($"Internet: {payForInternet * mounts:F2} lv");
            //•	4ти ред: "Other: {други за всички месеци} lv"
            Console.WriteLine($"Other: {payForOther:F2} lv");
            //•	5ти ред: "Average: {средно всички разходи за месец} lv"
            Console.WriteLine($"Average: {payForAll / mounts:F2} lv");
            //Всички числа трябва да са форматирана до вторият знак след запетаята.

        }
    }
}
