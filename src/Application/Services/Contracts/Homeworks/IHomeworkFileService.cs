using Application.DataTransferObjects.HomeWorks;
using Application.ViewModel.Homeworks;

namespace Application.Services.Contracts.Homeworks
{
    public interface IHomeworkFileService
    {
        ValueTask<HomeworkFileViewModel> AddAsync(HomeworkFileCreationDTO homeworkFileCreationDTO);
        ValueTask<List<HomeworkFileViewModel>> GetAllAsync();
        ValueTask<HomeworkFileViewModel> GetByIdAsync(long id);
        ValueTask<HomeworkFileViewModel> UpdateAsync(HomeworkFileModificationDTO homeworkFileModificationDTO, long id);
        ValueTask<HomeworkFileViewModel> DeleteAsync(long id);
    }
}
