using Microsoft.AspNetCore.Mvc;
using SchoolApp.Context;

namespace SchoolApp.ViewComponents.HomePageViewComponents
{
    public class HomePageTeachersViewComponent : ViewComponent
    {
        private readonly SchoolDbContext _schoolDbContext;

        public HomePageTeachersViewComponent(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var value = _schoolDbContext.Teachers.Take(4).ToList();
            return View(value);
        }
    }
}
