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
            var result = await _lessonRepository.InsertAsync(lesson);
            var lessonViewModel = result.Adapt<LessonViewModel>();

            return lessonViewModel;
        }

        public async ValueTask<LessonViewModel> DeleteAsync(long id)
        {
            var result = await _lessonRepository.DeleteAsync(id);
            var lessonViewModel = result.Adapt<LessonViewModel>();

            return lessonViewModel;
        }

        public async ValueTask<List<LessonViewModel>> GetAllAsync()
        {
            var result = _lessonRepository.SelectAll();
            var lessons = result.ToList().Adapt<List<LessonViewModel>>();

            return lessons;
        }

        public async ValueTask<LessonViewModel> GetByIdAsync(long id)
        {
            var result = await _lessonRepository.SelectByIdAsync(id);
            var lessonViewModel = result.Adapt<LessonViewModel>();

            return lessonViewModel;
        }

        public async ValueTask<LessonViewModel> UpdateAsync(LessonModificationDTO lessonModificationDTO, long id)
        {
            var lesson = lessonModificationDTO.Adapt<Lesson>();
            lesson.Id = id;
            var result = await _lessonRepository.UpdateAsync(lesson);
            var lessonViewModel = result.Adapt<LessonViewModel>();

            return lessonViewModel;
        }
    }
}
