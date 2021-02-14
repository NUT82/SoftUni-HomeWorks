using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        readonly List<Book> books;
        
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
            BookComparator bookComparator = new BookComparator();

            this.books.Sort(bookComparator);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        class LibraryIterator : IEnumerator<Book>
        {
            readonly List<Book> books;
            int currentIndex;

            public LibraryIterator(List<Book> books)
            {
                Reset();
                this.books = new List<Book>(books);
            }

            public Book Current => books.ToList()[currentIndex];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                currentIndex++;
                return currentIndex < books.Count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
    }
}
