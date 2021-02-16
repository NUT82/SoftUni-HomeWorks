using System;
using System.Linq;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack<int> customStack = new CustomStack<int>();

            string input = Console.ReadLine();
            while (input != "END")
            {
                if (input == "Pop")
                {
                    try
                    {
                        customStack.Pop();
                    }
                    catch (IndexOutOfRangeException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    customStack.Push(input  .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                            .Skip(1)
                                            .Select(int.Parse)
                                            .ToArray());
                }
                input = Console.ReadLine();
            }
            for (int i = 0; i < 2; i++)
            {
                foreach (var item in customStack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
