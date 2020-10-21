using System;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Имаме банкноти и монети по 1лв., по 2лв. и по 5лв. Да се напише програма, която прочита въведените от потребителя брой банкноти и монети и сума, и извежда на екран всички възможни начини по които сумата може да се изплати с наличните банкноти. 

            //1.	Брой монети по 1лв. - цяло положително число; 
            int monetsOneLv = int.Parse(Console.ReadLine());
            //2.	Брой монети по 2лв. - цяло положително число;
            int monetsTwoLv = int.Parse(Console.ReadLine());
            //3.	Брой банкноти по 5лв. - цяло положително число;
            int banknotesFiveLv = int.Parse(Console.ReadLine());
            //4.	Сума - цяло положително число в интервала [1…1000];
            int sumOfAllCash = int.Parse(Console.ReadLine());

            for (int oneLv = 0; oneLv <= monetsOneLv; oneLv++)
            {
                for (int twoLv = 0; twoLv <= monetsTwoLv; twoLv++)
                {
                    for (int fiveLv = 0; fiveLv <= banknotesFiveLv; fiveLv++)
                    {
                        if (oneLv * 1 + twoLv * 2 + fiveLv * 5 == sumOfAllCash)
                        {
                            Console.WriteLine($"{oneLv} * 1 lv. + {twoLv} * 2 lv. + {fiveLv} * 5 lv. = {sumOfAllCash} lv.");
                        }
                    }
                }
            }

            //Да се отпечатат на конзолата всички комбинации от дадените номинали, образуващи сумата, форматирани по следния начин:
            //o	"{бр. 1лв.} * 1 lv. + {бр. 2лв.} * 2 lv. + {бр. 5лв.} * 5 lv. = {сума} lv."

        }
    }
}
