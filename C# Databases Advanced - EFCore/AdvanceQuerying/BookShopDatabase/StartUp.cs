using BookShop.Data;
using BookShop.Models.Enums;
using System;
using System.Linq;
using System.Text;

namespace BookShop
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            BookShopContext context = new BookShopContext();
            //string command = Console.ReadLine();

            //Console.WriteLine(GetBooksByAgeRestriction(context, command));
            //Console.WriteLine(GetGoldenBooks(context));
            Console.WriteLine(GetBooksByPrice(context));
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            if (Enum.TryParse(command, true, out AgeRestriction ageRestriction))
            {
                string[] titles = context.Books
                                    .Where(r => r.AgeRestriction == ageRestriction)
                                    .Select(b => b.Title)
                                    .OrderBy(t => t)
                                    .ToArray();

                return string.Join(Environment.NewLine, titles);
            }

            return $"{command} is not valid restriction!";
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            string[] titles = context.Books
                                    .Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000)
                                    .OrderBy(i => i.BookId)
                                    .Select(b => b.Title)
                                    .ToArray();

            return string.Join(Environment.NewLine, titles);
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var titlesAndPrices = context.Books
                                    .Where(b => b.Price > 40)
                                    .Select(b => new
                                    {
                                        b.Title,
                                        b.Price
                                    })
                                    .OrderByDescending(p => p.Price)
                                    .ToList();

            foreach (var item in titlesAndPrices)
            {
                sb.AppendLine($"{item.Title} - ${item.Price:F2}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
