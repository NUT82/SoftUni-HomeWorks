using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMsgs = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfMsgs; i++)
            {
                Adverisment.PrintRandomAdvertisment();
            }
        }
    }

    public class Adverisment
    {
        public static readonly string[] AllPhrases = {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."};
        public static readonly string[] AllEvents = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
        public static readonly string[] AllAuthors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        public static readonly string[] AllCities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

        public string Phrase { get; set; }
        public string Event { get; set; }
        public string Author { get; set; }
        public string City { get; set; }

        public static void PrintRandomAdvertisment()
        {
            Adverisment newAdver = new Adverisment();
            {
                int index = GiveRandomIndex(AllPhrases.Length);
                newAdver.Phrase = AllPhrases[index];
            }
            {
                int index = GiveRandomIndex(AllEvents.Length);
                newAdver.Event = AllEvents[index];
            }
            {
                int index = GiveRandomIndex(AllAuthors.Length);
                newAdver.Author = AllAuthors[index];
            }
            {
                int index = GiveRandomIndex(AllCities.Length);
                newAdver.City = AllCities[index];
            }

            Console.WriteLine($"{newAdver.Phrase} {newAdver.Event} {newAdver.Author} – {newAdver.City}.");
        }

        private static int GiveRandomIndex(int length)
        {
            Random rnd = new Random();
            return rnd.Next(length);
        }
    }
}
