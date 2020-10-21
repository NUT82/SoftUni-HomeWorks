using System;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дадени са 2*n-на брой числа. Първото и второто формират двойка, третото и четвъртото също и т.н. Всяка двойка има стойност – сумата от съставящите я числа. Напишете програма, която проверява дали всички двойки имат еднаква стойност или печата максималната разлика между две последователни двойки. Ако всички двойки имат еднаква стойност, отпечатайте "Yes, value = {Value}" + стойността. В противен случай отпечатайте "No, maxdiff = {Difference}" + максималната разлика. 

            //input
            int countOfPairs = int.Parse(Console.ReadLine());

            double maxDiference = 0;
            double sumOfCurrPair = 0;
            bool allEqualPairs = true;

            for (int i = 0; i < countOfPairs; i++)
            {
                double currNumber1 = double.Parse(Console.ReadLine());
                double currNumber2 = double.Parse(Console.ReadLine());
                if (currNumber1 + currNumber2 == sumOfCurrPair || i == 0)
                {
                    sumOfCurrPair = currNumber1 + currNumber2;
                }
                else
                {
                    allEqualPairs = false;
                    if (maxDiference < Math.Abs(currNumber1 + currNumber2 - sumOfCurrPair))
                    {
                        maxDiference = Math.Abs(currNumber1 + currNumber2 - sumOfCurrPair);
                    }
                    sumOfCurrPair = currNumber1 + currNumber2;
                }
            }
            if (allEqualPairs)
            {
                Console.WriteLine($"Yes, value={sumOfCurrPair}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiference}");
            }
        }
    }
}
