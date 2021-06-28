using Microsoft.AspNet.Identity;
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

            var service = CreateBookService();
            var model = service.GetBooks();

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
        public ActionResult Create(BookCreate model)
        {
            if (!ModelState.IsValid)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            };
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new BookService(userId);

            if (service.CreateBook(model))
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
        //Get: Book/Details
        public ActionResult Details(int id)
        {

            var service = CreateBookService();
            var cList = service.CreateChapterList(id);
            ViewBag.ChapterId = new SelectList(cList, "ChapterId", "ChapTitle");
            var model = service.GetBookDetail(id);
            return View(model);

        }

        public BookService CreateBookService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new BookService(userId);
            return service;
        }
    }
}