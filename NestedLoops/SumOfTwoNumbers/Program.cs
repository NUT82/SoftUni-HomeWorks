using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма която проверява всички възможни комбинации от двойка числа в интервала от две дадени числа. На изхода се отпечатва, коя поред е комбинацията чиито сбор от числата е равен на дадено магическо число. Ако няма нито една комбинация отговаряща на условието се отпечатва съобщение, че не е намерено.

            //•	Първи ред – начало на интервала – цяло число в интервала [1...999]
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            //•	Втори ред – край на интервала – цяло число в интервала [по-голямо от първото число...1000]
            //•	Трети ред – магическото число – цяло число в интервала [1...10000]
            int magicalNumber = int.Parse(Console.ReadLine());
            int countCombination = 0;
            string validCombination = "";
            bool isValidCombination = false;

            for (int i = number1; i <= number2; i++)
            {
                for (int a = number1; a <= number2; a++)
                {
                    countCombination++;
                    if (!isValidCombination && i + a == magicalNumber)
                    {
                        isValidCombination = true;
                        validCombination = countCombination + " (" + i + " + " + a;
                    }
                }
            }
            if (isValidCombination)
            {
                Console.WriteLine($"Combination N:{validCombination} = {magicalNumber})");
            }
            else
            {
                Console.WriteLine($"{countCombination} combinations - neither equals {magicalNumber}");
            }
            //•	Ако е намерена комбинация чиито сбор на числата е равен на магическото число
            //o	"Combination N:{пореден номер} ({първото число} + {второ число} = {магическото число})"
            //•	Ако не е намерена комбинация отговаряща на условието
            //o	"{броят на всички комбинации} combinations - neither equals {магическото число}"

        }
    }
}
