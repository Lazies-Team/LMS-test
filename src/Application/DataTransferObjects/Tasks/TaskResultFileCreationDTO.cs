using Microsoft.AspNetCore.Http;

namespace Application.DataTransferObjects.Tasks
{
    public record class TaskResultFileCreationDTO
    (
        long TaskResultId,
        IFormFile FilePath
    );
}