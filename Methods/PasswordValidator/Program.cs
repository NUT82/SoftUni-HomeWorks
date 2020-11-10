using System;
using System.Linq;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            PasswordValidator(password);
        }

        private static void PasswordValidator(string password)
        {
            bool isValid = true;
            int countOfDigits = 0;
            int countOfLetters = 0;
            foreach (var item in password)
            {
                if (char.IsDigit(item))
                {
                    countOfDigits++;
                }
                else if (char.IsLetter(item))
                {
                    countOfLetters++;
                }
            }
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }
            if (password.Length != countOfDigits + countOfLetters)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }
            if (countOfDigits < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }
            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
