using System;

namespace CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            //Деси трябва да разхожда своята котка ежедневно, но не може да прецени колко минути са досатъчни на ден. Като знаете колко калории приема котката на ден, колко пъти и по колко минути Деси разхожда котката си, напишете програма, която изчислява дали разходката е достатъчна. За всяка минута от разходката, котката гори по 5 калории. Разходката е достатъчна, ако котката изграря 50% от приетите калории.

            //•	На първия ред - минути разходка на ден - цяло число в интервала [1...50]
            int minutesOfWalkAtDay = int.Parse(Console.ReadLine());
            //•	На втория ред - броят на разходките дневно - цяло число в интервала [1…10]
            int countOfWalksAtDay = int.Parse(Console.ReadLine());
            //•	На третия ред - приетите от котката калории на ден – цяло число в интервала [100…4000]
            int caloriesOfCatPerDay = int.Parse(Console.ReadLine());

            int burnCalories = minutesOfWalkAtDay * 5 * countOfWalksAtDay;

            if (burnCalories >= caloriesOfCatPerDay / 2.00)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnCalories}.");
            }

            //•	Ако изгорените калории през разходката са повече или равни на  50% от приетите през деня калории: 
            //"Yes, the walk for your cat is enough. Burned calories per day: {общо изгорени калории от разходката}." 
            //•	Ако  изгорените калории през разходката са по-малко от 50% от приетите през деня калории:
            // "No, the walk for your cat is not enough. Burned calories per day: {общо изгорени калории от разходката}."

        }
    }
}
