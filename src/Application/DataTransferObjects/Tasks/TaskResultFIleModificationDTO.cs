using Microsoft.AspNetCore.Http;

namespace Application.DataTransferObjects.Tasks
{
    public record class TaskResultFIleModificationDTo
    (
        long Id,
        long TaskResultId,
        IFormFile FilePath
    );
}