using System;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = 100;
            int initialBitcoins = 0;

            string[] dungeonsRooms = Console.ReadLine().Split("|");
            int roomNumber = 0;
            foreach (var room in dungeonsRooms)
            {
                string command = room.Split()[0];
                int number = int.Parse(room.Split()[1]);
                roomNumber++;
                switch (command)
                {
                    case "potion":
                        initialHealth += number;
                        if (initialHealth > 100)
                        {
                            number -= initialHealth - 100;
                            initialHealth = 100;
                        }
                        Console.WriteLine($"You healed for {number} hp.");
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                        break;
                    case "chest":
                        initialBitcoins += number;
                        Console.WriteLine($"You found {number} bitcoins.");
                        break;
                    default:
                        initialHealth -= number;
                        string monster = command;
                        if (initialHealth > 0)
                        {
                            Console.WriteLine($"You slayed {monster}.");
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {monster}.");
                            Console.WriteLine($"Best room: {roomNumber}");
                            return;
                        }
                        break;
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {initialBitcoins}");
            Console.WriteLine($"Health: {initialHealth}");
        }
    }
}
