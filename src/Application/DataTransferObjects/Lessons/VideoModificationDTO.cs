using Microsoft.AspNetCore.Http;

namespace Application.DataTransferObjects.Lessons
{
    public record VideoModificationDTO
    (
        IFormFile? Path,
        string Description,
        long LessonId,
        long TeacherId
    );
}
