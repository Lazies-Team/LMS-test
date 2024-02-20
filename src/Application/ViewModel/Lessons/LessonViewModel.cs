using Domain.Entities.Courses;
using Domain.Entities.Homeworks;
using Domain.Entities.Lessons;

namespace Application.ViewModel.Lessons
{
    public record LessonViewModel
    (
        long id,
        string Name,
        DateOnly Date,
        long CourseId,
        DateTime CreatedAt,
        DateTime UpdatedDate,
        Course Course,
        ICollection<Video> Videos,
        ICollection<Homework> Homeworks,
        ICollection<Attendance> Attendances
    );
}
