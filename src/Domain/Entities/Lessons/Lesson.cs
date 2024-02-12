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

        public virtual Course Course { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
        public virtual ICollection<Homework> Homeworks { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}
