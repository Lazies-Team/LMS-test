using Domain.Comman;
using Domain.Entities.Lessons;
using Domain.Entities.Tasks;

namespace Domain.Entities.Homeworks
{
    public class Homework : Auditable
    {
        public string Description { get; set; }
        public long LessonId { get; set; }
        public DateTime Deadline { get; set; }

        public virtual Lesson Lesson { get; set; }
        public virtual ICollection<TaskResult> TaskResults { get; set; }
        public virtual ICollection<HomeworkFile> HomeworkFiles { get; set; }
    }
}
