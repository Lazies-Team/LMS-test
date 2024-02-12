using Microsoft.AspNetCore.Http;

namespace Application.DataTransferObjects.Tasks
{
    public record TaskResultFileCreationDTO
    (
        long TaskResultId,
        IFormFile FilePath
    );
}