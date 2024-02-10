using Domain.Comman;
using Domain.Entities.Homeworks;
using Domain.Entities.Users;
using Domain.Enums;

namespace Domain.Entities.Tasks
{
    public class TaskResult : Auditable
    {
        public long StudentId { get; set; }
        public long HomeworkId { get; set; }
        public string Description { get; set; }
        public TaskResultStatus TaskResultStatus { get; set; }

        public Student Student { get; set; }
        public Homework Homework { get; set; }
        public Grade Grade { get; set; }
        public ICollection<TaskResultFile> TaskResultFiles { get; set; }
    }
}
