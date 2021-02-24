using System;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            string[] command = Console.ReadLine().Split();
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "swap":
                        numbers = Swap(numbers, int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "multiply":
                        numbers = Multiply(numbers, int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "decrease":
                        numbers = numbers.Select(e => e -= 1).ToArray();
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        private static int[] Multiply(int[] numbers, int indexOne, int indexTwo)
        {
            numbers[indexOne] *= numbers[indexTwo];
            return numbers;
        }

        private static int[] Swap(int[] numbers, int indexOne, int indexTwo)
        {
            numbers[indexOne] = numbers[indexOne] ^ numbers[indexTwo];
            numbers[indexTwo] = numbers[indexOne] ^ numbers[indexTwo];
            numbers[indexOne] = numbers[indexOne] ^ numbers[indexTwo];
            return numbers;
        }
    }
}
