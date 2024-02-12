using Domain.Comman;

namespace Domain.Entities.Homeworks
{
    public class HomeworkFile : Auditable
    {
        public long HomeworkId { get; set; }
        public string Path { get; set; }

        public virtual Homework Homework { get; set; }
    }
}
