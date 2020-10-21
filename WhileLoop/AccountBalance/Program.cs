using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която пресмята колко общо пари има в сметката, след като направите определен брой вноски. На всеки ред ще получавате сумата, която трябва да внесете в сметката, до получаване на команда "NoMoreMoney" . При всяка получена сума на конзолата трябва да се извежда "Increase: " + сумата и тя да се прибавя в сметката. Ако получите число по-малко от 0 на конзолата трябва да се изведе "Invalid operation!" и програмата да приключи. Когато програмата приключи трябва да се принтира "Total: " + общата сума в сметката закръглена до втория знак след десетичната запетая. 
            double accountBalance = 0;
            string amountDeposit = Console.ReadLine();

            while (amountDeposit != "NoMoreMoney")
            {
                double amount = double.Parse(amountDeposit);
                if (amount >= 0)
                {
                    accountBalance += amount;
                    Console.WriteLine($"Increase: {amount:F2}");
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                amountDeposit = Console.ReadLine();
            }
            Console.WriteLine($"Total: {accountBalance:F2}");
        }
    }
}
