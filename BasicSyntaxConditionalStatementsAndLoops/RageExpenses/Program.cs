using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfLostGames = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());
            
            int countBreakingHeadset = countOfLostGames / 2;
            int countBreakingMouse = countOfLostGames / 3;
            int countBreakingKeyboard = countOfLostGames / 6;
            int countBreakingDisplay = countOfLostGames / 12;

            float expenses =    countBreakingHeadset    * headsetPrice + 
                                countBreakingMouse      * mousePrice + 
                                countBreakingKeyboard   * keyboardPrice + 
                                countBreakingDisplay    * displayPrice;

            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}
