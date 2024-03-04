using Application.DataTransferObjects.Lessons;
using Domain.Entities.Lessons;

namespace Application.Services.Contracts.Lessons
{
    public interface ILessonService
    {
        ValueTask<Lesson> AddAsync(LessonCreationDTO lessonCreationDTO);
        ValueTask<List<Lesson>> GetAllAsync();
        ValueTask<Lesson> GetByIdAsync(long id);
        ValueTask<Lesson> UpdateAsync(LessonModificationDTO lessonModificationDTO, long id);
        ValueTask<Lesson> DeleteAsync(long id);
    }
}
