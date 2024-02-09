using Domain.Comman;
using Domain.Entities.Users;

namespace Domain.Entities
{
    public class CourseStudent : Auditable
    {
        public long CourseId { get; set; }
        public long StudentId { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
