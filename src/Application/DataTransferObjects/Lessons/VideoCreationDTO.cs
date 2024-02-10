using Microsoft.AspNetCore.Http;

namespace Application.DataTransferObjects.Lessons
{
    public record VideoCreationDTO
    (
        IFormFile Path,
        string Description,
        long LessonId,
        long TeacherId
    );
}
