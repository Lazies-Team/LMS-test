using Microsoft.AspNetCore.Http;

namespace Application.DataTransferObjects.Lessons
{
    public record class VideoCreationDTO
    (
        IFormFile Path,
        string Size,
        string Description,
        long LessonId,
        long TeacherId
    );
}