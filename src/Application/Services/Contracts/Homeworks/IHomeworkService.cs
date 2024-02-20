using Application.DataTransferObjects.Courses;
using Application.DataTransferObjects.HomeWorks;
using Application.ViewModel.Homeworks;

namespace Application.Services.Contracts.Homeworks
{
    public interface IHomeworkService
    {
        ValueTask<HomeworkViewModel> AddAsync(HomeworkCreationDTO homeworkCreationDTO);
        ValueTask<List<HomeworkViewModel>> GetAllAsync();
        ValueTask<HomeworkViewModel> GetByIdAsync(long id);
        ValueTask<HomeworkViewModel> UpdateAsync(HomeworkModificationDTO homeworkModificationDTO, long id);
        ValueTask<HomeworkViewModel> DeleteAsync(long id);
    }
}
