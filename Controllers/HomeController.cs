using Microsoft.AspNetCore.Mvc;
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
        [HttpGet]
        public IActionResult Index()
        {
            var model = _contactRepository.GetAllContacts();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(string name,
                                   string position,
                                   string address,
                                   string nickName,
                                   string phoneNumber,
                                   string email)
        {
            var model = new Contact
            {
                Name = name,
                Position = position,
                Address = address,
                NickName = nickName,
                PhoneNumber = phoneNumber,
                Email = email
            };

            _contactRepository.AddContact(model);
            var models = _contactRepository.GetAllContacts();

            return View(models);
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
