using Store;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 11111-11111", "D. Knuth", "Книга номер 1","Description1",10.91m),
            new Book(2, "ISBN 11111-22222", "M. Fowler", "Книга номер 2", "Description2",15.91m),
            new Book(3, "ISBN 11111-33333", "B. Kernighan, D. Ritchie", "Книга номер 3", "Description3",20.91m),    
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
        public Book GetById(int id)
        {
            return books.Single(book => book.Id == id);
        }
    } 
}
