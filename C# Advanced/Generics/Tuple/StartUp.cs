using System;

namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();
            Tuple<string, string> tuple = new Tuple<string, string>(firstLine[0] + ' ' + firstLine[1], firstLine[2]);
            Console.WriteLine($"{tuple.FirstItem} -> {tuple.SecondItem}");

            string[] secondLine = Console.ReadLine().Split();
            Tuple<string, int> tupleTwo = new Tuple<string, int>(secondLine[0], int.Parse(secondLine[1]));
            Console.WriteLine($"{tupleTwo.FirstItem} -> {tupleTwo.SecondItem}");

            string[] thirdLine = Console.ReadLine().Split();
            Tuple<int, double> tupleThree = new Tuple<int, double>(int.Parse(thirdLine[0]), double.Parse(thirdLine[1]));
            Console.WriteLine($"{tupleThree.FirstItem} -> {tupleThree.SecondItem}");
        }
    }
}
