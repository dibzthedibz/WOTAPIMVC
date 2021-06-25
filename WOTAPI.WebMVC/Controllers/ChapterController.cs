using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WOTAPI.Models.Chapter;
using WOTAPI.Services;

namespace WOTAPI.WebMVC.Controllers
{
    [Authorize]
    public class ChapterController : Controller
    {
        // GET: Chapter
        public ActionResult Index()
        {
            
            var service = CreateChapService();
            var model = service.GetChaps();

            return View(model);
        }
        // Get: Chapter/Create
        public ActionResult Create()
        {
            var service = CreateChapService();
            var books = service.CreateBookList();
            ViewBag.BookId = new SelectList(books, "BookId", "Title");
            return View();
        }
        // Post: Chapter/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ChapterCreate model)
        {
            if (!ModelState.IsValid)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var service = CreateChapService();
            if (service.ChapterCreate(model))
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ChapterService CreateChapService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new ChapterService(userId);
            return service;
        }
    }
}