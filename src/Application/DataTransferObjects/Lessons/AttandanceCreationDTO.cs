using Domain.Enums;

namespace Application.DataTransferObjects.Lessons
{
    public record class AttandanceCreationDTO
    (
        long LessonId,
        long StudentId,
        AttendanceStatus Status,
        string Description
    );
}