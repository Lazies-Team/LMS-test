using Application.DataTransferObjects.Users;
using Domain.Entities.Users;

namespace Application.Services.Contracts.Users
{
    public interface IAdminService
    {
        ValueTask<List<Admin>> GetAllAsync();
        ValueTask<Admin> GetByIdAsync(long id);
        ValueTask<Admin> UpdateAsync(AdminModificationDTO adminModificationDTO, long id);
        ValueTask<Admin> DeleteAsync(long id);
    }
}
