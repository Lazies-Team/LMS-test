namespace Application.DataTransferObjects.HomeWorks
{
    public record class HomeworkCreationDTO
    (
        string Description,
        long LessonId,
        DateTime Deadline
    );
}