using System;

namespace Sequence2kPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете число n, въведено от потребителя, и отпечатва всички числа ≤ n от редицата: 1, 3, 7, 15, 31, …. Всяко следващо число се изчислява като умножим предишното с 2 и добавим 1.
            int inputNumber = int.Parse(Console.ReadLine());
            int startNumner = 1;
            while (startNumner <= inputNumber)
            {
                Console.WriteLine(startNumner);
                startNumner = startNumner * 2 + 1;
            }
        }
    }
}
