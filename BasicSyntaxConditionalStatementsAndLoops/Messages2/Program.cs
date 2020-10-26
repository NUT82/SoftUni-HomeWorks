using System;

namespace Messages2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int firstLetterIndex = (int)'a';
            int numberOfLetters = int.Parse(Console.ReadLine());
            string smsText = "";
            for (int i = 0; i < numberOfLetters; i++)
            {
                int currInput = int.Parse(Console.ReadLine());
                int lenghtOfCurrInput = currInput.ToString().Length;
                /* check validity of input
                if (lenghtOfCurrInput > 4)
                {
                    currInput = 1; // give invalid case
                }
                else if (lenghtOfCurrInput > 3 && (currInput % 10 == 7 || currInput % 10 == 9))
                {
                    currInput = 1; // give invalid case
                }
                else if (lenghtOfCurrInput > 1 && (currInput % 10 == 1 || currInput % 10 == 0))
                {
                    currInput = 1; // give invalid case
                }
                else
                {
                    for (int j = 0; j < currInput.ToString().Length - 1; j++)
                    {
                        if (currInput.ToString()[j] != currInput.ToString()[j + 1])
                        {
                            currInput = 1; // give invalid case
                        }
                    }
                }*/
                int offset = (currInput % 10 - 2) * 3 + lenghtOfCurrInput - 1;
                if (currInput % 10 > 7)
                {
                    offset++;
                }
                string currLetter = char.ConvertFromUtf32(firstLetterIndex + offset);
                if (currInput != 1)
                {
                    if (currInput == 0)
                    {
                        smsText += ' ';
                    }
                    else
                    {
                        smsText += currLetter;
                    }
                }
            }
            Console.WriteLine(smsText);
        }
    }
}
