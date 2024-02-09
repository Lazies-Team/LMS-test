using Domain.Comman;

namespace Domain.Entities
{
    public class Course : Auditable
    {
        public string Name { get; set; }
        public Specialty SpecialityId { get; set; }
        public TimeOnly LessonStartAt { get; set; }
        public TimeOnly LessonEndAt { get; set; }
        public DateOnly StartAt { get; set; }
        public DateOnly EndAt { get; set; }

    }
}
