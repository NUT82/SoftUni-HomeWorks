using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chat = new List<string>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] splitCommand = command.Split();
                string currCommand = splitCommand[0];
                string message = splitCommand[1];

                switch (currCommand)
                {
                    case "Chat":
                        chat.Add(message);
                        break;
                    case "Delete":
                        chat.Remove(message);
                        break;
                    case "Edit":
                        string newMessage = splitCommand[2];
                        int index = chat.IndexOf(message);
                        if (index >= 0)
                        {
                            chat[index] = newMessage;
                        }
                        break;
                    case "Pin":
                        if (chat.Remove(message))
                        {
                            chat.Add(message);
                        }
                        break;
                    case "Spam":
                        string[] spamMessages = splitCommand.Skip(1).ToArray();
                        for (int i = 0; i < spamMessages.Length; i++)
                        {
                            chat.Add(spamMessages[i]);
                        }
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, chat));
        }
    }
}
