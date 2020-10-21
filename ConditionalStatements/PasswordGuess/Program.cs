using System;

namespace PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете парола (един ред с произволен текст), въведена от потребителя и проверява, дали въведеното съвпада с фразата "s3cr3t!P@ssw0rd". При съвпадение да се изведе "Welcome". При несъвпадение да се изведе "Wrong password!".
            const string rightPassword = "s3cr3t!P@ssw0rd";
            string password = Console.ReadLine();

            if (password == rightPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
