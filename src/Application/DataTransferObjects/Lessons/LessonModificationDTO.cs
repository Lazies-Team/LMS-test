namespace Application.DataTransferObjects.Lessons
{
    public record class LessonModificationDTO
    (
        long Id,
        string Name,
        DateOnly Date,
        long CourseId
    );
}