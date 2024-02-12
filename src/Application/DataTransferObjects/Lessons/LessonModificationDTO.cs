namespace Application.DataTransferObjects.Lessons
{
    public record LessonModificationDTO
    (
        string Name,
        DateOnly Date,
        long CourseId
    );
}
