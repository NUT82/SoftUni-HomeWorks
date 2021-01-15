using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine()); // 50
            int sizeOfGunBarrel = int.Parse(Console.ReadLine()); // 2
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 11 10 5 11 10 20 
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray(); //   15 13 16 
            int intelligence = int.Parse(Console.ReadLine()); // 1500
            Queue<int> locksQueue = new Queue<int>(locks);
            Stack<int> bulletsStack = new Stack<int>(bullets);
            int useBullets = 0;
            
            while (bulletsStack.Count > 0 && locksQueue.Count > 0)
            {
                if (bulletsStack.Pop() <= locksQueue.Peek())
                {
                    locksQueue.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                useBullets++;
                if (useBullets % sizeOfGunBarrel == 0 && bulletsStack.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                }
            }

            if (locksQueue.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }
            else
            {
                int moneyEarned = intelligence - useBullets * priceOfBullet;
                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${moneyEarned}");
            }
        }
    }
}
