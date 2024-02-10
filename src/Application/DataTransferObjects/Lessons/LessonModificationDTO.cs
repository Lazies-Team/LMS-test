namespace Application.DataTransferObjects.Lessons
{
    public record LessonModificationDTO
    (
        long Id,
        string Name,
        DateOnly Date,
        long CourseId
    );
}
