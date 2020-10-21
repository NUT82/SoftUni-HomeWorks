using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = Console.ReadLine();

            while (true)
            {
                string inputPassword = Console.ReadLine();
                if (inputPassword == password)
                {
                    Console.WriteLine($"Welcome {userName}!");
                    break;
                }
            }
        }
    }
}
