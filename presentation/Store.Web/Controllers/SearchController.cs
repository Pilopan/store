using Microsoft.AspNetCore.Mvc;
using Store;

namespace Store.Web.Controllers
{
    public class SearchController : Controller
    {

        private readonly BookService bookService;
        public SearchController(BookService bookService)
        {
            this.bookService = bookService;
        }

        public IActionResult Index(string query)
        {
            if (query == null)
            {
                Book[] books = new Book[0];
                return View(books);
            } else
            {
                var books = bookService.GetAllByQuery(query);
                return View(books);
            }
            
        }
    }
}
