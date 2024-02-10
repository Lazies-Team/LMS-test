using Domain.Comman;
using Domain.Entities.Users;
using Domain.Enums;

namespace Domain.Entities
{
    public class TaskResult : Auditable
    {
        public long UserId { get; set; }
        public long HomeworkId { get; set; }
        public string Description { get; set; }
        public TaskResultStatus TaskResultStatus { get; set; }

        public User User { get; set; }
        public Homework Homework { get; set; }
    }
}
