namespace Application.DataTransferObjects.HomeWorks
{
    public record HomeworkModificationDTO
    (
        string Description,
        long LessonId,
        DateTime Deadline
    );
}
