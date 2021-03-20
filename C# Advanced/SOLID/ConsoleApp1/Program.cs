using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            var pianist = new Dictionary<string, Dictionary<string,string>>();


            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split("|");
                string peace = tokens[0];
                string composer = tokens[1];
                string key = tokens[2];
                pianist.Add(peace, new Dictionary<string, string>());
                pianist[peace].Add(composer, key);
            }

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] tokens = input.Split("|");
                string command = tokens[0];
                string piece = tokens[1];
                

                if (command == "Add")
                {
                    string composer = tokens[2];
                    string key = tokens[3];
                    if (!pianist.ContainsKey(piece))
                    {
                        pianist.Add(piece, new Dictionary<string, string>());
                        pianist[piece].Add(composer, key);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (command == "Remove")
                {
                    if (pianist.ContainsKey(piece))
                    {
                        pianist.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (command == "ChangeKey")
                {
                    string newKey = tokens[2];
                    if (pianist.ContainsKey(piece))
                    {
                        string currPianist = pianist[piece].Select(c => c.Key).FirstOrDefault();
                        pianist[piece][currPianist] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in pianist.OrderBy(x => x.Key))
            {
                foreach (var item in kvp.Value.OrderBy(c => c.Key))
                {
                    Console.WriteLine($"{kvp.Key} -> Composer: {item.Key}, Key: {item.Value}");
                }
            }


        }
    }
}
