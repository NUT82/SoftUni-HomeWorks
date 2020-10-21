using System;

namespace MaxOrMinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която до получаване на командата "Stop", чете цели числа, въведени от потребителя, и намира най-голямото измежду тях. Въвежда се по едно число на ред. 
            string input = Console.ReadLine();
            int minNumber = int.MaxValue;

            while (input != "Stop")
            {
                int number = int.Parse(input);
                if (number < minNumber)
                {
                    minNumber = number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
