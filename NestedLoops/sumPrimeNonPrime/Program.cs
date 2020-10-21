using System;

namespace sumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата цели числа в диапазона от -2,147,483,648 до 2,147,483,647, докато не се получи команда "stop". Да се намери сумата на всички въведени прости и сумата на всички въведени непрости числа. Тъй като по дефиниция от математиката отрицателните числа не могат да бъдат прости, ако на входа се подаде отрицателно число да се изведе следното съобщение "Number is negative.". В този случай въведено число се игнорира и не се прибавя към нито една от двете суми, а програмата продължава своето изпълнение, очаквайки въвеждане на следващо число. 
            //На изхода да се отпечатат на два реда двете намерени суми в следния формат:
            //"Sum of all prime numbers is: {prime numbers sum}"
            //"Sum of all non prime numbers is: {nonprime numbers sum}"

            string input = Console.ReadLine();
            int currNumber = 0;
            int sumPrime = 0;
            int sumNonPrime = 0;

            while (input != "stop")
            {
                currNumber = int.Parse(input);
                if (currNumber >= 0)
                {
                    int counter = 0;
                    for (int i = 2; i < currNumber; i++)
                    {
                        if (currNumber % i == 0)
                        {
                            counter++;
                        }
                    }
                    if (counter != 0)
                    {
                        sumNonPrime += currNumber;
                    }
                    else
                    {
                        sumPrime += currNumber;
                    }
                }
                else
                {
                    Console.WriteLine("Number is negative.");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
