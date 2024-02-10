using Microsoft.AspNetCore.Http;

namespace Application.DataTransferObjects.Tasks
{
    public record TaskResultFIleModificationDTo
    (
        long Id,
        long TaskResultId,
        IFormFile FilePath
    );
}