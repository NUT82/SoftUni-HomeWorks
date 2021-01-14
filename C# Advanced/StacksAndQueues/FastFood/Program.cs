using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Console.WriteLine(orders.Max());
            while (orders.Count > 0)
            {
                int currOrder = orders.Peek();
                if (quantityOfFood < currOrder)
                {
                    break;
                }
                else
                {
                    quantityOfFood -= orders.Dequeue();
                }
            }

            if (orders.Count > 0)
            {
                Console.WriteLine("Orders left: " + string.Join(" ", orders));
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
