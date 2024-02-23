using Domain.Enums;

namespace Application.ViewModel
{
    public record AttendanceViewModel
    (
        long Id,
        long LessonId,
        long StudentId,
        AttendanceStatus Status,
        string Description,

        LessonViewModel Lesson,
        StudentViewModel Student
    );
}
