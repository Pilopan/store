using store;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 11111-11111", "D. Knuth", "Книга номер 1"),
            new Book(1, "ISBN 11111-22222", "M. Fowler", "Книга номер 2"),
            new Book(1, "ISBN 11111-33333", "B. Kernighan, D. Ritchie", "Книга номер 3"),    
        };

        public Book[] GelAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn)
                        .ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Author.Contains(query) || book.Title.Contains(query))
                        .ToArray();
        }
    } 
}
