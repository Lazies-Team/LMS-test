namespace Application.DataTransferObjects.CourseConfiguration
{
    public record CourseTeacherModificationDTO
    (
        long Id,
        long CourseId,
        long TeacherId
    );
}