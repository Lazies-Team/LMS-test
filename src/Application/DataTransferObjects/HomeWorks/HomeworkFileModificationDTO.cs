using Microsoft.AspNetCore.Http;

namespace Application.DataTransferObjects.HomeWorks
{
    public record HomeworkFileModificationDTO
    (
        long HomeworkId,
        IFormFile? Path
    );
}
