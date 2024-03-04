using Application.DataTransferObjects.Users;
using Domain.Entities.Users;

namespace Application.Services.Contracts.Users
{
    public interface IStudentService
    {
        ValueTask<List<Student>> GetAllAsync();
        ValueTask<Student> GetByIdAsync(long id);
        ValueTask<Student> UpdateAsync(StudentModificationDTO studentModificationDTO, long id);
        ValueTask<Student> DeleteAsync(long id);
    }
}
