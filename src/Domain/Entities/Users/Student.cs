using Domain.Comman;
using Domain.Entities.Courses;
using Domain.Entities.Tasks;

namespace Domain.Entities.Users
{
    public class Student : Auditable
    {
        public long StudentKey { get; set; }
        public long UserId { get; set; }

        public User User { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<TaskResult> TaskResults { get; set; }
    }
}
