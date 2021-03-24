using BookShop.Data;
using BookShop.Models.Enums;
using System;
using System.Linq;

namespace BookShopAgeRestriction
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            BookShopContext context = new BookShopContext();
            string command = Console.ReadLine();

            Console.WriteLine();
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            AgeRestriction ageRestriction = Enum.Parse<AgeRestriction>(command, true);
            string[] titles = context.Books
                                    .Where(r => r.AgeRestriction == ageRestriction)
                                    .Select(b => b.Title)
                                    .OrderBy(t => t)
                                    .ToArray();

            return string.Join(Environment.NewLine, titles);
        }
    }
}
