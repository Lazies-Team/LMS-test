using Domain.Enums;

namespace Application.DataTransferObjects.Tasks
{
    public record TaskResultModificationDTO
    (
        long Id,
        long StudentId,
        long HomeworkId,
        string Description,
        TaskResultStatus TaskResultStatus
    );
}