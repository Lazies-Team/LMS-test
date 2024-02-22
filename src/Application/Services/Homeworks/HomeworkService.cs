using Application.Abstractions.Homeworks;
using Application.DataTransferObjects.HomeWorks;
using Application.Services.Contracts.Homeworks;
using Application.ViewModel.Homeworks;
using Domain.Entities.Homeworks;
using Mapster;

namespace Application.Services.Homeworks
{
    public class HomeworkService : IHomeworkService
    {
        private readonly IHomeworkRepository _homeworkRepository;

        public HomeworkService(IHomeworkRepository homeworkRepository)
            => _homeworkRepository = homeworkRepository;

        public async ValueTask<HomeworkViewModel> AddAsync(HomeworkCreationDTO homeworkCreationDTO)
        {
            var homework = homeworkCreationDTO.Adapt<Homework>();
            var result =  await _homeworkRepository.InsertAsync(homework);
            var homeworkViewModel = result.Adapt<HomeworkViewModel>();
            
            return homeworkViewModel;
        }

        public async ValueTask<List<HomeworkViewModel>> GetAllAsync()
        {
            var result = _homeworkRepository.SelectAll();
            var homeworklist = result.ToList().Adapt<List<HomeworkViewModel>>();

            return homeworklist;
        }

        public async ValueTask<HomeworkViewModel> GetByIdAsync(long id)
        {
            var result = await _homeworkRepository.SelectByIdAsync(id);
            var homeworkViewModel = result.Adapt<HomeworkViewModel>();

            return homeworkViewModel;
        }

        public async ValueTask<HomeworkViewModel> UpdateAsync(HomeworkModificationDTO homeworkModificationDTO, long id)
        {
            var homework = homeworkModificationDTO.Adapt<Homework>();
            homework.Id = id;
            var result = await _homeworkRepository.UpdateAsync(homework);
            var homeworkViewModel = result.Adapt<HomeworkViewModel>();

            return homeworkViewModel;
        }

        public async ValueTask<HomeworkViewModel> DeleteAsync(long id)
        {
            var result = await _homeworkRepository.DeleteAsync(id);
            var homeworkViewModel = result.Adapt<HomeworkViewModel>();

            return homeworkViewModel;
        }
    }
}
