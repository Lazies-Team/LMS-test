using Domain.Entities.Courses;
using Domain.Entities.Users;

namespace Application.ViewModel
{
    public class TeacherViewModel
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedDate { get; set; }
        public long UserId { get; set; }

        public User User { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
