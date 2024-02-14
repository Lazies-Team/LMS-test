using Domain.Entities.Courses;
using Domain.Entities.Tasks;

namespace Application.ViewModel
{
    public record StudentViewModel(
        long Id,
        string StudentKey,
        long UserId,
        //User User,
        ICollection<Course> Courses,
        ICollection<TaskResult> TaskResults,
        DateTime CreatedAt,
        DateTime UpdatedDate
    );
}
