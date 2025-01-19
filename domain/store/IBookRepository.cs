using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store
{
    public interface IBookRepository
    {
        Book[] GelAllByIsbn(string isbn);
        //Добавляел All, потому что возвращает несколько объектов, а не один
        //Интерфейсом определили метод для получения книг по названию (части названия)
        Book[] GetAllByTitle(string titlePart);
    }
}
