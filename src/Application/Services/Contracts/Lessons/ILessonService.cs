using Application.DataTransferObjects.Lessons;
using Application.ViewModel.Lessons;

namespace Application.Services.Contracts.Lessons
{
    public interface ILessonService
    {
        ValueTask<LessonViewModel> AddAsync(LessonCreationDTO lessonCreationDTO);
        ValueTask<List<LessonViewModel>> GetAllAsync();
        ValueTask<LessonViewModel> GetByIdAsync(long id);
        ValueTask<LessonViewModel> UpdateAsync(LessonModificationDTO lessonModificationDTO, long id);
        ValueTask<LessonViewModel> DeleteAsync(long id);
    }
}
