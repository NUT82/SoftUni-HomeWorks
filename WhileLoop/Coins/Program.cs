using System;

namespace Coins
{
    class Program
    {
        static void Main()
        {
            //Производителите на вендинг машини искали да направят машините си да връщат възможно най-малко монети ресто. Напишете програма, която приема сума - рестото, което трябва да се върне и изчислява с колко най-малко монети може да стане това.
            double returnedMoney = double.Parse(Console.ReadLine());
            
            int countOfCoins = 0;

            while (returnedMoney >= 0.01)
            {
                if (returnedMoney >= 2)
                {
                    returnedMoney -= 2.00;
                }
                else if (returnedMoney >= 1)
                {
                    returnedMoney -= 1.00;
                }
                else if (returnedMoney >= 0.5)
                {
                    returnedMoney -= 0.50;
                }
                else if (returnedMoney >= 0.2)
                {
                    returnedMoney -= 0.20;
                }
                else if (returnedMoney >= 0.1)
                {
                    returnedMoney -= 0.10;
                }
                else if (returnedMoney >= 0.05)
                {
                    returnedMoney -= 0.05;
                }
                else if (returnedMoney >= 0.02)
                {
                    returnedMoney -= 0.02;
                }
                else
                {
                    returnedMoney -= 0.01;
                }
                countOfCoins++;
            }
            Console.WriteLine(countOfCoins);
        }
    }
}
