using store;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "Книга номер 1"),
            new Book(1, "Книга номер 2"),
            new Book(1, "Книга номер 3"),    
        };
        public Book[] GetAllByTitle(string titlePart)
        {
            return books.Where(book => book.Title.Contains(titlePart))
                        .ToArray();
        }
    } 
}
