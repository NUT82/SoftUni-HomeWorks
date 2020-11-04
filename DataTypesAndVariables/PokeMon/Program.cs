using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {

            //input
            //•	The input consists of 3 lines.
            //•	On the first line you will receive N – an integer.
            int pokePower = int.Parse(Console.ReadLine()); //You will be given the poke power the Poke Mon has, N – an integer.
            //•	On the second line you will receive M – an integer.
            int distance = int.Parse(Console.ReadLine()); //Then you will be given the distance between the poke targets, M – an integer.
            //•	On the third line you will receive Y – an integer.
            int exhaustionFactor = int.Parse(Console.ReadLine()); //Then you will be given the exhaustionFactor Y – an integer.

            int countOfPoke = 0;
            double halfPokePower = pokePower / 2.0; //NOTE: When you are calculating percentages, you should be PRECISE at maximum.
                                                    //Example: 505 is NOT EXACTLY 50 % from 1000, its 50.5 %.
            while (pokePower >= distance)
            {
                pokePower -= distance;
                countOfPoke++;
                if (pokePower == halfPokePower && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }

            //output
            //•	The output consists of 2 lines.
            //•	On the first line print what has remained of N, after subtracting from it.
            Console.WriteLine(pokePower);
            //•	On the second line print the count of targets, you’ve managed to poke.
            Console.WriteLine(countOfPoke);
        }
    }
}
