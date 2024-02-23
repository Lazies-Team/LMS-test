using Domain.Entities.Courses;
using Domain.Entities.Users;

namespace Domain.Entities
{
    public class CourseTeacher
    {
        public long CourseId { get; set; }
        public virtual Course Course { get; set; }

        public long TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
