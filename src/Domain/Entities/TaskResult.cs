using Domain.Comman;

namespace Domain.Entities
{
    public class TaskResult : Auditable
    {
        public long UserId { get; set; }
        public long HomeworkId { get; set; }
        public string Description { get; set; }
        public TaskResultStatus 
    }
}
