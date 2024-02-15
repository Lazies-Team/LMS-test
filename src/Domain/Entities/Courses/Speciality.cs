using Domain.Comman;

namespace Domain.Entities.Courses
{
    public class Speciality : Auditable
    {
        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
