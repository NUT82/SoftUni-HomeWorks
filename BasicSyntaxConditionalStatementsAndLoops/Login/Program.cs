using System;
using System.Linq;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            byte countWrongPass = 0;
            do
            {
                string input = Console.ReadLine();
                string reversePass = string.Empty;
                for (int i = userName.Length - 1; i >= 0; i--)
                {
                    reversePass += userName[i];
                }
                 if (input != reversePass)
                {
                    countWrongPass++;
                    if (countWrongPass == 4)
                    {
                        Console.WriteLine($"User {userName} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
            } while (true);
        }
    }
}
