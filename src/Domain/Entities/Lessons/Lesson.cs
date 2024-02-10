using Domain.Comman;
using Domain.Entities.Courses;
using Domain.Entities.Homeworks;

namespace Domain.Entities.Lessons
{
    public class Lesson : Auditable
    {
        public string Name { get; set; }
        public DateOnly Date { get; set; }
        public long CourseId { get; set; }

        public Course Course { get; set; }
        public ICollection<Video> Videos { get; set; }
        public ICollection<Homework> Homeworks { get; set; }
        public ICollection<Attendance> Attendances { get; set; }
    }
}
