using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WOTAPI.Models.Book;
using WOTAPI.Services;

namespace WOTAPI.WebMVC.Controllers
{
    [Authorize]
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            var model = new BookListItem[0];
            return View(model);
        }

        // Get: Book/Create
        public ActionResult Create()
        {
            return View();
        }
        // Post: Book/Create
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookCreate book)
        {
            if (!ModelState.IsValid)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            };
            var service = new BookService();

            if (service.CreateBook(book))
            {
                return RedirectToAction("Index");
            }
            return View(book);
        }
    }
}