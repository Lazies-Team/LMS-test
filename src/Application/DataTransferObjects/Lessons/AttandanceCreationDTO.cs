using Domain.Enums;

namespace Application.DataTransferObjects.Lessons
{
    public record AttandanceCreationDTO
    (
        long LessonId,
        long StudentId,
        AttendanceStatus Status,
        string Description
    );
}
