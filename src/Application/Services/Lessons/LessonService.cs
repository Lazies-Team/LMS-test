using Application.Abstractions.Lessons;
using Application.DataTransferObjects.Lessons;
using Application.Services.Contracts.Lessons;
using Application.ViewModel.Lessons;
using Domain.Entities.Lessons;
using Mapster;

namespace Application.Services.Lessons
{
    public class LessonService : ILessonService
    {
        private readonly ILessonRepository _lessonRepository;

        public LessonService(ILessonRepository lessonRepository)
            => _lessonRepository = lessonRepository;

        public async ValueTask<LessonViewModel> AddAsync(LessonCreationDTO lessonCreationDTO)
        {
            var lesson = lessonCreationDTO.Adapt<Lesson>();
            var created = await _lessonRepository.InsertAsync(lesson);
            var result = created.Adapt<LessonViewModel>();

            return result;
        }

        public async ValueTask<LessonViewModel> DeleteAsync(long id)
        {
            var lesson = await _lessonRepository.DeleteAsync(id);
            var deleted = lesson.Adapt<LessonViewModel>();

            return deleted;
        }

        public async ValueTask<List<LessonViewModel>> GetAllAsync()
        {
            var lesson = _lessonRepository.SelectAll();
            var lessons = lesson.ToList().Adapt<List<LessonViewModel>>();

            return lessons;
        }

        public async ValueTask<LessonViewModel> GetByIdAsync(long id)
        {
            var lesson = await _lessonRepository.SelectByIdAsync(id);
            var result = lesson.Adapt<LessonViewModel>();

            return result;
        }

        public async ValueTask<LessonViewModel> UpdateAsync(LessonModificationDTO lessonModificationDTO, long id)
        {
            var lesson = lessonModificationDTO.Adapt<Lesson>();
            lesson.Id = id;
            var update = await _lessonRepository.UpdateAsync(lesson);
            var result = update.Adapt<LessonViewModel>();

            return result;
        }
    }
}
