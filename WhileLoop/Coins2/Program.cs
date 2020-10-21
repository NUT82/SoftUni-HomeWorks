using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            //Производителите на вендинг машини искали да направят машините си да връщат възможно най-малко монети ресто. Напишете програма, която приема сума - рестото, което трябва да се върне и изчислява с колко най-малко монети може да стане това.
            double returnedMoney = double.Parse(Console.ReadLine());
            double returnedMoneyInStotinks = returnedMoney * 100;

            int countOfCoins = 0;

            while (returnedMoneyInStotinks >= 1)
            {
                if (returnedMoneyInStotinks >= 200)
                {
                    returnedMoneyInStotinks -= 200;
                }
                else if (returnedMoneyInStotinks >= 100)
                {
                    returnedMoneyInStotinks -= 100;
                }
                else if (returnedMoneyInStotinks >= 50)
                {
                    returnedMoneyInStotinks -= 50;
                }
                else if (returnedMoneyInStotinks >= 20)
                {
                    returnedMoneyInStotinks -= 20;
                }
                else if (returnedMoneyInStotinks >= 10)
                {
                    returnedMoneyInStotinks -= 10;
                }
                else if (returnedMoneyInStotinks >= 5)
                {
                    returnedMoneyInStotinks -= 5;
                }
                else if (returnedMoneyInStotinks >= 2)
                {
                    returnedMoneyInStotinks -= 2;
                }
                else
                {
                    returnedMoneyInStotinks -= 1;
                }
                countOfCoins++;
            }
            Console.WriteLine(countOfCoins);
        }
    }
}

