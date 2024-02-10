namespace Application.DataTransferObjects.CourseConfiguration
{
    public record class CourseTeacherModificationDTO
    (
        long Id,
        long CourseId,
        long TeacherId
    );
}