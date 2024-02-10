using Domain.Comman;
using Domain.Entities.Users;

namespace Domain.Entities
{
    public class Video : Auditable
    {
        public string Path { get; set; }
        public string Size { get; set; }
        public string Description { get; set; }
        public long LessonId { get; set; }
        public long UserId { get; set; }

        public Lesson Lesson { get; set; }
        public User User { get; set; }
    }
}
