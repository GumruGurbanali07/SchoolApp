using Microsoft.AspNetCore.Identity;

namespace SchoolApp.Models
{
    public class User : IdentityUser
    {
        public string NameSurname { get; set; }
        public string Image { get; set; }
    }
}
