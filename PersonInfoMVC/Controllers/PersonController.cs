﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonInfoMVC.Models;
using System;

namespace PersonInfoMVC.Controllers
{
    public class PersonController : Controller
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        List<PersonModel> people = new();

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
        public ActionResult Create(PersonModel person)
        {
            if (ModelState.IsValid == false)
            {
                _logger.LogWarning("The user submitted an invalid person upon Create");
            }

            try
            {
                people.Add(person);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
