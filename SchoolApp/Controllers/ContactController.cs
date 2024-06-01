using Microsoft.AspNetCore.Mvc;
using SchoolApp.Context;
using SchoolApp.Models;

namespace SchoolApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly SchoolDbContext _context;

        public ContactController(SchoolDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
