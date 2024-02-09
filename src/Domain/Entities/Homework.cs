using Domain.Comman;
using Domain.Entities.Users;

namespace Domain.Entities
{
    public class Homework : Auditable
    {
        public string Description { get; set; }
        public long LessonId { get; set; }
        public long UserId { get; set; }
        public DateTime Dedline { get; set; }

        public Lesson Lesson { get; set; }
        public User User { get; set; }
    }
}
