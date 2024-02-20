using Domain.Entities.Courses;

namespace Application.ViewModel.Users
{
    public record TeacherViewModel
    (
        long Id,
        DateTime CreatedAt,
        DateTime UpdatedDate,
        long UserId,
        ICollection<Course> Courses
    );
}
