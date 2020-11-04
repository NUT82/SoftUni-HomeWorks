using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            /*You will receive n lines.On those lines, you will receive one of the following:
            •	Opening bracket – “(“,
            •	Closing bracket – “)” or
            •	Random string
            Your task is to find out if the brackets are balanced.That means after every closing bracket should follow an opening one.Nested parentheses are not valid, and if two consecutive opening brackets exist, the expression should be marked as unbalanced.*/
            bool isBalanced = false;
            bool openBracket = false;
            //input
            //•	On the first line, you will receive n – the number of lines, which will follow
            int numberOfLines = int.Parse(Console.ReadLine());
            //•	On the next n lines, you will receive “(”, “)” or another string
            for (int i = 0; i < numberOfLines; i++)
            {
                string currString = Console.ReadLine();
                if (currString == "(" || currString == ")")
                {
                    if (currString == "(")
                    {
                        if (!openBracket)
                        {
                            openBracket = true;
                        }
                        else
                        {
                            openBracket = false;
                        }
                    }
                    if (currString == ")" && openBracket)
                    {
                        isBalanced = true;
                        openBracket = false;
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
            }

            //Output
            //You have to print “BALANCED”, if the parentheses are balanced and “UNBALANCED” otherwise.
            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }

        }
    }
}
