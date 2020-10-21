using System;

namespace Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            //Гошо работи в ресторант и отговаря за зареждането на съдомиялната накрая на деня.
            //Вашата задача е да напишете програма, която изчислява, дали дадено закупено количество бутилки от препарат за съдомиялна е достатъчно, за да измие определено количество съдове. Знае се, че всяка бутилка съдържа 750 мл. препарат, за 1 чиния са нужни 5 мл., а за тенджера 15 мл.  Приемете, че на всяко трето зареждане със съдове, съдомиялната се пълни само с тенджери, а останалите пъти с чинии. Докато не получите команда "End" ще продължите да получавате бройка съдове, които трябва да бъдат измити.
            const int detergentForOneDish = 5;
            const int detergentForOnePot = 15;
            //•	Брой бутилки от препарат, който ще бъде използван за миенето на чинии - цяло число в интервала [1…10]
            int bottlesDetergent = int.Parse(Console.ReadLine());
            int detergentInMl = bottlesDetergent * 750;
            bool detergentIsOver = false;
            int washedDishes = 0;
            int washedPots = 0;
            int countOfWashingCicles = 0;

            //На всеки следващ ред, до получаване на командата "End" или докато количеството препарат не се изчерпи, брой съдове, които трябва да бъдат измити -цяло число в интервала[1…100]
            string input = Console.ReadLine();

            while (input != "End")
            {
                countOfWashingCicles++;
                if (countOfWashingCicles == 3)
                {
                    countOfWashingCicles = 0;
                    washedPots += int.Parse(input);
                    detergentInMl -= int.Parse(input) * detergentForOnePot;
                }
                else
                {
                    washedDishes += int.Parse(input);
                    detergentInMl -= int.Parse(input) * detergentForOneDish;
                }
                if (detergentInMl <= 0)
                {
                    detergentIsOver = true;
                    break;
                }
                input = Console.ReadLine();
            }
            //В случай, че количеството препарат е било достатъчно за измиването на съдовете:
            if (!detergentIsOver || detergentInMl == 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{washedDishes} dishes and {washedPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergentInMl} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(detergentInMl)} ml. more necessary!");
            }
            //"Detergent was enough!"
            //"{брой чисти чинии} dishes and {брой чисти тенджери} pots were washed."
            //"Leftover detergent {количество останал препарат} ml."
            //В случай, че количеството препарат не е било достатъчно за измиването на съдовете:
            //"Not enough detergent, {количество не достигнал препарат} ml. more necessary!"

        }
    }
}
