using Domain.Comman;

namespace Domain.Entities.Courses
{
    public class Specialty : Auditable
    {
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
