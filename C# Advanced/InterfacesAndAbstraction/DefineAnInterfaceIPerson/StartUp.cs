using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBuyer> buyers = new List<IBuyer>();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] buyer = Console.ReadLine().Split();
                if (buyer.Length == 4)
                {
                    Citizen citizen = new Citizen(buyer[0], int.Parse(buyer[1]), buyer[2], buyer[3]);
                    buyers.Add(citizen);
                }
                else
                {
                    Rebel rebel = new Rebel(buyer[0], int.Parse(buyer[1]), buyer[2]);
                    buyers.Add(rebel);
                }
            }

            string name = Console.ReadLine();

            while (name != "End")
            {
                if (buyers.Select(b => b.Name).Contains(name))
                {
                    buyers.FirstOrDefault(b => b.Name == name).BuyFood();
                }

                name = Console.ReadLine();
            }

            Console.WriteLine(buyers.Sum(b => b.Food));
        }
    }
}
