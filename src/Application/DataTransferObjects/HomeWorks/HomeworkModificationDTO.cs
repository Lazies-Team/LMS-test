namespace Application.DataTransferObjects.HomeWorks
{
    public record HomeworkModificationDTO
    (
        long Id,
        string Description,
        long LessonId,
        DateTime Deadline
    );
}