using Microsoft.AspNetCore.Http;

namespace Application.DataTransferObjects.HomeWorks
{
    public record class HomeworkFileCreationDTO
    (
        long HomeworkId,
        IFormFile Path
    );
}