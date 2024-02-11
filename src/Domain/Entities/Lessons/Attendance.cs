using Domain.Comman;
using Domain.Entities.Users;
using Domain.Enums;

namespace Domain.Entities.Lessons
{
    public class Attendance : Auditable
    {
        public long LessonId { get; set; }
        public long StudentId { get; set; }
        public AttendanceStatus Status { get; set; }
        public string Description { get; set; }

        public virtual Lesson Lesson { get; set; }
        public virtual Student Student { get; set; }
    }
}
