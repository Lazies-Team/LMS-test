namespace Application.DataTransferObjects.CourseConfiguration
{
    public record CourseTeacherModificationDTO
    (
        long CourseId,
        long TeacherId
    );
}