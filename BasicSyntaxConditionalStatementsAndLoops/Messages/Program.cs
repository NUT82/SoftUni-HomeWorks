using System;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which emulates typing an SMS, following this guide:
            /*
             1	 2   3
                 abc def
            4    5   6
            ghi	 jkl mno
            7    8   9
            pqrs tuv wxyz
                 0
                space	
            */
            int numberOfLetters = int.Parse(Console.ReadLine());
            string smsText = "";
            for (int i = 0; i < numberOfLetters; i++)
            {
                int currInput = int.Parse(Console.ReadLine());
                int lenghtOfCurrInput = currInput.ToString().Length;
                // check validity of input
                if (lenghtOfCurrInput > 4)
                {
                    currInput = 10; // give invalid case
                }
                else if (lenghtOfCurrInput > 3 && (currInput % 10 == 7 || currInput % 10 == 9))
                {
                    currInput = 10; // give invalid case
                }
                else if (lenghtOfCurrInput > 1 && (currInput % 10 == 1 || currInput % 10 == 0))
                {
                    currInput = 10; // give invalid case
                }
                else
                {
                    for (int j = 0; j < currInput.ToString().Length - 1; j++)
                    {
                        if (currInput.ToString()[j] != currInput.ToString()[j + 1])
                        {
                            currInput = 10; // give invalid case
                        }
                    }
                }
                char currLetter = ' ';
                switch (currInput % 10)
                {
                    case 1:
                        break;
                    case 2:
                        if (lenghtOfCurrInput == 1)
                        {
                            currLetter = 'a';
                        }
                        else if (lenghtOfCurrInput == 2)
                        {
                            currLetter = 'b';
                        }
                        else
                        {
                            currLetter = 'c';
                        }
                        break;
                    case 3:
                        if (lenghtOfCurrInput == 1)
                        {
                            currLetter = 'd';
                        }
                        else if (lenghtOfCurrInput == 2)
                        {
                            currLetter = 'e';
                        }
                        else
                        {
                            currLetter = 'f';
                        }
                        break;
                    case 4:
                        if (lenghtOfCurrInput == 1)
                        {
                            currLetter = 'g';
                        }
                        else if (lenghtOfCurrInput == 2)
                        {
                            currLetter = 'h';
                        }
                        else
                        {
                            currLetter = 'i';
                        }
                        break;
                    case 5:
                        if (lenghtOfCurrInput == 1)
                        {
                            currLetter = 'j';
                        }
                        else if (lenghtOfCurrInput == 2)
                        {
                            currLetter = 'k';
                        }
                        else
                        {
                            currLetter = 'l';
                        }
                        break;
                    case 6:
                        if (lenghtOfCurrInput == 1)
                        {
                            currLetter = 'm';
                        }
                        else if (lenghtOfCurrInput == 2)
                        {
                            currLetter = 'n';
                        }
                        else
                        {
                            currLetter = 'o';
                        }
                        break;
                    case 7:
                        if (lenghtOfCurrInput == 1)
                        {
                            currLetter = 'p';
                        }
                        else if (lenghtOfCurrInput == 2)
                        {
                            currLetter = 'q';
                        }
                        else if (lenghtOfCurrInput == 3)
                        {
                            currLetter = 'r';
                        }
                        else
                        {
                            currLetter = 's';
                        }
                        break;
                    case 8:
                        if (lenghtOfCurrInput == 1)
                        {
                            currLetter = 't';
                        }
                        else if (lenghtOfCurrInput == 2)
                        {
                            currLetter = 'u';
                        }
                        else
                        {
                            currLetter = 'v';
                        }
                        break;
                    case 9:
                        if (lenghtOfCurrInput == 1)
                        {
                            currLetter = 'w';
                        }
                        else if (lenghtOfCurrInput == 2)
                        {
                            currLetter = 'x';
                        }
                        else if (lenghtOfCurrInput == 3)
                        {
                            currLetter = 'y';
                        }
                        else
                        {
                            currLetter = 'z';
                        }
                        break;
                    case 0:
                            currLetter = ' ';
                        break;
                    default:
                        break;
                }
                smsText += currLetter;
            }
            Console.WriteLine(smsText);
        }
    }
}
