using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfValues = Console.ReadLine();
            string valueOne = Console.ReadLine();
            string valueTwo = Console.ReadLine();

            switch (typeOfValues)
            {
                case "int":
                    Console.WriteLine(GetMax(int.Parse(valueOne), int.Parse(valueTwo)));
                    break;
                case "char":
                    Console.WriteLine(GetMax(valueOne[0], valueTwo[0]));
                    break;
                case "string":
                    Console.WriteLine(GetMax(valueOne, valueTwo));
                    break;
                default:
                    break;
            }
        }

        static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            return num2;
        }

        static char GetMax(char char1, char char2)
        {
            if (char1 > char2)
            {
                return char1;
            }
            return char2;
        }

        static string GetMax(string string1, string string2)
        {
            if (string.Compare(string1, string2) > 0)
            {
                return string1;
            }
            return string2;
        }
    }
}
