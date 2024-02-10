namespace Application.DataTransferObjects.CourseConfiguration
{
    public record class CourseModificationDTO
    (
        long Id,
        long CourseId,
        long StudentId
    );
}