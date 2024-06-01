namespace SchoolApp.Dtos
{
    public class RegisterDto
    {
        public string NameSurname { get; set; }
        public IFormFile Image { get; set; }
        public string Username { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
    }
}
