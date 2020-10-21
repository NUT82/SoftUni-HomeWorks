using System;

namespace FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double foodForPets = double.Parse(Console.ReadLine());
            double biscuits = 0;
            double foodForDog = 0;
            double foodForCat = 0;

            for (int i = 1; i <= days; i++)
            {
                int dogFoodForCurrDay = int.Parse(Console.ReadLine());
                int catFoodForCurrDay = int.Parse(Console.ReadLine());
                foodForDog += dogFoodForCurrDay;
                foodForCat += catFoodForCurrDay;
                if (i % 3 == 0)
                {
                    biscuits += (dogFoodForCurrDay + catFoodForCurrDay) * 0.1;
                }
            }
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{(foodForCat + foodForDog) * 100 / foodForPets:F2}% of the food has been eaten.");
            Console.WriteLine($"{foodForDog * 100 / (foodForCat + foodForDog):F2}% eaten from the dog.");
            Console.WriteLine($"{foodForCat * 100 / (foodForCat + foodForDog):F2}% eaten from the cat.");
        }
    }
}
