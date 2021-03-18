using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isSuccessParse = int.TryParse(Console.ReadLine(), out int parseResult);

            if (isSuccessParse)
            {
                int addFive = parseResult + 5;

                Console.WriteLine(addFive);
            }
            else
            {
                Console.WriteLine("This is not number!");
            }
            
        }
    }
}
