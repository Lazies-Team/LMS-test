using Domain.Enums;

namespace Application.DataTransferObjects.Tasks
{
    public record TaskResultCreationDTO
    (
        long StudentId,
        long HomeworkId,
        string Description,
        TaskResultStatus TaskResultStatus
    );
}