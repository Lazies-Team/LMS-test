using Domain.Enums;

namespace Application.DataTransferObjects.Tasks
{
    public record TaskResultModificationDTO
    (
        long StudentId,
        long HomeworkId,
        string Description,
        TaskResultStatus TaskResultStatus
    );
}