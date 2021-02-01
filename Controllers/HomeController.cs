using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.Models;

namespace TestProject.Controllers
{
    public class HomeController : Controller
    {

        private readonly IContactRepository _contactRepository;

        public HomeController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public IActionResult Index()
        {
            var model = _contactRepository.GetAllContacts();
            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var model = _contactRepository.GetContact(id);
            return View(model);
        }
    }
}
