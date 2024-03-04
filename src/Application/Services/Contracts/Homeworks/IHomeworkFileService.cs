using Application.DataTransferObjects.HomeWorks;
using Domain.Entities.Homeworks;

namespace Application.Services.Contracts.Homeworks
{
    public interface IHomeworkFileService
    {
        ValueTask<HomeworkFile> AddAsync(HomeworkFileCreationDTO homeworkFileCreationDTO);
        ValueTask<List<HomeworkFile>> GetAllAsync();
        ValueTask<HomeworkFile> GetByIdAsync(long id);
        ValueTask<HomeworkFile> UpdateAsync(HomeworkFileModificationDTO homeworkFileModificationDTO, long id);
        ValueTask<HomeworkFile> DeleteAsync(long id);
    }
}
