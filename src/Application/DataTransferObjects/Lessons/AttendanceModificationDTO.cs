using Domain.Enums;

namespace Application.DataTransferObjects.Lessons
{
    public record AttendanceModificationDTO
    (
        long LessonId,
        long StudentId,
        AttendanceStatus Status,
        string Description
    );
}
