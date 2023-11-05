using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonInfoMVC.Models;
using System;

namespace PersonInfoMVC.Controllers
{
    public class PersonController : Controller
    {

        // GET: PersonController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PersonController/Create
        public ActionResult Create()
        {
            return View();

        }

        // POST: PersonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, PersonModel person)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
