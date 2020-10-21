using System;
using System.Threading;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Снимките за дългоочаквания филм "Годзила срещу Конг" започват. Сценаристът Адам Уингард ви моли да напишете програма, която да изчисли, дали предвидените средства са достатъчни за снимането на филма. За снимките  ще бъдат нужни определен брой статисти, облекло за всеки един статист и декор.
            //Известно е, че:
            //•	Декорът за филма е на стойност 10% от бюджета. 
            //•	При повече от 150 статиста,  има отстъпка за облеклото на стойност 10%.
            const double decorCost = 0.1;
            const double discountClothing = 0.1;

            //input
            //Ред 1.	Бюджет за филма – реално число в интервала [1.00 … 1000000.00]
            double needBudget = double.Parse(Console.ReadLine());
            //Ред 2.	Брой на статистите – цяло число в интервала [1 … 500]
            int numberOfExtras = int.Parse(Console.ReadLine());
            //Ред 3.	Цена за облекло на един статист – реално число в интервала [1.00 … 1000.00]
            double priceOfClothingForOneExtra = double.Parse(Console.ReadLine());

            //calculations
            double priceOfClothing = numberOfExtras * priceOfClothingForOneExtra;
            if (numberOfExtras > 150)
            {
                priceOfClothing = priceOfClothing - priceOfClothing * discountClothing;
            }
            double budget = needBudget * decorCost + priceOfClothing;
            double diferenceBudget = Math.Abs(budget - needBudget);

            //На конзолата трябва да се отпечатат два реда:
            //•	Ако  парите за декора и дрехите са повече от бюджета:
            if (budget > needBudget)
            {
                //o	"Not enough money!"
                //o	"Wingard needs {парите недостигащи за филма} leva more."
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {diferenceBudget:F2} leva more.");
            }
            //•	Ако парите за декора и дрехите са по малко или равни на бюджета:
            else
            {
                //o	"Action!" 
                //o	"Wingard starts filming with {останалите пари} leva left."
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {diferenceBudget:F2} leva left.");
            }
            //Резултатът трябва да е форматиран до втория знак след десетичната запетая.
        }
    }
}
