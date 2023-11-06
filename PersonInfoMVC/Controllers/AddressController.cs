using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonInfoMVC.Models;

namespace PersonInfoMVC.Controllers
{
    public class AddressController : Controller
    {
        private readonly ILogger<AddressController> _logger;

        public AddressController(ILogger<AddressController> logger)
        {
            _logger = logger;
        }

        // GET: AddressController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AddressController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddressController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddressModel data)
        {
            if (ModelState.IsValid == false)
            {
                _logger.LogWarning("The user submitted invalid address upon Create");
            }
  
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
