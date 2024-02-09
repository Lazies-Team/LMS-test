using Domain.Comman;

namespace Domain.Entities
{
    public class Lesson : Auditable
    {
        public string Name { get; set; }
        public DateOnly Date { get; set; }
        //public Course CourseId { get; set; }

    }
}
