using Application.Abstractions.Homeworks;
using Application.DataTransferObjects.HomeWorks;
using Application.Services.Contracts.Homeworks;
using Domain.Entities.Homeworks;
using Mapster;

namespace Application.Services.Homeworks
{
    public class HomeworkService : IHomeworkService
    {
        private readonly IHomeworkRepository _homeworkRepository;

        public HomeworkService(IHomeworkRepository homeworkRepository)
            => _homeworkRepository = homeworkRepository;

        public async ValueTask<Homework> AddAsync(HomeworkCreationDTO homeworkCreationDTO)
        {
            var homework = homeworkCreationDTO.Adapt<Homework>();
            var created = await _homeworkRepository.InsertAsync(homework);

            return created;
        }

        public async ValueTask<List<Homework>> GetAllAsync()
        {
            var homeworks = _homeworkRepository.SelectAll().ToList();

            return homeworks;
        }

        public async ValueTask<Homework> GetByIdAsync(long id)
        {
            var homework = await _homeworkRepository.SelectByIdAsync(id);

            return homework;
        }

        public async ValueTask<Homework> UpdateAsync(HomeworkModificationDTO homeworkModificationDTO, long id)
        {
            var homework = homeworkModificationDTO.Adapt<Homework>();
            homework.Id = id;

            var updated = await _homeworkRepository.UpdateAsync(homework);

            return updated;
        }

        public async ValueTask<Homework> DeleteAsync(long id)
        {
            var deleted = await _homeworkRepository.DeleteAsync(id);

            return deleted ;
        }
    }
}
