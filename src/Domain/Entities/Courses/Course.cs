using Domain.Comman;
using Domain.Entities.Lessons;
using Domain.Entities.Users;

namespace Domain.Entities.Courses
{
    public class Course : Auditable
    {
        public string Name { get; set; }
        public long SpecialityId { get; set; }
        public TimeOnly LessonStartAt { get; set; }
        public TimeOnly LessonEndAt { get; set; }
        public DateOnly StartAt { get; set; }
        public DateOnly EndAt { get; set; }

        public virtual Speciality Specialty { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
