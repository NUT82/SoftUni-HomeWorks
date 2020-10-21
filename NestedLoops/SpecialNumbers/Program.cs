using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете едно цяло число N, въведено от потребителя, и генерира всички възможни “специални” числа от 1111 до 9999. За да бъде “специалнo” едно число, то трябва да отговаря на следното условие: 
            //•	N да се дели на всяка една от неговите цифри без остатък.
            //Пример: при N = 16, 2418 е специално число:
            //•	16 / 2 = 8 без остатък
            //•	16 / 4 = 4 без остатък
            //•	16 / 1 = 16 без остатък
            //•	16 / 8 = 2 без остатък

            //Входът се чете от конзолата и се състои от едно цяло число в интервала [1…600000]
            int number = int.Parse(Console.ReadLine());
            for (int i = 1111; i <= 9999; i++)
            {
                string numerToString = i.ToString();
                int counter = 0;
                for (int a = 0; a < 4; a++)
                {
                    int currDigit = int.Parse(numerToString[a].ToString());
                    if (currDigit != 0)
                    {
                        if (number % currDigit == 0)
                        {
                            counter++;
                        }
                    } 
                }
                if (counter == 4)
                {
                    Console.Write(i + " ");
                }
            }


            //На конзолата трябва да се отпечатат всички “специални” числа, разделени с интервал

        }
    }
}
