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
        public Book[] GetAllByTitle(string titlePart)
        {
            return books.Where(book => book.Title.Contains(titlePart))
                        .ToArray();
        }
    } 
}
