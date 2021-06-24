using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WOTAPI.Models.Book;

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
    }
}