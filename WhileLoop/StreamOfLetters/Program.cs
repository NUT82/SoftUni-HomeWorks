using System;

namespace StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която прочита скрито съобщение в поредица от символи. Те се получават по един на ред до получаване на командата "End". Думите се образуват от буквите в реда на четенето им. Символите, които не са латински букви трябва да бъдат игнорирани. Думите скрити в потока са разделени от тайна команда от три букви – "c", "o" и "n". При първото получаване на една от тези букви, тя се маркира като срещната, но не се запазва в думата. При всяко следващо нейно срещане се записва нормално в думата. След като са налични и трите символа от командата, се печата думата и интервал " ". Започва се нова дума, която по същия начин чака тайната команда, за да бъде отпечатана.
            const string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            //От конзолата се чете поредица от редове с един символ на всеки до получаване на командата "End".
            string input = Console.ReadLine();
            int countInputCharC = 0;
            int countInputCharO = 0;
            int countInputCharN = 0;
            string currWord = "";
            string outputText = "";

            while (input != "End")
            {
                if (allowedChars.Contains(input))
                {
                    switch (input)
                    {
                        case "c":
                            countInputCharC++;
                            if (countInputCharC > 1)
                            {
                                currWord += input;
                            }
                            break;
                        case "o":
                            countInputCharO++;
                            if (countInputCharO > 1)
                            {
                                currWord += input;
                            }
                            break;
                        case "n":
                            countInputCharN++;
                            if (countInputCharN > 1)
                            {
                                currWord += input;
                            }
                            break;
                        default:
                            currWord += input;
                            break;
                    }
                    if (countInputCharC > 0 && countInputCharN > 0 && countInputCharO > 0)
                    {
                        countInputCharC = countInputCharN = countInputCharO = 0;
                        outputText += currWord + " ";
                        currWord = "";
                    }
                }
                input = Console.ReadLine();
            }

            //На конзолата се печата на един ред всяка дума след тайната команда, следвана от интервал.
            Console.Write(outputText);
        }
    }
}
