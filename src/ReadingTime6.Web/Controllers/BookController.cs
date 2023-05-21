using Microsoft.AspNetCore.Mvc;
using ReadingTime6.Web.Services;

namespace ReadingTime6.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly BookService bookService;

        public BookController()
        {
            bookService = new BookService();
        }

        // GET: Book
        public ActionResult Index()
        {
            return View(bookService.Books());
        }
   }
}