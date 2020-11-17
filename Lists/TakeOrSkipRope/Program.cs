using System;
using System.Collections.Generic;

namespace TakeOrSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<int> digitsOfText = new List<int>(text.Length);
            List<char> nonDigitsOfText = new List<char>(text.Length);

            foreach (var item in text)
            {
                if (char.IsDigit(item))
                {
                    digitsOfText.Add(int.Parse(item.ToString()));
                }
                else
                {
                    nonDigitsOfText.Add(item);
                }
            }
            List<int> takeList = new List<int>(digitsOfText.Count);
            List<int> skipList = new List<int>(digitsOfText.Count);

            for (int i = 0; i < digitsOfText.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(digitsOfText[i]);
                }
                else
                {
                    skipList.Add(digitsOfText[i]);
                }
            }

            List<string> output = new List<string>(nonDigitsOfText.Count);
            int index = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                int offset = takeList[i];
                if (index + offset > nonDigitsOfText.Count - 1)
                {
                    offset = nonDigitsOfText.Count - index;
                }

                for (int j = index; j < index + offset; j++)
                {
                    output.Add(nonDigitsOfText[j].ToString());
                }
                
                index += takeList[i] + skipList[i];
            }

            Console.WriteLine(string.Join("",output));
        }
    }
}
