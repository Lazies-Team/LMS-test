using Microsoft.AspNetCore.Http;

namespace Application.DataTransferObjects.HomeWorks
{
    public record HomeworkFileModificationDTO
    (
        long Id,
        long HomeworkId,
        IFormFile? Path
    );
}
