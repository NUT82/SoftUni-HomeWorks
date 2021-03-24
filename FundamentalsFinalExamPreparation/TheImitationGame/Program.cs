using System;
using System.Linq;

namespace TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMsg = Console.ReadLine();

            string input = Console.ReadLine();
            while (input != "Decode")
            {
                string[] splitInput = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string command = splitInput[0];

                switch (command)
                {
                    case "Move":
                        int numberOfLetters = int.Parse(splitInput[1]);
                        encryptedMsg = MoveLetters(encryptedMsg, numberOfLetters);
                        break;
                    case "Insert":
                        int index = int.Parse(splitInput[1]);
                        string value = splitInput[2];
                        encryptedMsg = encryptedMsg.Insert(index, value);
                        break;
                    case "ChangeAll":
                        string substring = splitInput[1];
                        string replacement = splitInput[2];
                        encryptedMsg = encryptedMsg.Replace(substring, replacement);
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {encryptedMsg}");
        }

        private static string MoveLetters(string message, int numberOfLetters)
        {
            return message.Substring(numberOfLetters) + message.Substring(0, numberOfLetters);
        }
    }
}
