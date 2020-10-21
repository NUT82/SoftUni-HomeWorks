using System;

namespace TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            double winMoney = 0;
            int daysWinCount = 0;
            int daysLoseCount = 0;

            int days = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < days; i++)
            {
                int winCountCurrDay = 0;
                int loseCountCurrDay = 0;
                double winMoneyForCurrDay = 0;
                string sportType = Console.ReadLine();
                while (sportType != "Finish")
                {
                    string resultForCurrGame = Console.ReadLine();
                    if (resultForCurrGame == "win")
                    {
                        winMoneyForCurrDay += 20;
                        winCountCurrDay++;
                    }
                    else
                    {
                        loseCountCurrDay++;
                    }
                    sportType = Console.ReadLine();
                }
                if (winCountCurrDay > loseCountCurrDay)
                {
                    winMoneyForCurrDay += winMoneyForCurrDay * 0.1;
                    daysWinCount++;
                }
                else
                {
                    daysLoseCount++;
                }
                winMoney += winMoneyForCurrDay;
                
            }
            if (daysWinCount > daysLoseCount)
            {
                winMoney += winMoney * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {winMoney:F2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {winMoney:F2}");
            }
        }
    }
}
