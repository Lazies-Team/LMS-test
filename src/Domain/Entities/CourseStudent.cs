using Domain.Entities.Courses;
using Domain.Entities.Users;

namespace Domain.Entities
{
    public class CourseStudent
    {
        public long CourseId { get; set; }
        public long StudentId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
