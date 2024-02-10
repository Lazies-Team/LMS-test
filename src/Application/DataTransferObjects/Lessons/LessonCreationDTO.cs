namespace Application.DataTransferObjects.Lessons
{
    public record class LessonCreationDTO
    (
        string Name,
        DateOnly Date,
        long CourseId
    );
}