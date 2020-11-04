using System;

namespace DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive a key (integer) and n characters afterward. Add the key to each of the characters and append them to a message. At the end print the message, which you decrypted. 
            string decryptedMsg = "";
            //input
            //•	On the first line, you will receive the key
            int key = int.Parse(Console.ReadLine());
            //•	On the second line, you will receive n – the number of lines, which will follow
            int numberOfLines = int.Parse(Console.ReadLine());
            //•	On the next n lines – you will receive lower and uppercase characters from the Latin alphabet
            for (int i = 0; i < numberOfLines; i++)
            {
                char currChar = char.Parse(Console.ReadLine());
                decryptedMsg += (char)(currChar + key);
            }
            Console.WriteLine(decryptedMsg);
        }
    }
}
