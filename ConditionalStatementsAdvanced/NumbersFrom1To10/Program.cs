using System;
using System.Xml.Schema;

namespace NumbersFrom1To10
{
    class Program
    {
        static void Main()
        {
            int number = 1;
            //Напишете програма, която отпечатва числата от 1 до 10, по едно на ред.
            while (number <= 10)
            {
                Console.WriteLine(number);
                number += 1;
            }
        }
    }
}
