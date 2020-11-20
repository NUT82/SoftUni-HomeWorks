using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>(numberOfSongs);

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] inputLine = Console.ReadLine().Split("_");
                Song currSong = new Song();
                currSong.TypeList = inputLine[0];
                currSong.Name = inputLine[1];
                currSong.Time = inputLine[2];

                songs.Add(currSong);
            }

            string command = Console.ReadLine();
            if (command == "all")
            {
                foreach(var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs.Where(x => x.TypeList == command))
                {
                    Console.WriteLine(song.Name);
                }
            }
            
        }
        
    }
    
}
