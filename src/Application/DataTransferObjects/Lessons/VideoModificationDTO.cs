using Microsoft.AspNetCore.Http;

namespace Application.DataTransferObjects.Lessons
{
    public record VideoModificationDTO
    (
        long Id,
        IFormFile? Path,
        string Size,
        string Description,
        long LessonId,
        long TeacherId
    );
}