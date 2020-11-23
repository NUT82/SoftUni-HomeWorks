using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>(numberOfArticles);
            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] line = Console.ReadLine().Split(", ");
                Article article = new Article(line[0], line[1], line[2]);
                articles.Add(article);
            }

            string filter = Console.ReadLine();
            switch (filter)
            {
                case "title":
                    foreach(Article item in articles.OrderBy(x => x.Title))
            {
                        Console.WriteLine(item.ToString());
                    }
                    break;
                case "content":
                    foreach (Article item in articles.OrderBy(x => x.Content))
                    {
                        Console.WriteLine(item.ToString());
                    }
                    break;
                case "author":
                    foreach (Article item in articles.OrderBy(x => x.Author))
                    {
                        Console.WriteLine(item.ToString());
                    }
                    break;
                default:
                    break;
            }
        }
    }

    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
