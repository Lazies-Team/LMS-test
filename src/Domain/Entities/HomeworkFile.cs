using Domain.Comman;

namespace Domain.Entities
{
    public class HomeworkFile : Auditable
    {
        public long HomeworkId { get; set; }
        public string Path { get; set; }

    }
}
