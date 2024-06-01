using System.ComponentModel.DataAnnotations;

namespace SchoolApp.Models
{
    public class Lesson
    {
        [Key]
        public int LessonId { get; set; }
        public string Image { get; set; }
        public string LessonName { get; set;}
        public string LessonDescription { get; set;}
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set;}
    }
}
