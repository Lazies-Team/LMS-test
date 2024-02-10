using Domain.Enums;

namespace Application.DataTransferObjects.Tasks
{
    public record class TaskResultCreationDTO
    (
        long StudentId,
        long HomeworkId,
        string Description,
        TaskResultStatus TaskResultStatus
    );
}