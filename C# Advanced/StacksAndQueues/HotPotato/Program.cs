using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();
            int number = int.Parse(Console.ReadLine());
            int count = 1;
            Queue<string> kidsQueue = new Queue<string>(kids);
            while (kidsQueue.Count > 1)
            {
                if (count == number)
                {
                    Console.WriteLine("Removed " + kidsQueue.Dequeue());
                    count = 1;
                }
                else
                {
                    kidsQueue.Enqueue(kidsQueue.Dequeue());
                    count++;
                }
            }
            Console.WriteLine("Last is " + kidsQueue.Dequeue());
        }
    }
}
