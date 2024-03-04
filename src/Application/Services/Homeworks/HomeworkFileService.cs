using Application.Abstractions.Homeworks;
using Application.DataTransferObjects.HomeWorks;
using Application.Services.Contracts.Homeworks;

using Domain.Entities.Homeworks;

using Mapster;

namespace Application.Services.Homeworks
{
    public class HomeworkFileService : IHomeworkFileService
    {
        private readonly IHomeworkFileRepository _repository;

        public HomeworkFileService(IHomeworkFileRepository repository)
            => _repository = repository;

        public async ValueTask<HomeworkFile> AddAsync(HomeworkFileCreationDTO homeworkFileCreationDTO)
        {
            var homeworkFile = homeworkFileCreationDTO.Adapt<HomeworkFile>();
            var result = await _repository.InsertAsync(homeworkFile);

            return result;
        }

        public async ValueTask<List<HomeworkFile>> GetAllAsync()
        {
            var homeworkfiles = _repository.SelectAll().ToList();

            return homeworkfiles;
        }

        public async ValueTask<HomeworkFile> GetByIdAsync(long id)
        {
            var homeworkfile = await _repository.SelectByIdAsync(id);

            return homeworkfile;
        }

        public async ValueTask<HomeworkFile> UpdateAsync(HomeworkFileModificationDTO homeworkFileModificationDTO, long id)
        {
            var homeworkfile = homeworkFileModificationDTO.Adapt<HomeworkFile>();
            homeworkfile.Id = id;

            var result = await _repository.UpdateAsync(homeworkfile);

            return result;
        }

        public async ValueTask<HomeworkFile> DeleteAsync(long id)
        {
            var result = await _repository.DeleteAsync(id);

            return result;
        }
    }
}
