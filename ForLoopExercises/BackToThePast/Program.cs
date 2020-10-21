using System;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            //Иванчо е на 18 години и получава наследство, което се състои от X сума пари и машина на времето. Той решава да се върне до 1800 година, но не знае дали парите ще са достатъчни, за да живее без да работи. Напишете програма, която пресмята, дали Иванчо ще има достатъчно пари, за да не се налага да работи до дадена година включително. Като приемем, че за всяка четна (1800, 1802 и т.н.) година ще харчи 12 000 лева. За всяка нечетна (1801,1803  и т.н.) ще харчи 12 000 + 50 * [годините, които е навършил през дадената година].
            const double moneySpentEvenYear = 12000;
            //input
            //•	Наследените пари – реално число в интервала [1.00 ... 1 000 000.00]
            double inheritedMoney = double.Parse(Console.ReadLine());
            //•	Годината, до която трябва да живее(включително) – цяло число в интервала[1801... 1900]
            int yearToGo = int.Parse(Console.ReadLine());
            double moneySpentForAllTime = 0;

            for (int i = 1800; i <= yearToGo; i++)
            {
                if (i % 2 == 0)
                {
                    moneySpentForAllTime += moneySpentEvenYear;
                }
                else
                {
                    moneySpentForAllTime += moneySpentEvenYear + 50 * (i - 1800 + 18);
                }
            }
            double diferenceMoney = Math.Abs(inheritedMoney - moneySpentForAllTime);

            //output
            //•	Ако парите са достатъчно:
            if (moneySpentForAllTime <= inheritedMoney)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {diferenceMoney:F2} dollars left.");
            }
            //o	"Yes! He will live a carefree life and will have {N} dollars left." – където N са парите, които ще му останат.
            //•	Ако парите НЕ са достатъчно:
            else
            {
                Console.WriteLine($"He will need {diferenceMoney:F2} dollars to survive.");
            }
            //o	"He will need {М} dollars to survive." – където M е сумата, която НЕ достига.

        }
    }
}
