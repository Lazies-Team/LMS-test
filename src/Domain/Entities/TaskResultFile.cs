using Domain.Comman;

namespace Domain.Entities
{
    public class TaskResultFile : Auditable
    {
        public long TaskResultId { get; set; }
        public string FilePath { get; set; }

        public TaskResult TaskResult { get; set; }
    }
}
