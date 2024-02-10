namespace Application.DataTransferObjects.HomeWorks
{
    public record class HomeworkModificationDTO
    (
        long Id,
        string Description,
        long LessonId,
        DateTime Deadline
    );
}