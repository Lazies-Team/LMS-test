using Microsoft.AspNetCore.Http;

namespace Application.DataTransferObjects.Lessons
{
    public record class VideoModificationDTO
    (
        long Id,
        IFormFile? Path,
        string Size,
        string Description,
        long LessonId,
        long TeacherId
    );
}