using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolApp.Models;

namespace SchoolApp.ViewComponents.LayoutViewComponents
{
    public class ProfileNavbarViewComponent : ViewComponent
    {
        private readonly UserManager<User> _userManager;

        public ProfileNavbarViewComponent(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(values);
        }

    }
}
