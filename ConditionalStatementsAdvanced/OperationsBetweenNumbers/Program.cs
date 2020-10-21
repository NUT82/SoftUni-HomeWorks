using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main()
        {
            //Напишете програма, която чете две цели числа (N1 и N2) и оператор, с който да се извърши дадена математическа операция с тях. Възможните операции са: Събиране(+), Изваждане(-), Умножение(*), Деление(/) и Модулно деление(%). При събиране, изваждане и умножение на конзолата трябва да се отпечатат резултата и дали той е четен или нечетен. При обикновеното деление – резултата. При модулното деление – остатъка. Трябва да се има предвид, че делителят може да е равен на 0(нула), а на нула не се дели. В този случай трябва да се отпечата специално съобщениe.

            //input
            //•	N1 – цяло число в интервала[0...40 000]
            int numberOne = int.Parse(Console.ReadLine());
            //•	N2 – цяло число в интервала[0...40 000]
            int numberTwo = int.Parse(Console.ReadLine());
            //•	Оператор – един символ измежду: „+“, „-“, „*“, „/“, „%“
            string symbol = Console.ReadLine();
            string evenOrOdd = "odd";
            double result = 0.0;
            
            if ((symbol == "/" || symbol == "%") && numberTwo == 0)
            {
                symbol = "error";
            }

            //output
            //•	Ако операцията е събиране, изваждане или умножение:
            //o "{N1} {оператор} {N2} = {резултат} – {even/odd}"
            switch (symbol)
            {
                case "+":
                    result = numberOne + numberTwo;
                    break;
                case "-":
                    result = numberOne - numberTwo;
                    break;
                case "*":
                    result = numberOne * numberTwo;
                    break;
                case "/":
                    result = (double)numberOne / (double)numberTwo;
                    break;
                case "%":
                    result = numberOne % numberTwo;
                    break;
                default: //error
            //•	В случай на деление с 0(нула): 
            //o   "Cannot divide {N1} by zero"
                    Console.WriteLine($"Cannot divide {numberOne} by zero");
                    break;
            }

            if (result % 2 == 0)
            {
                evenOrOdd = "even";
            }

            if (symbol == "+" || symbol == "-" || symbol == "*")
            {
                Console.WriteLine($"{numberOne} {symbol} {numberTwo} = {result} - {evenOrOdd}");
            }
            else if (symbol == "/")
            {
            //•	Ако операцията е деление:
            //o"{N1} / {N2} = {резултат}" – резултатът е форматиран до вторият знак след дес.запетая
                Console.WriteLine($"{numberOne} / {numberTwo} = {result:F2}");
            }
            else if (symbol == "%")
            {
            //•	Ако операцията е модулно деление:
            //o   "{N1} % {N2} = {остатък}"
                Console.WriteLine($"{numberOne} % {numberTwo} = {result}");
            }

        }
    }
}
