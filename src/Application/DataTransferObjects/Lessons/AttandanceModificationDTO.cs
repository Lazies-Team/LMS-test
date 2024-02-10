using Domain.Enums;

namespace Application.DataTransferObjects.Lessons
{
    public record AttandanceModificationDTO
    (
        long Id,
        long LessonId,
        long StudentId,
        AttendanceStatus Status,
        string Description
    );
}