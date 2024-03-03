using Application.DataTransferObjects.HomeWorks;
using Domain.Entities.Homeworks;

namespace Application.Services.Contracts.Homeworks
{
    public interface IHomeworkService
    {
        ValueTask<Homework> AddAsync(HomeworkCreationDTO homeworkCreationDTO);
        ValueTask<List<Homework>> GetAllAsync();
        ValueTask<Homework> GetByIdAsync(long id);
        ValueTask<Homework> UpdateAsync(HomeworkModificationDTO homeworkModificationDTO, long id);
        ValueTask<Homework> DeleteAsync(long id);
    }
}
