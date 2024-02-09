using Domain.Comman;
using Domain.Entities.Users;
using Domain.Enums;

namespace Domain.Entities
{
    public class Attendance : Auditable
    {
        public long LessonId { get; set; }
        public long StudentId { get; set; }
        public Status Status { get; set; }
        public string Description { get; set; }

        public Lesson Lesson { get; set; }
        public Student Student { get; set; }

    }
}
