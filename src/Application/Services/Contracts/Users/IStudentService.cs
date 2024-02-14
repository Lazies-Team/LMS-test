using Application.DataTransferObjects.Users;
using Application.ViewModel;

namespace Application.Services.Contracts.Users
{
    public interface IStudentService
    {
        ValueTask<List<StudentViewModel>> GetAllAsync();
        ValueTask<StudentViewModel> GetByIdAsync(long id);
        ValueTask<StudentViewModel> UpdateAsync(StudentModificationDTO studentModificationDTO, long id);
        ValueTask<StudentViewModel> DeleteAsync(long id);
    }
}
