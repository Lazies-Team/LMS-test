using Domain.Comman;

namespace Domain.Entities.Tasks
{
    public class Grade : Auditable
    {
        public string Description { get; set; }
        public long TaskResultId { get; set; }
        public int Percent { get; set; }

        public TaskResult TaskResult { get; set; }
    }
}
