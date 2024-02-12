using Domain.Comman;

namespace Domain.Entities.Tasks
{
    public class TaskResultFile : Auditable
    {
        public long TaskResultId { get; set; }
        public string FilePath { get; set; }

        public virtual TaskResult TaskResult { get; set; }
    }
}
