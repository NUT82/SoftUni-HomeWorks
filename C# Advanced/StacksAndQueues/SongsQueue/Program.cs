using System;
using System.Collections.Generic;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));
            while (songs.Count > 0)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songs));
                        break;
                    default:
                        string song = command.Substring(4, command.Length - 4);
                        if (songs.Contains(song))
                        {
                            Console.WriteLine(song + " is already contained!");
                        }
                        else
                        {
                            songs.Enqueue(song);
                        }
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
