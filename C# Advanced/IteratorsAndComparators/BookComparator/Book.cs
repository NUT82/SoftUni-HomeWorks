using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }

        public int Year { get; set; }

        public IReadOnlyList<string> Authors { get; set; }
        
        public Book(string title, int year, params string[] authors)
        {
            Authors = new List<string>(authors);
            Title = title;
            Year = year;

        }

        public int CompareTo([AllowNull] Book other)
        {
            if (this.Year.CompareTo(other.Year) == 0)
                return Title.CompareTo(other.Title);

            return Year.CompareTo(other.Year);
        }

        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
}
