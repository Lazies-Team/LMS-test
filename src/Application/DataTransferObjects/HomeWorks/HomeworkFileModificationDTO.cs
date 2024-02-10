using Microsoft.AspNetCore.Http;

namespace Application.DataTransferObjects.HomeWorks
{
    public record class HomeworkFileModificationDTO
    (
        long Id,
        long HomeworkId,
        IFormFile? Path
    );
}