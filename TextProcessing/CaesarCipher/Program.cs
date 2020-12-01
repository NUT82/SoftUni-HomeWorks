using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            StringBuilder encryptLine = new StringBuilder();
            foreach (var symbol in line)
            {
                encryptLine.Append((char)(symbol + 3));
            }

            Console.WriteLine(encryptLine);
        }
    }
}
