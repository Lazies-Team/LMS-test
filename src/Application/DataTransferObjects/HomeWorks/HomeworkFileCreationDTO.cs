using Microsoft.AspNetCore.Http;

namespace Application.DataTransferObjects.HomeWorks
{
    public record HomeworkFileCreationDTO
    (
        long HomeworkId,
        IFormFile Path
    );
}
