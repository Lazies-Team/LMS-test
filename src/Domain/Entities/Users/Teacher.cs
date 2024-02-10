using Domain.Comman;
using Domain.Entities.Courses;

namespace Domain.Entities.Users
{
    public class Teacher : Auditable
    {
        public long UserId { get; set; }

        public User User { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
