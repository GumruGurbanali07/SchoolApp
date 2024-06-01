using Microsoft.AspNetCore.Mvc;
using SchoolApp.Context;

namespace SchoolApp.ViewComponents.HomePageViewComponents
{
    public class HomePageAboutViewComponent : ViewComponent
    {
        private readonly SchoolDbContext _schoolDbContext;

        public HomePageAboutViewComponent(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var value = _schoolDbContext.About.ToList();
            return View(value);
        }
    }
}
