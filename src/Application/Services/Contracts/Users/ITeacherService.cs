using Application.DataTransferObjects.Users;
using Domain.Entities.Users;

namespace Application.Services.Contracts.Users
{
    public interface ITeacherService
    {
        ValueTask<List<Teacher>> GetAllAsync();
        ValueTask<Teacher> GetByIdAsync(long id);
        ValueTask<Teacher> UpdateAsync(TeacherModificationDTO teacherModificationDTO, long id);
        ValueTask<Teacher> DeleteAsync(long id);
    }
}
