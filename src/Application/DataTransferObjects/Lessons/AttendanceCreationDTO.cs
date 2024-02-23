using Domain.Enums;

namespace Application.DataTransferObjects.Lessons
{
    public record AttendanceCreationDTO
    (
        long LessonId,
        long StudentId,
        AttendanceStatus Status,
        string Description
    );
}
