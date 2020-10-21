using System;

namespace CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int purchasedFoodForDogInGrams = int.Parse(Console.ReadLine()) * 1000;
            int allEatenFood = 0;
            string input = Console.ReadLine();
            while (input != "Adopted")
            {
                int foodForCurrDay = int.Parse(input);
                allEatenFood += foodForCurrDay;
                input = Console.ReadLine();
            }
            int diference = Math.Abs(allEatenFood - purchasedFoodForDogInGrams);
            if (allEatenFood <= purchasedFoodForDogInGrams)
            {
                Console.WriteLine($"Food is enough! Leftovers: {diference} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {diference} grams more.");
            }
        }
    }
}
