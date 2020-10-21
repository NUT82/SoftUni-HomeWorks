using System;

namespace InvalidNumber
{
    class Program
    {
        static void Main()
        {
            //Дадено число е валидно, ако е в диапазона [100…200] или е 0. Да се напише програма, която чете цяло число, въведено от потребителя, и печата "invalid" ако въведеното число не е валидно. 
            int number = int.Parse(Console.ReadLine());

            if ((number >= 100 && number <= 200) || number == 0)
            {
                //valid
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
