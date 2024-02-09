using Domain.Comman;
using Domain.Entities.Users;
using Domain.Enums;

namespace Domain.Entities
{
    public class Attendance : Auditable
    {
        public Lesson LessonId { get; set; }
        public Student StudentId { get; set; }
        public Status Status { get; set; }
        public string Description { get; set; }

    }
}
