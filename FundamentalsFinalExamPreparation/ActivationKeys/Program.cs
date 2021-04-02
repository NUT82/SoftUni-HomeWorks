using System;
using System.Linq;
using System.Text;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            const string delimiter = ">>>";
            string activationKey = Console.ReadLine(); // letters and numbers only

            string command = Console.ReadLine();
            while (command != "Generate")
            {
                string[] tokens = command.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                string currCommand = tokens[0];
                switch (currCommand)
                {
                    case "Contains":
                        string substring = tokens[1];
                        if (activationKey.Contains(substring))
                        {
                            Console.WriteLine($"{activationKey} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        string letterCase = tokens[1];
                        int startIndex = int.Parse(tokens[2]);
                        int endIndex = int.Parse(tokens[3]);
                        activationKey = FlipCase(activationKey, letterCase, startIndex, endIndex);
                        Console.WriteLine(activationKey);
                        break;
                    case "Slice":
                        startIndex = int.Parse(tokens[1]);
                        endIndex = int.Parse(tokens[2]);
                        activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(activationKey);
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {activationKey}");

        }

        private static string FlipCase(string text, string letterCase, int startIndex, int endIndex)
        {
            if (letterCase == "Upper")
            {
                text = text.Replace(text[startIndex..endIndex], text[startIndex..endIndex].ToUpper());
            }
            else
            {
                text = text.Replace(text[startIndex..endIndex], text[startIndex..endIndex].ToLower());
            }
            return text;
        }
    }
}
