using Domain.Comman;
using Domain.Entities.Courses;
using Domain.Entities.Tasks;

namespace Domain.Entities.Users
{
    public class Student : Auditable
    {
        public string StudentKey { get; set; }
        public long UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<TaskResult> TaskResults { get; set; }
    }
}
