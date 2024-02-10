namespace Application.DataTransferObjects.Lessons
{
    public record LessonCreationDTO
    (
        string Name,
        DateOnly Date,
        long CourseId
    );
}