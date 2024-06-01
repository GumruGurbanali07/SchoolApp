using Microsoft.AspNetCore.Mvc;
using SchoolApp.Context;

namespace SchoolApp.ViewComponents.HomePageViewComponents
{
    public class HomePageLessonsViewComponent : ViewComponent
    {
        private readonly SchoolDbContext _schoolDbContext;

        public HomePageLessonsViewComponent(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var value = _schoolDbContext.Lessons.ToList();
            return View(value);
        }
    }
}
