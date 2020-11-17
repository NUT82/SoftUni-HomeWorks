using System;
using System.Collections.Generic;
using System.Linq;

namespace DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> initialDrumSet = drumSet.ToList();


            string input = Console.ReadLine();
            while (input != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);
                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= hitPower;
                }

                if(!drumSet.TrueForAll(x => x > 0))
                {
                    for (int i = 0; i < drumSet.Count; i++)
                    {
                        if (drumSet[i] <= 0)
                        {
                            double priceOfCurrDrum = initialDrumSet[i] * 3;
                            if (savings >= priceOfCurrDrum)
                            {
                                savings -= priceOfCurrDrum;
                                drumSet[i] = initialDrumSet[i];
                            }
                            else
                            {
                                drumSet.RemoveAt(i);
                                initialDrumSet.RemoveAt(i);
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", drumSet));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}
