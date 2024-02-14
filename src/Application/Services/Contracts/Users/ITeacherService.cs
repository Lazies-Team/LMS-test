using Application.DataTransferObjects.Users;
using Application.ViewModel;
using Domain.Entities.Users;

namespace Application.Services.Contracts.Users
{
    public interface ITeacherService
    {
        ValueTask<List<TeacherViewModel>> GetAllAsync();
        ValueTask<TeacherViewModel> GetByIdAsync(long id);
        ValueTask<TeacherViewModel> UpdateAsync(TeacherModificationDTO teacherModificationDTO, long id);
        ValueTask<TeacherViewModel> DeleteAsync(long id);
    }
}
