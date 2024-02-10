using Domain.Enums;

namespace Application.DataTransferObjects.Lessons
{
    public record AttandanceModificationDTO
    (
        long LessonId,
        long StudentId,
        AttendanceStatus Status,
        string Description
    );
}
