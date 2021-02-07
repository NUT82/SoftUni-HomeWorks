using System;
using System.Linq;

namespace Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();
            Threeuple<string, string, string> threeupleOne = new Threeuple<string, string, string>(firstLine[0] + ' ' + firstLine[1], firstLine[2], string.Join(' ', firstLine.TakeLast(firstLine.Length - 3)));
            Console.WriteLine($"{threeupleOne.FirstItem} -> {threeupleOne.SecondItem} -> {threeupleOne.ThirdItem}");

            string[] secondLine = Console.ReadLine().Split();
            Threeuple<string, int, bool> threeupleTwo = new Threeuple<string, int, bool>(secondLine[0], int.Parse(secondLine[1]), secondLine[2] == "drunk");
            Console.WriteLine($"{threeupleTwo.FirstItem} -> {threeupleTwo.SecondItem} -> {threeupleTwo.ThirdItem}");

            string[] thirdLine = Console.ReadLine().Split();
            Threeuple<string, double, string> threeupleThree = new Threeuple<string, double, string>(thirdLine[0], double.Parse(thirdLine[1]), thirdLine[2]);
            Console.WriteLine($"{threeupleThree.FirstItem} -> {threeupleThree.SecondItem} -> {threeupleThree.ThirdItem}");
        }
    }
}
