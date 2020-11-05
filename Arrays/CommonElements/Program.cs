using System;
using System.Linq;
using System.Text;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which prints common elements in two arrays. You have to compare the elements of the second array to the elements of the first.
            string[] firstArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] secondArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder outputString = new StringBuilder();
            foreach (var itemInSecondArray in secondArray)
            {
                foreach (var itemInFirstArray in firstArray)
                {
                    if (itemInSecondArray == itemInFirstArray)
                    {
                        outputString.Append(itemInSecondArray + " ");
                    }
                }
            }
            Console.WriteLine(outputString);
        }
    }
}
