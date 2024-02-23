using Domain.Entities.Lessons;
using Domain.Entities.Users;
using Domain.Enums;

namespace Application.ViewModel.Lessons
{
    public record AttendanceViewModel
    (
        long Id,
        string Description,
        AttendanceStatus Status,
        long StudentId,
        long LessonId,
        DateTime CreatedAt,
        DateTime UpdatedDate,
        Lesson Lesson,
        Student Student
    );
}
