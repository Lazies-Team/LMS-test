using Domain.Entities.Courses;
using Domain.Entities.Tasks;

namespace Application.ViewModel.Users
{
    public record StudentViewModel(
        long Id,
        string StudentKey,
        long UserId,
        ICollection<Course> Courses,
        ICollection<TaskResult> TaskResults,
        DateTime CreatedAt,
        DateTime UpdatedDate
    );
}
