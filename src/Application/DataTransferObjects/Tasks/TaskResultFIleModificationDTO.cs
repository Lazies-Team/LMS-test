using Microsoft.AspNetCore.Http;

namespace Application.DataTransferObjects.Tasks
{
    public record TaskResultFIleModificationDTo
    (
        long TaskResultId,
        IFormFile FilePath
    );
}