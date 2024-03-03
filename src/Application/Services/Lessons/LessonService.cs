using Application.Abstractions.Lessons;
using Application.DataTransferObjects.Lessons;
using Application.Services.Contracts.Lessons;
using Domain.Entities.Lessons;
using Mapster;

namespace Application.Services.Lessons
{
    public class LessonService : ILessonService
    {
        private readonly ILessonRepository _lessonRepository;

        public LessonService(ILessonRepository lessonRepository)
            => _lessonRepository = lessonRepository;

        public async ValueTask<Lesson> AddAsync(LessonCreationDTO lessonCreationDTO)
        {
            var lesson = lessonCreationDTO.Adapt<Lesson>();
            var result = await _lessonRepository.InsertAsync(lesson);

            return result;
        }

        public async ValueTask<Lesson> DeleteAsync(long id)
        {
            var result = await _lessonRepository.DeleteAsync(id);

            return result;
        }

        public async ValueTask<List<Lesson>> GetAllAsync()
        {
            var lessons = _lessonRepository.SelectAll().ToList();

            return lessons;
        }

        public async ValueTask<Lesson> GetByIdAsync(long id)
        {
            var result = await _lessonRepository.SelectByIdAsync(id);

            return result;
        }

        public async ValueTask<Lesson> UpdateAsync(LessonModificationDTO lessonModificationDTO, long id)
        {
            var lesson = lessonModificationDTO.Adapt<Lesson>();
            lesson.Id = id;

            var result = await _lessonRepository.UpdateAsync(lesson);

            return result;
        }
    }
}
