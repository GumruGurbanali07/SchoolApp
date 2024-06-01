using Microsoft.AspNetCore.Mvc;
using SchoolApp.Context;

namespace SchoolApp.Controllers
{
    public class AboutController : Controller
    {
        private readonly SchoolDbContext _schoolDbContext;

        public AboutController(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
        }

        public IActionResult Index()
        {
            var value = _schoolDbContext.About.ToList();
            return View(value);
        }
    }
}
