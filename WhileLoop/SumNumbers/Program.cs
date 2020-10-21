using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете цяло число от конзолата и на всеки следващ ред цели числа, докато тяхната сума стане по-голяма или равна на първоначалното число.. След приключване да се отпечата сумата на въведените числа.
            int targetNumber = int.Parse(Console.ReadLine());

            int sum = 0;
            while (sum < targetNumber)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                sum += inputNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
