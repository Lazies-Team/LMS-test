using Application.Abstractions.Homeworks;
using Application.DataTransferObjects.HomeWorks;
using Application.Services.Contracts.Homeworks;
using Application.ViewModel.Homeworks;
using Domain.Entities.Homeworks;
using Mapster;

namespace Application.Services.Homeworks
{
    public class HomeworkFileService : IHomeworkFileService
    {
        private readonly IHomeworkFileRepository _repository;

        public HomeworkFileService(IHomeworkFileRepository repository)
            => _repository = repository;

        public async ValueTask<HomeworkFileViewModel> AddAsync(HomeworkFileCreationDTO homeworkFileCreationDTO)
        {
            var homeworkFile = homeworkFileCreationDTO.Adapt<HomeworkFile>();
            var created = await _repository.InsertAsync(homeworkFile);
            var result = created.Adapt<HomeworkFileViewModel>();

            return result;
        }

        public async ValueTask<List<HomeworkFileViewModel>> GetAllAsync()
        {
            var homeworkfiles = _repository.SelectAll();
            var result = homeworkfiles.ToList().Adapt<List<HomeworkFileViewModel>>();

            return result;
        }

        public async ValueTask<HomeworkFileViewModel> GetByIdAsync(long id)
        {
            var homeworkfile = await _repository.SelectByIdAsync(id);
            var result = homeworkfile.Adapt<HomeworkFileViewModel>();

            return result;
        }

        public async ValueTask<HomeworkFileViewModel> UpdateAsync(HomeworkFileModificationDTO homeworkFileModificationDTO, long id)
        {
            var homeworkfile = homeworkFileModificationDTO.Adapt<HomeworkFile>();
            homeworkfile.Id = id;
            var updated =  _repository.UpdateAsync(homeworkfile);
            var result = updated.Adapt<HomeworkFileViewModel>();

            return result;
        }

        public async ValueTask<HomeworkFileViewModel> DeleteAsync(long id)
        {
            var homeworkfile = _repository.DeleteAsync(id);
            var result = homeworkfile.Adapt<HomeworkFileViewModel>();

            return result;
        }
    }
}
