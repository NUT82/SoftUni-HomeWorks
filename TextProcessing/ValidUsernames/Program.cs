using System;
using System.Globalization;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ");
            foreach (var user in userNames)
            {
                if (isValid(user))
                {
                    Console.WriteLine(user);
                }
            }
        }

        private static bool isValid(string user)
        {
            if (isValidLength(user) && hasValidSymbols(user))
            {
                return true;
            }
            return false;
        }

        private static bool hasValidSymbols(string user)
        {
            foreach (var symbol in user)
            {
                if (!char.IsLetterOrDigit(symbol) && symbol != '_' && symbol != '-')
                {
                    return false;
                }
            }
            return true;
        }

        private static bool isValidLength(string user)
        {
            if (user.Length >= 3 && user.Length <= 16)
            {
                return true;
            }
            return false;
        }
    }
}
