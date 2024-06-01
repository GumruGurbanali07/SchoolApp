using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace SchoolApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}