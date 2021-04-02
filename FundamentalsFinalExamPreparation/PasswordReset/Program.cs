using System;
using System.Text;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Done")
            {
                string[] tokens = command.Split();
                switch (tokens[0])
                {
                    case "TakeOdd":
                        password = TakeOdd(password);
                        Console.WriteLine(password);
                        break;
                    case "Cut":
                        int index = int.Parse(tokens[1]);
                        int length = int.Parse(tokens[2]);
                        string substring = password.Substring(index, length);
                        int firstIndex = password.IndexOf(substring);
                        password = password.Remove(firstIndex, length);
                        Console.WriteLine(password);
                        break;
                    case "Substitute":
                        string substringOne = tokens[1];
                        string substringTwo = tokens[2];
                        if (password.Contains(substringOne))
                        {
                            password = password.Replace(substringOne, substringTwo);
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }

        private static string TakeOdd(string password)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < password.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sb.Append(password[i]);
                }
            }

            return sb.ToString();
        }
    }
}
