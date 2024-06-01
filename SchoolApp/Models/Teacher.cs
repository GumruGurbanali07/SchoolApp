namespace SchoolApp.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Image { get; set; }
        public string TeacherName { get; set; }
        public string TeacherDescription { get; set; }
        public List<Lesson> Lessons { get; set; }
    }
}
