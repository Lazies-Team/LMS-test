namespace Application.DataTransferObjects.HomeWorks
{
    public record HomeworkCreationDTO
    (
        string Description,
        long LessonId,
        DateTime Deadline
    );
}
