using System;
using System.Linq;
using System.Numerics;
using System.Threading;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //A12b s17G	330.00	12/1=12, 12+2=14, 17*19=323, 323–7=316, 14+316=330
            string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            decimal result = 0;
            foreach (var item in strings)
            {
                Letter firstLetter = new Letter(item[0]);
                Letter lastLetter = new Letter(item[item.Length - 1]);
                decimal number = decimal.Parse(item.Substring(1, item.Length - 2));
                if (firstLetter.IsUppercase)
                {
                    number /= firstLetter.AlphabetPosition;
                }
                else
                {
                    number *= firstLetter.AlphabetPosition;
                }

                if (lastLetter.IsUppercase)
                {
                    number -= lastLetter.AlphabetPosition;
                }
                else
                {
                    number += lastLetter.AlphabetPosition;
                }

                result += number;
            }

            Console.WriteLine($"{result:F2}");
        }

        
    }

    public class Letter
    {
        public char Symbol { get; set; }
        public int AlphabetPosition { get; set; }
        public bool IsUppercase { get; set; }

        public Letter(char symbol)
        {
            Symbol = symbol;
            if (symbol < 'a')
            {
                IsUppercase = true;
            }
            else
            {
                IsUppercase = false;
            }
            AlphabetPosition = symbol.ToString().ToUpper().ToCharArray()[0] - 'A' + 1;
        }
    }
}
