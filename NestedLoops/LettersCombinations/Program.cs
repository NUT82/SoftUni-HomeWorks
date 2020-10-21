using System;

namespace LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която да принтира на конзолата всички комбинации от 3 букви в зададен интервал, като се пропускат комбинациите съдържащи зададена от конзолата буква. Накрая трябва да се изпринтира броят на отпечатаните комбинации.

            //Ред 1.	Малка буква от английската азбука за начало на интервала – от ‘a’ до ‚z’.
            string firstLetter = Console.ReadLine();
            //Ред 2.	Малка буква от английската азбука за край на интервала  – от първата буква до ‚z’.
            string endLetter = Console.ReadLine();
            //Ред 3.	Малка буква от английската азбука – от ‘a’ до ‚z’ – като комбинациите съдържащи тази буквата се пропускат.
            string exludingLetter = Console.ReadLine();
            const string allSmallLetters = "abcdefghijklmnopqrstuvwxyz";
            int startLetterIndex = allSmallLetters.IndexOf(firstLetter);
            int endLetterIndex = allSmallLetters.IndexOf(endLetter);
            

            int countCombinations = 0;
            for (int firstLetterFromCombination = startLetterIndex; firstLetterFromCombination <= endLetterIndex ; firstLetterFromCombination++)
            {
                for (int secondLetterFromCombination = startLetterIndex; secondLetterFromCombination <= endLetterIndex; secondLetterFromCombination++)
                {
                    for (int thirdLetterFromCombination = startLetterIndex; thirdLetterFromCombination <= endLetterIndex; thirdLetterFromCombination++)
                    {
                        if (allSmallLetters[firstLetterFromCombination].ToString() != exludingLetter && allSmallLetters[secondLetterFromCombination].ToString() != exludingLetter && allSmallLetters[thirdLetterFromCombination].ToString() != exludingLetter)
                        {
                            Console.Write($"{allSmallLetters[firstLetterFromCombination]}{allSmallLetters[secondLetterFromCombination]}{allSmallLetters[thirdLetterFromCombination]} ");
                            countCombinations++;
                        }
                    }
                }
            }
            Console.Write(countCombinations);

            //Да се отпечатат на един ред всички комбинации отговарящи на условието плюс броят им разделени с интервал.
        }
    }
}
