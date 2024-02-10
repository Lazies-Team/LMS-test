namespace Application.DataTransferObjects.CourseConfiguration
{
    public record CourseModificationDTO
    (
        long Id,
        long CourseId,
        long StudentId
    );
}