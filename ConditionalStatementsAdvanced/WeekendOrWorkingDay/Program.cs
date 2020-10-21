using System;
using System.Diagnostics;
using System.Dynamic;

namespace WeekendOrWorkingDay
{
    class Program
    {
        static void Main()
        {
            //Напишете програма която, чете ден от седмицата (текст), на английски език - въведен от потребителя.Ако денят е работен отпечатва на конзолата - "Working day", ако е почивен - "Weekend". Ако се въведе текст различен от ден от седмицата да се отпечата - "Error".
            string inputText = Console.ReadLine();

            switch (inputText)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }


        }
    }
}
