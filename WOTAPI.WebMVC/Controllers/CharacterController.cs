using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WOTAPI.Data;
using WOTAPI.Models.Character;
using WOTAPI.Services;

namespace WOTAPI.WebMVC.Controllers
{
    public class CharacterController : Controller
    {
        // GET: Character
        public ActionResult Index()
        {
            var service = CreateCharacterService();
            var model = service.GetCharacters();
            return View(model);
        }

        // Get: Character/Create
        public ActionResult Create()
        {
            var service = CreateCharacterService();
            var chars = service.CreateCharacterList();
            ViewBag.CharacterId = new SelectList(chars, "CharacterId", "FullName");
            return View();
        }

        // Post: Character/Create
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CharacterCreate model)
        {
            if (!ModelState.IsValid)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            };
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new CharacterService(userId);

            if (service.CreateCharacter(model))
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        

        public CharacterService CreateCharacterService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new CharacterService(userId);
            return service;
        }
    }
}