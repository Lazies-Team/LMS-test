using Domain.Entities.Homeworks;
using Domain.Entities.Tasks;

namespace Application.ViewModel
{
    public record HomeworkViewModel
    (
        long Id,
        string Description,
        long LessonId,
        DateTime Deadline,
        DateTime CreatedAt,
        DateTime UpdatedDate,
        ICollection<TaskResult> TaskResults,
        ICollection<HomeworkFile> HomeworkFiles
    );
}
